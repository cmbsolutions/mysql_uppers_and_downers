Imports System.Drawing

Namespace InfoSchema
    Public Class ForeignKey
        Public Property name As String
        Public Property table As Table
        Public Property propertyAlias As String
        Public Property columns As New List(Of FkColumn)
        Public Property ordinalPosition As Integer
        Public Property positionInUniqueConstraint As Integer
        Public Property referencedTable As Table
        Public Property referencedColumns As New List(Of FkColumn)
        Public Property Icon As Bitmap
        Public Property OnUpdate As String
        Public Property OnDelete As String
    End Class

    Public Class FkColumn
        Property fkPosition As Integer
        Property column As Column
    End Class
End Namespace
