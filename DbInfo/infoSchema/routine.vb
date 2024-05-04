Imports System.Drawing

Namespace InfoSchema
    <Serializable>
    Public Class routine
        Inherits InfoSchemaObject

        Property name As String
        Property isFunction As Boolean
        Property returnsRecordset As Boolean
        Property returnParam As Parameter
        Property returnLayout As Table
        Property params As New List(Of Parameter)
        Property hasExport As Boolean
        Property executiontime As TimeSpan
        Property UseBaseLayout As Boolean
        Property BaseLayoutName As String
        Property Icon As Bitmap
    End Class
End Namespace
