<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingForm))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.pb_logo = New System.Windows.Forms.PictureBox()
        Me.pb_status_mc = New System.Windows.Forms.PictureBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_curr_time = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pb_status_bar = New System.Windows.Forms.PictureBox()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.btn_st6 = New System.Windows.Forms.Button()
        Me.btn_st5 = New System.Windows.Forms.Button()
        Me.btn_st4 = New System.Windows.Forms.Button()
        Me.btn_st3 = New System.Windows.Forms.Button()
        Me.btn_st2 = New System.Windows.Forms.Button()
        Me.btn_st1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rtbSetting = New System.Windows.Forms.RichTextBox()
        Me.GroupBox177 = New System.Windows.Forms.GroupBox()
        Me.Label231 = New System.Windows.Forms.Label()
        Me.Label217 = New System.Windows.Forms.Label()
        Me.Label228 = New System.Windows.Forms.Label()
        Me.Label200 = New System.Windows.Forms.Label()
        Me.Label227 = New System.Windows.Forms.Label()
        Me.Label183 = New System.Windows.Forms.Label()
        Me.ind_stn_6 = New System.Windows.Forms.PictureBox()
        Me.ind_stn_3 = New System.Windows.Forms.PictureBox()
        Me.ind_stn_5 = New System.Windows.Forms.PictureBox()
        Me.ind_stn_2 = New System.Windows.Forms.PictureBox()
        Me.ind_stn_4 = New System.Windows.Forms.PictureBox()
        Me.ind_stn_1 = New System.Windows.Forms.PictureBox()
        Me.grp_plc = New System.Windows.Forms.GroupBox()
        Me.ind_connect_plc = New System.Windows.Forms.PictureBox()
        Me.btn_write = New System.Windows.Forms.Button()
        Me.btn_save_plc = New System.Windows.Forms.Button()
        Me.btn_connect_plc = New System.Windows.Forms.Button()
        Me.btn_read = New System.Windows.Forms.Button()
        Me.txt_port_plc = New System.Windows.Forms.TextBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.txt_ip_plc = New System.Windows.Forms.TextBox()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.DateTime = New System.Windows.Forms.Timer(Me.components)
        Me.ModbusRW = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_status_mc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_status_bar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox177.SuspendLayout()
        CType(Me.ind_stn_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ind_stn_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ind_stn_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ind_stn_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ind_stn_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ind_stn_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_plc.SuspendLayout()
        CType(Me.ind_connect_plc, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LimeGreen
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(371, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 31)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "MANUAL"
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
        Me.btn_home.TabIndex = 39
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
        Me.btn_st6.TabIndex = 53
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
        Me.btn_st5.TabIndex = 52
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
        Me.btn_st4.TabIndex = 51
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
        Me.btn_st3.TabIndex = 50
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
        Me.btn_st2.TabIndex = 49
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
        Me.btn_st1.TabIndex = 48
        Me.btn_st1.Text = "ST1"
        Me.btn_st1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_st1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rtbSetting)
        Me.GroupBox1.Controls.Add(Me.GroupBox177)
        Me.GroupBox1.Controls.Add(Me.grp_plc)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(136, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1150, 687)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Setting"
        '
        'rtbSetting
        '
        Me.rtbSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbSetting.Location = New System.Drawing.Point(397, 587)
        Me.rtbSetting.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbSetting.Name = "rtbSetting"
        Me.rtbSetting.Size = New System.Drawing.Size(657, 64)
        Me.rtbSetting.TabIndex = 68
        Me.rtbSetting.Text = ""
        '
        'GroupBox177
        '
        Me.GroupBox177.Controls.Add(Me.Label231)
        Me.GroupBox177.Controls.Add(Me.Label217)
        Me.GroupBox177.Controls.Add(Me.Label228)
        Me.GroupBox177.Controls.Add(Me.Label200)
        Me.GroupBox177.Controls.Add(Me.Label227)
        Me.GroupBox177.Controls.Add(Me.Label183)
        Me.GroupBox177.Controls.Add(Me.ind_stn_6)
        Me.GroupBox177.Controls.Add(Me.ind_stn_3)
        Me.GroupBox177.Controls.Add(Me.ind_stn_5)
        Me.GroupBox177.Controls.Add(Me.ind_stn_2)
        Me.GroupBox177.Controls.Add(Me.ind_stn_4)
        Me.GroupBox177.Controls.Add(Me.ind_stn_1)
        Me.GroupBox177.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox177.Location = New System.Drawing.Point(28, 38)
        Me.GroupBox177.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox177.Name = "GroupBox177"
        Me.GroupBox177.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox177.Size = New System.Drawing.Size(287, 153)
        Me.GroupBox177.TabIndex = 65
        Me.GroupBox177.TabStop = False
        Me.GroupBox177.Text = "Station Status"
        '
        'Label231
        '
        Me.Label231.AutoSize = True
        Me.Label231.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label231.Location = New System.Drawing.Point(177, 107)
        Me.Label231.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label231.Name = "Label231"
        Me.Label231.Size = New System.Drawing.Size(73, 20)
        Me.Label231.TabIndex = 0
        Me.Label231.Text = "Station 6"
        '
        'Label217
        '
        Me.Label217.AutoSize = True
        Me.Label217.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label217.Location = New System.Drawing.Point(39, 107)
        Me.Label217.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label217.Name = "Label217"
        Me.Label217.Size = New System.Drawing.Size(73, 20)
        Me.Label217.TabIndex = 0
        Me.Label217.Text = "Station 3"
        '
        'Label228
        '
        Me.Label228.AutoSize = True
        Me.Label228.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label228.Location = New System.Drawing.Point(177, 75)
        Me.Label228.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label228.Name = "Label228"
        Me.Label228.Size = New System.Drawing.Size(73, 20)
        Me.Label228.TabIndex = 0
        Me.Label228.Text = "Station 5"
        '
        'Label200
        '
        Me.Label200.AutoSize = True
        Me.Label200.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label200.Location = New System.Drawing.Point(39, 75)
        Me.Label200.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label200.Name = "Label200"
        Me.Label200.Size = New System.Drawing.Size(73, 20)
        Me.Label200.TabIndex = 0
        Me.Label200.Text = "Station 2"
        '
        'Label227
        '
        Me.Label227.AutoSize = True
        Me.Label227.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label227.Location = New System.Drawing.Point(177, 43)
        Me.Label227.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label227.Name = "Label227"
        Me.Label227.Size = New System.Drawing.Size(73, 20)
        Me.Label227.TabIndex = 0
        Me.Label227.Text = "Station 4"
        '
        'Label183
        '
        Me.Label183.AutoSize = True
        Me.Label183.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label183.Location = New System.Drawing.Point(39, 43)
        Me.Label183.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label183.Name = "Label183"
        Me.Label183.Size = New System.Drawing.Size(77, 20)
        Me.Label183.TabIndex = 0
        Me.Label183.Text = "Station 1 "
        '
        'ind_stn_6
        '
        Me.ind_stn_6.BackColor = System.Drawing.Color.Green
        Me.ind_stn_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_stn_6.Location = New System.Drawing.Point(145, 107)
        Me.ind_stn_6.Margin = New System.Windows.Forms.Padding(4)
        Me.ind_stn_6.Name = "ind_stn_6"
        Me.ind_stn_6.Size = New System.Drawing.Size(26, 24)
        Me.ind_stn_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ind_stn_6.TabIndex = 1
        Me.ind_stn_6.TabStop = False
        '
        'ind_stn_3
        '
        Me.ind_stn_3.BackColor = System.Drawing.Color.Green
        Me.ind_stn_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_stn_3.Location = New System.Drawing.Point(7, 107)
        Me.ind_stn_3.Margin = New System.Windows.Forms.Padding(4)
        Me.ind_stn_3.Name = "ind_stn_3"
        Me.ind_stn_3.Size = New System.Drawing.Size(26, 24)
        Me.ind_stn_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ind_stn_3.TabIndex = 1
        Me.ind_stn_3.TabStop = False
        '
        'ind_stn_5
        '
        Me.ind_stn_5.BackColor = System.Drawing.Color.Green
        Me.ind_stn_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_stn_5.Location = New System.Drawing.Point(145, 75)
        Me.ind_stn_5.Margin = New System.Windows.Forms.Padding(4)
        Me.ind_stn_5.Name = "ind_stn_5"
        Me.ind_stn_5.Size = New System.Drawing.Size(26, 24)
        Me.ind_stn_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ind_stn_5.TabIndex = 1
        Me.ind_stn_5.TabStop = False
        '
        'ind_stn_2
        '
        Me.ind_stn_2.BackColor = System.Drawing.Color.Green
        Me.ind_stn_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_stn_2.Location = New System.Drawing.Point(7, 75)
        Me.ind_stn_2.Margin = New System.Windows.Forms.Padding(4)
        Me.ind_stn_2.Name = "ind_stn_2"
        Me.ind_stn_2.Size = New System.Drawing.Size(26, 24)
        Me.ind_stn_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ind_stn_2.TabIndex = 1
        Me.ind_stn_2.TabStop = False
        '
        'ind_stn_4
        '
        Me.ind_stn_4.BackColor = System.Drawing.Color.Green
        Me.ind_stn_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_stn_4.Location = New System.Drawing.Point(145, 43)
        Me.ind_stn_4.Margin = New System.Windows.Forms.Padding(4)
        Me.ind_stn_4.Name = "ind_stn_4"
        Me.ind_stn_4.Size = New System.Drawing.Size(26, 24)
        Me.ind_stn_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ind_stn_4.TabIndex = 1
        Me.ind_stn_4.TabStop = False
        '
        'ind_stn_1
        '
        Me.ind_stn_1.BackColor = System.Drawing.Color.Green
        Me.ind_stn_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_stn_1.Location = New System.Drawing.Point(7, 43)
        Me.ind_stn_1.Margin = New System.Windows.Forms.Padding(4)
        Me.ind_stn_1.Name = "ind_stn_1"
        Me.ind_stn_1.Size = New System.Drawing.Size(26, 24)
        Me.ind_stn_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ind_stn_1.TabIndex = 1
        Me.ind_stn_1.TabStop = False
        '
        'grp_plc
        '
        Me.grp_plc.Controls.Add(Me.ind_connect_plc)
        Me.grp_plc.Controls.Add(Me.btn_write)
        Me.grp_plc.Controls.Add(Me.btn_save_plc)
        Me.grp_plc.Controls.Add(Me.btn_connect_plc)
        Me.grp_plc.Controls.Add(Me.btn_read)
        Me.grp_plc.Controls.Add(Me.txt_port_plc)
        Me.grp_plc.Controls.Add(Me.txtValue)
        Me.grp_plc.Controls.Add(Me.txt_ip_plc)
        Me.grp_plc.Controls.Add(Me.Label88)
        Me.grp_plc.Controls.Add(Me.txtAddress)
        Me.grp_plc.Controls.Add(Me.Label89)
        Me.grp_plc.Controls.Add(Me.Label90)
        Me.grp_plc.Controls.Add(Me.Label91)
        Me.grp_plc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_plc.Location = New System.Drawing.Point(28, 220)
        Me.grp_plc.Margin = New System.Windows.Forms.Padding(4)
        Me.grp_plc.Name = "grp_plc"
        Me.grp_plc.Padding = New System.Windows.Forms.Padding(4)
        Me.grp_plc.Size = New System.Drawing.Size(287, 431)
        Me.grp_plc.TabIndex = 64
        Me.grp_plc.TabStop = False
        Me.grp_plc.Text = "PLC"
        '
        'ind_connect_plc
        '
        Me.ind_connect_plc.BackColor = System.Drawing.Color.Green
        Me.ind_connect_plc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ind_connect_plc.Location = New System.Drawing.Point(60, 113)
        Me.ind_connect_plc.Margin = New System.Windows.Forms.Padding(4)
        Me.ind_connect_plc.Name = "ind_connect_plc"
        Me.ind_connect_plc.Size = New System.Drawing.Size(26, 24)
        Me.ind_connect_plc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ind_connect_plc.TabIndex = 1
        Me.ind_connect_plc.TabStop = False
        '
        'btn_write
        '
        Me.btn_write.AutoSize = True
        Me.btn_write.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_write.Location = New System.Drawing.Point(151, 328)
        Me.btn_write.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_write.Name = "btn_write"
        Me.btn_write.Size = New System.Drawing.Size(112, 43)
        Me.btn_write.TabIndex = 4
        Me.btn_write.Text = "Write"
        Me.btn_write.UseVisualStyleBackColor = True
        '
        'btn_save_plc
        '
        Me.btn_save_plc.AutoSize = True
        Me.btn_save_plc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save_plc.Location = New System.Drawing.Point(151, 145)
        Me.btn_save_plc.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_save_plc.Name = "btn_save_plc"
        Me.btn_save_plc.Size = New System.Drawing.Size(128, 43)
        Me.btn_save_plc.TabIndex = 4
        Me.btn_save_plc.Text = "Save Config"
        Me.btn_save_plc.UseVisualStyleBackColor = True
        '
        'btn_connect_plc
        '
        Me.btn_connect_plc.AutoSize = True
        Me.btn_connect_plc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_connect_plc.Location = New System.Drawing.Point(8, 145)
        Me.btn_connect_plc.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_connect_plc.Name = "btn_connect_plc"
        Me.btn_connect_plc.Size = New System.Drawing.Size(128, 43)
        Me.btn_connect_plc.TabIndex = 4
        Me.btn_connect_plc.Text = "Connect"
        Me.btn_connect_plc.UseVisualStyleBackColor = True
        '
        'btn_read
        '
        Me.btn_read.AutoSize = True
        Me.btn_read.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_read.Location = New System.Drawing.Point(24, 328)
        Me.btn_read.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_read.Name = "btn_read"
        Me.btn_read.Size = New System.Drawing.Size(112, 43)
        Me.btn_read.TabIndex = 4
        Me.btn_read.Text = "Read"
        Me.btn_read.UseVisualStyleBackColor = True
        '
        'txt_port_plc
        '
        Me.txt_port_plc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_port_plc.Location = New System.Drawing.Point(120, 70)
        Me.txt_port_plc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_port_plc.Name = "txt_port_plc"
        Me.txt_port_plc.Size = New System.Drawing.Size(148, 26)
        Me.txt_port_plc.TabIndex = 3
        '
        'txtValue
        '
        Me.txtValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.Location = New System.Drawing.Point(125, 267)
        Me.txtValue.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(148, 26)
        Me.txtValue.TabIndex = 3
        '
        'txt_ip_plc
        '
        Me.txt_ip_plc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ip_plc.Location = New System.Drawing.Point(120, 30)
        Me.txt_ip_plc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ip_plc.Name = "txt_ip_plc"
        Me.txt_ip_plc.Size = New System.Drawing.Size(148, 26)
        Me.txt_ip_plc.TabIndex = 2
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(41, 70)
        Me.Label88.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(46, 20)
        Me.Label88.TabIndex = 1
        Me.Label88.Text = "Port :"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(125, 226)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(148, 26)
        Me.txtAddress.TabIndex = 2
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(41, 271)
        Me.Label89.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(58, 20)
        Me.Label89.TabIndex = 1
        Me.Label89.Text = "Value :"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(5, 36)
        Me.Label90.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(82, 20)
        Me.Label90.TabIndex = 1
        Me.Label90.Text = "Server IP :"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.Location = New System.Drawing.Point(21, 230)
        Me.Label91.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(76, 20)
        Me.Label91.TabIndex = 1
        Me.Label91.Text = "Address :"
        '
        'DateTime
        '
        Me.DateTime.Enabled = True
        '
        'SettingForm
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb_status_bar)
        Me.Name = "SettingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SettingForm"
        CType(Me.pb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_status_mc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_status_bar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox177.ResumeLayout(False)
        Me.GroupBox177.PerformLayout()
        CType(Me.ind_stn_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ind_stn_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ind_stn_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ind_stn_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ind_stn_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ind_stn_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_plc.ResumeLayout(False)
        Me.grp_plc.PerformLayout()
        CType(Me.ind_connect_plc, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents pb_status_bar As PictureBox
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_st6 As Button
    Friend WithEvents btn_st5 As Button
    Friend WithEvents btn_st4 As Button
    Friend WithEvents btn_st3 As Button
    Friend WithEvents btn_st2 As Button
    Friend WithEvents btn_st1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox177 As GroupBox
    Friend WithEvents Label231 As Label
    Friend WithEvents Label217 As Label
    Friend WithEvents Label228 As Label
    Friend WithEvents Label200 As Label
    Friend WithEvents Label227 As Label
    Friend WithEvents Label183 As Label
    Friend WithEvents ind_stn_6 As PictureBox
    Friend WithEvents ind_stn_3 As PictureBox
    Friend WithEvents ind_stn_5 As PictureBox
    Friend WithEvents ind_stn_2 As PictureBox
    Friend WithEvents ind_stn_4 As PictureBox
    Friend WithEvents ind_stn_1 As PictureBox
    Friend WithEvents grp_plc As GroupBox
    Friend WithEvents ind_connect_plc As PictureBox
    Friend WithEvents btn_write As Button
    Friend WithEvents btn_save_plc As Button
    Friend WithEvents btn_connect_plc As Button
    Friend WithEvents btn_read As Button
    Friend WithEvents txt_port_plc As TextBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents txt_ip_plc As TextBox
    Friend WithEvents Label88 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label89 As Label
    Friend WithEvents Label90 As Label
    Friend WithEvents Label91 As Label
    Friend WithEvents DateTime As Timer
    Friend WithEvents ModbusRW As Timer
    Friend WithEvents rtbSetting As RichTextBox
End Class
