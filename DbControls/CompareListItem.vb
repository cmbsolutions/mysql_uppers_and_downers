Imports System.ComponentModel

Public Class CompareListItem
    Implements IDisposable

    Friend InternalObjects As List(Of CompareListItem)
    Private InternalIsGroup As Boolean
    Private InternalIsSelected As Boolean
    Private InternalGroupType As EGroupTypes
    Private InternalSourceObjectType As EObjectTypes
    Private InternalTargetObjectType As EObjectTypes
    Private InternalIsExpanded As Boolean = False
    Private InternalOperationType As EOperations
    Private InternalExpandable As Boolean
    Private InternalSourceName As String
    Private InternalTargetName As String
    Private disposedValue As Boolean
    Private InternalIsDirty As Boolean = False

    Private UiObject As UcCompareObject

    Public Function IsDirty() As Boolean
        If InternalIsDirty Then
            InternalIsDirty = False
            Return True
        Else
            Return False
        End If
    End Function

    Public Function DrawListItem() As UcCompareObject
        'If UiObject Is Nothing Then
        '    UiObject = New UcCompareObject With {
        '        '.ParentObject = Me
        '    }
        'End If

        Return UiObject
    End Function

    Property IsGroup As Boolean
        Get
            Return InternalIsGroup
        End Get
        Set(value As Boolean)
            If InternalIsGroup <> value Then
                InternalIsGroup = value
                InternalIsDirty = True
            End If
        End Set
    End Property

    Property GroupType As EGroupTypes
        Get
            Return InternalGroupType
        End Get
        Set(value As EGroupTypes)
            If InternalGroupType <> value Then
                InternalGroupType = value
                InternalIsDirty = True
            End If
        End Set
    End Property

    Property SourceObjectType As EObjectTypes
        Get
            Return InternalSourceObjectType
        End Get
        Set(value As EObjectTypes)
            If InternalSourceObjectType <> value Then
                InternalSourceObjectType = value
                InternalIsDirty = True
            End If
        End Set
    End Property

    Property TargetObjectType As EObjectTypes
        Get
            Return InternalTargetObjectType
        End Get
        Set(value As EObjectTypes)
            If InternalTargetObjectType <> value Then
                InternalTargetObjectType = value
                InternalIsDirty = True
            End If
        End Set
    End Property

    Property IsSelected As Boolean
        Get
            Return InternalIsSelected
        End Get
        Set(value As Boolean)
            If InternalIsSelected <> value Then
                InternalIsSelected = value
                InternalIsDirty = True
            End If
        End Set
    End Property

    Property SourceObjectName As String
        Get
            Return InternalSourceName
        End Get
        Set(value As String)
            If InternalSourceName <> value Then
                InternalSourceName = value
                InternalIsDirty = True
            End If
        End Set
    End Property

    Property TargetObjectName As String
        Get
            Return InternalTargetName
        End Get
        Set(value As String)
            If InternalTargetName <> value Then
                InternalTargetName = value
                InternalIsDirty = True
            End If
        End Set
    End Property

    ReadOnly Property GetHeight() As Integer
        Get
            Dim Height As Integer = 0
            If InternalObjects IsNot Nothing AndAlso InternalIsExpanded Then
                Height = InternalObjects.Sum(Function(c) c.GetHeight)
            Else
                Height = 24
            End If

            Return Height
        End Get
    End Property

    Property IsExpanded As Boolean
        Get
            Return InternalIsExpanded
        End Get
        Set(value As Boolean)
            If InternalIsExpanded <> value Then
                InternalIsExpanded = value
                InternalIsDirty = True
            End If
        End Set
    End Property

    Property OperationType As EOperations
        Get
            Return InternalOperationType
        End Get
        Set(value As EOperations)
            If InternalOperationType <> value Then
                InternalOperationType = value
                InternalIsDirty = True
            End If
        End Set
    End Property

    Property IsExpandable As Boolean
        Get
            Return InternalExpandable
        End Get
        Set(value As Boolean)
            If InternalExpandable <> value Then
                InternalExpandable = value
                InternalIsDirty = True
            End If
        End Set
    End Property


    Sub UpdateGroupCount()
        If InternalIsGroup Then
            Select Case GroupType
                Case EGroupTypes.NOOPERATION
                    SourceObjectName = $"No operation ({InternalObjects.Count} objects)"
                Case EGroupTypes.CREATED, EGroupTypes.DELETED, EGroupTypes.MODIFIED
                    SourceObjectName = $"Objects to be {InternalGroupType.ToString.ToLower} ({InternalObjects.Where(Function(c) c.IsSelected).Count} of {InternalObjects.Count} selected)"
            End Select
        End If
    End Sub

    Public Sub Add(obj As CompareListItem)
        If InternalObjects Is Nothing Then InternalObjects = New List(Of CompareListItem)
        InternalObjects.Add(obj)
    End Sub

#Region "Dispose"
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                If InternalObjects Is Nothing Then InternalObjects.ForEach(Sub(c) c.Dispose())
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
            ' TODO: set large fields to null
            disposedValue = True
        End If
    End Sub

    ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
    ' Protected Overrides Sub Finalize()
    '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
    '     Dispose(disposing:=False)
    '     MyBase.Finalize()
    ' End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
