<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FConnectionSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FConnectionSetup))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.StyleManagerAmbient1 = New DevComponents.DotNetBar.StyleManagerAmbient(Me.components)
        Me.BNext = New DevComponents.DotNetBar.ButtonX()
        Me.ConPanel = New DevComponents.DotNetBar.ExpandablePanel()
        Me.Db1 = New CMBSolutions.Db.UcConnectionControl()
        Me.Db2 = New CMBSolutions.Db.UcConnectionControl()
        Me.ConPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'BNext
        '
        Me.BNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BNext.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BNext.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.BNext.Location = New System.Drawing.Point(559, 280)
        Me.BNext.Name = "BNext"
        Me.BNext.Size = New System.Drawing.Size(75, 23)
        Me.BNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BNext.SymbolSize = 12.0!
        Me.BNext.TabIndex = 10
        Me.BNext.Text = "Next"
        '
        'ConPanel
        '
        Me.ConPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ConPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.ConPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ConPanel.Controls.Add(Me.Db1)
        Me.ConPanel.Controls.Add(Me.Db2)
        Me.ConPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.ConPanel.ExpandButtonVisible = False
        Me.ConPanel.HideControlsWhenCollapsed = True
        Me.ConPanel.Location = New System.Drawing.Point(12, 12)
        Me.ConPanel.Name = "ConPanel"
        Me.ConPanel.Size = New System.Drawing.Size(622, 262)
        Me.ConPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ConPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ConPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ConPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ConPanel.Style.GradientAngle = 90
        Me.ConPanel.TabIndex = 11
        Me.ConPanel.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ConPanel.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ConPanel.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ConPanel.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ConPanel.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ConPanel.TitleStyle.GradientAngle = 90
        Me.ConPanel.TitleText = "Connections"
        '
        'Db1
        '
        Me.Db1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Db1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Db1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Db1.InfoManager = Nothing
        Me.Db1.Location = New System.Drawing.Point(0, 27)
        Me.Db1.Name = "Db1"
        Me.Db1.Size = New System.Drawing.Size(308, 246)
        Me.Db1.TabIndex = 4
        '
        'Db2
        '
        Me.Db2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Db2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Db2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Db2.InfoManager = Nothing
        Me.Db2.Location = New System.Drawing.Point(314, 27)
        Me.Db2.Name = "Db2"
        Me.Db2.Size = New System.Drawing.Size(308, 246)
        Me.Db2.TabIndex = 5
        '
        'FConnectionSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CaptionFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientSize = New System.Drawing.Size(648, 305)
        Me.Controls.Add(Me.ConPanel)
        Me.Controls.Add(Me.BNext)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FConnectionSetup"
        Me.RenderFormIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connections setup"
        Me.TitleText = "Connections setup"
        Me.ConPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents StyleManagerAmbient1 As DevComponents.DotNetBar.StyleManagerAmbient
    Friend WithEvents Db1 As UcConnectionControl
    Friend WithEvents BNext As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Db2 As UcConnectionControl
    Friend WithEvents ConPanel As DevComponents.DotNetBar.ExpandablePanel
End Class
