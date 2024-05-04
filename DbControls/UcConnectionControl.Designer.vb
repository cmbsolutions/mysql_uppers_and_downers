<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcConnectionControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UcConnectionControl))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CBDatabase = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.THost = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TPort = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TUser = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.TPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BTest = New DevComponents.DotNetBar.ButtonX()
        Me.LInfo = New DevComponents.DotNetBar.LabelX()
        Me.SuperValidator1 = New DevComponents.DotNetBar.Validator.SuperValidator()
        Me.RequiredFieldValidator1 = New DevComponents.DotNetBar.Validator.RequiredFieldValidator("IP or Hostname is required")
        Me.RequiredFieldValidator2 = New DevComponents.DotNetBar.Validator.RequiredFieldValidator("Port is required")
        Me.RegularExpressionValidator1 = New DevComponents.DotNetBar.Validator.RegularExpressionValidator()
        Me.RequiredFieldValidator3 = New DevComponents.DotNetBar.Validator.RequiredFieldValidator("Username is required")
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager()
        Me.StyleManagerAmbient1 = New DevComponents.DotNetBar.StyleManagerAmbient()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.77778!))
        Me.TableLayoutPanel1.Controls.Add(Me.CBDatabase, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.THost, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TPort, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TUser, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TPassword, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(308, 122)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'CBDatabase
        '
        Me.CBDatabase.DisplayMember = "Text"
        Me.CBDatabase.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBDatabase.ForeColor = System.Drawing.Color.White
        Me.CBDatabase.FormattingEnabled = True
        Me.CBDatabase.ItemHeight = 17
        Me.CBDatabase.Location = New System.Drawing.Point(71, 99)
        Me.CBDatabase.Name = "CBDatabase"
        Me.CBDatabase.Size = New System.Drawing.Size(234, 23)
        Me.CBDatabase.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CBDatabase.TabIndex = 2
        Me.CBDatabase.WatermarkText = "-- Select database --"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(3, 99)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(62, 20)
        Me.LabelX5.TabIndex = 3
        Me.LabelX5.Text = "Database:"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelX4.Location = New System.Drawing.Point(3, 75)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(62, 18)
        Me.LabelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LabelX4.TabIndex = 5
        Me.LabelX4.Text = "Password:"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelX2.Location = New System.Drawing.Point(3, 27)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(62, 18)
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Port:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelX1.Location = New System.Drawing.Point(3, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(62, 18)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Host:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'THost
        '
        Me.THost.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.THost.Border.Class = "TextBoxBorder"
        Me.THost.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.THost.DisabledBackColor = System.Drawing.Color.Black
        Me.THost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.THost.ForeColor = System.Drawing.Color.White
        Me.THost.Location = New System.Drawing.Point(71, 3)
        Me.THost.MaxLength = 100
        Me.THost.Name = "THost"
        Me.THost.PreventEnterBeep = True
        Me.THost.Size = New System.Drawing.Size(234, 22)
        Me.THost.TabIndex = 2
        Me.THost.Text = "localhost"
        Me.SuperValidator1.SetValidator1(Me.THost, Me.RequiredFieldValidator1)
        Me.THost.WatermarkText = "localhost"
        '
        'TPort
        '
        Me.TPort.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.TPort.Border.Class = "TextBoxBorder"
        Me.TPort.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TPort.DisabledBackColor = System.Drawing.Color.Black
        Me.TPort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TPort.ForeColor = System.Drawing.Color.White
        Me.TPort.Location = New System.Drawing.Point(71, 27)
        Me.TPort.MaxLength = 100
        Me.TPort.Name = "TPort"
        Me.TPort.PreventEnterBeep = True
        Me.TPort.Size = New System.Drawing.Size(234, 22)
        Me.TPort.TabIndex = 6
        Me.TPort.Text = "3306"
        Me.SuperValidator1.SetValidator1(Me.TPort, Me.RequiredFieldValidator2)
        Me.SuperValidator1.SetValidator2(Me.TPort, Me.RegularExpressionValidator1)
        Me.TPort.WatermarkText = "port"
        '
        'TUser
        '
        Me.TUser.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.TUser.Border.Class = "TextBoxBorder"
        Me.TUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TUser.DisabledBackColor = System.Drawing.Color.Black
        Me.TUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TUser.ForeColor = System.Drawing.Color.White
        Me.TUser.Location = New System.Drawing.Point(71, 51)
        Me.TUser.MaxLength = 100
        Me.TUser.Name = "TUser"
        Me.TUser.PreventEnterBeep = True
        Me.TUser.Size = New System.Drawing.Size(234, 22)
        Me.TUser.TabIndex = 7
        Me.TUser.Text = "root"
        Me.SuperValidator1.SetValidator1(Me.TUser, Me.RequiredFieldValidator3)
        Me.TUser.WatermarkText = "User"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelX3.Location = New System.Drawing.Point(3, 51)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(62, 18)
        Me.LabelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LabelX3.TabIndex = 4
        Me.LabelX3.Text = "User:"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'TPassword
        '
        Me.TPassword.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.TPassword.Border.Class = "TextBoxBorder"
        Me.TPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TPassword.ButtonCustom.Symbol = "59636"
        Me.TPassword.ButtonCustom.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TPassword.ButtonCustom.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.TPassword.ButtonCustom.Visible = True
        Me.TPassword.DisabledBackColor = System.Drawing.Color.Black
        Me.TPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TPassword.ForeColor = System.Drawing.Color.White
        Me.TPassword.Location = New System.Drawing.Point(71, 75)
        Me.TPassword.MaxLength = 100
        Me.TPassword.Name = "TPassword"
        Me.TPassword.PreventEnterBeep = True
        Me.TPassword.Size = New System.Drawing.Size(234, 22)
        Me.TPassword.TabIndex = 8
        Me.TPassword.Text = "super-secret-password"
        Me.TPassword.UseSystemPasswordChar = True
        Me.TPassword.WatermarkText = "Password"
        '
        'BTest
        '
        Me.BTest.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BTest.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BTest.Location = New System.Drawing.Point(3, 128)
        Me.BTest.Name = "BTest"
        Me.BTest.Size = New System.Drawing.Size(108, 23)
        Me.BTest.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BTest.TabIndex = 1
        Me.BTest.Text = "Test Connection"
        Me.BTest.ThemeAware = True
        '
        'LInfo
        '
        '
        '
        '
        Me.LInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LInfo.Location = New System.Drawing.Point(44, 167)
        Me.LInfo.Name = "LInfo"
        Me.LInfo.Size = New System.Drawing.Size(217, 64)
        Me.LInfo.TabIndex = 2
        Me.LInfo.Text = "<b><font color=""LightBlue"">Information</font></b><br /><b>Host:{0}</b><br /><b>Po" &
    "rt:{1}</b><br /><b>Server version:{2}</b>"
        Me.LInfo.TextLineAlignment = System.Drawing.StringAlignment.Near
        '
        'SuperValidator1
        '
        Me.SuperValidator1.ContainerControl = Me
        Me.SuperValidator1.ErrorProvider = Me.ErrorProvider1
        Me.SuperValidator1.Highlighter = Me.Highlighter1
        '
        'RequiredFieldValidator1
        '
        Me.RequiredFieldValidator1.ErrorMessage = "IP or Hostname is required"
        Me.RequiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'RequiredFieldValidator2
        '
        Me.RequiredFieldValidator2.ErrorMessage = "Port is required"
        Me.RequiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'RegularExpressionValidator1
        '
        Me.RegularExpressionValidator1.ErrorMessage = "Enter a valid portnumber"
        Me.RegularExpressionValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        Me.RegularExpressionValidator1.ValidationExpression = "\d{2,7}"
        '
        'RequiredFieldValidator3
        '
        Me.RequiredFieldValidator3.ErrorMessage = "Username is required"
        Me.RequiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        Me.Highlighter1.CustomHighlightColors = New System.Drawing.Color() {System.Drawing.Color.Red}
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'UcConnectionControl
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Controls.Add(Me.LInfo)
        Me.Controls.Add(Me.BTest)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Name = "UcConnectionControl"
        Me.Size = New System.Drawing.Size(308, 246)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents THost As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TPort As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TUser As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BTest As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CBDatabase As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LInfo As DevComponents.DotNetBar.LabelX
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents SuperValidator1 As DevComponents.DotNetBar.Validator.SuperValidator
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents RequiredFieldValidator1 As DevComponents.DotNetBar.Validator.RequiredFieldValidator
    Friend WithEvents RequiredFieldValidator2 As DevComponents.DotNetBar.Validator.RequiredFieldValidator
    Friend WithEvents RegularExpressionValidator1 As DevComponents.DotNetBar.Validator.RegularExpressionValidator
    Friend WithEvents RequiredFieldValidator3 As DevComponents.DotNetBar.Validator.RequiredFieldValidator
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents StyleManagerAmbient1 As DevComponents.DotNetBar.StyleManagerAmbient
End Class
