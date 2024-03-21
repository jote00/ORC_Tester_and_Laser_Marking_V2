<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReferencesForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReferencesForm))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.pb_logo = New System.Windows.Forms.PictureBox()
        Me.pb_status_mc = New System.Windows.Forms.PictureBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_curr_time = New System.Windows.Forms.Label()
        Me.lbl_auto_man = New System.Windows.Forms.Label()
        Me.pb_status_bar = New System.Windows.Forms.PictureBox()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.btn_st6 = New System.Windows.Forms.Button()
        Me.btn_st5 = New System.Windows.Forms.Button()
        Me.btn_st4 = New System.Windows.Forms.Button()
        Me.btn_st3 = New System.Windows.Forms.Button()
        Me.btn_st2 = New System.Windows.Forms.Button()
        Me.btn_st1 = New System.Windows.Forms.Button()
        Me.DateTime = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox_Control = New System.Windows.Forms.GroupBox()
        Me.tbx_camera_program = New System.Windows.Forms.TextBox()
        Me.tbx_Ldist = New System.Windows.Forms.TextBox()
        Me.Label247 = New System.Windows.Forms.Label()
        Me.Label237 = New System.Windows.Forms.Label()
        Me.tbx_laser_template = New System.Windows.Forms.TextBox()
        Me.tbx_oring = New System.Windows.Forms.TextBox()
        Me.Label246 = New System.Windows.Forms.Label()
        Me.Label238 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.tbx_Rspeed = New System.Windows.Forms.TextBox()
        Me.tbx_lvl_toler = New System.Windows.Forms.TextBox()
        Me.tbx_Lspeed = New System.Windows.Forms.TextBox()
        Me.tbx_lvl_dist = New System.Windows.Forms.TextBox()
        Me.Label245 = New System.Windows.Forms.Label()
        Me.Label239 = New System.Windows.Forms.Label()
        Me.Label244 = New System.Windows.Forms.Label()
        Me.Label240 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.tbx_Rdist = New System.Windows.Forms.TextBox()
        Me.tbx_punching = New System.Windows.Forms.TextBox()
        Me.Label243 = New System.Windows.Forms.Label()
        Me.tbx_ref = New System.Windows.Forms.TextBox()
        Me.Label241 = New System.Windows.Forms.Label()
        Me.Label242 = New System.Windows.Forms.Label()
        Me.dgv_ref = New System.Windows.Forms.DataGridView()
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_status_mc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_status_bar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox_Control.SuspendLayout()
        CType(Me.dgv_ref, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.DarkRed
        Me.TextBox1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(10, 110)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(1402, 30)
        Me.TextBox1.TabIndex = 37
        Me.TextBox1.Text = "ALARM : . . . . . . . . "
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(1266, 19)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(146, 75)
        Me.lbl_user.TabIndex = 36
        Me.lbl_user.Text = "ENG"
        '
        'btn_login
        '
        Me.btn_login.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Image = Global.ORC_Tester_and_Laser_Marking_V2.My.Resources.Resources.icons8_change_user_65
        Me.btn_login.Location = New System.Drawing.Point(1138, 12)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(85, 85)
        Me.btn_login.TabIndex = 35
        Me.btn_login.Text = "Login"
        Me.btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'pb_logo
        '
        Me.pb_logo.Image = Global.ORC_Tester_and_Laser_Marking_V2.My.Resources.Resources.telemecanique_sensors_logo_transparent
        Me.pb_logo.Location = New System.Drawing.Point(12, 12)
        Me.pb_logo.Name = "pb_logo"
        Me.pb_logo.Size = New System.Drawing.Size(250, 85)
        Me.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_logo.TabIndex = 34
        Me.pb_logo.TabStop = False
        '
        'pb_status_mc
        '
        Me.pb_status_mc.Image = Global.ORC_Tester_and_Laser_Marking_V2.My.Resources.Resources.mark_ok
        Me.pb_status_mc.Location = New System.Drawing.Point(900, 12)
        Me.pb_status_mc.Name = "pb_status_mc"
        Me.pb_status_mc.Size = New System.Drawing.Size(85, 85)
        Me.pb_status_mc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_status_mc.TabIndex = 33
        Me.pb_status_mc.TabStop = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.LimeGreen
        Me.lbl_date.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.White
        Me.lbl_date.Location = New System.Drawing.Point(724, 55)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(124, 31)
        Me.lbl_date.TabIndex = 32
        Me.lbl_date.Text = "31-12-2000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LimeGreen
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(371, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 31)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "STOPPED"
        '
        'lbl_curr_time
        '
        Me.lbl_curr_time.AutoSize = True
        Me.lbl_curr_time.BackColor = System.Drawing.Color.LimeGreen
        Me.lbl_curr_time.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_curr_time.ForeColor = System.Drawing.Color.White
        Me.lbl_curr_time.Location = New System.Drawing.Point(748, 21)
        Me.lbl_curr_time.Name = "lbl_curr_time"
        Me.lbl_curr_time.Size = New System.Drawing.Size(100, 31)
        Me.lbl_curr_time.TabIndex = 30
        Me.lbl_curr_time.Text = "23:59:59"
        '
        'lbl_auto_man
        '
        Me.lbl_auto_man.AutoSize = True
        Me.lbl_auto_man.BackColor = System.Drawing.Color.LimeGreen
        Me.lbl_auto_man.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_auto_man.ForeColor = System.Drawing.Color.White
        Me.lbl_auto_man.Location = New System.Drawing.Point(371, 21)
        Me.lbl_auto_man.Name = "lbl_auto_man"
        Me.lbl_auto_man.Size = New System.Drawing.Size(110, 31)
        Me.lbl_auto_man.TabIndex = 29
        Me.lbl_auto_man.Text = "MANUAL"
        '
        'pb_status_bar
        '
        Me.pb_status_bar.BackColor = System.Drawing.Color.LimeGreen
        Me.pb_status_bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_status_bar.Location = New System.Drawing.Point(361, 12)
        Me.pb_status_bar.Name = "pb_status_bar"
        Me.pb_status_bar.Size = New System.Drawing.Size(500, 85)
        Me.pb_status_bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_status_bar.TabIndex = 28
        Me.pb_status_bar.TabStop = False
        '
        'btn_home
        '
        Me.btn_home.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.Image = Global.ORC_Tester_and_Laser_Marking_V2.My.Resources.Resources.icons8_home_50
        Me.btn_home.Location = New System.Drawing.Point(10, 162)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(120, 85)
        Me.btn_home.TabIndex = 38
        Me.btn_home.Text = "Home"
        Me.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'btn_st6
        '
        Me.btn_st6.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st6.Image = CType(resources.GetObject("btn_st6.Image"), System.Drawing.Image)
        Me.btn_st6.Location = New System.Drawing.Point(1292, 617)
        Me.btn_st6.Name = "btn_st6"
        Me.btn_st6.Size = New System.Drawing.Size(120, 85)
        Me.btn_st6.TabIndex = 45
        Me.btn_st6.Text = "ST6"
        Me.btn_st6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_st6.UseVisualStyleBackColor = True
        '
        'btn_st5
        '
        Me.btn_st5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st5.Image = CType(resources.GetObject("btn_st5.Image"), System.Drawing.Image)
        Me.btn_st5.Location = New System.Drawing.Point(1292, 526)
        Me.btn_st5.Name = "btn_st5"
        Me.btn_st5.Size = New System.Drawing.Size(120, 85)
        Me.btn_st5.TabIndex = 44
        Me.btn_st5.Text = "ST5"
        Me.btn_st5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_st5.UseVisualStyleBackColor = True
        '
        'btn_st4
        '
        Me.btn_st4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st4.Image = CType(resources.GetObject("btn_st4.Image"), System.Drawing.Image)
        Me.btn_st4.Location = New System.Drawing.Point(1292, 435)
        Me.btn_st4.Name = "btn_st4"
        Me.btn_st4.Size = New System.Drawing.Size(120, 85)
        Me.btn_st4.TabIndex = 43
        Me.btn_st4.Text = "ST4"
        Me.btn_st4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_st4.UseVisualStyleBackColor = True
        '
        'btn_st3
        '
        Me.btn_st3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st3.Image = CType(resources.GetObject("btn_st3.Image"), System.Drawing.Image)
        Me.btn_st3.Location = New System.Drawing.Point(1292, 344)
        Me.btn_st3.Name = "btn_st3"
        Me.btn_st3.Size = New System.Drawing.Size(120, 85)
        Me.btn_st3.TabIndex = 42
        Me.btn_st3.Text = "ST3"
        Me.btn_st3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_st3.UseVisualStyleBackColor = True
        '
        'btn_st2
        '
        Me.btn_st2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st2.Image = CType(resources.GetObject("btn_st2.Image"), System.Drawing.Image)
        Me.btn_st2.Location = New System.Drawing.Point(1292, 253)
        Me.btn_st2.Name = "btn_st2"
        Me.btn_st2.Size = New System.Drawing.Size(120, 85)
        Me.btn_st2.TabIndex = 41
        Me.btn_st2.Text = "ST2"
        Me.btn_st2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_st2.UseVisualStyleBackColor = True
        '
        'btn_st1
        '
        Me.btn_st1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_st1.Image = CType(resources.GetObject("btn_st1.Image"), System.Drawing.Image)
        Me.btn_st1.Location = New System.Drawing.Point(1292, 162)
        Me.btn_st1.Name = "btn_st1"
        Me.btn_st1.Size = New System.Drawing.Size(120, 85)
        Me.btn_st1.TabIndex = 40
        Me.btn_st1.Text = "ST1"
        Me.btn_st1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_st1.UseVisualStyleBackColor = True
        '
        'DateTime
        '
        Me.DateTime.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_ref)
        Me.GroupBox1.Controls.Add(Me.GroupBox_Control)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(136, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1150, 687)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "References"
        '
        'GroupBox_Control
        '
        Me.GroupBox_Control.BackColor = System.Drawing.Color.White
        Me.GroupBox_Control.Controls.Add(Me.tbx_camera_program)
        Me.GroupBox_Control.Controls.Add(Me.tbx_Ldist)
        Me.GroupBox_Control.Controls.Add(Me.Label247)
        Me.GroupBox_Control.Controls.Add(Me.Label237)
        Me.GroupBox_Control.Controls.Add(Me.tbx_laser_template)
        Me.GroupBox_Control.Controls.Add(Me.tbx_oring)
        Me.GroupBox_Control.Controls.Add(Me.Label246)
        Me.GroupBox_Control.Controls.Add(Me.Label238)
        Me.GroupBox_Control.Controls.Add(Me.btn_update)
        Me.GroupBox_Control.Controls.Add(Me.tbx_Rspeed)
        Me.GroupBox_Control.Controls.Add(Me.tbx_lvl_toler)
        Me.GroupBox_Control.Controls.Add(Me.tbx_Lspeed)
        Me.GroupBox_Control.Controls.Add(Me.tbx_lvl_dist)
        Me.GroupBox_Control.Controls.Add(Me.Label245)
        Me.GroupBox_Control.Controls.Add(Me.Label239)
        Me.GroupBox_Control.Controls.Add(Me.Label244)
        Me.GroupBox_Control.Controls.Add(Me.Label240)
        Me.GroupBox_Control.Controls.Add(Me.btn_delete)
        Me.GroupBox_Control.Controls.Add(Me.btn_add)
        Me.GroupBox_Control.Controls.Add(Me.tbx_Rdist)
        Me.GroupBox_Control.Controls.Add(Me.tbx_punching)
        Me.GroupBox_Control.Controls.Add(Me.Label243)
        Me.GroupBox_Control.Controls.Add(Me.tbx_ref)
        Me.GroupBox_Control.Controls.Add(Me.Label241)
        Me.GroupBox_Control.Controls.Add(Me.Label242)
        Me.GroupBox_Control.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Control.ForeColor = System.Drawing.Color.Black
        Me.GroupBox_Control.Location = New System.Drawing.Point(6, 37)
        Me.GroupBox_Control.Name = "GroupBox_Control"
        Me.GroupBox_Control.Size = New System.Drawing.Size(320, 500)
        Me.GroupBox_Control.TabIndex = 68
        Me.GroupBox_Control.TabStop = False
        Me.GroupBox_Control.Text = "Control"
        '
        'tbx_camera_program
        '
        Me.tbx_camera_program.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_camera_program.Location = New System.Drawing.Point(197, 369)
        Me.tbx_camera_program.MaxLength = 32
        Me.tbx_camera_program.Name = "tbx_camera_program"
        Me.tbx_camera_program.Size = New System.Drawing.Size(112, 26)
        Me.tbx_camera_program.TabIndex = 6
        '
        'tbx_Ldist
        '
        Me.tbx_Ldist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Ldist.Location = New System.Drawing.Point(196, 209)
        Me.tbx_Ldist.MaxLength = 32
        Me.tbx_Ldist.Name = "tbx_Ldist"
        Me.tbx_Ldist.Size = New System.Drawing.Size(112, 26)
        Me.tbx_Ldist.TabIndex = 6
        '
        'Label247
        '
        Me.Label247.AutoSize = True
        Me.Label247.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label247.Location = New System.Drawing.Point(18, 372)
        Me.Label247.Name = "Label247"
        Me.Label247.Size = New System.Drawing.Size(129, 20)
        Me.Label247.TabIndex = 18
        Me.Label247.Text = "Camera Program"
        '
        'Label237
        '
        Me.Label237.AutoSize = True
        Me.Label237.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label237.Location = New System.Drawing.Point(17, 212)
        Me.Label237.Name = "Label237"
        Me.Label237.Size = New System.Drawing.Size(160, 20)
        Me.Label237.TabIndex = 18
        Me.Label237.Text = "Festo LEFT Distance"
        '
        'tbx_laser_template
        '
        Me.tbx_laser_template.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_laser_template.Location = New System.Drawing.Point(197, 337)
        Me.tbx_laser_template.MaxLength = 32
        Me.tbx_laser_template.Name = "tbx_laser_template"
        Me.tbx_laser_template.Size = New System.Drawing.Size(112, 26)
        Me.tbx_laser_template.TabIndex = 5
        '
        'tbx_oring
        '
        Me.tbx_oring.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_oring.Location = New System.Drawing.Point(196, 177)
        Me.tbx_oring.MaxLength = 32
        Me.tbx_oring.Name = "tbx_oring"
        Me.tbx_oring.Size = New System.Drawing.Size(112, 26)
        Me.tbx_oring.TabIndex = 5
        '
        'Label246
        '
        Me.Label246.AutoSize = True
        Me.Label246.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label246.Location = New System.Drawing.Point(18, 340)
        Me.Label246.Name = "Label246"
        Me.Label246.Size = New System.Drawing.Size(119, 20)
        Me.Label246.TabIndex = 16
        Me.Label246.Text = "Laser Template"
        '
        'Label238
        '
        Me.Label238.AutoSize = True
        Me.Label238.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label238.Location = New System.Drawing.Point(17, 180)
        Me.Label238.Name = "Label238"
        Me.Label238.Size = New System.Drawing.Size(96, 20)
        Me.Label238.TabIndex = 16
        Me.Label238.Text = "Oring Check"
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(116, 414)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(85, 59)
        Me.btn_update.TabIndex = 13
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'tbx_Rspeed
        '
        Me.tbx_Rspeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Rspeed.Location = New System.Drawing.Point(197, 305)
        Me.tbx_Rspeed.MaxLength = 32
        Me.tbx_Rspeed.Name = "tbx_Rspeed"
        Me.tbx_Rspeed.Size = New System.Drawing.Size(112, 26)
        Me.tbx_Rspeed.TabIndex = 4
        '
        'tbx_lvl_toler
        '
        Me.tbx_lvl_toler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_lvl_toler.Location = New System.Drawing.Point(196, 145)
        Me.tbx_lvl_toler.MaxLength = 32
        Me.tbx_lvl_toler.Name = "tbx_lvl_toler"
        Me.tbx_lvl_toler.Size = New System.Drawing.Size(112, 26)
        Me.tbx_lvl_toler.TabIndex = 4
        '
        'tbx_Lspeed
        '
        Me.tbx_Lspeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Lspeed.Location = New System.Drawing.Point(197, 273)
        Me.tbx_Lspeed.MaxLength = 32
        Me.tbx_Lspeed.Name = "tbx_Lspeed"
        Me.tbx_Lspeed.Size = New System.Drawing.Size(112, 26)
        Me.tbx_Lspeed.TabIndex = 3
        '
        'tbx_lvl_dist
        '
        Me.tbx_lvl_dist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_lvl_dist.Location = New System.Drawing.Point(196, 113)
        Me.tbx_lvl_dist.MaxLength = 32
        Me.tbx_lvl_dist.Name = "tbx_lvl_dist"
        Me.tbx_lvl_dist.Size = New System.Drawing.Size(112, 26)
        Me.tbx_lvl_dist.TabIndex = 3
        '
        'Label245
        '
        Me.Label245.AutoSize = True
        Me.Label245.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label245.Location = New System.Drawing.Point(18, 308)
        Me.Label245.Name = "Label245"
        Me.Label245.Size = New System.Drawing.Size(143, 20)
        Me.Label245.TabIndex = 13
        Me.Label245.Text = "Festo Right Speed"
        '
        'Label239
        '
        Me.Label239.AutoSize = True
        Me.Label239.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label239.Location = New System.Drawing.Point(17, 148)
        Me.Label239.Name = "Label239"
        Me.Label239.Size = New System.Drawing.Size(120, 20)
        Me.Label239.TabIndex = 13
        Me.Label239.Text = "Level Tolerance"
        '
        'Label244
        '
        Me.Label244.AutoSize = True
        Me.Label244.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label244.Location = New System.Drawing.Point(18, 276)
        Me.Label244.Name = "Label244"
        Me.Label244.Size = New System.Drawing.Size(133, 20)
        Me.Label244.TabIndex = 12
        Me.Label244.Text = "Festo Left Speed"
        '
        'Label240
        '
        Me.Label240.AutoSize = True
        Me.Label240.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label240.Location = New System.Drawing.Point(17, 116)
        Me.Label240.Name = "Label240"
        Me.Label240.Size = New System.Drawing.Size(113, 20)
        Me.Label240.TabIndex = 12
        Me.Label240.Text = "Level Distance"
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(214, 414)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(85, 59)
        Me.btn_delete.TabIndex = 14
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(22, 414)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(80, 59)
        Me.btn_add.TabIndex = 12
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'tbx_Rdist
        '
        Me.tbx_Rdist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Rdist.Location = New System.Drawing.Point(197, 241)
        Me.tbx_Rdist.MaxLength = 32
        Me.tbx_Rdist.Name = "tbx_Rdist"
        Me.tbx_Rdist.Size = New System.Drawing.Size(112, 26)
        Me.tbx_Rdist.TabIndex = 2
        '
        'tbx_punching
        '
        Me.tbx_punching.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_punching.Location = New System.Drawing.Point(196, 81)
        Me.tbx_punching.MaxLength = 32
        Me.tbx_punching.Name = "tbx_punching"
        Me.tbx_punching.Size = New System.Drawing.Size(112, 26)
        Me.tbx_punching.TabIndex = 2
        '
        'Label243
        '
        Me.Label243.AutoSize = True
        Me.Label243.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label243.Location = New System.Drawing.Point(18, 244)
        Me.Label243.Name = "Label243"
        Me.Label243.Size = New System.Drawing.Size(172, 20)
        Me.Label243.TabIndex = 7
        Me.Label243.Text = "Festo RIGHT Distance"
        '
        'tbx_ref
        '
        Me.tbx_ref.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_ref.Location = New System.Drawing.Point(196, 49)
        Me.tbx_ref.MaxLength = 32
        Me.tbx_ref.Name = "tbx_ref"
        Me.tbx_ref.Size = New System.Drawing.Size(112, 26)
        Me.tbx_ref.TabIndex = 1
        '
        'Label241
        '
        Me.Label241.AutoSize = True
        Me.Label241.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label241.Location = New System.Drawing.Point(17, 84)
        Me.Label241.Name = "Label241"
        Me.Label241.Size = New System.Drawing.Size(119, 20)
        Me.Label241.TabIndex = 7
        Me.Label241.Text = "Punching Mode"
        '
        'Label242
        '
        Me.Label242.AutoSize = True
        Me.Label242.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label242.Location = New System.Drawing.Point(17, 52)
        Me.Label242.Name = "Label242"
        Me.Label242.Size = New System.Drawing.Size(92, 20)
        Me.Label242.TabIndex = 6
        Me.Label242.Text = "References"
        '
        'dgv_ref
        '
        Me.dgv_ref.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ref.Location = New System.Drawing.Point(349, 48)
        Me.dgv_ref.Name = "dgv_ref"
        Me.dgv_ref.RowHeadersWidth = 51
        Me.dgv_ref.Size = New System.Drawing.Size(795, 487)
        Me.dgv_ref.TabIndex = 69
        '
        'ReferencesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1424, 861)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_st6)
        Me.Controls.Add(Me.btn_st5)
        Me.Controls.Add(Me.btn_st4)
        Me.Controls.Add(Me.btn_st3)
        Me.Controls.Add(Me.btn_st2)
        Me.Controls.Add(Me.btn_st1)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.pb_logo)
        Me.Controls.Add(Me.pb_status_mc)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_curr_time)
        Me.Controls.Add(Me.lbl_auto_man)
        Me.Controls.Add(Me.pb_status_bar)
        Me.Name = "ReferencesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReferencesForm"
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_status_mc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_status_bar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox_Control.ResumeLayout(False)
        Me.GroupBox_Control.PerformLayout()
        CType(Me.dgv_ref, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbl_user As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents pb_logo As PictureBox
    Friend WithEvents pb_status_mc As PictureBox
    Friend WithEvents lbl_date As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_curr_time As Label
    Friend WithEvents lbl_auto_man As Label
    Friend WithEvents pb_status_bar As PictureBox
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_st6 As Button
    Friend WithEvents btn_st5 As Button
    Friend WithEvents btn_st4 As Button
    Friend WithEvents btn_st3 As Button
    Friend WithEvents btn_st2 As Button
    Friend WithEvents btn_st1 As Button
    Friend WithEvents DateTime As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_ref As DataGridView
    Friend WithEvents GroupBox_Control As GroupBox
    Friend WithEvents tbx_camera_program As TextBox
    Friend WithEvents tbx_Ldist As TextBox
    Friend WithEvents Label247 As Label
    Friend WithEvents Label237 As Label
    Friend WithEvents tbx_laser_template As TextBox
    Friend WithEvents tbx_oring As TextBox
    Friend WithEvents Label246 As Label
    Friend WithEvents Label238 As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents tbx_Rspeed As TextBox
    Friend WithEvents tbx_lvl_toler As TextBox
    Friend WithEvents tbx_Lspeed As TextBox
    Friend WithEvents tbx_lvl_dist As TextBox
    Friend WithEvents Label245 As Label
    Friend WithEvents Label239 As Label
    Friend WithEvents Label244 As Label
    Friend WithEvents Label240 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents tbx_Rdist As TextBox
    Friend WithEvents tbx_punching As TextBox
    Friend WithEvents Label243 As Label
    Friend WithEvents tbx_ref As TextBox
    Friend WithEvents Label241 As Label
    Friend WithEvents Label242 As Label
End Class
