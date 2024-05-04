Imports System.Drawing

Namespace InfoSchema

    <Serializable>
    Public Class Table
        Inherits InfoSchemaObject

        Property Name As String
        Property SingleName As String
        Property PluralName As String
        Property IsView As Boolean
        Property EscapeName As Boolean
        Property Columns As New List(Of Column)
        Property Indexes As New List(Of Index)
        Property ForeignKeys As New List(Of foreignKey)
        Property Relations As New List(Of relation)
        Property HasExport As Boolean
        Property HasMissingFields As Boolean
        Property NoAutoNumber As Boolean
        Property Executiontime As TimeSpan
        Property Table_collation As String
        Property Icon As Bitmap
    End Class
End Namespace
