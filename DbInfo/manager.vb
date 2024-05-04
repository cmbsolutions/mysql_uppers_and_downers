Imports System.Data.Entity.Infrastructure.Pluralization
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.Reflection

Namespace InfoSchema
	<Serializable>
	Public Class Manager
		Implements IDisposable

		Public Property InternalConnection As Connection
		Private Property DbConnections As Dictionary(Of String, MySqlConnection)
		Private Property DbCommand As MySqlCommand
		Private Property DbInfoCommand As MySqlCommand
		Private Property Pservice As New PluralizationService
		Private Property Keywords As New List(Of String)
		Private Property DatabaseName As String = ""

		Public Property ProjectTables As New List(Of Table)
		Public Property ProjectRoutines As New List(Of routine)

		Public Property Databases As List(Of String)
		Public Property Tables As List(Of Table)
		Public Property Routines As List(Of routine)


		Public Sub New()
			InitSchema()
		End Sub

		Public Sub New(Connection As Connection)
			InternalConnection = Connection
			InitSchema()
		End Sub

		Public Function SetConnection(host As String, user As String, pass As String) As Boolean
			InternalConnection = New InfoSchema.Connection With {
						.Host = host,
						.User = user,
						.Port = "3306",
						.Sslmode = ESslMode.Prefered,
						.Description = "Custom InternalConnection"
					}

			InternalConnection.SetPass(pass)

			Return TryConnect()
		End Function

		Public Sub SetDatabase(database As String)
			DatabaseName = database
		End Sub
		Public Function GetDatabase() As String
			Return DatabaseName
		End Function

		Public Sub HarvestObjects()
			Try
				Tables = New List(Of Table)
				Routines = New List(Of routine)
				GetTables()
				GetColumns()
				GetIndexes()
				GetForeignKeys()
				GetRoutines()

			Catch ex As Exception
				Throw
			End Try
		End Sub

#Region "object readers"
		Private Sub GetDatabases()
			Try
				Using _dbCommand = New MySqlCommand

					_dbCommand.Connection = DbConnection("infoSchema", "information_schema")
					_dbCommand.CommandText = "SELECT SCHEMA_NAME FROM SCHEMATA WHERE SCHEMA_NAME NOT IN ('information_schema', 'mysql', 'performance_schema', 'sys') ORDER BY SCHEMA_NAME"

					Using rdr As MySqlDataReader = _dbCommand.ExecuteReader
						While rdr.Read
							Databases.Add(rdr(0).ToString)
						End While
					End Using
				End Using
			Catch ex As Exception
				Throw
			End Try
		End Sub

		Private Sub GetTables()
			Try
				Using _dbCommand = New MySqlCommand

					_dbCommand.Connection = DbConnection("infoSchema", "information_schema")
					_dbCommand.CommandText = "SELECT T.TABLE_NAME, T.TABLE_TYPE, V.VIEW_DEFINITION, T.TABLE_COLLATION FROM `TABLES` AS T LEFT JOIN VIEWS AS V ON T.TABLE_SCHEMA = V.TABLE_SCHEMA AND T.TABLE_NAME = V.TABLE_NAME WHERE T.TABLE_SCHEMA = @database;"
					_dbCommand.Parameters.AddWithValue("database", DatabaseName)

					Using rdr As MySqlDataReader = _dbCommand.ExecuteReader
						While rdr.Read
							Dim t As Table
							If rdr.GetString("TABLE_TYPE") = "VIEW" Then
								t = New Table With {.Name = rdr.GetString("TABLE_NAME").ToString, .SingleName = Pservice.Singularize(rdr.GetString("TABLE_NAME")), .PluralName = Pservice.Pluralize(rdr.GetString("TABLE_NAME")), .IsView = True, .HasExport = True, .Icon = My.Resources.navicat_NICON_VIEW_2}
							Else
								t = New Table With {.Name = rdr.GetString("TABLE_NAME"), .SingleName = Pservice.Singularize(rdr.GetString("TABLE_NAME")), .PluralName = Pservice.Pluralize(rdr.GetString("TABLE_NAME")), .HasExport = True, .Table_collation = rdr.GetString("TABLE_COLLATION"), .Icon = My.Resources.navicat_NICON_TABLE_2}
							End If

							t.EscapeName = Keywords IsNot Nothing AndAlso Keywords.Exists(Function(c) c = t.SingleName)
							t.NoAutoNumber = True

							Tables.Add(t)

							Using _dbInfoCommand = New MySqlCommand
								_dbInfoCommand.Connection = DbConnection("definition", DatabaseName)
								_dbInfoCommand.CommandText = $"SHOW CREATE {rdr.GetString("TABLE_TYPE").Replace("BASE ", "")} {rdr("TABLE_NAME")}"

								Try
									Using irdr As MySqlDataReader = _dbInfoCommand.ExecuteReader
										While irdr.Read
											t.Definition = irdr($"Create {UcFirst(rdr.GetString("TABLE_TYPE").Replace("BASE ", ""))}").ToString
										End While
									End Using
								Catch rex As Exception
									Trace.WriteLine(rex.Message)
								End Try
							End Using
						End While
					End Using
				End Using
			Catch ex As Exception
				Throw
			End Try
		End Sub

		Private Sub GetColumns()
			Try
				For Each t In Tables

					t.Columns = New List(Of Column)

					Using _dbCommand = New MySqlCommand
						_dbCommand.Connection = DbConnection("infoSchema", "information_schema")
						_dbCommand.CommandText = "SELECT COLUMN_NAME,ORDINAL_POSITION,COLUMN_DEFAULT,IS_NULLABLE,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE,COLUMN_TYPE,COLUMN_KEY,EXTRA,CHARACTER_SET_NAME,COLLATION_NAME FROM COLUMNS WHERE TABLE_SCHEMA = @database AND TABLE_NAME = @table ORDER BY ORDINAL_POSITION ASC"
						_dbCommand.Parameters.AddWithValue("database", DatabaseName)
						_dbCommand.Parameters.AddWithValue("table", t.Name)
						'Debug.WriteLine(t.tableName)
						Using rdr As MySqlDataReader = _dbCommand.ExecuteReader()
							While rdr.Read
								'Debug.WriteLine(rdr("COLUMN_NAME").ToString)
								Dim c As New Column With {
									.Name = rdr("COLUMN_NAME").ToString,
									.Alias = AliasGenerator(rdr("COLUMN_NAME").ToString),
									.OrdinalPosition = CInt(rdr("ORDINAL_POSITION")),
									.DefaultValue = If(rdr("COLUMN_DEFAULT").ToString = "", "NULL", rdr("COLUMN_DEFAULT").ToString),
									.IsNullable = If(rdr("IS_NULLABLE").ToString = "YES", True, False),
									.MysqlType = rdr("DATA_TYPE").ToString,
									.MaximumLength = If(rdr("CHARACTER_MAXIMUM_LENGTH").ToString = "", 0, ToInt(rdr("CHARACTER_MAXIMUM_LENGTH"))),
									.NumericPrecision = ToInt(rdr("NUMERIC_PRECISION")),
									.NumericScale = ToInt(rdr("NUMERIC_SCALE")),
									.Key = rdr("COLUMN_KEY").ToString,
									.Icon = My.Resources.table_field
								}
								If Not t.IsView Then
									If rdr("EXTRA").ToString = "auto_increment" Then
										c.AutoIncrement = True
										t.NoAutoNumber = False
										c.Icon = My.Resources.key
									End If
								Else
									Dim pt = ProjectTables.FirstOrDefault(Function(x) x.Name = t.Name)
									If pt IsNot Nothing Then
										Dim ct = pt.Columns.FirstOrDefault(Function(y) y.Name = c.Name)

										If ct IsNot Nothing Then
											c.IsUserSelectedKey = ct.IsUserSelectedKey
										End If
									End If
								End If
								If rdr("EXTRA").ToString = "VIRTUAL GENERATED" Then
									c.IsVirtual = True
								End If
								c.VbType = GetVbType(rdr("DATA_TYPE").ToString)
								c.MySqlColumnType = rdr("COLUMN_TYPE").ToString
								c.PhpType = GetPHPType(c.MysqlType)
								If rdr("DATA_TYPE").ToString = "enum" Then
									Dim RegexObj As New Regex("\(([^)]+)")
									Dim tmpData As String = RegexObj.Match(rdr("COLUMN_TYPE").ToString()).Groups(1).Value

									c.Enums = New List(Of String)
									c.Enums.AddRange(tmpData.Replace("'", "").Split(","c))
								End If

								c.Character_set_name = If(rdr("CHARACTER_SET_NAME").ToString = "", "", rdr.GetString("CHARACTER_SET_NAME"))
								c.Collation_name = If(rdr("COLLATION_NAME").ToString = "", "", rdr.GetString("COLLATION_NAME"))

								t.Columns.Add(c)
							End While
						End Using

						If t.IsView AndAlso t.Columns.Count = 0 Then t.HasMissingFields = True
					End Using
				Next

			Catch ex As Exception
				Throw
			End Try
		End Sub

		Private Sub GetIndexes()
			Try
				Using _dbCommand = New MySqlCommand
					_dbCommand.Connection = DbConnection("infoSchema", "information_schema")
					_dbCommand.CommandText = "SELECT TABLE_NAME, NON_UNIQUE, NULLABLE, INDEX_NAME, COLUMN_NAME, SEQ_IN_INDEX FROM STATISTICS WHERE TABLE_SCHEMA=@database ORDER BY TABLE_NAME, INDEX_NAME, SEQ_IN_INDEX"
					_dbCommand.Parameters.AddWithValue("database", DatabaseName)

					Using rdr As MySqlDataReader = _dbCommand.ExecuteReader
						While rdr.Read
							Dim table = Tables.FirstOrDefault(Function(c) c.Name = rdr("TABLE_NAME").ToString)

							Dim idx = table.Indexes.FirstOrDefault(Function(c) c.Name = rdr("INDEX_NAME").ToString)

							If idx Is Nothing Then
								idx = New Index With {
									.Name = rdr("INDEX_NAME").ToString,
									.IsUnique = Not CBool(rdr("NON_UNIQUE")),
									.IsNullable = rdr("NULLABLE").ToString = "YES",
									.Icon = My.Resources.navicat_NICON_INDEX_2
								}
								table.Indexes.Add(idx)
							End If

							Dim col = table.Columns.FirstOrDefault(Function(c) c.Name = rdr("COLUMN_NAME").ToString)

							idx.columns.Add(New IndexColumn With {
											.indexPosition = ToInt(rdr("SEQ_IN_INDEX")),
											.column = col
							})

						End While
					End Using
				End Using
			Catch ex As Exception
				Throw
			End Try
		End Sub

		Private Sub GetForeignKeys()
			Try
				Using _dbCommand = New MySqlCommand
					_dbCommand.Connection = DbConnection("infoSchema", "information_schema")
					_dbCommand.CommandText = "SELECT
	kcu.CONSTRAINT_NAME, 
	kcu.TABLE_NAME, 
	kcu.COLUMN_NAME, 
	kcu.ORDINAL_POSITION, 
	kcu.POSITION_IN_UNIQUE_CONSTRAINT, 
	kcu.REFERENCED_TABLE_NAME, 
	kcu.REFERENCED_COLUMN_NAME, 
	rc.UPDATE_RULE, 
	rc.DELETE_RULE
FROM
	KEY_COLUMN_USAGE AS kcu
	INNER JOIN
	REFERENTIAL_CONSTRAINTS AS rc
	ON 
		kcu.CONSTRAINT_SCHEMA = rc.CONSTRAINT_SCHEMA AND
		kcu.CONSTRAINT_NAME = rc.CONSTRAINT_NAME
WHERE
	kcu.CONSTRAINT_SCHEMA = @database AND
	kcu.REFERENCED_TABLE_NAME IS NOT NULL
ORDER BY
	kcu.TABLE_NAME ASC, 
	kcu.ORDINAL_POSITION ASC, 
	kcu.POSITION_IN_UNIQUE_CONSTRAINT ASC"
					_dbCommand.Parameters.AddWithValue("database", DatabaseName)

					Using rdr As MySqlDataReader = _dbCommand.ExecuteReader
						While rdr.Read
							Dim table = Tables.FirstOrDefault(Function(c) c.Name = rdr("TABLE_NAME").ToString)

							Dim fk = table.ForeignKeys.FirstOrDefault(Function(c) c.name = rdr("CONSTRAINT_NAME").ToString)

							If fk Is Nothing Then
								fk = New ForeignKey With {
									.name = rdr("CONSTRAINT_NAME").ToString,
									.table = table,
									.Icon = My.Resources.link,
									.OnUpdate = rdr.GetString("UPDATE_RULE"),
									.OnDelete = rdr.GetString("DELETE_RULE")
								}
								table.ForeignKeys.Add(fk)
							End If

							Dim col = table.Columns.FirstOrDefault(Function(c) c.Name = rdr("COLUMN_NAME").ToString)

							fk.columns.Add(New FkColumn With {
								.fkPosition = ToInt(rdr("ORDINAL_POSITION")),
								.column = col
							})

							If col.Name.Replace("_id", "") <> col.Name Then
								fk.propertyAlias = FixKeyword(col.Name.Replace("_id", ""))
							Else
								fk.propertyAlias = $"{col.Name}_"
							End If

							Dim reftable As Table = Nothing
							Try
								reftable = Tables.First(Function(c) c.Name = rdr("REFERENCED_TABLE_NAME").ToString)
							Catch rex As Exception
								Throw New Exception($"Foreign key error on {table.Name} to {rdr("REFERENCED_TABLE_NAME")}, are you missing the table?", rex)
							End Try

							If fk.referencedTable Is Nothing Then
								fk.referencedTable = reftable
							End If

							Dim refcol As Column = Nothing

							Try
								refcol = reftable.Columns.FirstOrDefault(Function(c) c.Name = rdr("REFERENCED_COLUMN_NAME").ToString)
							Catch rex As Exception
								Throw New Exception($"Foreign key error on {table.Name} to {rdr("REFERENCED_TABLE_NAME")} and column {rdr("REFERENCED_COLUMN_NAME")}, are you missing the table?", rex)
							End Try

							fk.referencedColumns.Add(New FkColumn With {
								.fkPosition = ToInt(rdr("ORDINAL_POSITION")),
								.column = refcol
							})

							If fk.propertyAlias = reftable.SingleName Then
								reftable.Relations.Add(New relation With {
													.toTable = table,
													.toColumn = col,
													.localColumn = refcol,
													.isOptional = col.IsNullable,
													.[alias] = table.PluralName
													})
							Else
								Dim alreadyExists = reftable.Relations.FirstOrDefault(Function(c) c.alias = table.SingleName & reftable.PluralName)
								If alreadyExists Is Nothing Then
									reftable.Relations.Add(New relation With {
													.toTable = table,
													.toColumn = col,
													.localColumn = refcol,
													.isOptional = col.IsNullable,
													.[alias] = table.SingleName & reftable.PluralName})

								Else
									alreadyExists.alias = $"{alreadyExists.toTable.SingleName}{alreadyExists.toColumn.Name.Replace("_id", "")}"
									reftable.Relations.Add(New relation With {
													.toTable = table,
													.toColumn = col,
													.localColumn = refcol,
													.isOptional = col.IsNullable,
													.[alias] = $"{table.SingleName}{col.Name.Replace("_id", "")}"})

								End If
							End If
						End While
					End Using
				End Using
			Catch ex As Exception
				Throw
			End Try
		End Sub

		Private Sub ForeignKeyAliasBuilder()
			Try
				For Each table In Tables.Where(Function(c) c.ForeignKeys.Count > 0)
					For Each fk In table.ForeignKeys
						If table.ForeignKeys.LongCount(Function(c) c.referencedTable.Equals(fk.referencedTable)) > 1 Then
							fk.propertyAlias = FixKeyword(fk.columns.First.column.Name.Replace("_id", ""))
						Else
							fk.propertyAlias = FixKeyword(fk.referencedTable.SingleName)
						End If
					Next
				Next
			Catch ex As Exception
				Throw
			End Try
		End Sub
		Private Sub RelationAliasBuilder()
			Try
				For Each table In Tables.Where(Function(c) c.Relations.Count > 0)
					For Each re In table.Relations
						If table.Relations.LongCount(Function(c) c.toTable.Equals(re.toTable)) > 1 Then
							re.alias = re.toColumn.Name.Replace("_id", "")
						Else
							re.alias = re.toTable.SingleName
						End If
					Next
				Next
			Catch ex As Exception
				Throw
			End Try
		End Sub

		Private Sub GetRoutines()
			Try
				Using _dbCommand = New MySqlCommand

					_dbCommand.Connection = DbConnection("infoSchema", "information_schema")
					_dbCommand.CommandText = "Select r.ROUTINE_TYPE, r.ROUTINE_NAME, r.ROUTINE_DEFINITION, p.ORDINAL_POSITION, p.PARAMETER_NAME, p.DATA_TYPE, p.CHARACTER_MAXIMUM_LENGTH, p.NUMERIC_PRECISION FROM ROUTINES As r LEFT JOIN PARAMETERS As p On r.ROUTINE_SCHEMA = p.SPECIFIC_SCHEMA And r.ROUTINE_NAME = p.SPECIFIC_NAME WHERE r.ROUTINE_SCHEMA = @database ORDER BY r.ROUTINE_TYPE, p.SPECIFIC_NAME, p.ORDINAL_POSITION"
					_dbCommand.Parameters.AddWithValue("database", DatabaseName)

					Using rdr As MySqlDataReader = _dbCommand.ExecuteReader
						Dim rt As routine = Nothing

						While rdr.Read
							If rt Is Nothing OrElse rt.name <> rdr("ROUTINE_NAME").ToString Then
								If rt IsNot Nothing Then
									Dim prt = ProjectRoutines.FirstOrDefault(Function(c) c.name = rt.name)
									Routines.Add(rt)
								End If
								rt = New routine With {.name = rdr("ROUTINE_NAME").ToString, .hasExport = True, .Icon = My.Resources.navicat_NICON_PROCEDURE_2}
							End If

							Dim p As New Parameter With {
								.mysqlType = rdr("DATA_TYPE").ToString,
								.maximumLength = ToInt(rdr("CHARACTER_MAXIMUM_LENGTH")),
								.numericPrecision = ToInt(rdr("NUMERIC_PRECISION")),
								.vbType = GetVbType(rdr("DATA_TYPE").ToString),
								.name = rdr("PARAMETER_NAME").ToString
							}


							If rdr("ROUTINE_TYPE").ToString = "FUNCTION" Then
								rt.isFunction = True
								rt.Icon = My.Resources.navicat_NICON_FUNCTION_2

								If ToInt(rdr("ORDINAL_POSITION")) = 0 Then
									rt.returnParam = p
								End If
							End If

							If ToInt(rdr("ORDINAL_POSITION")) > 0 Then
								p.ordinalPosition = ToInt(rdr("ORDINAL_POSITION"))

								Dim prt = ProjectRoutines.FirstOrDefault(Function(c) c.name = rt.name)

								If prt IsNot Nothing AndAlso prt.params.Any Then
									Dim pvalue = prt.params.FirstOrDefault(Function(d) d.ordinalPosition = p.ordinalPosition)

									If pvalue IsNot Nothing AndAlso pvalue.PreviewValue IsNot Nothing Then
										p.PreviewValue = pvalue.PreviewValue
									End If
								End If
								rt.params.Add(p)
							End If

							If rt.Definition = "" Then
								Using _dbInfoCommand = New MySqlCommand
									_dbInfoCommand.Connection = DbConnection("definition", DatabaseName)
									_dbInfoCommand.CommandText = $"SHOW CREATE {rdr("ROUTINE_TYPE")} {rdr("ROUTINE_NAME")}"
									_dbInfoCommand.CommandType = CommandType.Text

									Using irdr As MySqlDataReader = _dbInfoCommand.ExecuteReader
										While irdr.Read
											rt.Definition = irdr($"Create {UcFirst(rdr("ROUTINE_TYPE").ToString)}").ToString

											If rt.Definition = "" Then ' definer is not current user or lacking rights. Use less complete definition
												rt.Definition = $"#### You are not the definer and/or are lacking the rights to see this ####"
											Else
												rt.Definition = Regex.Replace(rt.Definition, "definer=[^ ]* (?=procedure|function|sql|view)", "", RegexOptions.IgnoreCase)
											End If
										End While
									End Using

								End Using
							End If
						End While

						If rt IsNot Nothing Then
							Routines.Add(rt)
						End If
					End Using
				End Using
			Catch ex As Exception
				Throw
			End Try
		End Sub

		Public Function ConvertEntityResultSetToDataTable(EntityResultSet As Linq.IQueryable) As DataTable
			Try
				Dim table = New DataTable

				For Each EntityResult In EntityResultSet
					If table.Columns.Count = 0 Then
						For Each info As PropertyInfo In EntityResult.GetType().GetProperties()
							If info.CanRead Then
								Dim IsNullable As Boolean = (Nullable.GetUnderlyingType(info.PropertyType) IsNot Nothing)

								If IsNullable Then
									table.Columns.Add(info.Name, Nullable.GetUnderlyingType(info.PropertyType))
								Else
									table.Columns.Add(info.Name, info.PropertyType())
								End If
							End If
						Next
					End If

					Dim row As DataRow = table.NewRow

					For Each info As PropertyInfo In EntityResult.GetType().GetProperties()
						Dim IsNullable As Boolean = (Nullable.GetUnderlyingType(info.PropertyType) IsNot Nothing)

						If IsNullable Then
							Dim val As Object = info.GetValue(EntityResult, Nothing)
							If Not val Is Nothing Then row(info.Name) = Convert.ChangeType(val, Nullable.GetUnderlyingType(info.PropertyType))
						Else
							row(info.Name) = info.GetValue(EntityResult, Nothing)
						End If

					Next
					table.Rows.Add(row)
				Next

				Return table
			Catch ex As Exception
				Throw
			End Try

			Return Nothing
		End Function

#End Region

#Region "helpers"
		Public Sub InitSchema()
			Try
				Databases = New List(Of String)
				DbConnections = New Dictionary(Of String, MySqlConnection)

				Tables = New List(Of Table)
				Routines = New List(Of routine)

			Catch ex As Exception
				Throw
			End Try
		End Sub
		Public Function TryConnect() As Boolean
			Try
				GetDatabases()

				Return True
			Catch ex As Exception
				Throw
			End Try
		End Function

		Public Function GetServerVersion() As String
			Dim Version As String = ""

			Using _dbInfoCommand = New MySqlCommand
				_dbInfoCommand.Connection = DbConnection("versioninfo", "information_schema")
				_dbInfoCommand.CommandText = "SHOW VARIABLES LIKE 'version';"
				_dbInfoCommand.CommandType = CommandType.Text

				Using reader As MySqlDataReader = _dbInfoCommand.ExecuteReader
					While reader.Read
						Version = reader.GetValue(1).ToString
					End While
				End Using
			End Using

			Return Version
		End Function
		Private Function DbConnection(connectionName As String, databasename As String) As MySqlConnection
			Try
				If DbConnections Is Nothing Then
					DbConnections = New Dictionary(Of String, MySqlConnection)
				End If
				Dim con As MySqlConnection

				If DbConnections.ContainsKey(connectionName) Then
					con = DbConnections.First(Function(c) c.Key = connectionName).Value
				Else
					con = New MySqlConnection(InternalConnection.ToString)

					DbConnections.Add(connectionName, con)
				End If

				If con.State = ConnectionState.Closed Or con.State = ConnectionState.Broken Then
					Try
						con.Open()
					Catch msex As Exception
						InternalConnection.Sslmode = ESslMode.None
						con.ConnectionString = InternalConnection.ToString
						con.Open()
					End Try
					con.ChangeDatabase(databasename)
				End If
				Return con

			Catch ex As Exception
				Throw
			End Try
		End Function

		Private Function ToInt(obj As Object) As Integer
			If obj.ToString = "" Then
				Return 0
			Else
				Dim result As Integer

				If Not Integer.TryParse(obj.ToString, result) Then
					Return 0
				End If

				Return result
			End If
		End Function

		Private Function UcFirst(s As String) As String
			Return s.Substring(0, 1).ToUpper & s.Substring(1).ToLower

		End Function
		Private Function GetVbType(mysqlType As String) As String
			If mysqlType Is Nothing Then
				Return "Integer"
			End If
			Select Case mysqlType.ToLower
				Case "tinyint", "mediumint", "integer", "int", "smallint", "int16", "int24", "int32", "uint16", "uint24", "uint32"
					Return "Integer"
				Case "bigint", "int64", "uint64"
					Return "Long"
				Case "char", "varchar", "text", "tinytext", "mediumtext", "longtext", "string", "varstring", "varbinary", "binary", "tinyblob", "mediumblob", "longblob", "set", "enum"
					Return "String"
				Case "time", "timestamp"
					Return "TimeSpan"
				Case "date", "datetime"
					Return "Date"
				Case "double", "float"
					Return "Double"
				Case "decimal", "numeric", "newdecimal"
					Return "Decimal"
				Case "byte", "bit"
					Return "Boolean"
				Case Else
					Return "Object"
			End Select
		End Function

		Private Function GetPHPType(mysqlType As String) As String
			If mysqlType Is Nothing Then
				Return "int"
			End If
			Select Case mysqlType.ToLower
				Case "tinyint", "mediumint", "integer", "int", "smallint", "int16", "int24", "int32", "uint16", "uint24", "uint32"
					Return "int"
				Case "bigint", "int64", "uint64"
					Return "int"
				Case "char", "varchar", "text", "tinytext", "mediumtext", "longtext", "string", "varstring", "varbinary", "binary", "tinyblob", "mediumblob", "longblob", "set", "enum"
					Return "string"
				Case "time", "timestamp"
					Return "\Cake\I18n\FrozenTime"
				Case "date", "datetime"
					Return "\Cake\I18n\FrozenTime"
				Case "double", "float"
					Return "float"
				Case "decimal", "numeric", "newdecimal"
					Return "float"
				Case "byte", "bit"
					Return "bool"
				Case Else
					Return "null"
			End Select
		End Function
		Private Function AliasGenerator(original As String) As String
			Try
				Dim ali As String = original.ToLower
				Dim inc As Integer = 1

				' First check tablenames
				While Tables.Exists(Function(t) t.Name.ToLower = ali Or t.SingleName.ToLower = ali Or t.PluralName.ToLower = ali)
					ali = $"{original.ToLower}_{inc}"
					inc += 1
				End While

				' Then check if first char is a number
				If IsNumeric(ali.First) Then
					ali = $"x{ali}"
				End If

				' Then check keywords (depending on generatortype)
				If Keywords.Exists(Function(k) k = ali) Then
					ali = $"[{ali}]"
				End If

				' replace spaces with _
				Dim RegexObj As New Regex("[^a-z\d\-_]", RegexOptions.IgnoreCase Or RegexOptions.Multiline)

				ali = RegexObj.Replace(ali, "_")

				Return ali
			Catch ex As Exception
				Throw
			End Try
		End Function

		Private Function FixKeyword(inData As String) As String
			' Then check keywords (depending on generatortype)
			If Keywords.Exists(Function(k) k = inData) Then
				Return $"[{inData}]"
			Else
				Return inData
			End If
		End Function

#End Region

#Region "IDisposable Support"
		Private disposedValue As Boolean ' To detect redundant calls

		' IDisposable
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not disposedValue Then
				If disposing Then
					If DbConnections IsNot Nothing Then
						DbConnections.Values.ToList.ForEach(Sub(c) c.Dispose())
						DbConnections.Clear()
					End If
					If DbCommand IsNot Nothing Then DbCommand.Dispose()
					If Pservice IsNot Nothing Then Pservice.Dispose()
				End If

				Keywords = Nothing
				Databases = Nothing
				Tables = Nothing
				Routines = Nothing

			End If
			disposedValue = True
		End Sub

		Protected Overrides Sub Finalize()
			' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
			Dispose(False)
			MyBase.Finalize()
		End Sub

		' This code added by Visual Basic to correctly implement the disposable pattern.
		Public Sub Dispose() Implements IDisposable.Dispose
			' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
			Dispose(True)

			GC.SuppressFinalize(Me)
		End Sub
#End Region

	End Class

	Public Class PluralizationService
		Implements IDisposable

		Private _service As EnglishPluralizationService

		Public Sub New()
			Try
				'If My.Settings.customDictionary.Count > 0 Then

				'    Dim userEntries As New List(Of CustomPluralizationEntry)

				'    For Each s In My.Settings.customDictionary
				'        userEntries.Add(New CustomPluralizationEntry(s.Split("|"c).First, s.Split("|"c).Last))
				'    Next
				'    _service = New EnglishPluralizationService(userEntries)
				'Else
				_service = New EnglishPluralizationService()
				'End If

			Catch ex As Exception
				Throw
			End Try
		End Sub

		Public Function Singularize(s As Object) As String
			Return Singularize(s.ToString)
		End Function

		Public Function Singularize(s As String) As String
			Dim ret As String = _service.Singularize(s)

			Dim test As String

			' it did not singularize, is it already single?
			If ret = s Then
				test = _service.Pluralize(s)


				If test = s Then ' it did not pluralize either, maybe its two words....
					If s.Contains("_"c) AndAlso Not s.EndsWith("_"c) Then
						Dim l = s.Split("_"c).LastOrDefault

						test = _service.Singularize(l)
						ret = s.Replace(l, test)


						If ret = s Then ' no way to make it single, return s

							ret = s
						End If

					Else
						ret = s
					End If

				Else ' it did pluralize, return s
					ret = s
				End If
			End If

			Return ret
		End Function

		Public Function Pluralize(s As Object) As String
			Return Pluralize(s.ToString)
		End Function

		Public Function Pluralize(s As String) As String
			Dim ret As String = _service.Pluralize(s)
			Dim test As String = Singularize(s)

			If s = ret AndAlso s = test AndAlso test = ret Then ret &= "s"

			Return ret
		End Function

		Public Function IsSingle(s As Object) As Boolean
			Return isSingle(s.ToString)
		End Function

		Public Function isSingle(s As String) As Boolean
			Dim tmp As String = Singularize(s)

			Return tmp.Equals(s)
		End Function

		Public Function IsPlural(s As Object) As Boolean
			Return IsPlural(s.ToString)
		End Function

		Public Function IsPlural(s As String) As Boolean
			Dim tmp As String = Pluralize(s)

			Return tmp.Equals(s)
		End Function

#Region "IDisposable Support"
		Private disposedValue As Boolean ' To detect redundant calls

		' IDisposable
		Protected Overridable Sub Dispose(disposing As Boolean)
			If Not disposedValue Then
				If disposing Then
					_service = Nothing
				End If

				' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
				' TODO: set large fields to null.
			End If
			disposedValue = True
		End Sub

		' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
		'Protected Overrides Sub Finalize()
		'    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
		'    Dispose(False)
		'    MyBase.Finalize()
		'End Sub

		' This code added by Visual Basic to correctly implement the disposable pattern.
		Public Sub Dispose() Implements IDisposable.Dispose
			' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
			Dispose(True)
			' TODO: uncomment the following line if Finalize() is overridden above.
			' GC.SuppressFinalize(Me)
		End Sub
#End Region
	End Class
End Namespace
