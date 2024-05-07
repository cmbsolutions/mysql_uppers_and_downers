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
        Dim SuperTabItemColorTable2 As DevComponents.DotNetBar.Rendering.SuperTabItemColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemColorTable()
        Dim SuperTabColorStates2 As DevComponents.DotNetBar.Rendering.SuperTabColorStates = New DevComponents.DotNetBar.Rendering.SuperTabColorStates()
        Dim SuperTabItemStateColorTable2 As DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable()
        Dim SuperTabLinearGradientColorTable2 As DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable = New DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.StyleManagerAmbient1 = New DevComponents.DotNetBar.StyleManagerAmbient(Me.components)
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SourceSelectionTree = New DevComponents.AdvTree.AdvTree()
        Me.ElementStyleGroup = New DevComponents.DotNetBar.ElementStyle()
        Me.SelectGroupNode = New DevComponents.AdvTree.Node()
        Me.TableNode = New DevComponents.AdvTree.Node()
        Me.ColumnName = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnType = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnAttributes = New DevComponents.AdvTree.ColumnHeader()
        Me.ColumnNode = New DevComponents.AdvTree.Node()
        Me.NodeConnector2 = New DevComponents.AdvTree.NodeConnector()
        Me.ElementStyleDefault = New DevComponents.DotNetBar.ElementStyle()
        Me.ElementStyleHover = New DevComponents.DotNetBar.ElementStyle()
        Me.ElementStyleAlt = New DevComponents.DotNetBar.ElementStyle()
        Me.DestinationSelectionTree = New DevComponents.AdvTree.AdvTree()
        Me.NodeConnector3 = New DevComponents.AdvTree.NodeConnector()
        Me.STISyncObjectSelection = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.BNext = New DevComponents.DotNetBar.ButtonX()
        Me.DbFrom = New CMBSolutions.Db.UcConnectionControl()
        Me.DbTo = New CMBSolutions.Db.UcConnectionControl()
        Me.Connections = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.AdvTree1 = New DevComponents.AdvTree.AdvTree()
        Me.GroupStyle = New DevComponents.DotNetBar.ElementStyle()
        Me.NodeGroupTemplate = New DevComponents.AdvTree.Node()
        Me.NodeTemplateObject = New DevComponents.AdvTree.Node()
        Me.NodeTemplateColumn = New DevComponents.AdvTree.Node()
        Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
        Me.DefaultStyle = New DevComponents.DotNetBar.ElementStyle()
        Me.ElementHost2 = New System.Windows.Forms.Integration.ElementHost()
        Me.DiffViewer1 = New DiffPlex.Wpf.Controls.DiffViewer()
        Me.Compare = New DevComponents.DotNetBar.SuperTabItem()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel3.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SourceSelectionTree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DestinationSelectionTree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
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
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Connections, Me.Compare, Me.STISyncObjectSelection})
        Me.SuperTabControl1.Text = "SuperTabControl1"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.SplitContainer2)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 27)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(800, 423)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me.STISyncObjectSelection
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SourceSelectionTree)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DestinationSelectionTree)
        Me.SplitContainer2.Size = New System.Drawing.Size(800, 423)
        Me.SplitContainer2.SplitterDistance = 398
        Me.SplitContainer2.TabIndex = 0
        '
        'SourceSelectionTree
        '
        Me.SourceSelectionTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.SourceSelectionTree.AllowDrop = False
        Me.SourceSelectionTree.AllowExternalDrop = False
        Me.SourceSelectionTree.AlternateRowColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SourceSelectionTree.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        '
        '
        '
        Me.SourceSelectionTree.BackgroundStyle.Class = "TreeBorderKey"
        Me.SourceSelectionTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SourceSelectionTree.ColumnsVisible = False
        Me.SourceSelectionTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SourceSelectionTree.ExpandButtonSize = New System.Drawing.Size(9, 9)
        Me.SourceSelectionTree.ExpandImage = Global.CMBSolutions.Db.My.Resources.Resources.ButtonPlus9
        Me.SourceSelectionTree.ExpandImageCollapse = Global.CMBSolutions.Db.My.Resources.Resources.ButtonMin9
        Me.SourceSelectionTree.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SourceSelectionTree.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.SourceSelectionTree.GridColumnLines = False
        Me.SourceSelectionTree.GridLinesColor = System.Drawing.Color.DimGray
        Me.SourceSelectionTree.GridRowLines = True
        Me.SourceSelectionTree.GroupNodeStyle = Me.ElementStyleGroup
        Me.SourceSelectionTree.HotTracking = True
        Me.SourceSelectionTree.Location = New System.Drawing.Point(0, 0)
        Me.SourceSelectionTree.MultiSelect = True
        Me.SourceSelectionTree.Name = "SourceSelectionTree"
        Me.SourceSelectionTree.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.SelectGroupNode, Me.TableNode, Me.ColumnNode})
        Me.SourceSelectionTree.NodesConnector = Me.NodeConnector2
        Me.SourceSelectionTree.NodeStyle = Me.ElementStyleDefault
        Me.SourceSelectionTree.NodeStyleMouseOver = Me.ElementStyleHover
        Me.SourceSelectionTree.PathSeparator = ";"
        Me.SourceSelectionTree.Size = New System.Drawing.Size(398, 423)
        Me.SourceSelectionTree.Styles.Add(Me.ElementStyleDefault)
        Me.SourceSelectionTree.Styles.Add(Me.ElementStyleGroup)
        Me.SourceSelectionTree.Styles.Add(Me.ElementStyleHover)
        Me.SourceSelectionTree.Styles.Add(Me.ElementStyleAlt)
        Me.SourceSelectionTree.TabIndex = 1
        '
        'ElementStyleGroup
        '
        Me.ElementStyleGroup.BackColor = System.Drawing.Color.SteelBlue
        Me.ElementStyleGroup.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ElementStyleGroup.BackColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.SteelBlue, 0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer)), 1.0!)})
        Me.ElementStyleGroup.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyleGroup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElementStyleGroup.Name = "ElementStyleGroup"
        Me.ElementStyleGroup.TextColor = System.Drawing.Color.WhiteSmoke
        '
        'SelectGroupNode
        '
        Me.SelectGroupNode.CheckBoxThreeState = True
        Me.SelectGroupNode.CheckBoxVisible = True
        Me.SelectGroupNode.DragDropEnabled = False
        Me.SelectGroupNode.Editable = False
        Me.SelectGroupNode.Expanded = True
        Me.SelectGroupNode.FullRowBackground = True
        Me.SelectGroupNode.Name = "SelectGroupNode"
        Me.SelectGroupNode.Style = Me.ElementStyleGroup
        Me.SelectGroupNode.Text = "Selectable items"
        Me.SelectGroupNode.Visible = False
        '
        'TableNode
        '
        Me.TableNode.CheckBoxThreeState = True
        Me.TableNode.CheckBoxVisible = True
        Me.TableNode.Editable = False
        Me.TableNode.FullRowBackground = True
        Me.TableNode.Image = CType(resources.GetObject("TableNode.Image"), System.Drawing.Image)
        Me.TableNode.Name = "TableNode"
        Me.TableNode.NodesColumns.Add(Me.ColumnName)
        Me.TableNode.NodesColumns.Add(Me.ColumnType)
        Me.TableNode.NodesColumns.Add(Me.ColumnAttributes)
        Me.TableNode.Text = "tablename"
        Me.TableNode.Visible = False
        '
        'ColumnName
        '
        Me.ColumnName.DisplayIndex = 0
        Me.ColumnName.Editable = False
        Me.ColumnName.Name = "ColumnName"
        Me.ColumnName.SortingEnabled = False
        Me.ColumnName.Text = "Name"
        Me.ColumnName.Width.Absolute = 150
        '
        'ColumnType
        '
        Me.ColumnType.DisplayIndex = 1
        Me.ColumnType.Editable = False
        Me.ColumnType.Name = "ColumnType"
        Me.ColumnType.SortingEnabled = False
        Me.ColumnType.Text = "Type"
        Me.ColumnType.Width.Absolute = 50
        '
        'ColumnAttributes
        '
        Me.ColumnAttributes.DisplayIndex = 2
        Me.ColumnAttributes.Editable = False
        Me.ColumnAttributes.Name = "ColumnAttributes"
        Me.ColumnAttributes.SortingEnabled = False
        Me.ColumnAttributes.Text = "Attributes"
        Me.ColumnAttributes.Width.Absolute = 150
        '
        'ColumnNode
        '
        Me.ColumnNode.CheckBoxVisible = True
        Me.ColumnNode.Editable = False
        Me.ColumnNode.FullRowBackground = True
        Me.ColumnNode.Image = CType(resources.GetObject("ColumnNode.Image"), System.Drawing.Image)
        Me.ColumnNode.Name = "ColumnNode"
        Me.ColumnNode.NodesColumnsHeaderVisible = False
        Me.ColumnNode.Text = "action_id"
        Me.ColumnNode.Visible = False
        '
        'NodeConnector2
        '
        Me.NodeConnector2.LineColor = System.Drawing.Color.Silver
        '
        'ElementStyleDefault
        '
        Me.ElementStyleDefault.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ElementStyleDefault.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyleDefault.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElementStyleDefault.Name = "ElementStyleDefault"
        Me.ElementStyleDefault.TextColor = System.Drawing.Color.WhiteSmoke
        '
        'ElementStyleHover
        '
        Me.ElementStyleHover.BackColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.SteelBlue, 0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.CornflowerBlue, 1.0!)})
        Me.ElementStyleHover.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyleHover.Name = "ElementStyleHover"
        '
        'ElementStyleAlt
        '
        Me.ElementStyleAlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ElementStyleAlt.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyleAlt.Name = "ElementStyleAlt"
        '
        'DestinationSelectionTree
        '
        Me.DestinationSelectionTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.DestinationSelectionTree.AlternateRowColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DestinationSelectionTree.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer))
        '
        '
        '
        Me.DestinationSelectionTree.BackgroundStyle.Class = "TreeBorderKey"
        Me.DestinationSelectionTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DestinationSelectionTree.ColumnsVisible = False
        Me.DestinationSelectionTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DestinationSelectionTree.ExpandButtonSize = New System.Drawing.Size(9, 9)
        Me.DestinationSelectionTree.ExpandImage = Global.CMBSolutions.Db.My.Resources.Resources.ButtonPlus9
        Me.DestinationSelectionTree.ExpandImageCollapse = Global.CMBSolutions.Db.My.Resources.Resources.ButtonMin9
        Me.DestinationSelectionTree.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DestinationSelectionTree.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DestinationSelectionTree.GridColumnLines = False
        Me.DestinationSelectionTree.GridLinesColor = System.Drawing.Color.DimGray
        Me.DestinationSelectionTree.GridRowLines = True
        Me.DestinationSelectionTree.HotTracking = True
        Me.DestinationSelectionTree.Location = New System.Drawing.Point(0, 0)
        Me.DestinationSelectionTree.MultiSelect = True
        Me.DestinationSelectionTree.Name = "DestinationSelectionTree"
        Me.DestinationSelectionTree.NodesConnector = Me.NodeConnector3
        Me.DestinationSelectionTree.PathSeparator = ";"
        Me.DestinationSelectionTree.Size = New System.Drawing.Size(398, 423)
        Me.DestinationSelectionTree.TabIndex = 2
        '
        'NodeConnector3
        '
        Me.NodeConnector3.LineColor = System.Drawing.Color.Silver
        '
        'STISyncObjectSelection
        '
        Me.STISyncObjectSelection.AttachedControl = Me.SuperTabControlPanel3
        Me.STISyncObjectSelection.CanCustomize = False
        Me.STISyncObjectSelection.CloseButtonVisible = False
        Me.STISyncObjectSelection.Enabled = False
        Me.STISyncObjectSelection.GlobalItem = False
        Me.STISyncObjectSelection.Name = "STISyncObjectSelection"
        Me.STISyncObjectSelection.Text = "Selections"
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
        'Connections
        '
        Me.Connections.AttachedControl = Me.SuperTabControlPanel1
        Me.Connections.AutoCollapseOnClick = False
        Me.Connections.CanCustomize = False
        Me.Connections.CloseButtonVisible = False
        Me.Connections.GlobalItem = False
        Me.Connections.Name = "Connections"
        SuperTabLinearGradientColorTable2.AdaptiveGradient = False
        SuperTabLinearGradientColorTable2.Colors = New System.Drawing.Color(-1) {}
        SuperTabLinearGradientColorTable2.Positions = New Single(-1) {}
        SuperTabItemStateColorTable2.Background = SuperTabLinearGradientColorTable2
        SuperTabColorStates2.Normal = SuperTabItemStateColorTable2
        SuperTabItemColorTable2.Default = SuperTabColorStates2
        Me.Connections.TabColor = SuperTabItemColorTable2
        Me.Connections.Text = "Connections"
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
        Me.AdvTree1.AllowDrop = False
        Me.AdvTree1.AllowExternalDrop = False
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
        Me.AdvTree1.ForeColor = System.Drawing.Color.WhiteSmoke
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
        'NodeTemplateColumn
        '
        Me.NodeTemplateColumn.CheckBoxVisible = True
        Me.NodeTemplateColumn.DragDropEnabled = False
        Me.NodeTemplateColumn.Editable = False
        Me.NodeTemplateColumn.FullRowBackground = True
        Me.NodeTemplateColumn.Image = CType(resources.GetObject("NodeTemplateColumn.Image"), System.Drawing.Image)
        Me.NodeTemplateColumn.Name = "NodeTemplateColumn"
        Me.NodeTemplateColumn.NodesColumnsHeaderVisible = False
        Me.NodeTemplateColumn.Text = "action_id"
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
        Me.Compare.Visible = False
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
        Me.SuperTabControlPanel3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.SourceSelectionTree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DestinationSelectionTree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents DefaultStyle As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents NodeTemplateObject As DevComponents.AdvTree.Node
    Friend WithEvents NodeTemplateColumn As DevComponents.AdvTree.Node
    Friend WithEvents ColumnName As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnType As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents ColumnAttributes As DevComponents.AdvTree.ColumnHeader
    Friend WithEvents GroupStyle As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents NodeGroupTemplate As DevComponents.AdvTree.Node
    Friend WithEvents ElementHost2 As Integration.ElementHost
    Friend DiffViewer1 As DiffPlex.Wpf.Controls.DiffViewer
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents STISyncObjectSelection As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SourceSelectionTree As DevComponents.AdvTree.AdvTree
    Friend WithEvents ElementStyleGroup As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents TableNode As DevComponents.AdvTree.Node
    Friend WithEvents ColumnNode As DevComponents.AdvTree.Node
    Friend WithEvents NodeConnector2 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyleDefault As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ElementStyleHover As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents SelectGroupNode As DevComponents.AdvTree.Node
    Friend WithEvents ElementStyleAlt As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents DestinationSelectionTree As DevComponents.AdvTree.AdvTree
    Friend WithEvents NodeConnector3 As DevComponents.AdvTree.NodeConnector
End Class
