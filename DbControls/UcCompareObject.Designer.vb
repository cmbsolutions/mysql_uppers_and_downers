<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcCompareObject
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SourceName = New DevComponents.DotNetBar.LabelX()
        Me.ChkSelected = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PBOperation = New System.Windows.Forms.PictureBox()
        Me.PBTargetType = New System.Windows.Forms.PictureBox()
        Me.LTargetname = New DevComponents.DotNetBar.LabelX()
        Me.BExpand = New System.Windows.Forms.Button()
        Me.PBSourceType = New System.Windows.Forms.PictureBox()
        Me.FLPSubObjects = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.StyleManagerAmbient1 = New DevComponents.DotNetBar.StyleManagerAmbient(Me.components)
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PBOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBTargetType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBSourceType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SourceName
        '
        '
        '
        '
        Me.SourceName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SourceName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SourceName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SourceName.Location = New System.Drawing.Point(50, 0)
        Me.SourceName.Margin = New System.Windows.Forms.Padding(0)
        Me.SourceName.Name = "SourceName"
        Me.SourceName.Size = New System.Drawing.Size(349, 20)
        Me.SourceName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SourceName.TabIndex = 4
        Me.SourceName.Text = "actions"
        '
        'ChkSelected
        '
        '
        '
        '
        Me.ChkSelected.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkSelected.Checked = True
        Me.ChkSelected.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkSelected.CheckValue = "True"
        Me.ChkSelected.CheckValueChecked = "True"
        Me.ChkSelected.CheckValueUnchecked = "False"
        Me.ChkSelected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkSelected.Location = New System.Drawing.Point(12, 0)
        Me.ChkSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.ChkSelected.Name = "ChkSelected"
        Me.ChkSelected.Size = New System.Drawing.Size(20, 20)
        Me.ChkSelected.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChkSelected.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PBOperation, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PBTargetType, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LTargetname, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ChkSelected, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SourceName, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BExpand, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PBSourceType, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(836, 20)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'PBOperation
        '
        Me.PBOperation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBOperation.Image = Global.CMBSolutions.Db.My.Resources.Resources.arrow_right
        Me.PBOperation.Location = New System.Drawing.Point(399, 0)
        Me.PBOperation.Margin = New System.Windows.Forms.Padding(0)
        Me.PBOperation.Name = "PBOperation"
        Me.PBOperation.Size = New System.Drawing.Size(70, 20)
        Me.PBOperation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBOperation.TabIndex = 12
        Me.PBOperation.TabStop = False
        '
        'PBTargetType
        '
        Me.PBTargetType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBTargetType.Image = Global.CMBSolutions.Db.My.Resources.Resources.table
        Me.PBTargetType.Location = New System.Drawing.Point(469, 0)
        Me.PBTargetType.Margin = New System.Windows.Forms.Padding(0)
        Me.PBTargetType.Name = "PBTargetType"
        Me.PBTargetType.Size = New System.Drawing.Size(18, 20)
        Me.PBTargetType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBTargetType.TabIndex = 11
        Me.PBTargetType.TabStop = False
        '
        'LTargetname
        '
        '
        '
        '
        Me.LTargetname.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LTargetname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LTargetname.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTargetname.Location = New System.Drawing.Point(487, 0)
        Me.LTargetname.Margin = New System.Windows.Forms.Padding(0)
        Me.LTargetname.Name = "LTargetname"
        Me.LTargetname.Size = New System.Drawing.Size(349, 20)
        Me.LTargetname.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LTargetname.TabIndex = 8
        Me.LTargetname.Text = "actions"
        '
        'BExpand
        '
        Me.BExpand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BExpand.FlatAppearance.BorderSize = 0
        Me.BExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BExpand.Image = Global.CMBSolutions.Db.My.Resources.Resources.ButtonPlus9
        Me.BExpand.Location = New System.Drawing.Point(0, 0)
        Me.BExpand.Margin = New System.Windows.Forms.Padding(0)
        Me.BExpand.Name = "BExpand"
        Me.BExpand.Size = New System.Drawing.Size(12, 20)
        Me.BExpand.TabIndex = 9
        Me.BExpand.UseVisualStyleBackColor = False
        '
        'PBSourceType
        '
        Me.PBSourceType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBSourceType.Image = Global.CMBSolutions.Db.My.Resources.Resources.table
        Me.PBSourceType.Location = New System.Drawing.Point(32, 0)
        Me.PBSourceType.Margin = New System.Windows.Forms.Padding(0)
        Me.PBSourceType.Name = "PBSourceType"
        Me.PBSourceType.Size = New System.Drawing.Size(18, 20)
        Me.PBSourceType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBSourceType.TabIndex = 10
        Me.PBSourceType.TabStop = False
        '
        'FLPSubObjects
        '
        Me.FLPSubObjects.AutoSize = True
        Me.FLPSubObjects.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FLPSubObjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLPSubObjects.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLPSubObjects.Location = New System.Drawing.Point(12, 44)
        Me.FLPSubObjects.Margin = New System.Windows.Forms.Padding(0)
        Me.FLPSubObjects.Name = "FLPSubObjects"
        Me.FLPSubObjects.Size = New System.Drawing.Size(824, 20)
        Me.FLPSubObjects.TabIndex = 7
        Me.FLPSubObjects.WrapContents = False
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 44)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(12, 20)
        Me.Panel1.TabIndex = 8
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel2.SetColumnSpan(Me.LabelX1, 2)
        Me.LabelX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelX1.FontBold = True
        Me.LabelX1.Location = New System.Drawing.Point(32, 0)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(367, 24)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LabelX1.TabIndex = 13
        Me.LabelX1.Text = "Source Object"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelX2.FontBold = True
        Me.LabelX2.Location = New System.Drawing.Point(399, 0)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(70, 24)
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LabelX2.TabIndex = 14
        Me.LabelX2.Text = "Operation"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TableLayoutPanel2.SetColumnSpan(Me.LabelX3, 2)
        Me.LabelX3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelX3.FontBold = True
        Me.LabelX3.Location = New System.Drawing.Point(469, 0)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(367, 24)
        Me.LabelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LabelX3.TabIndex = 15
        Me.LabelX3.Text = "Target Object"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(836, 24)
        Me.Panel2.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 7
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX2, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX3, 5, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(836, 24)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'UcCompareObject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Controls.Add(Me.FLPSubObjects)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "UcCompareObject"
        Me.Size = New System.Drawing.Size(836, 64)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PBOperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBTargetType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBSourceType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SourceName As DevComponents.DotNetBar.LabelX
    Friend WithEvents ChkSelected As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LTargetname As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FLPSubObjects As FlowLayoutPanel
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents StyleManagerAmbient1 As DevComponents.DotNetBar.StyleManagerAmbient
    Friend WithEvents BExpand As Button
    Friend WithEvents PBSourceType As PictureBox
    Friend WithEvents PBTargetType As PictureBox
    Friend WithEvents PBOperation As PictureBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
