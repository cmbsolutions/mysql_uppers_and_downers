Namespace InfoSchema
    <Serializable>
    Public Class relation
        Property toTable As Table
        Property toColumn As Column
        Property localColumn As Column
        Property isOptional As Boolean
        Property [alias] As String
    End Class
End Namespace

