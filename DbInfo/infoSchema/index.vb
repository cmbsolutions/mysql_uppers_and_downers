Imports System.Drawing

Namespace InfoSchema
    Public Class Index
        Property Name As String
        Property IsUnique As Boolean
        Property IsNullable As Boolean
        Property columns As New List(Of IndexColumn)
        Property Icon As Bitmap
    End Class

    Public Class IndexColumn
        Property indexPosition As Integer
        Property column As Column
    End Class
End Namespace
