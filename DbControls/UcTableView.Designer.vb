<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcTableView
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabColumns = New DevComponents.DotNetBar.SuperTabItem()
        Me.TabERD = New DevComponents.DotNetBar.SuperTabItem()
        Me.TabReferences = New DevComponents.DotNetBar.SuperTabItem()
        Me.TabStatistics = New DevComponents.DotNetBar.SuperTabItem()
        Me.TabIndexes = New DevComponents.DotNetBar.SuperTabItem()
        Me.TabFks = New DevComponents.DotNetBar.SuperTabItem()
        Me.STC = New DevComponents.DotNetBar.SuperTabControl()
        Me.STPDDL = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.SCDDL = New ScintillaNET.Scintilla()
        Me.STDDL = New DevComponents.DotNetBar.SuperTabItem()
        Me.STPColumns = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.DgvColumns = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.STColumns = New DevComponents.DotNetBar.SuperTabItem()
        Me.STPReferences = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.DgvReferences = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.STReferences = New DevComponents.DotNetBar.SuperTabItem()
        Me.STPIndexes = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.DgvIndexes = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.STIndexes = New DevComponents.DotNetBar.SuperTabItem()
        Me.STPFKs = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.DgvFks = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.STFks = New DevComponents.DotNetBar.SuperTabItem()
        Me.STPStatistics = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.STStatistics = New DevComponents.DotNetBar.SuperTabItem()
        Me.STPERDiagram = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.STERDiagram = New DevComponents.DotNetBar.SuperTabItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.StyleManagerAmbient1 = New DevComponents.DotNetBar.StyleManagerAmbient(Me.components)
        Me.ColumnHeader1 = New DevComponents.Tree.ColumnHeader()
        Me.ColumnHeader2 = New DevComponents.Tree.ColumnHeader()
        CType(Me.STC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.STC.SuspendLayout()
        Me.STPDDL.SuspendLayout()
        Me.STPColumns.SuspendLayout()
        CType(Me.DgvColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.STPReferences.SuspendLayout()
        CType(Me.DgvReferences, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.STPIndexes.SuspendLayout()
        CType(Me.DgvIndexes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.STPFKs.SuspendLayout()
        CType(Me.DgvFks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabColumns
        '
        Me.TabColumns.CloseButtonVisible = False
        Me.TabColumns.GlobalItem = False
        Me.TabColumns.Name = "TabColumns"
        Me.TabColumns.Symbol = ""
        Me.TabColumns.SymbolColor = System.Drawing.Color.DimGray
        Me.TabColumns.SymbolSize = 10.0!
        Me.TabColumns.Text = "Columns"
        '
        'TabERD
        '
        Me.TabERD.GlobalItem = False
        Me.TabERD.Name = "TabERD"
        Me.TabERD.Symbol = ""
        Me.TabERD.SymbolColor = System.Drawing.Color.DimGray
        Me.TabERD.SymbolSize = 10.0!
        Me.TabERD.Text = "ER Diagram"
        '
        'TabReferences
        '
        Me.TabReferences.GlobalItem = False
        Me.TabReferences.Name = "TabReferences"
        Me.TabReferences.Symbol = ""
        Me.TabReferences.SymbolColor = System.Drawing.Color.DimGray
        Me.TabReferences.SymbolSize = 10.0!
        Me.TabReferences.Text = "References"
        '
        'TabStatistics
        '
        Me.TabStatistics.GlobalItem = False
        Me.TabStatistics.Name = "TabStatistics"
        Me.TabStatistics.Symbol = "59535"
        Me.TabStatistics.SymbolColor = System.Drawing.Color.DimGray
        Me.TabStatistics.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.TabStatistics.SymbolSize = 12.0!
        Me.TabStatistics.Text = "Statistics"
        '
        'TabIndexes
        '
        Me.TabIndexes.GlobalItem = False
        Me.TabIndexes.Name = "TabIndexes"
        Me.TabIndexes.Symbol = ""
        Me.TabIndexes.SymbolColor = System.Drawing.Color.DimGray
        Me.TabIndexes.SymbolSize = 10.0!
        Me.TabIndexes.Text = "Indexes"
        '
        'TabFks
        '
        Me.TabFks.GlobalItem = False
        Me.TabFks.Name = "TabFks"
        Me.TabFks.Symbol = ""
        Me.TabFks.SymbolColor = System.Drawing.Color.DimGray
        Me.TabFks.SymbolSize = 10.0!
        Me.TabFks.Text = "Foreign keys"
        '
        'STC
        '
        Me.STC.AutoCloseTabs = False
        Me.STC.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.STC.CloseButtonOnTabsAlwaysDisplayed = False
        '
        '
        '
        '
        '
        '
        Me.STC.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.STC.ControlBox.MenuBox.Name = ""
        Me.STC.ControlBox.Name = ""
        Me.STC.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.STC.ControlBox.MenuBox, Me.STC.ControlBox.CloseBox})
        Me.STC.Controls.Add(Me.STPERDiagram)
        Me.STC.Controls.Add(Me.STPColumns)
        Me.STC.Controls.Add(Me.STPDDL)
        Me.STC.Controls.Add(Me.STPReferences)
        Me.STC.Controls.Add(Me.STPIndexes)
        Me.STC.Controls.Add(Me.STPFKs)
        Me.STC.Controls.Add(Me.STPStatistics)
        Me.STC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.STC.ForeColor = System.Drawing.Color.White
        Me.STC.Location = New System.Drawing.Point(0, 0)
        Me.STC.Name = "STC"
        Me.STC.ReorderTabsEnabled = True
        Me.STC.SelectedTabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.STC.SelectedTabIndex = 0
        Me.STC.Size = New System.Drawing.Size(638, 379)
        Me.STC.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left
        Me.STC.TabFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STC.TabIndex = 0
        Me.STC.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.STColumns, Me.STFks, Me.STIndexes, Me.STReferences, Me.STDDL, Me.STERDiagram, Me.STStatistics})
        '
        'STPDDL
        '
        Me.STPDDL.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.STPDDL.Controls.Add(Me.SCDDL)
        Me.STPDDL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.STPDDL.Location = New System.Drawing.Point(103, 0)
        Me.STPDDL.Name = "STPDDL"
        Me.STPDDL.Size = New System.Drawing.Size(535, 379)
        Me.STPDDL.TabIndex = 0
        Me.STPDDL.TabItem = Me.STDDL
        '
        'SCDDL
        '
        Me.SCDDL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SCDDL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SCDDL.FontQuality = ScintillaNET.FontQuality.AntiAliased
        Me.SCDDL.IdleStyling = ScintillaNET.IdleStyling.All
        Me.SCDDL.Lexer = ScintillaNET.Lexer.Sql
        Me.SCDDL.Location = New System.Drawing.Point(0, 0)
        Me.SCDDL.Name = "SCDDL"
        Me.SCDDL.Size = New System.Drawing.Size(535, 379)
        Me.SCDDL.TabIndex = 0
        '
        'STDDL
        '
        Me.STDDL.AttachedControl = Me.STPDDL
        Me.STDDL.GlobalItem = False
        Me.STDDL.Name = "STDDL"
        Me.STDDL.Symbol = ""
        Me.STDDL.SymbolColor = System.Drawing.Color.DimGray
        Me.STDDL.SymbolSize = 11.0!
        Me.STDDL.Text = "DDL"
        '
        'STPColumns
        '
        Me.STPColumns.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.STPColumns.Controls.Add(Me.DgvColumns)
        Me.STPColumns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.STPColumns.Location = New System.Drawing.Point(103, 0)
        Me.STPColumns.Name = "STPColumns"
        Me.STPColumns.Size = New System.Drawing.Size(535, 379)
        Me.STPColumns.TabIndex = 1
        Me.STPColumns.TabItem = Me.STColumns
        '
        'DgvColumns
        '
        Me.DgvColumns.AllowUserToAddRows = False
        Me.DgvColumns.AllowUserToDeleteRows = False
        Me.DgvColumns.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvColumns.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvColumns.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvColumns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvColumns.EnableHeadersVisualStyles = False
        Me.DgvColumns.GridColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.DgvColumns.Location = New System.Drawing.Point(0, 0)
        Me.DgvColumns.Name = "DgvColumns"
        Me.DgvColumns.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvColumns.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvColumns.Size = New System.Drawing.Size(535, 379)
        Me.DgvColumns.TabIndex = 0
        '
        'STColumns
        '
        Me.STColumns.AttachedControl = Me.STPColumns
        Me.STColumns.GlobalItem = False
        Me.STColumns.Name = "STColumns"
        Me.STColumns.Symbol = ""
        Me.STColumns.SymbolColor = System.Drawing.Color.DimGray
        Me.STColumns.SymbolSize = 10.0!
        Me.STColumns.Text = "Columns"
        '
        'STPReferences
        '
        Me.STPReferences.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.STPReferences.Controls.Add(Me.DgvReferences)
        Me.STPReferences.Dock = System.Windows.Forms.DockStyle.Fill
        Me.STPReferences.Location = New System.Drawing.Point(103, 0)
        Me.STPReferences.Name = "STPReferences"
        Me.STPReferences.Size = New System.Drawing.Size(535, 379)
        Me.STPReferences.TabIndex = 0
        Me.STPReferences.TabItem = Me.STReferences
        '
        'DgvReferences
        '
        Me.DgvReferences.AllowUserToAddRows = False
        Me.DgvReferences.AllowUserToDeleteRows = False
        Me.DgvReferences.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvReferences.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvReferences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvReferences.DefaultCellStyle = DataGridViewCellStyle5
        Me.DgvReferences.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvReferences.EnableHeadersVisualStyles = False
        Me.DgvReferences.GridColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.DgvReferences.Location = New System.Drawing.Point(0, 0)
        Me.DgvReferences.Name = "DgvReferences"
        Me.DgvReferences.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvReferences.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvReferences.Size = New System.Drawing.Size(535, 379)
        Me.DgvReferences.TabIndex = 1
        '
        'STReferences
        '
        Me.STReferences.AttachedControl = Me.STPReferences
        Me.STReferences.GlobalItem = False
        Me.STReferences.Name = "STReferences"
        Me.STReferences.Symbol = ""
        Me.STReferences.SymbolColor = System.Drawing.Color.DimGray
        Me.STReferences.SymbolSize = 10.0!
        Me.STReferences.Text = "References"
        '
        'STPIndexes
        '
        Me.STPIndexes.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.STPIndexes.Controls.Add(Me.DgvIndexes)
        Me.STPIndexes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.STPIndexes.Location = New System.Drawing.Point(103, 0)
        Me.STPIndexes.Name = "STPIndexes"
        Me.STPIndexes.Size = New System.Drawing.Size(535, 379)
        Me.STPIndexes.TabIndex = 0
        Me.STPIndexes.TabItem = Me.STIndexes
        '
        'DgvIndexes
        '
        Me.DgvIndexes.AllowUserToAddRows = False
        Me.DgvIndexes.AllowUserToDeleteRows = False
        Me.DgvIndexes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvIndexes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DgvIndexes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvIndexes.DefaultCellStyle = DataGridViewCellStyle8
        Me.DgvIndexes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvIndexes.EnableHeadersVisualStyles = False
        Me.DgvIndexes.GridColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.DgvIndexes.Location = New System.Drawing.Point(0, 0)
        Me.DgvIndexes.Name = "DgvIndexes"
        Me.DgvIndexes.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvIndexes.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DgvIndexes.Size = New System.Drawing.Size(535, 379)
        Me.DgvIndexes.TabIndex = 1
        '
        'STIndexes
        '
        Me.STIndexes.AttachedControl = Me.STPIndexes
        Me.STIndexes.GlobalItem = False
        Me.STIndexes.Name = "STIndexes"
        Me.STIndexes.Symbol = ""
        Me.STIndexes.SymbolColor = System.Drawing.Color.DimGray
        Me.STIndexes.SymbolSize = 10.0!
        Me.STIndexes.Text = "Indexes"
        '
        'STPFKs
        '
        Me.STPFKs.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.STPFKs.Controls.Add(Me.DgvFks)
        Me.STPFKs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.STPFKs.Location = New System.Drawing.Point(103, 0)
        Me.STPFKs.Name = "STPFKs"
        Me.STPFKs.Size = New System.Drawing.Size(535, 379)
        Me.STPFKs.TabIndex = 0
        Me.STPFKs.TabItem = Me.STFks
        '
        'DgvFks
        '
        Me.DgvFks.AllowUserToAddRows = False
        Me.DgvFks.AllowUserToDeleteRows = False
        Me.DgvFks.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvFks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DgvFks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvFks.DefaultCellStyle = DataGridViewCellStyle11
        Me.DgvFks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvFks.EnableHeadersVisualStyles = False
        Me.DgvFks.GridColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.DgvFks.Location = New System.Drawing.Point(0, 0)
        Me.DgvFks.Name = "DgvFks"
        Me.DgvFks.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvFks.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DgvFks.Size = New System.Drawing.Size(535, 379)
        Me.DgvFks.TabIndex = 1
        '
        'STFks
        '
        Me.STFks.AttachedControl = Me.STPFKs
        Me.STFks.GlobalItem = False
        Me.STFks.Name = "STFks"
        Me.STFks.Symbol = ""
        Me.STFks.SymbolColor = System.Drawing.Color.DimGray
        Me.STFks.SymbolSize = 10.0!
        Me.STFks.Text = "Foreign keys"
        '
        'STPStatistics
        '
        Me.STPStatistics.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.STPStatistics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.STPStatistics.Location = New System.Drawing.Point(103, 0)
        Me.STPStatistics.Name = "STPStatistics"
        Me.STPStatistics.Size = New System.Drawing.Size(535, 379)
        Me.STPStatistics.TabIndex = 0
        Me.STPStatistics.TabItem = Me.STStatistics
        '
        'STStatistics
        '
        Me.STStatistics.AttachedControl = Me.STPStatistics
        Me.STStatistics.GlobalItem = False
        Me.STStatistics.Name = "STStatistics"
        Me.STStatistics.Symbol = ""
        Me.STStatistics.SymbolColor = System.Drawing.Color.DimGray
        Me.STStatistics.SymbolSize = 10.0!
        Me.STStatistics.Text = "Statistics"
        '
        'STPERDiagram
        '
        Me.STPERDiagram.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.STPERDiagram.Dock = System.Windows.Forms.DockStyle.Fill
        Me.STPERDiagram.Location = New System.Drawing.Point(103, 0)
        Me.STPERDiagram.Name = "STPERDiagram"
        Me.STPERDiagram.Size = New System.Drawing.Size(535, 379)
        Me.STPERDiagram.TabIndex = 0
        Me.STPERDiagram.TabItem = Me.STERDiagram
        '
        'STERDiagram
        '
        Me.STERDiagram.AttachedControl = Me.STPERDiagram
        Me.STERDiagram.GlobalItem = False
        Me.STERDiagram.Name = "STERDiagram"
        Me.STERDiagram.Symbol = ""
        Me.STERDiagram.SymbolColor = System.Drawing.Color.DimGray
        Me.STERDiagram.SymbolSize = 10.0!
        Me.STERDiagram.Text = "ER Diagram"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.ColumnName = "ColHead1"
        Me.ColumnHeader1.Name = "ColumnHeader1"
        Me.ColumnHeader1.Text = "Column1"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Name = "ColumnHeader2"
        Me.ColumnHeader2.Text = "safvaf"
        '
        'UcTableView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Controls.Add(Me.STC)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UcTableView"
        Me.Size = New System.Drawing.Size(638, 379)
        CType(Me.STC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.STC.ResumeLayout(False)
        Me.STPDDL.ResumeLayout(False)
        Me.STPColumns.ResumeLayout(False)
        CType(Me.DgvColumns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.STPReferences.ResumeLayout(False)
        CType(Me.DgvReferences, System.ComponentModel.ISupportInitialize).EndInit()
        Me.STPIndexes.ResumeLayout(False)
        CType(Me.DgvIndexes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.STPFKs.ResumeLayout(False)
        CType(Me.DgvFks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabColumns As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents TabStatistics As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents TabReferences As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents TabIndexes As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents TabFks As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents TabERD As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents STC As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents STPColumns As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents STColumns As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents STPStatistics As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents STStatistics As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents STPERDiagram As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents STERDiagram As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents STPDDL As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents STDDL As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents STPReferences As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents STReferences As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents STPIndexes As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents STIndexes As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents STPFKs As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents STFks As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents DgvColumns As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents StyleManagerAmbient1 As DevComponents.DotNetBar.StyleManagerAmbient
    Friend WithEvents DgvReferences As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DgvIndexes As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DgvFks As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents SCDDL As ScintillaNET.Scintilla
    Friend WithEvents ColumnHeader2 As DevComponents.Tree.ColumnHeader
    Friend WithEvents ColumnHeader1 As DevComponents.Tree.ColumnHeader
End Class
