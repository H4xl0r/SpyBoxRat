<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class REMOTE_BUILDER
    Inherits Custom_Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REMOTE_BUILDER))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.XuiCustomGroupbox3 = New XanderUI.XUICustomGroupbox()
        Me.XuiCustomGroupbox4 = New XanderUI.XUICustomGroupbox()
        Me.Spread_CHK_BOX = New XanderUI.XUICheckBox()
        Me.AddToStartup = New XanderUI.XUICheckBox()
        Me.X86BOX = New XanderUI.XUICheckBox()
        Me.x64BOX = New XanderUI.XUICheckBox()
        Me.stealth_CHK_BOX = New XanderUI.XUICheckBox()
        Me.XuiCustomGroupbox2 = New XanderUI.XUICustomGroupbox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.XuiCustomGroupbox1 = New XanderUI.XUICustomGroupbox()
        Me.Remote_VPORT_UP = New System.Windows.Forms.NumericUpDown()
        Me.UcBtnExt2 = New HZH_Controls.Controls.UCBtnExt()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.XuiCustomGroupbox3.SuspendLayout()
        Me.XuiCustomGroupbox4.SuspendLayout()
        Me.XuiCustomGroupbox2.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XuiCustomGroupbox1.SuspendLayout()
        CType(Me.Remote_VPORT_UP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(319, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 28)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "-"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(353, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 28)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(387, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 28)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'XuiCustomGroupbox3
        '
        Me.XuiCustomGroupbox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XuiCustomGroupbox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.XuiCustomGroupbox3.BorderWidth = 1
        Me.XuiCustomGroupbox3.Controls.Add(Me.XuiCustomGroupbox4)
        Me.XuiCustomGroupbox3.Controls.Add(Me.XuiCustomGroupbox2)
        Me.XuiCustomGroupbox3.Controls.Add(Me.XuiCustomGroupbox1)
        Me.XuiCustomGroupbox3.Controls.Add(Me.UcBtnExt2)
        Me.XuiCustomGroupbox3.Location = New System.Drawing.Point(12, 34)
        Me.XuiCustomGroupbox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XuiCustomGroupbox3.Name = "XuiCustomGroupbox3"
        Me.XuiCustomGroupbox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XuiCustomGroupbox3.ShowText = True
        Me.XuiCustomGroupbox3.Size = New System.Drawing.Size(402, 443)
        Me.XuiCustomGroupbox3.TabIndex = 14
        Me.XuiCustomGroupbox3.TabStop = False
        Me.XuiCustomGroupbox3.Text = "Connection Settings"
        Me.XuiCustomGroupbox3.TextColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        '
        'XuiCustomGroupbox4
        '
        Me.XuiCustomGroupbox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.XuiCustomGroupbox4.BorderWidth = 1
        Me.XuiCustomGroupbox4.Controls.Add(Me.Spread_CHK_BOX)
        Me.XuiCustomGroupbox4.Controls.Add(Me.AddToStartup)
        Me.XuiCustomGroupbox4.Controls.Add(Me.X86BOX)
        Me.XuiCustomGroupbox4.Controls.Add(Me.x64BOX)
        Me.XuiCustomGroupbox4.Controls.Add(Me.stealth_CHK_BOX)
        Me.XuiCustomGroupbox4.Location = New System.Drawing.Point(6, 192)
        Me.XuiCustomGroupbox4.Name = "XuiCustomGroupbox4"
        Me.XuiCustomGroupbox4.ShowText = True
        Me.XuiCustomGroupbox4.Size = New System.Drawing.Size(388, 182)
        Me.XuiCustomGroupbox4.TabIndex = 16
        Me.XuiCustomGroupbox4.TabStop = False
        Me.XuiCustomGroupbox4.Text = "Miscellaneous Settings"
        Me.XuiCustomGroupbox4.TextColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        '
        'Spread_CHK_BOX
        '
        Me.Spread_CHK_BOX.CheckboxCheckColor = System.Drawing.Color.White
        Me.Spread_CHK_BOX.CheckboxColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Spread_CHK_BOX.CheckboxHoverColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Spread_CHK_BOX.CheckboxStyle = XanderUI.XUICheckBox.Style.Material
        Me.Spread_CHK_BOX.Checked = False
        Me.Spread_CHK_BOX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Spread_CHK_BOX.Location = New System.Drawing.Point(6, 124)
        Me.Spread_CHK_BOX.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Spread_CHK_BOX.Name = "Spread_CHK_BOX"
        Me.Spread_CHK_BOX.Size = New System.Drawing.Size(124, 20)
        Me.Spread_CHK_BOX.TabIndex = 14
        Me.Spread_CHK_BOX.Text = "Spread"
        Me.Spread_CHK_BOX.TickThickness = 2
        Me.ToolTip1.SetToolTip(Me.Spread_CHK_BOX, "Try to spread on all drives found on device")
        '
        'AddToStartup
        '
        Me.AddToStartup.CheckboxCheckColor = System.Drawing.Color.White
        Me.AddToStartup.CheckboxColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.AddToStartup.CheckboxHoverColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.AddToStartup.CheckboxStyle = XanderUI.XUICheckBox.Style.Material
        Me.AddToStartup.Checked = False
        Me.AddToStartup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AddToStartup.Location = New System.Drawing.Point(250, 78)
        Me.AddToStartup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddToStartup.Name = "AddToStartup"
        Me.AddToStartup.Size = New System.Drawing.Size(124, 20)
        Me.AddToStartup.TabIndex = 12
        Me.AddToStartup.Text = "Add to StartUp"
        Me.AddToStartup.TickThickness = 2
        '
        'X86BOX
        '
        Me.X86BOX.CheckboxCheckColor = System.Drawing.Color.White
        Me.X86BOX.CheckboxColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.X86BOX.CheckboxHoverColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.X86BOX.CheckboxStyle = XanderUI.XUICheckBox.Style.Material
        Me.X86BOX.Checked = False
        Me.X86BOX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.X86BOX.Location = New System.Drawing.Point(6, 30)
        Me.X86BOX.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.X86BOX.Name = "X86BOX"
        Me.X86BOX.Size = New System.Drawing.Size(155, 20)
        Me.X86BOX.TabIndex = 7
        Me.X86BOX.Text = "x86"
        Me.X86BOX.TickThickness = 2
        '
        'x64BOX
        '
        Me.x64BOX.CheckboxCheckColor = System.Drawing.Color.White
        Me.x64BOX.CheckboxColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.x64BOX.CheckboxHoverColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.x64BOX.CheckboxStyle = XanderUI.XUICheckBox.Style.Material
        Me.x64BOX.Checked = False
        Me.x64BOX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.x64BOX.Location = New System.Drawing.Point(250, 30)
        Me.x64BOX.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.x64BOX.Name = "x64BOX"
        Me.x64BOX.Size = New System.Drawing.Size(132, 20)
        Me.x64BOX.TabIndex = 8
        Me.x64BOX.Text = "x64"
        Me.x64BOX.TickThickness = 2
        '
        'stealth_CHK_BOX
        '
        Me.stealth_CHK_BOX.CheckboxCheckColor = System.Drawing.Color.White
        Me.stealth_CHK_BOX.CheckboxColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.stealth_CHK_BOX.CheckboxHoverColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.stealth_CHK_BOX.CheckboxStyle = XanderUI.XUICheckBox.Style.Material
        Me.stealth_CHK_BOX.Checked = False
        Me.stealth_CHK_BOX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.stealth_CHK_BOX.Location = New System.Drawing.Point(6, 78)
        Me.stealth_CHK_BOX.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.stealth_CHK_BOX.Name = "stealth_CHK_BOX"
        Me.stealth_CHK_BOX.Size = New System.Drawing.Size(155, 20)
        Me.stealth_CHK_BOX.TabIndex = 10
        Me.stealth_CHK_BOX.Text = "Stealth Mode"
        Me.stealth_CHK_BOX.TickThickness = 2
        Me.ToolTip1.SetToolTip(Me.stealth_CHK_BOX, "If not checked , will start with a prompt message then will request admin privile" &
        "ge." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Only use Stealth Mode on your own computer(s) or with the agreement of the " &
        "owner" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'XuiCustomGroupbox2
        '
        Me.XuiCustomGroupbox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.XuiCustomGroupbox2.BorderWidth = 1
        Me.XuiCustomGroupbox2.Controls.Add(Me.NumericUpDown2)
        Me.XuiCustomGroupbox2.Controls.Add(Me.TextBox1)
        Me.XuiCustomGroupbox2.Location = New System.Drawing.Point(6, 20)
        Me.XuiCustomGroupbox2.Name = "XuiCustomGroupbox2"
        Me.XuiCustomGroupbox2.ShowText = True
        Me.XuiCustomGroupbox2.Size = New System.Drawing.Size(388, 78)
        Me.XuiCustomGroupbox2.TabIndex = 15
        Me.XuiCustomGroupbox2.TabStop = False
        Me.XuiCustomGroupbox2.Text = "Main Connection Settings"
        Me.XuiCustomGroupbox2.TextColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.BackColor = System.Drawing.Color.White
        Me.NumericUpDown2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NumericUpDown2.Location = New System.Drawing.Point(6, 46)
        Me.NumericUpDown2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {90000, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(376, 20)
        Me.NumericUpDown2.TabIndex = 2
        Me.NumericUpDown2.Value = New Decimal(New Integer() {8080, 0, 0, 0})
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(376, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "127.0.0.1"
        '
        'XuiCustomGroupbox1
        '
        Me.XuiCustomGroupbox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.XuiCustomGroupbox1.BorderWidth = 1
        Me.XuiCustomGroupbox1.Controls.Add(Me.Remote_VPORT_UP)
        Me.XuiCustomGroupbox1.Location = New System.Drawing.Point(6, 113)
        Me.XuiCustomGroupbox1.Name = "XuiCustomGroupbox1"
        Me.XuiCustomGroupbox1.ShowText = True
        Me.XuiCustomGroupbox1.Size = New System.Drawing.Size(388, 58)
        Me.XuiCustomGroupbox1.TabIndex = 14
        Me.XuiCustomGroupbox1.TabStop = False
        Me.XuiCustomGroupbox1.Text = "Remote Viewer Port"
        Me.XuiCustomGroupbox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        '
        'Remote_VPORT_UP
        '
        Me.Remote_VPORT_UP.BackColor = System.Drawing.Color.White
        Me.Remote_VPORT_UP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Remote_VPORT_UP.Location = New System.Drawing.Point(6, 20)
        Me.Remote_VPORT_UP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Remote_VPORT_UP.Maximum = New Decimal(New Integer() {90000, 0, 0, 0})
        Me.Remote_VPORT_UP.Name = "Remote_VPORT_UP"
        Me.Remote_VPORT_UP.Size = New System.Drawing.Size(376, 20)
        Me.Remote_VPORT_UP.TabIndex = 3
        Me.Remote_VPORT_UP.Value = New Decimal(New Integer() {8081, 0, 0, 0})
        '
        'UcBtnExt2
        '
        Me.UcBtnExt2.BackColor = System.Drawing.Color.White
        Me.UcBtnExt2.BtnBackColor = System.Drawing.Color.White
        Me.UcBtnExt2.BtnFont = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UcBtnExt2.BtnForeColor = System.Drawing.Color.White
        Me.UcBtnExt2.BtnText = "Build !"
        Me.UcBtnExt2.ConerRadius = 5
        Me.UcBtnExt2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcBtnExt2.EnabledMouseEffect = True
        Me.UcBtnExt2.FillColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.UcBtnExt2.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UcBtnExt2.IsRadius = True
        Me.UcBtnExt2.IsShowRect = True
        Me.UcBtnExt2.IsShowTips = False
        Me.UcBtnExt2.Location = New System.Drawing.Point(6, 377)
        Me.UcBtnExt2.Margin = New System.Windows.Forms.Padding(0)
        Me.UcBtnExt2.Name = "UcBtnExt2"
        Me.UcBtnExt2.RectColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UcBtnExt2.RectWidth = 1
        Me.UcBtnExt2.Size = New System.Drawing.Size(388, 46)
        Me.UcBtnExt2.TabIndex = 5
        Me.UcBtnExt2.TabStop = False
        Me.UcBtnExt2.TipsColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.UcBtnExt2.TipsText = ""
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ToolTip1.InitialDelay = 250
        Me.ToolTip1.ReshowDelay = 100
        '
        'REMOTE_BUILDER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(427, 490)
        Me.Controls.Add(Me.XuiCustomGroupbox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "REMOTE_BUILDER"
        Me.Sizeable = False
        Me.Text = "REMOTE_BUILDER"
        Me.XuiCustomGroupbox3.ResumeLayout(False)
        Me.XuiCustomGroupbox3.PerformLayout()
        Me.XuiCustomGroupbox4.ResumeLayout(False)
        Me.XuiCustomGroupbox4.PerformLayout()
        Me.XuiCustomGroupbox2.ResumeLayout(False)
        Me.XuiCustomGroupbox2.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XuiCustomGroupbox1.ResumeLayout(False)
        Me.XuiCustomGroupbox1.PerformLayout()
        CType(Me.Remote_VPORT_UP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents XuiCustomGroupbox3 As XanderUI.XUICustomGroupbox
    Friend WithEvents UcBtnExt2 As HZH_Controls.Controls.UCBtnExt
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents x64BOX As XanderUI.XUICheckBox
    Friend WithEvents X86BOX As XanderUI.XUICheckBox
    Friend WithEvents stealth_CHK_BOX As XanderUI.XUICheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents AddToStartup As XanderUI.XUICheckBox
    Friend WithEvents XuiCustomGroupbox4 As XanderUI.XUICustomGroupbox
    Friend WithEvents XuiCustomGroupbox2 As XanderUI.XUICustomGroupbox
    Friend WithEvents XuiCustomGroupbox1 As XanderUI.XUICustomGroupbox
    Friend WithEvents Remote_VPORT_UP As NumericUpDown
    Friend WithEvents Spread_CHK_BOX As XanderUI.XUICheckBox
End Class
