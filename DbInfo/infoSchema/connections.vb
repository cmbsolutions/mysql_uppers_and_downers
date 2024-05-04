Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.Cryptography
Imports System.Security
Imports System.Xml.Serialization


Namespace InfoSchema
    <Serializable>
    Public Class Connections
        Implements IList(Of Connection)
        Implements IDisposable

        <System.Xml.Serialization.XmlArray("items")>
        Private _internal As List(Of Connection)

        Public Sub New()
            If _internal Is Nothing Then _internal = New List(Of Connection)
        End Sub

        Public ReadOnly Property Count As Integer Implements ICollection(Of Connection).Count
            Get
                Return _internal.Count
            End Get
        End Property

        Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of Connection).IsReadOnly
            Get
                Return False
            End Get
        End Property

        Default Public Property Item(index As Integer) As Connection Implements IList(Of Connection).Item
            Get
                If index >= 0 AndAlso index < Count Then
                    Return _internal.Item(index)
                Else
                    Return Nothing
                End If
            End Get
            Set(value As Connection)
                If index >= 0 AndAlso index < Count Then
                    _internal.Item(index) = value
                Else
                    Add(value)
                End If
            End Set
        End Property

        Public Sub Add(item As Connection) Implements ICollection(Of Connection).Add
            _internal.Add(item)
        End Sub

        Public Sub Clear() Implements ICollection(Of Connection).Clear
            _internal.Clear()
        End Sub

        Public Sub CopyTo(array() As Connection, arrayIndex As Integer) Implements ICollection(Of Connection).CopyTo
            _internal.CopyTo(array, arrayIndex)
        End Sub

        Public Sub Insert(index As Integer, item As Connection) Implements IList(Of Connection).Insert
            _internal.Insert(index, item)
        End Sub

        Public Sub RemoveAt(index As Integer) Implements IList(Of Connection).RemoveAt
            _internal.RemoveAt(index)
        End Sub

        Public Function Contains(item As Connection) As Boolean Implements ICollection(Of Connection).Contains
            Return _internal.Contains(item)
        End Function

        Public Function GetEnumerator() As IEnumerator(Of Connection) Implements IEnumerable(Of Connection).GetEnumerator
            Return _internal.GetEnumerator
        End Function

        Public Function IndexOf(item As Connection) As Integer Implements IList(Of Connection).IndexOf
            Return _internal.IndexOf(item)
        End Function

        Public Function Remove(item As Connection) As Boolean Implements ICollection(Of Connection).Remove
            Return _internal.Remove(item)
        End Function

        Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            Return GetEnumerator()
        End Function

        Public Sub SaveToFile(file As IO.FileInfo)
            Try
                Dim formatter As New BinaryFormatter

                If Not file.Directory.Exists Then file.Directory.Create()

                Using data As New FileStream(file.FullName, FileMode.Create, FileAccess.Write, FileShare.None)
                    formatter.Serialize(data, _internal.Where(Function(c) Not c.FromNavicat).ToList)
                End Using

                formatter = Nothing
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub LoadFromFile(file As IO.FileInfo)
            Try
                _internal = New List(Of Connection)

                If file.Exists Then
                    Dim formatter As New BinaryFormatter

                    Using data As New FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.Read)
                        _internal = CType(formatter.Deserialize(data), List(Of Connection))
                    End Using
                    formatter = Nothing

                    Trace.WriteLine($"Loaded {_internal.Count} connections")
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub LoadFromNavicat()
            Dim registryRoot As String = "Software\PremiumSoft\Navicat\Servers"

            Try
                Using mainReg = My.Computer.Registry.CurrentUser.OpenSubKey(registryRoot, False)
                    If mainReg IsNot Nothing Then
                        For Each entry In mainReg.GetSubKeyNames
                            Using subKey = mainReg.OpenSubKey(entry)
                                _internal.Add(New Connection With {
                                              .FromNavicat = True,
                                              .Host = subKey.GetValue("Host").ToString,
                                              .User = subKey.GetValue("UserName").ToString,
                                              .Pass = subKey.GetValue("Pwd").ToString,
                                              .Description = entry,
                                              .Sslmode = ESslMode.Required
                                              })
                            End Using
                        Next

                        Trace.WriteLine($"Added {_internal.LongCount(Function(c) c.FromNavicat)} connections from navicat")
                    End If

                End Using
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    _internal = Nothing
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

    <Serializable>
    Public Class Connection
        Property Host As String
        Property Port As String
        Property User As String
        Property Pass As String
        Property Sslmode As ESslMode
        Property Description As String

        <XmlIgnore()>
        Property FromNavicat As Boolean

        Public Sub SetPass(ByVal p As String)
            Using security As New Secure
                Pass = security.EncryptData(p)
            End Using
        End Sub
        Public Function DecryptedPass() As String
            If FromNavicat Then
                Using navi As New CMBSolutions.NavicatEncrypt
                    Return navi.Decrypt(Pass)
                End Using
            Else
                Using security As New Secure
                    Return security.DecryptData(Pass)
                End Using
            End If
        End Function
        Public Overrides Function ToString() As String
            Return $"server={Host};user id={User};password={DecryptedPass()};allowuservariables=True;characterset=utf8mb4;interactivesession=True;treattinyasboolean=False;compress=True;persistsecurityinfo=True;sslmode={Sslmode}"
        End Function

        Public Sub Clone(ByRef [to] As Connection)
            [to] = DirectCast(Me.MemberwiseClone(), Connection)
        End Sub
    End Class

    <Serializable>
    Public Enum ESslMode
        None
        Prefered
        Required
    End Enum

    Public NotInheritable Class Secure
        Implements IDisposable

        Private TripleDes As New TripleDESCryptoServiceProvider

        Public Sub New()
            Try
                Using securePwd As New SecureString()

                    securePwd.AppendChar("k"c)
                    securePwd.AppendChar("8"c)
                    securePwd.AppendChar("H"c)
                    securePwd.AppendChar("E"c)
                    securePwd.AppendChar("s"c)
                    securePwd.AppendChar("!"c)
                    securePwd.AppendChar("U"c)
                    securePwd.AppendChar("p"c)

                    TripleDes.Key = TruncateHash(securePwd.ToString, TripleDes.KeySize \ 8)
                    TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Public Sub New(ByVal key As String)
            Try
                ' Initialize the crypto provider.
                TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
                TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
            Catch ex As Exception
                Throw
            End Try
        End Sub

        Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()
            Try
                Using sha1 As New SHA1CryptoServiceProvider

                    ' Hash the key.
                    Dim keyBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(key)
                    Dim hash() As Byte = sha1.ComputeHash(keyBytes)

                    ' Truncate or pad the hash.
                    ReDim Preserve hash(length - 1)
                    Return hash
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function EncryptData(ByVal plaintext As String) As String
            Try
                ' Convert the plaintext string to a byte array.
                Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)

                ' Create the stream.
                Using ms As New System.IO.MemoryStream
                    ' Create the encoder to write to the stream.
                    Using encStream As New CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

                        ' Use the crypto stream to write the byte array to the stream.
                        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
                        encStream.FlushFinalBlock()
                    End Using

                    ' Convert the encrypted stream to a printable string.
                    Return Convert.ToBase64String(ms.ToArray)
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function DecryptData(ByVal encryptedtext As String) As String
            Try
                ' Convert the encrypted text string to a byte array.
                Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

                ' Create the stream.
                Using ms As New System.IO.MemoryStream
                    ' Create the decoder to write to the stream.
                    Using decStream As New CryptoStream(ms, TripleDes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

                        ' Use the crypto stream to write the byte array to the stream.
                        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
                        decStream.FlushFinalBlock()
                    End Using
                    ' Convert the plaintext stream to a string.
                    Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Function

#Region "IDisposable Support"
        Private disposedValue As Boolean

        Protected Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    TripleDes.Dispose()
                End If
            End If
            disposedValue = True
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
        End Sub
#End Region
    End Class
End Namespace
