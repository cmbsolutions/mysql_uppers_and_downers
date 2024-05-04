Imports System.Drawing
Imports System.Reflection

Namespace InfoSchema
    Public Class Column
        Property Name As String
        Property [Alias] As String
        Property MysqlType As String
        Property MySqlColumnType As String
        Property VbType As String
        Property PhpType As String
        Property OrdinalPosition As Integer
        Property DefaultValue As String
        Property IsNullable As Boolean
        Property MaximumLength As Long
        Property NumericPrecision As Integer
        Property NumericScale As Integer
        Property Key As String
        Property AutoIncrement As Boolean
        Property Enums As New List(Of String)
        Property IsUserSelectedKey As Boolean
        Property Character_set_name As String
        Property Collation_name As String
        Property IsVirtual As Boolean
        Property Icon As Bitmap


        Public Overrides Function Equals(obj As Object) As Boolean
            Try
                Dim objB = TryCast(obj, Column)

                If objB Is Nothing Then Return False

                For Each p As PropertyInfo In Me.GetType().GetProperties
                    If p.GetValue(Me) IsNot Nothing AndAlso p.GetValue(objB) IsNot Nothing AndAlso p.GetValue(Me).ToString <> p.GetValue(objB).ToString Then Return False
                Next
            Catch ex As Exception
                Return False
            End Try

            Return True
        End Function
    End Class
End Namespace
