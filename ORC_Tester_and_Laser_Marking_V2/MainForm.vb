Imports System.Threading
Imports System.IO
Imports System.Data.SqlClient
Imports ControlBPM
Public Class MainForm
    Dim ThreadLoadingBar As Thread
    ' Dim plcStatusThread As Thread
    Dim MainModbusThread As Thread
    'Dim Statusbar As Thread


    Dim fullPath As String = System.AppDomain.CurrentDomain.BaseDirectory
    Dim projectFolder As String = fullPath.Replace("\ORC_Tester_and_Laser_Marking_V2\bin\Debug\", "").Replace("\ORC_Tester_and_Laser_Marking\bin\Release\", "")
    Dim iniPath As String = projectFolder + "\Config\Config.INI"
    Dim logFileName As String = $"Log_{Date.Now.ToString("yyyyMMdd")}.csv"

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hide()
        initLoadingBar()
        AutoConnection()
        'Statusbar = New Thread(New ThreadStart(AddressOf manualauto))
        'Statusbar.Start()
        ' plcStatusThread = New Thread(New ThreadStart(AddressOf plcStatus))
        'plcStatusThread.Start()
        MainModbusThread = New Thread(AddressOf MainModbus)
        MainModbusThread.Start()

        UpdateLoadingBar(20, "Loading")
        Thread.Sleep(500)

        UpdateLoadingBar(40, "Loading.")
        Thread.Sleep(500)

        UpdateLoadingBar(60, "Loading..")
        Thread.Sleep(500)

        UpdateLoadingBar(80, "Loading...")
        Thread.Sleep(500)

        UpdateLoadingBar(100, "Loading")
        Thread.Sleep(500)

        killLoadingBar()
        Cursor = Cursors.Default
        LoginForm.ShowDialog()
        GetUserLevel()

        With Config
            .dbHostName = ReadINI(iniPath, "DATABASE", "Hostname")
            .dbUsername = ReadINI(iniPath, "DATABASE", "Username")
            .dbPassword = ReadINI(iniPath, "DATABASE", "Password")
            .dbDatabase = ReadINI(iniPath, "DATABASE", "Database")
        End With

        Status.Enabled = True

        'Button Station Enable

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Name.StartsWith("btn_st") Then
                ctrl.Enabled = False
            End If
        Next
    End Sub

    Private Sub initLoadingBar()
        ThreadLoadingBar = New Thread(New ThreadStart(AddressOf ProcessLoad))
        ThreadLoadingBar.Start()
    End Sub
    Private Sub ProcessLoad()
        Do
            Try
                LoadingForm.ShowDialog()
                Thread.Sleep(100)
            Catch ex As Exception

            End Try
        Loop
    End Sub
    Private Sub UpdateLoadingBar(value As Integer, msg As String)
        LoadingBarValue = value
        LoadingBarMessage = msg
    End Sub
    Private Sub killLoadingBar()
        ThreadLoadingBar.Abort()
    End Sub

    Private Sub GetUserLevel()
        If UserLevel = 1 Then
            lbl_user.Text = "ADM"
            btn_setting.Enabled = True
            btn_manual.Enabled = True
            btn_references.Enabled = True
            btn_alarm.Enabled = True
            btn_log.Enabled = True
        ElseIf UserLevel = 2 Then
            lbl_user.Text = "ENG"
            btn_setting.Enabled = True
            btn_manual.Enabled = True
            btn_references.Enabled = True
            btn_alarm.Enabled = True
            btn_log.Enabled = True
        ElseIf UserLevel = 3 Then
            lbl_user.Text = "OPE"
            btn_setting.Enabled = False
            btn_manual.Enabled = False
            btn_references.Enabled = False
            btn_alarm.Enabled = False
            btn_log.Enabled = False
        ElseIf UserLevel = 4 Then
            lbl_user.Text = "QUA"
            btn_setting.Enabled = False
            btn_manual.Enabled = False
            btn_references.Enabled = False
            btn_alarm.Enabled = False
            btn_log.Enabled = False
        End If
    End Sub


    Private Sub DateTime_Tick(sender As Object, e As EventArgs) Handles DateTime.Tick
        lbl_date.Text = Date.Now.ToString("dd-MM-yyyy")
        lbl_curr_time.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Hide()
        LoginForm.ShowDialog()
        GetUserLevel()
    End Sub

    Private Sub btn_manual_Click(sender As Object, e As EventArgs) Handles btn_manual.Click
        Hide()
        'plcStatusThread.Abort()
        ManualForm.Show()
        'plcReadThread = New Thread(AddressOf plcReading)
        'plcReadThread.Start()
    End Sub

    Private Sub btn_references_Click(sender As Object, e As EventArgs) Handles btn_references.Click
        Hide()
        ' plcStatusThread.Abort()
        MainModbusThread.Abort()
        ReferencesForm.Show()
        'MainModbusThread = New Thread(AddressOf MainModbus)
        'MainModbusThread.Start()
    End Sub

    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click
        Hide()
        'plcStatusThread.Abort()
        MainModbusThread.Abort()
        SettingForm.Show()
        'MainModbusThread = New Thread(AddressOf MainModbus)
        'MainModbusThread.Start()
    End Sub

    'Private Sub plcStatus()
    '    Do
    '        Console.WriteLine("Modbus MainForm")
    '        If Connected() Then
    '            'RunningMode Status
    '            RUNNING_MODE = Modbus.ReadModbus(ADDR_RUNNING_MODE, 1)(0)
    '            Select Case RUNNING_MODE
    '                Case 0
    '                    Me.Invoke(Sub()
    '                                  lbl_auto_man.Text = "..."
    '                              End Sub)
    '                Case 1
    '                    Me.Invoke(Sub()
    '                                  lbl_auto_man.Text = "AUTO"
    '                              End Sub)
    '                Case 2
    '                    Me.Invoke(Sub()
    '                                  lbl_auto_man.Text = "MANUAL"
    '                              End Sub)
    '            End Select


    '            'Check PLC
    '            Try
    '                PLC_READY = Modbus.ReadModbus(ADDR_PLC_READY, 1)(0)
    '                If PLC_READY = 1 Then
    '                    ind_plc_status.BackColor = Color.Lime
    '                Else
    '                    ind_plc_status.BackColor = Color.Red
    '                End If

    '            Catch ex As Exception

    '            End Try
    '        End If

    '        Thread.Sleep(100)
    '    Loop
    'End Sub

    'For Refrences, Operator ID,PO Number

    Private hasInvalidReferenceMessageBoxShown As Boolean = False
    Private Sub Status_Tick(sender As Object, e As EventArgs) Handles Status.Tick


        'Select Case SCAN_MODE
        '    Case 0
        '        If txt_ref.Text <> "" Then
        '            Call ConnectionDB.connection_db()
        '            Dim sc As New SqlCommand("SELECT * FROM tbl_References WHERE [References]=@Reference", ConnectionDB.Connection)
        '            sc.Parameters.AddWithValue("@Reference", txt_ref.Text)
        '            Dim rd As SqlDataReader = sc.ExecuteReader()

        '            If rd.HasRows Then
        '                SCAN_MODE = 1
        '            Else
        '                MsgBox("Invalid Reference")
        '                txt_ref.Text = ""
        '            End If

        '            rd.Close()
        '        End If

        '    Case 1
        '        If txt_ope_id.Text <> "" Then
        '            SCAN_MODE = 2
        '        End If

        '    Case 2
        '        If txt_po_num.Text <> "" Then
        '            Call ConnectionDB.connection_db()
        '            Dim sc As New SqlCommand("SELECT * FROM tbl_References WHERE [References]=@Reference", ConnectionDB.Connection)
        '            sc.Parameters.AddWithValue("@Reference", txt_ref.Text)
        '            Dim rd As SqlDataReader = sc.ExecuteReader()

        '            If rd.HasRows Then
        '                rd.Read()
        '                Modbus.WriteModbus(ADDR_PUNCHING_MODE, rd.Item("Punching Mode"))
        '                Modbus.WriteDataFloat(ADDR_LVL_DIST, Single.Parse(rd.Item("Level Distance").Replace(",", ".")))
        '                Modbus.WriteDataFloat(ADDR_LVL_TOLER, Single.Parse(rd.Item("Level Tolerance").Replace(",", ".")))
        '                Modbus.WriteModbus(ADDR_ORING, rd.Item("Oring Check"))
        '                Modbus.WriteModbus(ADDR_FESTO_LDIST1, rd.Item("Festo LEFT Distance"))
        '                Modbus.WriteModbus(ADDR_FESTO_LDIST2, rd.Item("Festo LEFT Distance"))
        '                Modbus.WriteModbus(ADDR_FESTO_RDIST1, rd.Item("Festo RIGHT Distance"))
        '                Modbus.WriteModbus(ADDR_FESTO_RDIST2, rd.Item("Festo RIGHT Distance"))
        '                Modbus.WriteModbus(ADDR_FESTO_LSPEED, rd.Item("Festo LEFT Speed"))
        '                Modbus.WriteModbus(ADDR_FESTO_RSPEED, rd.Item("Festo RIGHT Speed"))
        '                Modbus.WriteModbus(ADDR_LASER_TEMPLATE, rd.Item("Laser Template"))
        '                Modbus.WriteModbus(ADDR_CAMERA_PROGRAM, rd.Item("Camera Program"))



        '                SCAN_MODE = 3
        '            Else
        '                MsgBox("Invalid Reference")
        '                txt_ref.Text = ""
        '            End If

        '            rd.Close()
        '        End If
        'End Select

        Select Case SCAN_MODE
            Case 0
                If txt_ref.Text <> "" Then
                    Call ConnectionDB.connection_db()
                    Dim sc As New SqlCommand("SELECT * FROM tbl_References WHERE [References]='" & txt_ref.Text & "'", ConnectionDB.Connection)
                    Dim rd As SqlDataReader = sc.ExecuteReader
                    rd.Read()
                    If Not rd.HasRows Then
                        'If Not hasInvalidReferenceMessageBoxShown Then
                        'txt_msg.Text = "Invalid Reference"
                        'MessageBox.Show("Invalid Reference", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'hasInvalidReferenceMessageBoxShown = True

                        'If
                        txt_ref.Text = ""
                        Return
                    End If
                    SCAN_MODE = 1
                End If
            Case 1
                If txt_ope_id.Text <> "" Then
                    SCAN_MODE = 2
                End If
            Case 2
                If txt_po_num.Text <> "" Then
                    'Insert data to database
                    Call ConnectionDB.connection_db()
                    Dim sc As New SqlCommand("SELECT * FROM tbl_References WHERE [References]='" & txt_ref.Text & "'", ConnectionDB.Connection)
                    Dim rd As SqlDataReader = sc.ExecuteReader
                    rd.Read()
                    txt_sendref.Text = txt_ref.Text


                    'write to plc
                    Modbus.WriteModbus(ADDR_PUNCHING_MODE, rd.Item("Punching Mode"))
                    Modbus.WriteDataFloat(ADDR_LVL_DIST, Single.Parse(rd.Item("Level Distance").Replace(",", ".")))
                    Modbus.WriteDataFloat(ADDR_LVL_TOLER, Single.Parse(rd.Item("Level Tolerance").Replace(",", ".")))
                    Modbus.WriteModbus(ADDR_ORING, rd.Item("Oring Check"))
                    Modbus.WriteModbus(ADDR_FESTO_LDIST1, rd.Item("Festo LEFT Distance"))
                    Modbus.WriteModbus(ADDR_FESTO_LDIST2, rd.Item("Festo LEFT Distance"))
                    Modbus.WriteModbus(ADDR_FESTO_RDIST1, rd.Item("Festo RIGHT Distance"))
                    Modbus.WriteModbus(ADDR_FESTO_RDIST2, rd.Item("Festo RIGHT Distance"))
                    Modbus.WriteModbus(ADDR_FESTO_LSPEED, rd.Item("Festo LEFT Speed"))
                    Modbus.WriteModbus(ADDR_FESTO_RSPEED, rd.Item("Festo RIGHT Speed"))
                    Modbus.WriteModbus(ADDR_LASER_TEMPLATE, rd.Item("Laser Template"))
                    Modbus.WriteModbus(ADDR_CAMERA_PROGRAM, rd.Item("Camera Program"))

                    '    Select Case LASER_STATE
                    '        Case 0
                    '            Laser.GetMarkStatus
                    '            If Laser.ReadData("2") Then
                    '                LASER_STATE += 1
                    '            End If
                    '        Case 1
                    '            Laser.SetMarkingTemplate(rd.Item("Laser Template"))
                    '            If Laser.ReadData("Ok") Then
                    '                LASER_STATE += 1
                    '            End If
                    '        Case 2
                    '            SCAN_MODE = 3
                    '    End Select

                    SCAN_MODE = 3
                End If
        End Select
    End Sub

    Private Sub MainModbus()
        Do
            Console.WriteLine("MainForm thread=MainModbus")

            If Not plcTrigger Then
                plcReading()
            Else
                plcWriting()
                'Thread.Sleep(10)
                plcTrigger = False
            End If
            Thread.Sleep(100)
        Loop
    End Sub

    Private Sub plcReading()
        Try

            'Auto Manual Status
            If Connected() Then
                RUNNING_MODE = Modbus.ReadModbus(ADDR_RUNNING_MODE, 1)(0)
                Select Case RUNNING_MODE
                    Case 0
                        Me.Invoke(Sub()
                                      lbl_auto_man.Text = "..."
                                  End Sub)
                    Case 1
                        Me.Invoke(Sub()
                                      lbl_auto_man.Text = "AUTO"
                                  End Sub)
                    Case 2
                        Me.Invoke(Sub()
                                      lbl_auto_man.Text = "MANUAL"
                                  End Sub)
                End Select
                'Check PLC

                PLC_READY = Modbus.ReadModbus(ADDR_PLC_READY, 1)(0)
                If PLC_READY = 1 Then
                    ind_plc_status.BackColor = Color.Lime
                Else
                    ind_plc_status.BackColor = Color.Red
                End If





            End If

            GetAutoMan.RUNNING_MODE = Modbus.ReadModbus(ADDR_RUNNING_MODE, 1)(0)

            'Cylinder
            GetCylFest.V101 = Modbus.ReadModbus(ADDR_STN1_SEN1, 1)(0)
            GetCylFest.V301 = Modbus.ReadModbus(ADDR_STN3_SEN1, 1)(0)
            GetCylFest.V302 = Modbus.ReadModbus(ADDR_STN3_SEN2, 1)(0)
            GetCylFest.V303 = Modbus.ReadModbus(ADDR_STN3_SEN3, 1)(0)
            GetCylFest.V304 = Modbus.ReadModbus(ADDR_STN3_SEN4, 1)(0)
            GetCylFest.V401 = Modbus.ReadModbus(ADDR_STN4_SEN1, 1)(0)
            GetCylFest.V501 = Modbus.ReadModbus(ADDR_STN5_SEN1, 1)(0)
            GetCylFest.V502 = Modbus.ReadModbus(ADDR_STN5_SEN2, 1)(0)
            GetCylFest.V503 = Modbus.ReadModbus(ADDR_STN5_SEN3, 1)(0)
            GetCylFest.V601 = Modbus.ReadModbus(ADDR_STN6_SEN1, 1)(0)
            GetCylFest.V602 = Modbus.ReadModbus(ADDR_STN6_SEN2, 1)(0)
            GetCylFest.V603 = Modbus.ReadModbus(ADDR_STN6_SEN3, 1)(0)

            ''Festo Indicator Read
            'GetCylFest.LALM = Modbus.ReadBit(ADDR_STN3_IND_LFESTO, 0)
            'GetCylFest.LPEND = Modbus.ReadBit(ADDR_STN3_IND_LFESTO, 1)
            'GetCylFest.LHEND = Modbus.ReadBit(ADDR_STN3_IND_LFESTO, 2)
            'GetCylFest.LSVON = Modbus.ReadBit(ADDR_STN3_IND_LFESTO, 3)
            'GetCylFest.LEMG = Modbus.ReadBit(ADDR_STN3_IND_LFESTO, 4)
            'GetCylFest.RALM = Modbus.ReadBit(ADDR_STN3_IND_RFESTO, 0)
            'GetCylFest.RPEND = Modbus.ReadBit(ADDR_STN3_IND_RFESTO, 1)
            'GetCylFest.RHEND = Modbus.ReadBit(ADDR_STN3_IND_RFESTO, 2)
            'GetCylFest.RSVON = Modbus.ReadBit(ADDR_STN3_IND_RFESTO, 3)
            'GetCylFest.REMG = Modbus.ReadBit(ADDR_STN3_IND_RFESTO, 4)

            ''Festo TextBox Read
            'GetCylFest.LPOSITION = Modbus.ReadDoubleAddrees(ADDR_STN3_PSTN_LFESTO)
            'GetCylFest.LSPEED = Modbus.ReadModbus(ADDR_STN3_SPD_LFESTO, 1)(0)
            'GetCylFest.LALARM = Modbus.ReadModbus(ADDR_STN3_ALM_LFESTO, 1)(0)
            'GetCylFest.RPOSITION = Modbus.ReadDoubleAddrees(ADDR_STN3_PSTN_RFESTO)
            'GetCylFest.RSPEED = Modbus.ReadModbus(ADDR_STN3_SPD_RFESTO, 1)(0)
            'GetCylFest.RALARM = Modbus.ReadModbus(ADDR_STN3_ALM_RFESTO, 1)(0)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub plcWriting()

        'Write Rotary table
        Modbus.WriteBit(ADDR_ROTARY_TABLE, 0, SetRotate.V101)


        'Write Cylinder

        'Bit0
        Modbus.WriteBit(ADDR_STN1_CYL1, 0, SetCyl0.V101)
        Modbus.WriteBit(ADDR_STN3_CYL1, 0, SetCyl0.V301)
        Modbus.WriteBit(ADDR_STN3_CYL2, 0, SetCyl0.V302)
        Modbus.WriteBit(ADDR_STN3_CYL3, 0, SetCyl0.V303)
        Modbus.WriteBit(ADDR_STN3_CYL4, 0, SetCyl0.V304)
        Modbus.WriteBit(ADDR_STN4_CYL1, 0, SetCyl0.V401)
        Modbus.WriteBit(ADDR_STN5_CYL1, 0, SetCyl0.V501)
        Modbus.WriteBit(ADDR_STN5_CYL2, 0, SetCyl0.V502)
        Modbus.WriteBit(ADDR_STN5_CYL3, 0, SetCyl0.V503)
        Modbus.WriteBit(ADDR_STN6_CYL1, 0, SetCyl0.V601)
        Modbus.WriteBit(ADDR_STN6_CYL2, 0, SetCyl0.V602)
        Modbus.WriteBit(ADDR_STN6_CYL3, 0, SetCyl0.V603)

        'Bit1
        Modbus.WriteBit(ADDR_STN1_CYL1, 1, SetCyl1.V101)
        Modbus.WriteBit(ADDR_STN3_CYL1, 1, SetCyl1.V301)
        Modbus.WriteBit(ADDR_STN3_CYL2, 1, SetCyl1.V302)
        Modbus.WriteBit(ADDR_STN3_CYL3, 1, SetCyl1.V303)
        Modbus.WriteBit(ADDR_STN3_CYL4, 1, SetCyl1.V304)
        Modbus.WriteBit(ADDR_STN4_CYL1, 1, SetCyl1.V401)
        Modbus.WriteBit(ADDR_STN5_CYL1, 1, SetCyl1.V501)
        Modbus.WriteBit(ADDR_STN5_CYL2, 1, SetCyl1.V502)
        Modbus.WriteBit(ADDR_STN5_CYL3, 1, SetCyl1.V503)
        Modbus.WriteBit(ADDR_STN6_CYL1, 1, SetCyl1.V601)
        Modbus.WriteBit(ADDR_STN6_CYL2, 1, SetCyl1.V602)
        Modbus.WriteBit(ADDR_STN6_CYL3, 1, SetCyl1.V603)


        ''Write Festo
        'Modbus.WriteBit(370, 0, SetCylFest.LALMRES)
        'Modbus.WriteBit(370, 1, SetCylFest.LSERVO)
        'Modbus.WriteBit(370, 2, SetCylFest.LJOGMIN)
        'Modbus.WriteBit(370, 3, SetCylFest.LJOGPLUS)
        'Modbus.WriteBit(370, 4, SetCylFest.LHOMING)
        'Modbus.WriteBit(370, 5, SetCylFest.LJISL)
        'Modbus.WriteBit(370, 6, SetCylFest.LPWRRES)
        'Modbus.WriteBit(380, 0, SetCylFest.RALMRES)
        'Modbus.WriteBit(380, 1, SetCylFest.RSERVO)
        'Modbus.WriteBit(380, 2, SetCylFest.RJOGMIN)
        'Modbus.WriteBit(380, 3, SetCylFest.RJOGPLUS)
        'Modbus.WriteBit(380, 4, SetCylFest.RHOMING)
        'Modbus.WriteBit(380, 5, SetCylFest.RJISL)
        'Modbus.WriteBit(380, 6, SetCylFest.RPWRRES)
    End Sub

    Private Sub btn_sendref_Click(sender As Object, e As EventArgs) Handles btn_sendref.Click
        Dim char_data As Char
        Dim string_data As String
        Dim current_len As Integer
        string_data = txt_sendref.Text
        current_len = string_data.Length
        '' fix string to 20 char
        For i As Integer = current_len To 19
            string_data = string_data & " "
        Next

        If Connected() Then
            '' send 20 char string
            For index As Integer = 0 To 19
                char_data = string_data.Chars(index)
                ''Debug.Write(index & " ")
                ''Debug.WriteLine(char_data & " ")
                WriteModbus(7100 + index, Convert.ToInt32(char_data))
            Next

        End If
    End Sub
End Class
