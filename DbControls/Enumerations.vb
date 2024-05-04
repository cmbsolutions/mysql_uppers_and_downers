Public Enum EGroupTypes
    NONE
    MODIFIED
    CREATED
    DELETED
    NOOPERATION
End Enum

Public Enum EOperations
    NONE
    MODIFY
    ADD
    REMOVE
End Enum

Public Enum EObjectTypes
    NONE
    TABLE
    FIELD
    INDEX
    FOREIGNKEY
    PRIMARYKEY
    VIEW
    [FUNCTION]
    PROCEDURE
    TRIGGER
    OPTIONS
End Enum

Public Class ResXHelper
    Public Shared Function GetImageFromEnum(e As EObjectTypes) As Image
        Select Case e
            Case EObjectTypes.TABLE
                Return My.Resources.table
            Case EObjectTypes.FIELD
                Return My.Resources.table_field
            Case EObjectTypes.INDEX
                Return My.Resources.sort
            Case EObjectTypes.FOREIGNKEY
                Return My.Resources.relationships
            Case EObjectTypes.PRIMARYKEY
                Return My.Resources.key
            Case EObjectTypes.VIEW
                Return My.Resources.Vierw16
            Case EObjectTypes.FUNCTION
                Return My.Resources.Fx16
            Case EObjectTypes.PROCEDURE
                Return My.Resources.Px16
            Case EObjectTypes.TRIGGER
                Return My.Resources.execute
            Case EObjectTypes.OPTIONS
                Return My.Resources.table_gear
            Case Else
                Return Nothing
        End Select
    End Function

    Public Shared Function GetImageFromEnum(e As EOperations) As Image
        Select Case e
            Case EOperations.MODIFY
                Return My.Resources.arrow_right
            Case EOperations.ADD
                Return My.Resources.add
            Case EOperations.REMOVE
                Return My.Resources.delete
            Case Else
                Return Nothing
        End Select
    End Function

    Public Shared Function GetImageFromEnum(e As EGroupTypes) As Image
        Select Case e
            Case EGroupTypes.MODIFIED
                Return My.Resources.arrow_right
            Case EGroupTypes.CREATED
                Return My.Resources.add
            Case EGroupTypes.DELETED
                Return My.Resources.delete
            Case EGroupTypes.NOOPERATION
                Return My.Resources.Equals16
            Case Else
                Return Nothing
        End Select
    End Function
End Class