Imports System.Threading
Imports System.IO
Public Class MainForm
    Dim ThreadLoadingBar As Thread
    Dim plcReadThread As Thread
    'Dim Statusbar As Thread
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hide()
        initLoadingBar()
        AutoConnection()
        'Statusbar = New Thread(New ThreadStart(AddressOf manualauto))
        'Statusbar.Start()
        plcReadThread = New Thread(New ThreadStart(AddressOf plcReading))
        plcReadThread.Start()

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
            LoadingForm.ShowDialog()
            Thread.Sleep(100)
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
        plcReadThread.Abort()
        ManualForm.ShowDialog()
        plcReadThread = New Thread(AddressOf plcReading)
        plcReadThread.Start()
    End Sub

    Private Sub btn_references_Click(sender As Object, e As EventArgs) Handles btn_references.Click
        Hide()
        ReferencesForm.ShowDialog()
    End Sub

    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click
        Hide()
        plcReadThread.Abort()
        SettingForm.ShowDialog()
        plcReadThread = New Thread(AddressOf plcReading)
        plcReadThread.Start()
    End Sub

    Private Sub plcReading()
        Do
            Console.WriteLine("Modbus MainForm")
            If Connected() Then
                'RunningMode Status
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
                Try
                    PLC_READY = Modbus.ReadModbus(ADDR_PLC_READY, 1)(0)
                    If PLC_READY = 1 Then
                        ind_plc_status.BackColor = Color.Lime
                    Else
                        ind_plc_status.BackColor = Color.Red
                    End If

                Catch ex As Exception

                End Try
            End If

            Thread.Sleep(100)
        Loop
    End Sub


End Class
