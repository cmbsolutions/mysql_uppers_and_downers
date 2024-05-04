<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcGroup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UcGroup))
        Me.ChkGroup = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.StyleManagerAmbient1 = New DevComponents.DotNetBar.StyleManagerAmbient(Me.components)
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SymbolBox1 = New DevComponents.DotNetBar.Controls.SymbolBox()
        Me.SuspendLayout()
        '
        'ChkGroup
        '
        '
        '
        '
        Me.ChkGroup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ChkGroup.CheckValue = "False"
        Me.ChkGroup.CheckValueChecked = "True"
        Me.ChkGroup.CheckValueUnchecked = "False"
        Me.ChkGroup.Location = New System.Drawing.Point(3, 3)
        Me.ChkGroup.Name = "ChkGroup"
        Me.ChkGroup.Size = New System.Drawing.Size(15, 23)
        Me.ChkGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ChkGroup.TabIndex = 0
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
        Me.LabelX1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(46, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(294, 23)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Objects to be modified (0 of 0 selected)"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "arrow.png")
        Me.ImageList1.Images.SetKeyName(1, "arrow_180.png")
        Me.ImageList1.Images.SetKeyName(2, "chain.png")
        Me.ImageList1.Images.SetKeyName(3, "cross.png")
        Me.ImageList1.Images.SetKeyName(4, "databases_relation.png")
        Me.ImageList1.Images.SetKeyName(5, "equals.png")
        Me.ImageList1.Images.SetKeyName(6, "key.png")
        Me.ImageList1.Images.SetKeyName(7, "plus.png")
        Me.ImageList1.Images.SetKeyName(8, "sort_alphabet.png")
        Me.ImageList1.Images.SetKeyName(9, "sql_join.png")
        Me.ImageList1.Images.SetKeyName(10, "sql_join_inner.png")
        Me.ImageList1.Images.SetKeyName(11, "sql_join_left.png")
        Me.ImageList1.Images.SetKeyName(12, "sql_join_left_exclude.png")
        Me.ImageList1.Images.SetKeyName(13, "sql_join_outer.png")
        Me.ImageList1.Images.SetKeyName(14, "sql_join_outer_exclude.png")
        Me.ImageList1.Images.SetKeyName(15, "sql_join_right.png")
        Me.ImageList1.Images.SetKeyName(16, "sql_join_right_exclude.png")
        Me.ImageList1.Images.SetKeyName(17, "table.png")
        Me.ImageList1.Images.SetKeyName(18, "table_insert_column.png")
        Me.ImageList1.Images.SetKeyName(19, "tables_relation.png")
        '
        'SymbolBox1
        '
        '
        '
        '
        Me.SymbolBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SymbolBox1.Location = New System.Drawing.Point(17, 0)
        Me.SymbolBox1.Name = "SymbolBox1"
        Me.SymbolBox1.Size = New System.Drawing.Size(26, 29)
        Me.SymbolBox1.Symbol = "58824"
        Me.SymbolBox1.SymbolColor = System.Drawing.Color.DodgerBlue
        Me.SymbolBox1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.SymbolBox1.SymbolSize = 18.0!
        Me.SymbolBox1.TabIndex = 2
        Me.SymbolBox1.Text = "SymbolBox1"
        '
        'UcGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Controls.Add(Me.SymbolBox1)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.ChkGroup)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Name = "UcGroup"
        Me.Size = New System.Drawing.Size(530, 27)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChkGroup As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents StyleManagerAmbient1 As DevComponents.DotNetBar.StyleManagerAmbient
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents SymbolBox1 As DevComponents.DotNetBar.Controls.SymbolBox
End Class
