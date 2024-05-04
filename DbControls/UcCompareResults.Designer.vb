<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcCompareResults
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
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.StyleManagerAmbient1 = New DevComponents.DotNetBar.StyleManagerAmbient(Me.components)
        Me.VScrollBarAdv1 = New DevComponents.DotNetBar.VScrollBarAdv()
        Me.FLPMaster = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'VScrollBarAdv1
        '
        Me.VScrollBarAdv1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBarAdv1.Location = New System.Drawing.Point(836, 0)
        Me.VScrollBarAdv1.Name = "VScrollBarAdv1"
        Me.VScrollBarAdv1.Size = New System.Drawing.Size(14, 84)
        Me.VScrollBarAdv1.TabIndex = 1
        '
        'FLPMaster
        '
        Me.FLPMaster.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FLPMaster.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FLPMaster.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLPMaster.Location = New System.Drawing.Point(0, 0)
        Me.FLPMaster.Margin = New System.Windows.Forms.Padding(0)
        Me.FLPMaster.Name = "FLPMaster"
        Me.FLPMaster.Size = New System.Drawing.Size(836, 64)
        Me.FLPMaster.TabIndex = 2
        Me.FLPMaster.WrapContents = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FLPMaster)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(836, 84)
        Me.Panel1.TabIndex = 0
        '
        'UcCompareResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.VScrollBarAdv1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Name = "UcCompareResults"
        Me.Size = New System.Drawing.Size(850, 84)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents StyleManagerAmbient1 As DevComponents.DotNetBar.StyleManagerAmbient
    Friend WithEvents VScrollBarAdv1 As DevComponents.DotNetBar.VScrollBarAdv
    Friend WithEvents FLPMaster As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
End Class
