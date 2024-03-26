Imports System.Threading
Imports System.IO
Public Class ManualForm
    Dim plcReadThread As Thread
    Dim plcWriteThread As Thread
    Dim MainLoopThread As Thread

    Private Sub DateTime_Tick(sender As Object, e As EventArgs) Handles DateTime.Tick
        lbl_date.Text = Date.Now.ToString("dd-MM-yyyy")
        lbl_curr_time.Text = Date.Now.ToString("hh:mm:ss")
    End Sub
    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        'plcReadThread.Abort()
        'plcWriteThread.Abort()
        MainLoopThread.Abort()
        Close()
        MainForm.Show()
    End Sub
    Private Sub GetUserLevel()
        If UserLevel = 1 Then
            lbl_user.Text = "ADM"
        ElseIf UserLevel = 2 Then
            lbl_user.Text = "ENG"
        ElseIf UserLevel = 3 Then
            lbl_user.Text = "OPE"
        ElseIf UserLevel = 4 Then
            lbl_user.Text = "QUA"
        End If
    End Sub
    Private Sub ManualForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetUserLevel()
        '  AutoConnection()
        'plcReadThread = New Thread(AddressOf plcReading)
        'plcReadThread.Start()
        'plcWriteThread = New Thread(AddressOf plcWriting)
        'plcWriteThread.Start()
        MainLoopThread = New Thread(AddressOf MainLoop)
        MainLoopThread.Start()


        'Button Station Enable
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Name.StartsWith("btn_st") Then
                ctrl.Enabled = True
            End If
        Next
    End Sub

    'Thread Abort
    'Private Sub ManualForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    If plcReadThread IsNot Nothing AndAlso plcReadThread.IsAlive Then
    '        plcReadThread.Abort()
    '    End If
    'End Sub

    'Show Station in Manual Form

    Private Sub ShowStation(st As String)


        If st = "ST1" Then
            gb_st1_man.Visible = True

        Else
            gb_st1_man.Visible = False
        End If

        If st = "ST2" Then
            gb_st2_man.Visible = True

        Else
            gb_st2_man.Visible = False
        End If

        If st = "ST3" Then
            tab_st3_man.Visible = True
        Else
            tab_st3_man.Visible = False
        End If


        If st = "ST4" Then
            gb_st4_man.Visible = True

        Else
            gb_st4_man.Visible = False
        End If

        If st = "ST5" Then
            gb_st5_man.Visible = True

        Else
            gb_st5_man.Visible = False
        End If

        If st = "ST6" Then
            gb_st6_man.Visible = True

        Else
            gb_st6_man.Visible = False
        End If
    End Sub

    Private Sub btn_st1_Click(sender As Object, e As EventArgs) Handles btn_st1.Click
        ShowStation("ST1")
    End Sub
    Private Sub btn_st2_Click(sender As Object, e As EventArgs) Handles btn_st2.Click
        ShowStation("ST2")
    End Sub

    Private Sub btn_st3_Click(sender As Object, e As EventArgs) Handles btn_st3.Click
        ShowStation("ST3")
    End Sub

    Private Sub btn_st4_Click(sender As Object, e As EventArgs) Handles btn_st4.Click
        ShowStation("ST4")
    End Sub

    Private Sub btn_st5_Click(sender As Object, e As EventArgs) Handles btn_st5.Click
        ShowStation("ST5")
    End Sub

    Private Sub btn_st6_Click(sender As Object, e As EventArgs) Handles btn_st6.Click
        ShowStation("ST6")
    End Sub



    'New PLC Read

    Private Sub MainLoop()
        Do
            Console.WriteLine("Manual Form Thread=MainLoop")

            'Auto Manual Status
            Select Case GetAutoMan.RUNNING_MODE
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


            ''Text Box Festo read ----------------------------------------------
            'Me.Invoke(Sub()

            '              tbx_Lfesto_position.Text = GetCylFest.LPOSITION
            '              tbx_Lfesto_speed.Text = GetCylFest.LSPEED
            '              tbx_Lfesto_alarm.Text = GetCylFest.LALARM

            '              tbx_Rfesto_position.Text = GetCylFest.RPOSITION
            '              tbx_Rfesto_speed.Text = GetCylFest.RSPEED
            '              tbx_Rfesto_alarm.Text = GetCylFest.RALARM
            '          End Sub)

            'Station 1 - ---------------------------------------------
            'CylSen 1
            If GetCylFest.V101 = FORWARD Then
                man_stn1_cyl1_max.Image = My.Resources.led_green_on
            Else
                man_stn1_cyl1_max.Image = My.Resources.led_red_on
            End If


            If GetCylFest.V101 = BACKWARD Then
                man_stn1_cyl1_min.Image = My.Resources.led_green_on
            Else
                man_stn1_cyl1_min.Image = My.Resources.led_red_on
            End If

            'Station 3 ----------------------------------------------
            'CylSen 1
            If GetCylFest.V301 = FORWARD Then
                man_stn3_cyl1_max.Image = My.Resources.led_green_on
            Else
                man_stn3_cyl1_max.Image = My.Resources.led_red_on
            End If


            If GetCylFest.V301 = BACKWARD Then
                man_stn3_cyl1_min.Image = My.Resources.led_green_on
            Else
                man_stn3_cyl1_min.Image = My.Resources.led_red_on
            End If

            'CylSen 2
            If GetCylFest.V302 = FORWARD Then
                man_stn3_cyl2_max.Image = My.Resources.led_green_on
            Else
                man_stn3_cyl2_max.Image = My.Resources.led_red_on
            End If


            If GetCylFest.V302 = BACKWARD Then
                man_stn3_cyl2_min.Image = My.Resources.led_green_on
            Else
                man_stn3_cyl2_min.Image = My.Resources.led_red_on
            End If

            'CylSen 3
            If GetCylFest.V303 = FORWARD Then
                man_stn3_cyl3_max.Image = My.Resources.led_green_on
            Else
                man_stn3_cyl3_max.Image = My.Resources.led_red_on
            End If


            If GetCylFest.V303 = BACKWARD Then
                man_stn3_cyl3_min.Image = My.Resources.led_green_on
            Else
                man_stn3_cyl3_min.Image = My.Resources.led_red_on
            End If

            'CylSen 4
            If GetCylFest.V304 = FORWARD Then
                man_stn3_cyl4_max.Image = My.Resources.led_green_on
            Else
                man_stn3_cyl4_max.Image = My.Resources.led_red_on
            End If


            If GetCylFest.V304 = BACKWARD Then
                man_stn3_cyl4_min.Image = My.Resources.led_green_on
            Else
                man_stn3_cyl4_min.Image = My.Resources.led_red_on
            End If

            ''Festo Left
            'If GetCylFest.LALM = 1 Then
            '    ind_stn3_Lfesto_alm.Image = My.Resources.led_green_on
            'Else
            '    ind_stn3_Lfesto_alm.Image = My.Resources.led_red_on
            'End If

            'If GetCylFest.LPEND = 1 Then
            '    ind_stn3_Lfesto_pend.Image = My.Resources.led_green_on
            'Else
            '    ind_stn3_Lfesto_pend.Image = My.Resources.led_red_on
            'End If

            'If GetCylFest.LHEND = 1 Then
            '    ind_stn3_Lfesto_hend.Image = My.Resources.led_green_on
            'Else
            '    ind_stn3_Lfesto_hend.Image = My.Resources.led_red_on
            'End If

            'If GetCylFest.LSVON = 1 Then
            '    ind_stn3_Lfesto_svon.Image = My.Resources.led_green_on
            'Else
            '    ind_stn3_Lfesto_svon.Image = My.Resources.led_red_on
            'End If

            'If GetCylFest.LEMG = 1 Then
            '    ind_stn3_Lfesto_emg.Image = My.Resources.led_green_on
            'Else
            '    ind_stn3_Lfesto_emg.Image = My.Resources.led_red_on
            'End If

            ''Festo Right
            'If GetCylFest.RALM = 1 Then
            '    ind_stn3_Rfesto_alm.Image = My.Resources.led_green_on
            'Else
            '    ind_stn3_Rfesto_alm.Image = My.Resources.led_red_on
            'End If

            'If GetCylFest.RPEND = 1 Then
            '    ind_stn3_Rfesto_pend.Image = My.Resources.led_green_on
            'Else
            '    ind_stn3_Rfesto_pend.Image = My.Resources.led_red_on
            'End If

            'If GetCylFest.RHEND = 1 Then
            '    ind_stn3_Rfesto_hend.Image = My.Resources.led_green_on
            'Else
            '    ind_stn3_Rfesto_hend.Image = My.Resources.led_red_on
            'End If

            'If GetCylFest.RSVON = 1 Then
            '    ind_stn3_Rfesto_svon.Image = My.Resources.led_green_on
            'Else
            '    ind_stn3_Rfesto_svon.Image = My.Resources.led_red_on
            'End If

            'If GetCylFest.REMG = 1 Then
            '    ind_stn3_Rfesto_emg.Image = My.Resources.led_green_on
            'Else
            '    ind_stn3_Rfesto_emg.Image = My.Resources.led_red_on
            'End If



            'Station 4 ----------------------------------------------
            'CylSen 1
            If GetCylFest.V401 = FORWARD Then
                man_stn4_cyl1_max.Image = My.Resources.led_green_on
            Else
                man_stn4_cyl1_max.Image = My.Resources.led_red_on
            End If


            If GetCylFest.V401 = BACKWARD Then
                man_stn4_cyl1_min.Image = My.Resources.led_green_on
            Else
                man_stn4_cyl1_min.Image = My.Resources.led_red_on
            End If


            'Station 5 ----------------------------------------------
            'CylSen 1
            If GetCylFest.V501 = FORWARD Then
                man_stn5_cyl1_max.Image = My.Resources.led_green_on
            Else
                man_stn5_cyl1_max.Image = My.Resources.led_red_on
            End If


            If GetCylFest.V501 = BACKWARD Then
                man_stn5_cyl1_min.Image = My.Resources.led_green_on
            Else
                man_stn5_cyl1_min.Image = My.Resources.led_red_on
            End If

            'CylSen 2
            If GetCylFest.V502 = FORWARD Then
                man_stn5_cyl2_max.Image = My.Resources.led_green_on
            Else
                man_stn5_cyl2_max.Image = My.Resources.led_red_on
            End If


            If GetCylFest.V502 = BACKWARD Then
                man_stn5_cyl2_min.Image = My.Resources.led_green_on
            Else
                man_stn5_cyl2_min.Image = My.Resources.led_red_on
            End If

            'CylSen 3
            If GetCylFest.V503 = FORWARD Then
                man_stn5_cyl3_max.Image = My.Resources.led_green_on
            Else
                man_stn5_cyl3_max.Image = My.Resources.led_red_on
            End If


            If GetCylFest.V503 = BACKWARD Then
                man_stn5_cyl3_min.Image = My.Resources.led_green_on
            Else
                man_stn5_cyl3_min.Image = My.Resources.led_red_on
            End If


            'Station 6 ----------------------------------------------
            'CylSen 1
            If GetCylFest.V601 = FORWARD Then
                man_stn6_cyl1_max.Image = My.Resources.led_green_on
            Else
                man_stn6_cyl1_max.Image = My.Resources.led_red_on
            End If


            If GetCylFest.V601 = BACKWARD Then
                man_stn6_cyl1_min.Image = My.Resources.led_green_on
            Else
                man_stn6_cyl1_min.Image = My.Resources.led_red_on
            End If

            'CylSen 2
            If GetCylFest.V602 = FORWARD Then
                man_stn6_cyl2_max.Image = My.Resources.led_green_on
            Else
                man_stn6_cyl2_max.Image = My.Resources.led_red_on
            End If


            If GetCylFest.V602 = BACKWARD Then
                man_stn6_cyl2_min.Image = My.Resources.led_green_on
            Else
                man_stn6_cyl2_min.Image = My.Resources.led_red_on
            End If

            'CylSen 3
            If GetCylFest.V603 = FORWARD Then
                man_stn6_cyl3_max.Image = My.Resources.led_green_on
            Else
                man_stn6_cyl3_max.Image = My.Resources.led_red_on
            End If


            If GetCylFest.V603 = BACKWARD Then
                man_stn6_cyl3_min.Image = My.Resources.led_green_on
            Else
                man_stn6_cyl3_min.Image = My.Resources.led_red_on
            End If

            Thread.Sleep(150)
        Loop
    End Sub


    'ReadPLC

    'Private Sub plcReading()
    '    Do
    '        Console.WriteLine("Modbus ManualForm ReadPLC")
    '        If Connected() Then

    '            Dim readS11 = ReadModbus(ADDR_STN1_SEN1, 1)

    '            Dim readS31 = ReadModbus(ADDR_STN3_SEN1, 1)
    '            Dim readS32 = ReadModbus(ADDR_STN3_SEN2, 1)
    '            Dim readS33 = ReadModbus(ADDR_STN3_SEN3, 1)
    '            Dim readS34 = ReadModbus(ADDR_STN3_SEN4, 1)

    '            Dim readS41 = ReadModbus(ADDR_STN4_SEN1, 1)

    '            Dim readS51 = ReadModbus(ADDR_STN5_SEN1, 1)
    '            Dim readS52 = ReadModbus(ADDR_STN5_SEN2, 1)
    '            Dim readS53 = ReadModbus(ADDR_STN5_SEN3, 1)    'STN5

    '            Dim readS61 = ReadModbus(ADDR_STN6_SEN1, 1)
    '            Dim readS62 = ReadModbus(ADDR_STN6_SEN2, 1)
    '            Dim readS63 = ReadModbus(ADDR_STN6_SEN3, 1)    'STN6

    '            Dim readLALM As Integer = ReadBit(ADDR_STN3_IND_LFESTO, 0)
    '            Dim readLPEND As Integer = ReadBit(ADDR_STN3_IND_LFESTO, 1)
    '            Dim readLHEND As Integer = ReadBit(ADDR_STN3_IND_LFESTO, 2)   'Indicator LFesto
    '            Dim readLSVON As Integer = ReadBit(ADDR_STN3_IND_LFESTO, 3)
    '            Dim readLEMG As Integer = ReadBit(ADDR_STN3_IND_LFESTO, 4)

    '            Dim readRALM As Integer = ReadBit(ADDR_STN3_IND_RFESTO, 0)
    '            Dim readRPEND As Integer = ReadBit(ADDR_STN3_IND_RFESTO, 1)
    '            Dim readRHEND As Integer = ReadBit(ADDR_STN3_IND_RFESTO, 2)   'Indicator RFesto
    '            Dim readRSVON As Integer = ReadBit(ADDR_STN3_IND_RFESTO, 3)
    '            Dim readREMG As Integer = ReadBit(ADDR_STN3_IND_RFESTO, 4)

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


    '            'Text Box Festo read ----------------------------------------------
    '            Me.Invoke(Sub()

    '                          tbx_Lfesto_position.Text = ReadDoubleAddrees(ADDR_STN3_PSTN_LFESTO)
    '                          tbx_Lfesto_speed.Text = ReadModbus(ADDR_STN3_SPD_LFESTO, 1)(0)
    '                          tbx_Lfesto_alarm.Text = ReadModbus(ADDR_STN3_ALM_LFESTO, 1)(0)

    '                          tbx_Rfesto_position.Text = ReadDoubleAddrees(ADDR_STN3_PSTN_RFESTO)
    '                          tbx_Rfesto_speed.Text = ReadModbus(ADDR_STN3_SPD_RFESTO, 1)(0)
    '                          tbx_Rfesto_alarm.Text = ReadModbus(ADDR_STN3_ALM_RFESTO, 1)(0)
    '                      End Sub)



    '            'Station 1 - ---------------------------------------------
    '            'CylSen 1
    '            If readS11.Length > 0 AndAlso readS11(0) = FORWARD Then
    '                man_stn1_cyl1_max.Image = My.Resources.led_green_on
    '            Else
    '                man_stn1_cyl1_max.Image = My.Resources.led_red_on
    '            End If


    '            If readS11.Length > 0 AndAlso readS11(0) = BACKWARD Then
    '                man_stn1_cyl1_min.Image = My.Resources.led_green_on
    '            Else
    '                man_stn1_cyl1_min.Image = My.Resources.led_red_on
    '            End If


    '            'Station 3 ----------------------------------------------
    '            'CylSen 1
    '            If readS31.Length > 0 AndAlso readS31(0) = FORWARD Then
    '                man_stn3_cyl1_max.Image = My.Resources.led_green_on
    '            Else
    '                man_stn3_cyl1_max.Image = My.Resources.led_red_on
    '            End If


    '            If readS31.Length > 0 AndAlso readS31(0) = BACKWARD Then
    '                man_stn3_cyl1_min.Image = My.Resources.led_green_on
    '            Else
    '                man_stn3_cyl1_min.Image = My.Resources.led_red_on
    '            End If

    '            'CylSen 2
    '            If readS32.Length > 0 AndAlso readS32(0) = FORWARD Then
    '                man_stn3_cyl2_max.Image = My.Resources.led_green_on
    '            Else
    '                man_stn3_cyl2_max.Image = My.Resources.led_red_on
    '            End If


    '            If readS32.Length > 0 AndAlso readS32(0) = BACKWARD Then
    '                man_stn3_cyl2_min.Image = My.Resources.led_green_on
    '            Else
    '                man_stn3_cyl2_min.Image = My.Resources.led_red_on
    '            End If

    '            'CylSen 3
    '            If readS33.Length > 0 AndAlso readS33(0) = FORWARD Then
    '                man_stn3_cyl3_max.Image = My.Resources.led_green_on
    '            Else
    '                man_stn3_cyl3_max.Image = My.Resources.led_red_on
    '            End If


    '            If readS33.Length > 0 AndAlso readS33(0) = BACKWARD Then
    '                man_stn3_cyl3_min.Image = My.Resources.led_green_on
    '            Else
    '                man_stn3_cyl3_min.Image = My.Resources.led_red_on
    '            End If

    '            'CylSen 4
    '            If readS34.Length > 0 AndAlso readS34(0) = FORWARD Then
    '                man_stn3_cyl4_max.Image = My.Resources.led_green_on
    '            Else
    '                man_stn3_cyl4_max.Image = My.Resources.led_red_on
    '            End If


    '            If readS34.Length > 0 AndAlso readS34(0) = BACKWARD Then
    '                man_stn3_cyl4_min.Image = My.Resources.led_green_on
    '            Else
    '                man_stn3_cyl4_min.Image = My.Resources.led_red_on
    '            End If

    '            'Festo Left
    '            If readLALM = 1 Then
    '                ind_stn3_Lfesto_alm.Image = My.Resources.led_green_on
    '            Else
    '                ind_stn3_Lfesto_alm.Image = My.Resources.led_red_on
    '            End If

    '            If readLPEND = 1 Then
    '                ind_stn3_Lfesto_pend.Image = My.Resources.led_green_on
    '            Else
    '                ind_stn3_Lfesto_pend.Image = My.Resources.led_red_on
    '            End If

    '            If readLHEND = 1 Then
    '                ind_stn3_Lfesto_hend.Image = My.Resources.led_green_on
    '            Else
    '                ind_stn3_Lfesto_hend.Image = My.Resources.led_red_on
    '            End If

    '            If readLSVON = 1 Then
    '                ind_stn3_Lfesto_svon.Image = My.Resources.led_green_on
    '            Else
    '                ind_stn3_Lfesto_svon.Image = My.Resources.led_red_on
    '            End If

    '            If readLEMG = 1 Then
    '                ind_stn3_Lfesto_emg.Image = My.Resources.led_green_on
    '            Else
    '                ind_stn3_Lfesto_emg.Image = My.Resources.led_red_on
    '            End If

    '            'Festo Right
    '            If readRALM = 1 Then
    '                ind_stn3_Rfesto_alm.Image = My.Resources.led_green_on
    '            Else
    '                ind_stn3_Rfesto_alm.Image = My.Resources.led_red_on
    '            End If

    '            If readRPEND = 1 Then
    '                ind_stn3_Rfesto_pend.Image = My.Resources.led_green_on
    '            Else
    '                ind_stn3_Rfesto_pend.Image = My.Resources.led_red_on
    '            End If

    '            If readRHEND = 1 Then
    '                ind_stn3_Rfesto_hend.Image = My.Resources.led_green_on
    '            Else
    '                ind_stn3_Rfesto_hend.Image = My.Resources.led_red_on
    '            End If

    '            If readRSVON = 1 Then
    '                ind_stn3_Rfesto_svon.Image = My.Resources.led_green_on
    '            Else
    '                ind_stn3_Rfesto_svon.Image = My.Resources.led_red_on
    '            End If

    '            If readREMG = 1 Then
    '                ind_stn3_Rfesto_emg.Image = My.Resources.led_green_on
    '            Else
    '                ind_stn3_Rfesto_emg.Image = My.Resources.led_red_on
    '            End If



    '            'Station 4 ----------------------------------------------
    '            'CylSen 1
    '            If readS41.Length > 0 AndAlso readS41(0) = FORWARD Then
    '                man_stn4_cyl1_max.Image = My.Resources.led_green_on
    '            Else
    '                man_stn4_cyl1_max.Image = My.Resources.led_red_on
    '            End If


    '            If readS41.Length > 0 AndAlso readS41(0) = BACKWARD Then
    '                man_stn4_cyl1_min.Image = My.Resources.led_green_on
    '            Else
    '                man_stn4_cyl1_min.Image = My.Resources.led_red_on
    '            End If


    '            'Station 5 ----------------------------------------------
    '            'CylSen 1
    '            If readS51.Length > 0 AndAlso readS51(0) = FORWARD Then
    '                man_stn5_cyl1_max.Image = My.Resources.led_green_on

    '            Else
    '                man_stn5_cyl1_max.Image = My.Resources.led_red_on
    '            End If


    '            If readS51.Length > 0 AndAlso readS51(0) = BACKWARD Then
    '                man_stn5_cyl1_min.Image = My.Resources.led_green_on
    '            Else
    '                man_stn5_cyl1_min.Image = My.Resources.led_red_on
    '            End If

    '            'CylSen 2
    '            If readS52.Length > 0 AndAlso readS52(0) = FORWARD Then
    '                man_stn5_cyl2_max.Image = My.Resources.led_green_on
    '            Else
    '                man_stn5_cyl2_max.Image = My.Resources.led_red_on
    '            End If


    '            If readS52.Length > 0 AndAlso readS52(0) = BACKWARD Then
    '                man_stn5_cyl2_min.Image = My.Resources.led_green_on
    '            Else
    '                man_stn5_cyl2_min.Image = My.Resources.led_red_on
    '            End If

    '            'CylSen 3
    '            If readS53.Length > 0 AndAlso readS53(0) = FORWARD Then
    '                man_stn5_cyl3_max.Image = My.Resources.led_green_on
    '            Else
    '                man_stn5_cyl3_max.Image = My.Resources.led_red_on
    '            End If


    '            If readS53.Length > 0 AndAlso readS53(0) = BACKWARD Then
    '                man_stn5_cyl3_min.Image = My.Resources.led_green_on
    '            Else
    '                man_stn5_cyl3_min.Image = My.Resources.led_red_on
    '            End If


    '            'Station 6 ----------------------------------------------
    '            'CylSen 1
    '            If readS61.Length > 0 AndAlso readS61(0) = FORWARD Then
    '                man_stn6_cyl1_max.Image = My.Resources.led_green_on
    '            Else
    '                man_stn6_cyl1_max.Image = My.Resources.led_red_on
    '            End If


    '            If readS61.Length > 0 AndAlso readS61(0) = BACKWARD Then
    '                man_stn6_cyl1_min.Image = My.Resources.led_green_on
    '            Else
    '                man_stn6_cyl1_min.Image = My.Resources.led_red_on
    '            End If

    '            'CylSen 2
    '            If readS62.Length > 0 AndAlso readS62(0) = FORWARD Then
    '                man_stn6_cyl2_max.Image = My.Resources.led_green_on
    '            Else
    '                man_stn6_cyl2_max.Image = My.Resources.led_red_on
    '            End If


    '            If readS62.Length > 0 AndAlso readS62(0) = BACKWARD Then
    '                man_stn6_cyl2_min.Image = My.Resources.led_green_on
    '            Else
    '                man_stn6_cyl2_min.Image = My.Resources.led_red_on
    '            End If

    '            'CylSen 3
    '            If readS63.Length > 0 AndAlso readS63(0) = FORWARD Then
    '                man_stn6_cyl3_max.Image = My.Resources.led_green_on
    '            Else
    '                man_stn6_cyl3_max.Image = My.Resources.led_red_on
    '            End If


    '            If readS63.Length > 0 AndAlso readS63(0) = BACKWARD Then
    '                man_stn6_cyl3_min.Image = My.Resources.led_green_on
    '            Else
    '                man_stn6_cyl3_min.Image = My.Resources.led_red_on
    '            End If

    '        End If
    '        Thread.Sleep(100)
    '    Loop
    'End Sub

    'Private Sub ModbusWriter(output As Integer, address As Integer)
    '    If output = FORWARD Then
    '        Modbus.WriteModbus(address, FORWARD)
    '    ElseIf output = BACKWARD Then
    '        Modbus.WriteModbus(address, BACKWARD)
    '    Else
    '        Modbus.WriteModbus(address, IDLE)
    '    End If
    'End Sub

    'Private Sub plcWriting()
    '    Do
    '        Console.WriteLine("Modbus ManualForm WritePLC")
    '        If Connected() Then
    '            'Station 1

    '            If STN1_CYL1 <> LAST_STN1_CYL1 Then
    '                ModbusWriter(STN1_CYL1, ADDR_STN1_CYL1)
    '                LAST_STN1_CYL1 = STN1_CYL1
    '            End If


    '            'Station 3  

    '            If STN3_CYL1 <> LAST_STN3_CYL1 Then
    '                ModbusWriter(STN3_CYL1, ADDR_STN3_CYL1)
    '                LAST_STN3_CYL1 = STN3_CYL1
    '            End If

    '            If STN3_CYL2 <> LAST_STN3_CYL2 Then
    '                ModbusWriter(STN3_CYL2, ADDR_STN3_CYL2)
    '                LAST_STN3_CYL2 = STN3_CYL2
    '            End If

    '            If STN3_CYL3 <> LAST_STN3_CYL3 Then
    '                ModbusWriter(STN3_CYL3, ADDR_STN3_CYL3)
    '                LAST_STN3_CYL3 = STN3_CYL3
    '            End If

    '            If STN3_CYL4 <> LAST_STN3_CYL4 Then
    '                ModbusWriter(STN3_CYL4, ADDR_STN3_CYL4)
    '                LAST_STN3_CYL4 = STN3_CYL4
    '            End If

    '            'Station 4

    '            If STN4_CYL1 <> LAST_STN4_CYL1 Then
    '                ModbusWriter(STN4_CYL1, ADDR_STN4_CYL1)
    '                LAST_STN4_CYL1 = STN4_CYL1
    '            End If

    '            'Station 5

    '            If STN5_CYL1 <> LAST_STN5_CYL1 Then
    '                ModbusWriter(STN5_CYL1, ADDR_STN5_CYL1)
    '                LAST_STN5_CYL1 = STN5_CYL1
    '            End If

    '            If STN5_CYL2 <> LAST_STN5_CYL2 Then
    '                ModbusWriter(STN5_CYL2, ADDR_STN5_CYL2)
    '                LAST_STN5_CYL2 = STN5_CYL2
    '            End If

    '            If STN5_CYL3 <> LAST_STN5_CYL3 Then
    '                ModbusWriter(STN5_CYL3, ADDR_STN5_CYL3)
    '                LAST_STN5_CYL3 = STN5_CYL3
    '            End If

    '            'Station 6

    '            If STN6_CYL1 <> LAST_STN6_CYL1 Then
    '                ModbusWriter(STN6_CYL1, ADDR_STN6_CYL1)
    '                LAST_STN6_CYL1 = STN6_CYL1
    '            End If

    '            If STN6_CYL2 <> LAST_STN6_CYL2 Then
    '                ModbusWriter(STN6_CYL2, ADDR_STN6_CYL2)
    '                LAST_STN6_CYL2 = STN6_CYL2
    '            End If

    '            If STN6_CYL3 <> LAST_STN6_CYL3 Then
    '                ModbusWriter(STN6_CYL3, ADDR_STN6_CYL3)
    '                LAST_STN6_CYL3 = STN6_CYL3
    '            End If

    '        End If
    '        Thread.Sleep(100)
    '    Loop
    'End Sub


    'Button Manual Click Function

    'Rotary Table Button
    Private Sub btn_rotate_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_rotate.MouseDown
        If btn_rotate.Text = "Rotate" Then
            SetRotate.V101 = 1
            btn_rotate.Tag = btn_rotate.BackColor
            btn_rotate.BackColor = Color.Lavender
            btn_rotate.Text = "Rotating"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_rotate_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_rotate.MouseUp
        If btn_rotate.Text = "Rotating" Then
            SetRotate.V101 = 0
            btn_rotate.BackColor = DirectCast(btn_rotate.Tag, Color)
            btn_rotate.Text = "Rotate"
        End If
        plcTrigger = True
    End Sub

    'Cylinder Button
    Private Sub btn_stn1_cyl1_fw_Click(sender As Object, e As EventArgs) Handles btn_stn1_cyl1_fw.Click
        If btn_stn1_cyl1_bw.Text = "Is Backward" Then
            btn_stn1_cyl1_bw.PerformClick()
        End If

        If btn_stn1_cyl1_fw.Text = "Forward" Then
            SetCyl0.V101 = 1
            SetCyl1.V101 = 0
            btn_stn1_cyl1_fw.Image = My.Resources.button_white
            btn_stn1_cyl1_fw.Text = "Is Forward"
        ElseIf btn_stn1_cyl1_fw.Text = "Is Forward" Then
            SetCyl0.V101 = 0
            SetCyl1.V101 = 0
            btn_stn1_cyl1_fw.Image = My.Resources.button_silver
            btn_stn1_cyl1_fw.Text = "Forward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn1_cyl1_bw_Click(sender As Object, e As EventArgs) Handles btn_stn1_cyl1_bw.Click
        If btn_stn1_cyl1_fw.Text = "Is Forward" Then
            btn_stn1_cyl1_fw.PerformClick()
        End If

        If btn_stn1_cyl1_bw.Text = "Backward" Then
            SetCyl0.V101 = 0
            SetCyl1.V101 = 1
            btn_stn1_cyl1_bw.Image = My.Resources.button_white
            btn_stn1_cyl1_bw.Text = "Is Backward"
        ElseIf btn_stn1_cyl1_bw.Text = "Is Backward" Then
            SetCyl0.V101 = 0
            SetCyl1.V101 = 0
            btn_stn1_cyl1_bw.Image = My.Resources.button_silver
            btn_stn1_cyl1_bw.Text = "Backward"
        End If
        plcTrigger = True
    End Sub

    'Button Manual Station 3

    Private Sub btn_stn3_cyl1_fw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl1_fw.Click
        If btn_stn3_cyl1_bw.Text = "Is Backward" Then
            btn_stn3_cyl1_bw.PerformClick()
        End If

        If btn_stn3_cyl1_fw.Text = "Forward" Then
            SetCyl0.V301 = 1
            SetCyl1.V301 = 0
            btn_stn3_cyl1_fw.Image = My.Resources.button_white
            btn_stn3_cyl1_fw.Text = "Is Forward"
        ElseIf btn_stn3_cyl1_fw.Text = "Is Forward" Then
            SetCyl0.V301 = 0
            SetCyl1.V301 = 0
            btn_stn3_cyl1_fw.Image = My.Resources.button_silver
            btn_stn3_cyl1_fw.Text = "Forward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn3_cyl1_bw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl1_bw.Click
        If btn_stn3_cyl1_fw.Text = "Is Forward" Then
            btn_stn3_cyl1_fw.PerformClick()
        End If

        If btn_stn3_cyl1_bw.Text = "Backward" Then
            SetCyl0.V301 = 0
            SetCyl1.V301 = 1
            btn_stn3_cyl1_bw.Image = My.Resources.button_white
            btn_stn3_cyl1_bw.Text = "Is Backward"
        ElseIf btn_stn3_cyl1_bw.Text = "Is Backward" Then
            SetCyl0.V301 = 0
            SetCyl1.V301 = 0
            btn_stn3_cyl1_bw.Image = My.Resources.button_silver
            btn_stn3_cyl1_bw.Text = "Backward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn3_cyl2_fw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl2_fw.Click
        If btn_stn3_cyl2_bw.Text = "Is Backward" Then
            btn_stn3_cyl2_bw.PerformClick()
        End If

        If btn_stn3_cyl2_fw.Text = "Forward" Then
            SetCyl0.V302 = 1
            SetCyl1.V302 = 0
            btn_stn3_cyl2_fw.Image = My.Resources.button_white
            btn_stn3_cyl2_fw.Text = "Is Forward"
        ElseIf btn_stn3_cyl2_fw.Text = "Is Forward" Then
            SetCyl0.V302 = 0
            SetCyl1.V302 = 0
            btn_stn3_cyl2_fw.Image = My.Resources.button_silver
            btn_stn3_cyl2_fw.Text = "Forward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn3_cyl2_bw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl2_bw.Click
        If btn_stn3_cyl2_fw.Text = "Is Forward" Then
            btn_stn3_cyl2_fw.PerformClick()
        End If

        If btn_stn3_cyl2_bw.Text = "Backward" Then
            SetCyl0.V302 = 0
            SetCyl1.V302 = 1
            btn_stn3_cyl2_bw.Image = My.Resources.button_white
            btn_stn3_cyl2_bw.Text = "Is Backward"
        ElseIf btn_stn3_cyl2_bw.Text = "Is Backward" Then
            SetCyl0.V302 = 0
            SetCyl1.V302 = 0
            btn_stn3_cyl2_bw.Image = My.Resources.button_silver
            btn_stn3_cyl2_bw.Text = "Backward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn3_cyl3_fw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl3_fw.Click
        If btn_stn3_cyl3_bw.Text = "Is Backward" Then
            btn_stn3_cyl3_bw.PerformClick()
        End If

        If btn_stn3_cyl3_fw.Text = "Forward" Then
            SetCyl0.V303 = 1
            SetCyl1.V303 = 0
            btn_stn3_cyl3_fw.Image = My.Resources.button_white
            btn_stn3_cyl3_fw.Text = "Is Forward"
        ElseIf btn_stn3_cyl3_fw.Text = "Is Forward" Then
            SetCyl0.V303 = 0
            SetCyl1.V303 = 0
            btn_stn3_cyl3_fw.Image = My.Resources.button_silver
            btn_stn3_cyl3_fw.Text = "Forward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn3_cyl3_bw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl3_bw.Click
        If btn_stn3_cyl3_fw.Text = "Is Forward" Then
            btn_stn3_cyl3_fw.PerformClick()
        End If

        If btn_stn3_cyl3_bw.Text = "Backward" Then
            SetCyl0.V303 = 0
            SetCyl1.V303 = 1
            btn_stn3_cyl3_bw.Image = My.Resources.button_white
            btn_stn3_cyl3_bw.Text = "Is Backward"
        ElseIf btn_stn3_cyl3_bw.Text = "Is Backward" Then
            SetCyl0.V303 = 0
            SetCyl1.V303 = 0
            btn_stn3_cyl3_bw.Image = My.Resources.button_silver
            btn_stn3_cyl3_bw.Text = "Backward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn3_cyl4_fw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl4_fw.Click
        If btn_stn3_cyl4_bw.Text = "Is Backward" Then
            btn_stn3_cyl4_bw.PerformClick()
        End If

        If btn_stn3_cyl4_fw.Text = "Forward" Then
            SetCyl0.V304 = 1
            SetCyl1.V304 = 0
            btn_stn3_cyl4_fw.Image = My.Resources.button_white
            btn_stn3_cyl4_fw.Text = "Is Forward"
        ElseIf btn_stn3_cyl4_fw.Text = "Is Forward" Then
            SetCyl0.V304 = 0
            SetCyl1.V304 = 0
            btn_stn3_cyl4_fw.Image = My.Resources.button_silver
            btn_stn3_cyl4_fw.Text = "Forward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn3_cyl4_bw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl4_bw.Click
        If btn_stn3_cyl4_fw.Text = "Is Forward" Then
            btn_stn3_cyl4_fw.PerformClick()
        End If

        If btn_stn3_cyl4_bw.Text = "Backward" Then
            SetCyl0.V304 = 0
            SetCyl1.V304 = 1
            btn_stn3_cyl4_bw.Image = My.Resources.button_white
            btn_stn3_cyl4_bw.Text = "Is Backward"
        ElseIf btn_stn3_cyl4_bw.Text = "Is Backward" Then
            SetCyl0.V304 = 0
            SetCyl1.V304 = 0
            btn_stn3_cyl4_bw.Image = My.Resources.button_silver
            btn_stn3_cyl4_bw.Text = "Backward"
        End If
        plcTrigger = True
    End Sub


    'Button Manual Station 4

    Private Sub btn_stn4_cyl1_fw_Click(sender As Object, e As EventArgs) Handles btn_stn4_cyl1_fw.Click
        If btn_stn4_cyl1_bw.Text = "Is Backward" Then
            btn_stn4_cyl1_bw.PerformClick()
        End If

        If btn_stn4_cyl1_fw.Text = "Forward" Then
            SetCyl0.V401 = 1
            SetCyl1.V401 = 0
            btn_stn4_cyl1_fw.Image = My.Resources.button_white
            btn_stn4_cyl1_fw.Text = "Is Forward"
        ElseIf btn_stn4_cyl1_fw.Text = "Is Forward" Then
            SetCyl0.V401 = 0
            SetCyl1.V401 = 0
            btn_stn4_cyl1_fw.Image = My.Resources.button_silver
            btn_stn4_cyl1_fw.Text = "Forward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn4_cyl1_bw_Click(sender As Object, e As EventArgs) Handles btn_stn4_cyl1_bw.Click
        If btn_stn4_cyl1_fw.Text = "Is Forward" Then
            btn_stn4_cyl1_fw.PerformClick()
        End If

        If btn_stn4_cyl1_bw.Text = "Backward" Then
            SetCyl0.V401 = 0
            SetCyl1.V401 = 1
            btn_stn4_cyl1_bw.Image = My.Resources.button_white
            btn_stn4_cyl1_bw.Text = "Is Backward"
        ElseIf btn_stn4_cyl1_bw.Text = "Is Backward" Then
            SetCyl0.V401 = 0
            SetCyl1.V401 = 0
            btn_stn4_cyl1_bw.Image = My.Resources.button_silver
            btn_stn4_cyl1_bw.Text = "Backward"
        End If
        plcTrigger = True
    End Sub


    'Button Manual Station 5

    Private Sub btn_stn5_cyl1_fw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl1_fw.Click
        If btn_stn5_cyl1_bw.Text = "Is Backward" Then
            btn_stn5_cyl1_bw.PerformClick()
        End If

        If btn_stn5_cyl1_fw.Text = "Forward" Then
            SetCyl0.V501 = 1
            SetCyl1.V501 = 0
            btn_stn5_cyl1_fw.Image = My.Resources.button_white
            btn_stn5_cyl1_fw.Text = "Is Forward"
        ElseIf btn_stn5_cyl1_fw.Text = "Is Forward" Then
            SetCyl0.V501 = 0
            SetCyl1.V501 = 0
            btn_stn5_cyl1_fw.Image = My.Resources.button_silver
            btn_stn5_cyl1_fw.Text = "Forward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn5_cyl1_bw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl1_bw.Click
        If btn_stn5_cyl1_fw.Text = "Is Forward" Then
            btn_stn5_cyl1_fw.PerformClick()
        End If

        If btn_stn5_cyl1_bw.Text = "Backward" Then
            SetCyl0.V501 = 0
            SetCyl1.V501 = 1
            btn_stn5_cyl1_bw.Image = My.Resources.button_white
            btn_stn5_cyl1_bw.Text = "Is Backward"
        ElseIf btn_stn5_cyl1_bw.Text = "Is Backward" Then
            SetCyl0.V501 = 0
            SetCyl1.V501 = 0
            btn_stn5_cyl1_bw.Image = My.Resources.button_silver
            btn_stn5_cyl1_bw.Text = "Backward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn5_cyl2_fw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl2_fw.Click
        If btn_stn5_cyl2_bw.Text = "Is Backward" Then
            btn_stn5_cyl2_bw.PerformClick()
        End If

        If btn_stn5_cyl2_fw.Text = "Forward" Then
            SetCyl0.V502 = 1
            SetCyl1.V502 = 0
            btn_stn5_cyl2_fw.Image = My.Resources.button_white
            btn_stn5_cyl2_fw.Text = "Is Forward"
        ElseIf btn_stn5_cyl2_fw.Text = "Is Forward" Then
            SetCyl0.V502 = 0
            SetCyl1.V502 = 0
            btn_stn5_cyl2_fw.Image = My.Resources.button_silver
            btn_stn5_cyl2_fw.Text = "Forward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn5_cyl2_bw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl2_bw.Click
        If btn_stn5_cyl2_fw.Text = "Is Forward" Then
            btn_stn5_cyl2_fw.PerformClick()
        End If

        If btn_stn5_cyl2_bw.Text = "Backward" Then
            SetCyl0.V502 = 0
            SetCyl1.V502 = 1
            btn_stn5_cyl2_bw.Image = My.Resources.button_white
            btn_stn5_cyl2_bw.Text = "Is Backward"
        ElseIf btn_stn5_cyl2_bw.Text = "Is Backward" Then
            SetCyl0.V502 = 0
            SetCyl1.V502 = 0
            btn_stn5_cyl2_bw.Image = My.Resources.button_silver
            btn_stn5_cyl2_bw.Text = "Backward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn5_cyl3_fw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl3_fw.Click
        If btn_stn5_cyl3_bw.Text = "Is Backward" Then
            btn_stn5_cyl3_bw.PerformClick()
        End If

        If btn_stn5_cyl3_fw.Text = "Forward" Then
            SetCyl0.V503 = 1
            SetCyl1.V503 = 0
            btn_stn5_cyl3_fw.Image = My.Resources.button_white
            btn_stn5_cyl3_fw.Text = "Is Forward"
        ElseIf btn_stn5_cyl3_fw.Text = "Is Forward" Then
            SetCyl0.V503 = 0
            SetCyl1.V503 = 0
            btn_stn5_cyl3_fw.Image = My.Resources.button_silver
            btn_stn5_cyl3_fw.Text = "Forward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn5_cyl3_bw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl3_bw.Click
        If btn_stn5_cyl3_fw.Text = "Is Forward" Then
            btn_stn5_cyl3_fw.PerformClick()
        End If

        If btn_stn5_cyl3_bw.Text = "Backward" Then
            SetCyl0.V503 = 0
            SetCyl1.V503 = 1
            btn_stn5_cyl3_bw.Image = My.Resources.button_white
            btn_stn5_cyl3_bw.Text = "Is Backward"
        ElseIf btn_stn5_cyl3_bw.Text = "Is Backward" Then
            SetCyl0.V503 = 0
            SetCyl1.V503 = 0
            btn_stn5_cyl3_bw.Image = My.Resources.button_silver
            btn_stn5_cyl3_bw.Text = "Backward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn6_cyl1_fw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl1_fw.Click
        If btn_stn6_cyl1_bw.Text = "Is Backward" Then
            btn_stn6_cyl1_bw.PerformClick()
        End If

        If btn_stn6_cyl1_fw.Text = "Forward" Then
            SetCyl0.V601 = 1
            SetCyl1.V601 = 0
            btn_stn6_cyl1_fw.Image = My.Resources.button_white
            btn_stn6_cyl1_fw.Text = "Is Forward"
        ElseIf btn_stn6_cyl1_fw.Text = "Is Forward" Then
            SetCyl0.V601 = 0
            SetCyl1.V601 = 0
            btn_stn6_cyl1_fw.Image = My.Resources.button_silver
            btn_stn6_cyl1_fw.Text = "Forward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn6_cyl1_bw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl1_bw.Click
        If btn_stn6_cyl1_fw.Text = "Is Forward" Then
            btn_stn6_cyl1_fw.PerformClick()
        End If

        If btn_stn6_cyl1_bw.Text = "Backward" Then
            SetCyl0.V601 = 0
            SetCyl1.V601 = 1
            btn_stn6_cyl1_bw.Image = My.Resources.button_white
            btn_stn6_cyl1_bw.Text = "Is Backward"
        ElseIf btn_stn6_cyl1_bw.Text = "Is Backward" Then
            SetCyl0.V601 = 0
            SetCyl1.V601 = 0
            btn_stn6_cyl1_bw.Image = My.Resources.button_silver
            btn_stn6_cyl1_bw.Text = "Backward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn6_cyl2_fw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl2_fw.Click
        If btn_stn6_cyl2_bw.Text = "Is Backward" Then
            btn_stn6_cyl2_bw.PerformClick()
        End If

        If btn_stn6_cyl2_fw.Text = "Forward" Then
            SetCyl0.V602 = 1
            SetCyl1.V602 = 0
            btn_stn6_cyl2_fw.Image = My.Resources.button_white
            btn_stn6_cyl2_fw.Text = "Is Forward"
        ElseIf btn_stn6_cyl2_fw.Text = "Is Forward" Then
            SetCyl0.V602 = 0
            SetCyl1.V602 = 0
            btn_stn6_cyl2_fw.Image = My.Resources.button_silver
            btn_stn6_cyl2_fw.Text = "Forward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn6_cyl2_bw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl2_bw.Click
        If btn_stn6_cyl2_fw.Text = "Is Forward" Then
            btn_stn6_cyl2_fw.PerformClick()
        End If

        If btn_stn6_cyl2_bw.Text = "Backward" Then
            SetCyl0.V602 = 0
            SetCyl1.V602 = 1
            btn_stn6_cyl2_bw.Image = My.Resources.button_white
            btn_stn6_cyl2_bw.Text = "Is Backward"
        ElseIf btn_stn6_cyl2_bw.Text = "Is Backward" Then
            SetCyl0.V602 = 0
            SetCyl1.V602 = 0
            btn_stn6_cyl2_bw.Image = My.Resources.button_silver
            btn_stn6_cyl2_bw.Text = "Backward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn6_cyl3_fw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl3_fw.Click
        If btn_stn6_cyl3_bw.Text = "Is Backward" Then
            btn_stn6_cyl3_bw.PerformClick()
        End If

        If btn_stn6_cyl3_fw.Text = "Forward" Then
            SetCyl0.V603 = 1
            SetCyl1.V603 = 0
            btn_stn6_cyl3_fw.Image = My.Resources.button_white
            btn_stn6_cyl3_fw.Text = "Is Forward"
        ElseIf btn_stn6_cyl3_fw.Text = "Is Forward" Then
            SetCyl0.V603 = 0
            SetCyl1.V603 = 0
            btn_stn6_cyl3_fw.Image = My.Resources.button_silver
            btn_stn6_cyl3_fw.Text = "Forward"
        End If
        plcTrigger = True
    End Sub

    Private Sub btn_stn6_cyl3_bw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl3_bw.Click
        If btn_stn6_cyl3_fw.Text = "Is Forward" Then
            btn_stn6_cyl3_fw.PerformClick()
        End If

        If btn_stn6_cyl3_bw.Text = "Backward" Then
            SetCyl0.V603 = 0
            SetCyl1.V603 = 1
            btn_stn6_cyl3_bw.Image = My.Resources.button_white
            btn_stn6_cyl3_bw.Text = "Is Backward"
        ElseIf btn_stn6_cyl3_bw.Text = "Is Backward" Then
            SetCyl0.V603 = 0
            SetCyl1.V603 = 0
            btn_stn6_cyl3_bw.Image = My.Resources.button_silver
            btn_stn6_cyl3_bw.Text = "Backward"
        End If
        plcTrigger = True
    End Sub



    ''###############################################################################################################################################################################################
    ''Festo Controller Button

    ''Festo Left ----------------------------------------------
    ''Alarm Reset 
    'Private Sub btn_Lfesto_alarm_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Lfesto_alarm.MouseDown
    '    SetCylFest.LALMRES = 1
    '    plcTrigger = True
    '    btn_Lfesto_alarm.Tag = New Tuple(Of Color, Color)(btn_Lfesto_alarm.BackColor, btn_Lfesto_alarm.ForeColor)
    '    btn_Lfesto_alarm.BackColor = SystemColors.GradientInactiveCaption
    '    btn_Lfesto_alarm.ForeColor = Color.DarkBlue
    'End Sub

    'Private Sub btn_Lfesto_alarm_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Lfesto_alarm.MouseUp
    '    SetCylFest.LALMRES = 0
    '    plcTrigger = True
    '    Dim originalColors As Tuple(Of Color, Color) = DirectCast(btn_Lfesto_alarm.Tag, Tuple(Of Color, Color))
    '    btn_Lfesto_alarm.BackColor = originalColors.Item1
    '    btn_Lfesto_alarm.ForeColor = originalColors.Item2
    'End Sub


    ''Servo On
    'Private Sub btn_Lfesto_servo_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Lfesto_servo.MouseDown
    '    SetCylFest.LSERVO = 1
    '    plcTrigger = True
    '    btn_Lfesto_servo.Tag = New Tuple(Of Color, Color)(btn_Lfesto_servo.BackColor, btn_Lfesto_servo.ForeColor)
    '    btn_Lfesto_servo.BackColor = SystemColors.GradientInactiveCaption
    '    btn_Lfesto_servo.ForeColor = Color.DarkBlue
    'End Sub

    'Private Sub btn_Lfesto_servo_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Lfesto_servo.MouseUp
    '    SetCylFest.LSERVO = 0
    '    plcTrigger = True
    '    Dim originalColors As Tuple(Of Color, Color) = DirectCast(btn_Lfesto_servo.Tag, Tuple(Of Color, Color))
    '    btn_Lfesto_servo.BackColor = originalColors.Item1
    '    btn_Lfesto_servo.ForeColor = originalColors.Item2
    'End Sub

    ''Jog Min
    'Private Sub btn_Lfesto_jog_min_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Lfesto_jog_min.MouseDown
    '    SetCylFest.LJOGMIN = 1
    '    plcTrigger = True
    '    btn_Lfesto_jog_min.Tag = New Tuple(Of Color, Color)(btn_Lfesto_jog_min.BackColor, btn_Lfesto_jog_min.ForeColor)
    '    btn_Lfesto_jog_min.BackColor = SystemColors.GradientInactiveCaption
    '    btn_Lfesto_jog_min.ForeColor = Color.DarkBlue
    'End Sub

    'Private Sub btn_Lfesto_jog_min_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Lfesto_jog_min.MouseUp
    '    SetCylFest.LJOGMIN = 0
    '    plcTrigger = True
    '    Dim originalColors As Tuple(Of Color, Color) = DirectCast(btn_Lfesto_jog_min.Tag, Tuple(Of Color, Color))
    '    btn_Lfesto_jog_min.BackColor = originalColors.Item1
    '    btn_Lfesto_jog_min.ForeColor = originalColors.Item2
    'End Sub

    ''Jog Plus
    'Private Sub btn_Lfesto_jog_plus_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Lfesto_jog_plus.MouseDown
    '    SetCylFest.LJOGPLUS = 1
    '    plcTrigger = True
    '    btn_Lfesto_jog_plus.Tag = New Tuple(Of Color, Color)(btn_Lfesto_jog_plus.BackColor, btn_Lfesto_jog_plus.ForeColor)
    '    btn_Lfesto_jog_plus.BackColor = SystemColors.GradientInactiveCaption
    '    btn_Lfesto_jog_plus.ForeColor = Color.DarkBlue
    'End Sub

    'Private Sub btn_Lfesto_jog_plus_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Lfesto_jog_plus.MouseUp
    '    SetCylFest.LJOGPLUS = 0
    '    plcTrigger = True
    '    Dim originalColors As Tuple(Of Color, Color) = DirectCast(btn_Lfesto_jog_plus.Tag, Tuple(Of Color, Color))
    '    btn_Lfesto_jog_plus.BackColor = originalColors.Item1
    '    btn_Lfesto_jog_plus.ForeColor = originalColors.Item2
    'End Sub

    ''Homing
    'Private Sub btn_Lfesto_homing_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Lfesto_homing.MouseDown
    '    SetCylFest.LHOMING = 1
    '    plcTrigger = True
    '    btn_Lfesto_homing.Tag = New Tuple(Of Color, Color)(btn_Lfesto_homing.BackColor, btn_Lfesto_homing.ForeColor)
    '    btn_Lfesto_homing.BackColor = SystemColors.GradientInactiveCaption
    '    btn_Lfesto_homing.ForeColor = Color.DarkBlue
    'End Sub

    'Private Sub btn_Lfesto_homing_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Lfesto_homing.MouseUp
    '    SetCylFest.LHOMING = 0
    '    plcTrigger = True
    '    Dim originalColors As Tuple(Of Color, Color) = DirectCast(btn_Lfesto_homing.Tag, Tuple(Of Color, Color))
    '    btn_Lfesto_homing.BackColor = originalColors.Item1
    '    btn_Lfesto_homing.ForeColor = originalColors.Item2
    'End Sub

    ''Jisl
    'Private Sub btn_Lfesto_jisl_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Lfesto_jisl.MouseDown
    '    SetCylFest.LJISL = 1
    '    plcTrigger = True
    '    btn_Lfesto_jisl.Tag = New Tuple(Of Color, Color)(btn_Lfesto_jisl.BackColor, btn_Lfesto_jisl.ForeColor)
    '    btn_Lfesto_jisl.BackColor = SystemColors.GradientInactiveCaption
    '    btn_Lfesto_jisl.ForeColor = Color.DarkBlue
    'End Sub

    'Private Sub btn_Lfesto_jisl_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Lfesto_jisl.MouseUp
    '    SetCylFest.LJISL = 0
    '    plcTrigger = True
    '    Dim originalColors As Tuple(Of Color, Color) = DirectCast(btn_Lfesto_jisl.Tag, Tuple(Of Color, Color))
    '    btn_Lfesto_jisl.BackColor = originalColors.Item1
    '    btn_Lfesto_jisl.ForeColor = originalColors.Item2
    'End Sub

    ''Power Reset
    'Private Sub btn_Lfesto_power_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Lfesto_power.MouseDown
    '    SetCylFest.LPWRRES = 1
    '    plcTrigger = True
    '    btn_Lfesto_power.Tag = New Tuple(Of Color, Color)(btn_Lfesto_power.BackColor, btn_Lfesto_power.ForeColor)
    '    btn_Lfesto_power.BackColor = SystemColors.GradientInactiveCaption
    '    btn_Lfesto_power.ForeColor = Color.DarkBlue
    'End Sub

    'Private Sub btn_Lfesto_power_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Lfesto_power.MouseUp
    '    SetCylFest.LPWRRES = 1
    '    plcTrigger = True
    '    Dim originalColors As Tuple(Of Color, Color) = DirectCast(btn_Lfesto_power.Tag, Tuple(Of Color, Color))
    '    btn_Lfesto_power.BackColor = originalColors.Item1
    '    btn_Lfesto_power.ForeColor = originalColors.Item2
    'End Sub

    ''Festo Right ----------------------------------------------
    ''Alarm Reset 
    'Private Sub btn_Rfesto_alarm_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Rfesto_alarm.MouseDown
    '    SetCylFest.RALMRES = 1
    '    plcTrigger = True
    '    btn_Rfesto_alarm.Tag = New Tuple(Of Color, Color)(btn_Rfesto_alarm.BackColor, btn_Rfesto_alarm.ForeColor)
    '    btn_Rfesto_alarm.BackColor = SystemColors.GradientInactiveCaption
    '    btn_Rfesto_alarm.ForeColor = Color.DarkBlue
    'End Sub

    'Private Sub btn_Rfesto_alarm_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Rfesto_alarm.MouseUp
    '    SetCylFest.RALMRES = 0
    '    plcTrigger = True
    '    Dim originalColors As Tuple(Of Color, Color) = DirectCast(btn_Rfesto_alarm.Tag, Tuple(Of Color, Color))
    '    btn_Rfesto_alarm.BackColor = originalColors.Item1
    '    btn_Rfesto_alarm.ForeColor = originalColors.Item2
    'End Sub


    ''Servo On
    'Private Sub btn_Rfesto_servo_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Rfesto_servo.MouseDown
    '    SetCylFest.RSERVO = 1
    '    plcTrigger = True
    '    btn_Rfesto_servo.Tag = New Tuple(Of Color, Color)(btn_Rfesto_servo.BackColor, btn_Rfesto_servo.ForeColor)
    '    btn_Rfesto_servo.BackColor = SystemColors.GradientInactiveCaption
    '    btn_Rfesto_servo.ForeColor = Color.DarkBlue
    'End Sub

    'Private Sub btn_Rfesto_servo_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Rfesto_servo.MouseUp
    '    SetCylFest.RSERVO = 0
    '    plcTrigger = True
    '    Dim originalColors As Tuple(Of Color, Color) = DirectCast(btn_Rfesto_servo.Tag, Tuple(Of Color, Color))
    '    btn_Rfesto_servo.BackColor = originalColors.Item1
    '    btn_Rfesto_servo.ForeColor = originalColors.Item2
    'End Sub

    ''Jog Min
    'Private Sub btn_Rfesto_jog_min_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Rfesto_jog_min.MouseDown
    '    SetCylFest.RJOGMIN = 1
    '    plcTrigger = True
    '    btn_Rfesto_jog_min.Tag = New Tuple(Of Color, Color)(btn_Rfesto_jog_min.BackColor, btn_Rfesto_jog_min.ForeColor)
    '    btn_Rfesto_jog_min.BackColor = SystemColors.GradientInactiveCaption
    '    btn_Rfesto_jog_min.ForeColor = Color.DarkBlue
    'End Sub

    'Private Sub btn_Rfesto_jog_min_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Rfesto_jog_min.MouseUp
    '    SetCylFest.RJOGMIN = 0
    '    plcTrigger = True
    '    Dim originalColors As Tuple(Of Color, Color) = DirectCast(btn_Rfesto_jog_min.Tag, Tuple(Of Color, Color))
    '    btn_Rfesto_jog_min.BackColor = originalColors.Item1
    '    btn_Rfesto_jog_min.ForeColor = originalColors.Item2
    'End Sub

    ''Jog Plus
    'Private Sub btn_Rfesto_jog_plus_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Rfesto_jog_plus.MouseDown
    '    SetCylFest.RJOGPLUS = 1
    '    plcTrigger = True
    '    btn_Rfesto_jog_plus.Tag = New Tuple(Of Color, Color)(btn_Rfesto_jog_plus.BackColor, btn_Rfesto_jog_plus.ForeColor)
    '    btn_Rfesto_jog_plus.BackColor = SystemColors.GradientInactiveCaption
    '    btn_Rfesto_jog_plus.ForeColor = Color.DarkBlue
    'End Sub

    'Private Sub btn_Rfesto_jog_plus_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Rfesto_jog_plus.MouseUp
    '    SetCylFest.RJOGPLUS = 0
    '    plcTrigger = True
    '    Dim originalColors As Tuple(Of Color, Color) = DirectCast(btn_Rfesto_jog_plus.Tag, Tuple(Of Color, Color))
    '    btn_Rfesto_jog_plus.BackColor = originalColors.Item1
    '    btn_Rfesto_jog_plus.ForeColor = originalColors.Item2
    'End Sub

    ''Homing
    'Private Sub btn_Rfesto_homing_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Rfesto_homing.MouseDown
    '    SetCylFest.RHOMING = 1
    '    plcTrigger = True
    '    btn_Rfesto_homing.Tag = New Tuple(Of Color, Color)(btn_Rfesto_homing.BackColor, btn_Rfesto_homing.ForeColor)
    '    btn_Rfesto_homing.BackColor = SystemColors.GradientInactiveCaption
    '    btn_Rfesto_homing.ForeColor = Color.DarkBlue
    'End Sub

    'Private Sub btn_Rfesto_homing_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Rfesto_homing.MouseUp
    '    SetCylFest.RHOMING = 0
    '    plcTrigger = True
    '    Dim originalColors As Tuple(Of Color, Color) = DirectCast(btn_Rfesto_homing.Tag, Tuple(Of Color, Color))
    '    btn_Rfesto_homing.BackColor = originalColors.Item1
    '    btn_Rfesto_homing.ForeColor = originalColors.Item2
    'End Sub

    ''Jisl
    'Private Sub btn_Rfesto_jisl_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Rfesto_jisl.MouseDown
    '    SetCylFest.RJISL = 1
    '    plcTrigger = True
    '    btn_Rfesto_jisl.Tag = New Tuple(Of Color, Color)(btn_Rfesto_jisl.BackColor, btn_Rfesto_jisl.ForeColor)
    '    btn_Rfesto_jisl.BackColor = SystemColors.GradientInactiveCaption
    '    btn_Rfesto_jisl.ForeColor = Color.DarkBlue
    'End Sub

    'Private Sub btn_Rfesto_jisl_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Rfesto_jisl.MouseUp
    '    SetCylFest.RJISL = 0
    '    plcTrigger = True
    '    Dim originalColors As Tuple(Of Color, Color) = DirectCast(btn_Rfesto_jisl.Tag, Tuple(Of Color, Color))
    '    btn_Rfesto_jisl.BackColor = originalColors.Item1
    '    btn_Rfesto_jisl.ForeColor = originalColors.Item2
    'End Sub

    ''Power Reset
    'Private Sub btn_Rfesto_power_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Rfesto_power.MouseDown
    '    SetCylFest.RPWRRES = 1
    '    plcTrigger = True
    '    btn_Rfesto_power.Tag = New Tuple(Of Color, Color)(btn_Rfesto_power.BackColor, btn_Rfesto_power.ForeColor)
    '    btn_Rfesto_power.BackColor = SystemColors.GradientInactiveCaption
    '    btn_Rfesto_power.ForeColor = Color.DarkBlue
    'End Sub

    'Private Sub btn_Rfesto_power_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Rfesto_power.MouseUp
    '    SetCylFest.RPWRRES = 1
    '    plcTrigger = True
    '    Dim originalColors As Tuple(Of Color, Color) = DirectCast(btn_Rfesto_power.Tag, Tuple(Of Color, Color))
    '    btn_Rfesto_power.BackColor = originalColors.Item1
    '    btn_Rfesto_power.ForeColor = originalColors.Item2
    'End Sub
End Class