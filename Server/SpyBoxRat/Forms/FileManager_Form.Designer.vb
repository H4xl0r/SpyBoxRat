<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FileManager_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileManager_Form))
        Me.FM_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GoForwardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteFileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveToBinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AESENCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AesDecryptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RC6EncryptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RC6DecryptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlowFishEncyptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlowFishDecryptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TwoFishEncryptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TwoFishDecryptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Salsa20EncryptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Salsa20DecryptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Cast6EncryptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cast6DecryptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FM_MenuStrip.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FM_MenuStrip
        '
        Me.FM_MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.FM_MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.FM_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoForwardToolStripMenuItem, Me.BackToolStripMenuItem, Me.DownloadFileToolStripMenuItem, Me.DeleteFileToolStripMenuItem, Me.OpenFileToolStripMenuItem, Me.SdToolStripMenuItem})
        Me.FM_MenuStrip.Name = "FM_MenuStrip"
        Me.FM_MenuStrip.Size = New System.Drawing.Size(207, 206)
        '
        'GoForwardToolStripMenuItem
        '
        Me.GoForwardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.GoForwardToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GoForwardToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_arrow_right_go
        Me.GoForwardToolStripMenuItem.Name = "GoForwardToolStripMenuItem"
        Me.GoForwardToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.GoForwardToolStripMenuItem.Text = "Go Forward"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BackToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BackToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_arrow_left_back
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'DownloadFileToolStripMenuItem
        '
        Me.DownloadFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.DownloadFileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DownloadFileToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_downloassd_32
        Me.DownloadFileToolStripMenuItem.Name = "DownloadFileToolStripMenuItem"
        Me.DownloadFileToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.DownloadFileToolStripMenuItem.Text = "Download File"
        Me.DownloadFileToolStripMenuItem.ToolTipText = "A message will pop when the data of the file have been downloaded ! Depending on " &
    "your connection ! Until the message pop , do not send other request to client !"
        '
        'DeleteFileToolStripMenuItem
        '
        Me.DeleteFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.DeleteFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteFileToolStripMenuItem1, Me.MoveToBinToolStripMenuItem})
        Me.DeleteFileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DeleteFileToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_trashsa
        Me.DeleteFileToolStripMenuItem.Name = "DeleteFileToolStripMenuItem"
        Me.DeleteFileToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.DeleteFileToolStripMenuItem.Text = "Delete File"
        '
        'DeleteFileToolStripMenuItem1
        '
        Me.DeleteFileToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.DeleteFileToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DeleteFileToolStripMenuItem1.Image = Global.AnonMon.My.Resources.Resources.icons8_delete_docfument_32
        Me.DeleteFileToolStripMenuItem1.Name = "DeleteFileToolStripMenuItem1"
        Me.DeleteFileToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.DeleteFileToolStripMenuItem1.Text = "Delete File"
        '
        'MoveToBinToolStripMenuItem
        '
        Me.MoveToBinToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.MoveToBinToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MoveToBinToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.imageres_54
        Me.MoveToBinToolStripMenuItem.Name = "MoveToBinToolStripMenuItem"
        Me.MoveToBinToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.MoveToBinToolStripMenuItem.Text = "Move To Bin"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.OpenFileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.OpenFileToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_enter
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.OpenFileToolStripMenuItem.Text = "Open File"
        '
        'SdToolStripMenuItem
        '
        Me.SdToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.SdToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AESENCToolStripMenuItem, Me.AesDecryptionToolStripMenuItem, Me.RC6EncryptionToolStripMenuItem, Me.RC6DecryptionToolStripMenuItem, Me.BlowFishEncyptionToolStripMenuItem, Me.BlowFishDecryptionToolStripMenuItem, Me.TwoFishEncryptionToolStripMenuItem, Me.TwoFishDecryptionToolStripMenuItem, Me.Salsa20EncryptionToolStripMenuItem, Me.Salsa20DecryptionToolStripMenuItem, Me.Cast6EncryptionToolStripMenuItem, Me.Cast6DecryptionToolStripMenuItem})
        Me.SdToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.SdToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_fdile_32
        Me.SdToolStripMenuItem.Name = "SdToolStripMenuItem"
        Me.SdToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.SdToolStripMenuItem.Text = "Encryption | Decryption"
        '
        'AESENCToolStripMenuItem
        '
        Me.AESENCToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.AESENCToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.AESENCToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_locks_64
        Me.AESENCToolStripMenuItem.Name = "AESENCToolStripMenuItem"
        Me.AESENCToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.AESENCToolStripMenuItem.Text = "Aes Encryption"
        '
        'AesDecryptionToolStripMenuItem
        '
        Me.AesDecryptionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.AesDecryptionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.AesDecryptionToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_padsdflock_32
        Me.AesDecryptionToolStripMenuItem.Name = "AesDecryptionToolStripMenuItem"
        Me.AesDecryptionToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.AesDecryptionToolStripMenuItem.Text = "Aes Decryption"
        '
        'RC6EncryptionToolStripMenuItem
        '
        Me.RC6EncryptionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.RC6EncryptionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.RC6EncryptionToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_locks_64
        Me.RC6EncryptionToolStripMenuItem.Name = "RC6EncryptionToolStripMenuItem"
        Me.RC6EncryptionToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.RC6EncryptionToolStripMenuItem.Text = "RC6 Encryption"
        '
        'RC6DecryptionToolStripMenuItem
        '
        Me.RC6DecryptionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.RC6DecryptionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.RC6DecryptionToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_padlosqdck_64
        Me.RC6DecryptionToolStripMenuItem.Name = "RC6DecryptionToolStripMenuItem"
        Me.RC6DecryptionToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.RC6DecryptionToolStripMenuItem.Text = "RC6 Decryption"
        '
        'BlowFishEncyptionToolStripMenuItem
        '
        Me.BlowFishEncyptionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BlowFishEncyptionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BlowFishEncyptionToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_locks_64
        Me.BlowFishEncyptionToolStripMenuItem.Name = "BlowFishEncyptionToolStripMenuItem"
        Me.BlowFishEncyptionToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.BlowFishEncyptionToolStripMenuItem.Text = "BlowFish Encyption"
        '
        'BlowFishDecryptionToolStripMenuItem
        '
        Me.BlowFishDecryptionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BlowFishDecryptionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BlowFishDecryptionToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_padlosqdck_64
        Me.BlowFishDecryptionToolStripMenuItem.Name = "BlowFishDecryptionToolStripMenuItem"
        Me.BlowFishDecryptionToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.BlowFishDecryptionToolStripMenuItem.Text = "BlowFish Decryption"
        '
        'TwoFishEncryptionToolStripMenuItem
        '
        Me.TwoFishEncryptionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TwoFishEncryptionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TwoFishEncryptionToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_locks_64
        Me.TwoFishEncryptionToolStripMenuItem.Name = "TwoFishEncryptionToolStripMenuItem"
        Me.TwoFishEncryptionToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.TwoFishEncryptionToolStripMenuItem.Text = "TwoFish Encryption"
        '
        'TwoFishDecryptionToolStripMenuItem
        '
        Me.TwoFishDecryptionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TwoFishDecryptionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TwoFishDecryptionToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_padlosqdck_64
        Me.TwoFishDecryptionToolStripMenuItem.Name = "TwoFishDecryptionToolStripMenuItem"
        Me.TwoFishDecryptionToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.TwoFishDecryptionToolStripMenuItem.Text = "TwoFish Decryption"
        '
        'Salsa20EncryptionToolStripMenuItem
        '
        Me.Salsa20EncryptionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Salsa20EncryptionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Salsa20EncryptionToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_locks_64
        Me.Salsa20EncryptionToolStripMenuItem.Name = "Salsa20EncryptionToolStripMenuItem"
        Me.Salsa20EncryptionToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.Salsa20EncryptionToolStripMenuItem.Text = "Salsa20 Encryption"
        '
        'Salsa20DecryptionToolStripMenuItem
        '
        Me.Salsa20DecryptionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Salsa20DecryptionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Salsa20DecryptionToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_padlosqdck_64
        Me.Salsa20DecryptionToolStripMenuItem.Name = "Salsa20DecryptionToolStripMenuItem"
        Me.Salsa20DecryptionToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.Salsa20DecryptionToolStripMenuItem.Text = "Salsa20 Decryption"
        '
        'ToolTip1
        '
        Me.ToolTip1.ForeColor = System.Drawing.Color.Red
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(364, 29)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(567, 18)
        Me.TextBox1.TabIndex = 30
        Me.TextBox1.Text = "123456"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AnonMon.My.Resources.Resources.icons8_key
        Me.PictureBox2.Location = New System.Drawing.Point(207, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(225, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 24)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Key To Encrypt | Decrypt  :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(42, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 24)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Disk :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AnonMon.My.Resources.Resources.icons8_ssdd_32
        Me.PictureBox1.Location = New System.Drawing.Point(12, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(13, 502)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(755, 36)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "About Download File : A message will pop when the data of the file have been down" &
    "loaded ! Depending on your connection ! Until the message pop , do not send othe" &
    "r request to client !"
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
        Me.Button3.Location = New System.Drawing.Point(936, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 28)
        Me.Button3.TabIndex = 24
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
        Me.Button2.Location = New System.Drawing.Point(970, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 28)
        Me.Button2.TabIndex = 23
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
        Me.Button1.Location = New System.Drawing.Point(1004, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 28)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(10, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Label4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Disk :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(225, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Label1"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(175, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ListView1.ContextMenuStrip = Me.FM_MenuStrip
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 80)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1020, 419)
        Me.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView1.TabIndex = 16
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Cast6EncryptionToolStripMenuItem
        '
        Me.Cast6EncryptionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Cast6EncryptionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Cast6EncryptionToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_locks_64
        Me.Cast6EncryptionToolStripMenuItem.Name = "Cast6EncryptionToolStripMenuItem"
        Me.Cast6EncryptionToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.Cast6EncryptionToolStripMenuItem.Text = "Cast6 Encryption"
        '
        'Cast6DecryptionToolStripMenuItem
        '
        Me.Cast6DecryptionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Cast6DecryptionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Cast6DecryptionToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_padlosqdck_64
        Me.Cast6DecryptionToolStripMenuItem.Name = "Cast6DecryptionToolStripMenuItem"
        Me.Cast6DecryptionToolStripMenuItem.Size = New System.Drawing.Size(190, 30)
        Me.Cast6DecryptionToolStripMenuItem.Text = "Cast6 Decryption"
        '
        'FileManager_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1044, 547)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FileManager_Form"
        Me.Text = "Files Manager"
        Me.FM_MenuStrip.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label4 As Label
    Friend WithEvents FM_MenuStrip As ContextMenuStrip
    Friend WithEvents GoForwardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DownloadFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DeleteFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AESENCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AesDecryptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RC6EncryptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RC6DecryptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlowFishEncyptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlowFishDecryptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TwoFishEncryptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TwoFishDecryptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Salsa20EncryptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Salsa20DecryptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteFileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MoveToBinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Cast6EncryptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Cast6DecryptionToolStripMenuItem As ToolStripMenuItem
End Class
