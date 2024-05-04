<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits DevComponents.DotNetBar.OfficeForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim SuperTabItemColorTable1 As DevComponents.DotNetBar.Rendering.SuperTabItemColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemColorTable()
        Dim SuperTabColorStates1 As DevComponents.DotNetBar.Rendering.SuperTabColorStates = New DevComponents.DotNetBar.Rendering.SuperTabColorStates()
        Dim SuperTabItemStateColorTable1 As DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable()
        Dim SuperTabLinearGradientColorTable1 As DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable = New DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.StyleManagerAmbient1 = New DevComponents.DotNetBar.StyleManagerAmbient(Me.components)
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.AdvTree1 = New DevComponents.AdvTree.AdvTree()
        Me.GroupStyle = New DevComponents.DotNetBar.ElementStyle()
        Me.NodeGroupTemplate = New DevComponents.AdvTree.Node()
        Me.NodeTemplateObject = New DevComponents.AdvTree.Node()
        Me.ColumnName = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnType = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnAttributes = New DevComponents.AdvTree.ColumnHeader()
        Me.NodeTemplateColumn = New DevComponents.AdvTree.Node()
        Me.Cell1 = New DevComponents.AdvTree.Cell()
        Me.Cell2 = New DevComponents.AdvTree.Cell()
        Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
        Me.DefaultStyle = New DevComponents.DotNetBar.ElementStyle()
        Me.Compare = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.BNext = New DevComponents.DotNetBar.ButtonX()
        Me.Connections = New DevComponents.DotNetBar.SuperTabItem()
        Me.DbFrom = New CMBSolutions.Db.UcConnectionControl()
        Me.DbTo = New CMBSolutions.Db.UcConnectionControl()
        Me.ComparableObjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElementHost2 = New System.Windows.Forms.Integration.ElementHost()
        Me.DiffViewer1 = New DiffPlex.Wpf.Controls.DiffViewer()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel1.SuspendLayout()
        CType(Me.ComparableObjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'SuperTabControl1
        '
        Me.SuperTabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl1.ForeColor = System.Drawing.Color.White
        Me.SuperTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 1
        Me.SuperTabControl1.Size = New System.Drawing.Size(800, 450)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 0
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Connections, Me.Compare})
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.SplitContainer1)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 27)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(800, 423)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.Compare
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.AdvTree1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ElementHost2)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 423)
        Me.SplitContainer1.SplitterDistance = 241
        Me.SplitContainer1.SplitterWidth = 8
        Me.SplitContainer1.TabIndex = 3
        '
        'AdvTree1
        '
        Me.AdvTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.AdvTree1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        '
        '
        '
        Me.AdvTree1.BackgroundStyle.Class = "TreeBorderKey"
        Me.AdvTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AdvTree1.ColumnsVisible = False
        Me.AdvTree1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdvTree1.DragDropEnabled = False
        Me.AdvTree1.DragDropNodeCopyEnabled = False
        Me.AdvTree1.ExpandButtonSize = New System.Drawing.Size(9, 9)
        Me.AdvTree1.ExpandImage = Global.CMBSolutions.Db.My.Resources.Resources.ButtonPlus9
        Me.AdvTree1.ExpandImageCollapse = Global.CMBSolutions.Db.My.Resources.Resources.ButtonMin9
        Me.AdvTree1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdvTree1.GridColumnLines = False
        Me.AdvTree1.GridRowLines = True
        Me.AdvTree1.GroupNodeStyle = Me.GroupStyle
        Me.AdvTree1.HotTracking = True
        Me.AdvTree1.Location = New System.Drawing.Point(0, 0)
        Me.AdvTree1.MultiNodeDragCountVisible = False
        Me.AdvTree1.MultiNodeDragDropAllowed = False
        Me.AdvTree1.Name = "AdvTree1"
        Me.AdvTree1.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.NodeGroupTemplate, Me.NodeTemplateObject, Me.NodeTemplateColumn})
        Me.AdvTree1.NodesConnector = Me.NodeConnector1
        Me.AdvTree1.NodeStyle = Me.DefaultStyle
        Me.AdvTree1.PathSeparator = ";"
        Me.AdvTree1.Size = New System.Drawing.Size(800, 241)
        Me.AdvTree1.Styles.Add(Me.DefaultStyle)
        Me.AdvTree1.Styles.Add(Me.GroupStyle)
        Me.AdvTree1.TabIndex = 0
        '
        'GroupStyle
        '
        Me.GroupStyle.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupStyle.BackColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.SteelBlue, 0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer)), 1.0!)})
        Me.GroupStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupStyle.Name = "GroupStyle"
        Me.GroupStyle.TextColor = System.Drawing.Color.WhiteSmoke
        '
        'NodeGroupTemplate
        '
        Me.NodeGroupTemplate.CheckBoxVisible = True
        Me.NodeGroupTemplate.Checked = True
        Me.NodeGroupTemplate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NodeGroupTemplate.DragDropEnabled = False
        Me.NodeGroupTemplate.Expanded = True
        Me.NodeGroupTemplate.Name = "NodeGroupTemplate"
        Me.NodeGroupTemplate.NodesColumnsHeaderVisible = False
        Me.NodeGroupTemplate.Style = Me.GroupStyle
        Me.NodeGroupTemplate.Text = "Objects to be modified (11/11)"
        '
        'NodeTemplateObject
        '
        Me.NodeTemplateObject.CheckBoxVisible = True
        Me.NodeTemplateObject.Checked = True
        Me.NodeTemplateObject.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NodeTemplateObject.DragDropEnabled = False
        Me.NodeTemplateObject.Editable = False
        Me.NodeTemplateObject.Expanded = True
        Me.NodeTemplateObject.FullRowBackground = True
        Me.NodeTemplateObject.Image = CType(resources.GetObject("NodeTemplateObject.Image"), System.Drawing.Image)
        Me.NodeTemplateObject.Name = "NodeTemplateObject"
        Me.NodeTemplateObject.NodesColumns.Add(Me.ColumnName)
        Me.NodeTemplateObject.NodesColumns.Add(Me.ColumnType)
        Me.NodeTemplateObject.NodesColumns.Add(Me.ColumnAttributes)
        Me.NodeTemplateObject.NodesColumnsHeaderVisible = False
        Me.NodeTemplateObject.Text = "actions"
        '
        'ColumnName
        '
        Me.ColumnName.Editable = False
        Me.ColumnName.Name = "ColumnName"
        Me.ColumnName.SortingEnabled = False
        Me.ColumnName.Text = "Name"
        Me.ColumnName.Width.Absolute = 150
        '
        'ColumnType
        '
        Me.ColumnType.Editable = False
        Me.ColumnType.Name = "ColumnType"
        Me.ColumnType.SortingEnabled = False
        Me.ColumnType.Text = "Type"
        Me.ColumnType.Width.Absolute = 50
        '
        'ColumnAttributes
        '
        Me.ColumnAttributes.Editable = False
        Me.ColumnAttributes.Name = "ColumnAttributes"
        Me.ColumnAttributes.SortingEnabled = False
        Me.ColumnAttributes.Text = "Attributes"
        Me.ColumnAttributes.Width.Absolute = 150
        '
        'NodeTemplateColumn
        '
        Me.NodeTemplateColumn.Cells.Add(Me.Cell1)
        Me.NodeTemplateColumn.Cells.Add(Me.Cell2)
        Me.NodeTemplateColumn.CheckBoxVisible = True
        Me.NodeTemplateColumn.DragDropEnabled = False
        Me.NodeTemplateColumn.Editable = False
        Me.NodeTemplateColumn.FullRowBackground = True
        Me.NodeTemplateColumn.Image = CType(resources.GetObject("NodeTemplateColumn.Image"), System.Drawing.Image)
        Me.NodeTemplateColumn.Name = "NodeTemplateColumn"
        Me.NodeTemplateColumn.NodesColumnsHeaderVisible = False
        Me.NodeTemplateColumn.Text = "action_id"
        '
        'Cell1
        '
        Me.Cell1.Editable = False
        Me.Cell1.Name = "Cell1"
        Me.Cell1.StyleMouseOver = Nothing
        Me.Cell1.Text = "int(10)"
        '
        'Cell2
        '
        Me.Cell2.Editable = False
        Me.Cell2.Name = "Cell2"
        Me.Cell2.StyleMouseOver = Nothing
        Me.Cell2.Text = "Not Null AutoIncrement"
        '
        'NodeConnector1
        '
        Me.NodeConnector1.LineColor = System.Drawing.Color.Silver
        '
        'DefaultStyle
        '
        Me.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.DefaultStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DefaultStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultStyle.Name = "DefaultStyle"
        Me.DefaultStyle.TextColor = System.Drawing.Color.WhiteSmoke
        '
        'Compare
        '
        Me.Compare.AttachedControl = Me.SuperTabControlPanel2
        Me.Compare.AutoCollapseOnClick = False
        Me.Compare.CanCustomize = False
        Me.Compare.CloseButtonVisible = False
        Me.Compare.Enabled = False
        Me.Compare.GlobalItem = False
        Me.Compare.Name = "Compare"
        Me.Compare.Text = "Compare"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.BNext)
        Me.SuperTabControlPanel1.Controls.Add(Me.DbFrom)
        Me.SuperTabControlPanel1.Controls.Add(Me.DbTo)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 27)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(800, 423)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.Connections
        '
        'BNext
        '
        Me.BNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BNext.Location = New System.Drawing.Point(713, 388)
        Me.BNext.Name = "BNext"
        Me.BNext.Size = New System.Drawing.Size(75, 23)
        Me.BNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BNext.TabIndex = 8
        Me.BNext.Text = "Next"
        '
        'Connections
        '
        Me.Connections.AttachedControl = Me.SuperTabControlPanel1
        Me.Connections.AutoCollapseOnClick = False
        Me.Connections.CanCustomize = False
        Me.Connections.CloseButtonVisible = False
        Me.Connections.GlobalItem = False
        Me.Connections.Name = "Connections"
        SuperTabLinearGradientColorTable1.AdaptiveGradient = False
        SuperTabLinearGradientColorTable1.Colors = New System.Drawing.Color(-1) {}
        SuperTabLinearGradientColorTable1.Positions = New Single(-1) {}
        SuperTabItemStateColorTable1.Background = SuperTabLinearGradientColorTable1
        SuperTabColorStates1.Normal = SuperTabItemStateColorTable1
        SuperTabItemColorTable1.Default = SuperTabColorStates1
        Me.Connections.TabColor = SuperTabItemColorTable1
        Me.Connections.Text = "Connections"
        '
        'DbFrom
        '
        Me.DbFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DbFrom.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DbFrom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DbFrom.InfoManager = Nothing
        Me.DbFrom.Location = New System.Drawing.Point(81, 46)
        Me.DbFrom.Name = "DbFrom"
        Me.DbFrom.Size = New System.Drawing.Size(308, 246)
        Me.DbFrom.TabIndex = 6
        '
        'DbTo
        '
        Me.DbTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DbTo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DbTo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DbTo.InfoManager = Nothing
        Me.DbTo.Location = New System.Drawing.Point(395, 46)
        Me.DbTo.Name = "DbTo"
        Me.DbTo.Size = New System.Drawing.Size(308, 246)
        Me.DbTo.TabIndex = 7
        '
        'ComparableObjectBindingSource
        '
        Me.ComparableObjectBindingSource.DataMember = "GetDatabaseObjects"
        Me.ComparableObjectBindingSource.DataSource = GetType(CMBSolutions.Db.Models.CompareContext)
        '
        'ElementHost2
        '
        Me.ElementHost2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ElementHost2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElementHost2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ElementHost2.Location = New System.Drawing.Point(0, 0)
        Me.ElementHost2.Margin = New System.Windows.Forms.Padding(0)
        Me.ElementHost2.Name = "ElementHost2"
        Me.ElementHost2.Size = New System.Drawing.Size(800, 174)
        Me.ElementHost2.TabIndex = 2
        Me.ElementHost2.Text = "ElementHost2"
        Me.ElementHost2.Child = Me.DiffViewer1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SuperTabControl1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TitleText = "MySql Uppers & Downers"
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel1.ResumeLayout(False)
        CType(Me.ComparableObjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents StyleManagerAmbient1 As DevComponents.DotNetBar.StyleManagerAmbient
    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents Connections As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents Compare As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents DbTo As UcConnectionControl
    Friend WithEvents BNext As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DbFrom As UcConnectionControl
    Friend WithEvents AdvTree1 As DevComponents.AdvTree.AdvTree
    Friend WithEvents ComparableObjectBindingSource As BindingSource
    Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents DefaultStyle As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents NodeTemplateObject As DevComponents.AdvTree.Node
    Friend WithEvents NodeTemplateColumn As DevComponents.AdvTree.Node
    Friend WithEvents Cell1 As DevComponents.AdvTree.Cell
    Friend WithEvents Cell2 As DevComponents.AdvTree.Cell
    Friend WithEvents ColumnName As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnType As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnAttributes As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents GroupStyle As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents NodeGroupTemplate As DevComponents.AdvTree.Node
    Friend WithEvents ElementHost2 As Integration.ElementHost
    Friend DiffViewer1 As DiffPlex.Wpf.Controls.DiffViewer
End Class
