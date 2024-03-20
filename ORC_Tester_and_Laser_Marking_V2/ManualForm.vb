Imports System.Threading
Imports System.IO
Public Class ManualForm
    Dim plcReadThread As Thread
    Dim runningModeThread As Thread
    Private Sub DateTime_Tick(sender As Object, e As EventArgs) Handles DateTime.Tick
        lbl_curr_time.Text = Date.Now.ToString("dd-MM-yyyy")
        lbl_curr_time.Text = Date.Now.ToString("hh:mm:ss")
    End Sub
    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
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
        AutoConnection()
        plcReadThread = New Thread(New ThreadStart(AddressOf plcReading))
        plcReadThread.Start()
        runningModeThread = New Thread(New ThreadStart(AddressOf runningMode))
        runningModeThread.Start()

        'Button Station Enable

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Name.StartsWith("btn_st") Then
                ctrl.Enabled = True
            End If
        Next
    End Sub

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

    'Button Manual Click Function

    Private Sub btn_stn1_cyl1_fw_Click(sender As Object, e As EventArgs) Handles btn_stn1_cyl1_fw.Click
        If btn_stn1_cyl1_bw.Text = "Is Backward" Then
            btn_stn1_cyl1_bw.PerformClick()
        End If

        If btn_stn1_cyl1_fw.Text = "Forward" Then
            STN1_CYL1 = FORWARD
            btn_stn1_cyl1_fw.Image = My.Resources.button_white
            btn_stn1_cyl1_fw.Text = "Is Forward"
        ElseIf btn_stn1_cyl1_fw.Text = "Is Forward" Then
            STN1_CYL1 = IDLE
            btn_stn1_cyl1_fw.Image = My.Resources.button_silver
            btn_stn1_cyl1_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn1_cyl1_bw_Click(sender As Object, e As EventArgs) Handles btn_stn1_cyl1_bw.Click
        If btn_stn1_cyl1_fw.Text = "Is Forward" Then
            btn_stn1_cyl1_fw.PerformClick()
        End If

        If btn_stn1_cyl1_bw.Text = "Backward" Then
            STN1_CYL1 = BACKWARD
            btn_stn1_cyl1_bw.Image = My.Resources.button_white
            btn_stn1_cyl1_bw.Text = "Is Backward"
        ElseIf btn_stn1_cyl1_bw.Text = "Is Backward" Then
            STN1_CYL1 = IDLE
            btn_stn1_cyl1_bw.Image = My.Resources.button_silver
            btn_stn1_cyl1_bw.Text = "Backward"
        End If
    End Sub

    'Button Manual Station 3

    Private Sub btn_stn3_cyl1_fw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl1_fw.Click
        If btn_stn3_cyl1_bw.Text = "Is Backward" Then
            btn_stn3_cyl1_bw.PerformClick()
        End If

        If btn_stn3_cyl1_fw.Text = "Forward" Then
            STN3_CYL1 = FORWARD
            btn_stn3_cyl1_fw.Image = My.Resources.button_white
            btn_stn3_cyl1_fw.Text = "Is Forward"
        ElseIf btn_stn3_cyl1_fw.Text = "Is Forward" Then
            STN3_CYL1 = IDLE
            btn_stn3_cyl1_fw.Image = My.Resources.button_silver
            btn_stn3_cyl1_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn3_cyl1_bw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl1_bw.Click
        If btn_stn3_cyl1_fw.Text = "Is Forward" Then
            btn_stn3_cyl1_fw.PerformClick()
        End If

        If btn_stn3_cyl1_bw.Text = "Backward" Then
            STN3_CYL1 = BACKWARD
            btn_stn3_cyl1_bw.Image = My.Resources.button_white
            btn_stn3_cyl1_bw.Text = "Is Backward"
        ElseIf btn_stn3_cyl1_bw.Text = "Is Backward" Then
            STN3_CYL1 = IDLE
            btn_stn3_cyl1_bw.Image = My.Resources.button_silver
            btn_stn3_cyl1_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn3_cyl2_fw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl2_fw.Click
        If btn_stn3_cyl2_bw.Text = "Is Backward" Then
            btn_stn3_cyl2_bw.PerformClick()
        End If

        If btn_stn3_cyl2_fw.Text = "Forward" Then
            STN3_CYL2 = FORWARD
            btn_stn3_cyl2_fw.Image = My.Resources.button_white
            btn_stn3_cyl2_fw.Text = "Is Forward"
        ElseIf btn_stn3_cyl2_fw.Text = "Is Forward" Then
            STN3_CYL2 = IDLE
            btn_stn3_cyl2_fw.Image = My.Resources.button_silver
            btn_stn3_cyl2_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn3_cyl2_bw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl2_bw.Click
        If btn_stn3_cyl2_fw.Text = "Is Forward" Then
            btn_stn3_cyl2_fw.PerformClick()
        End If

        If btn_stn3_cyl2_bw.Text = "Backward" Then
            STN3_CYL2 = BACKWARD
            btn_stn3_cyl2_bw.Image = My.Resources.button_white
            btn_stn3_cyl2_bw.Text = "Is Backward"
        ElseIf btn_stn3_cyl2_bw.Text = "Is Backward" Then
            STN3_CYL2 = IDLE
            btn_stn3_cyl2_bw.Image = My.Resources.button_silver
            btn_stn3_cyl2_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn3_cyl3_fw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl3_fw.Click
        If btn_stn3_cyl3_bw.Text = "Is Backward" Then
            btn_stn3_cyl3_bw.PerformClick()
        End If

        If btn_stn3_cyl3_fw.Text = "Forward" Then
            STN3_CYL3 = FORWARD
            btn_stn3_cyl3_fw.Image = My.Resources.button_white
            btn_stn3_cyl3_fw.Text = "Is Forward"
        ElseIf btn_stn3_cyl3_fw.Text = "Is Forward" Then
            STN3_CYL3 = IDLE
            btn_stn3_cyl3_fw.Image = My.Resources.button_silver
            btn_stn3_cyl3_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn3_cyl3_bw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl3_bw.Click
        If btn_stn3_cyl3_fw.Text = "Is Forward" Then
            btn_stn3_cyl3_fw.PerformClick()
        End If

        If btn_stn3_cyl3_bw.Text = "Backward" Then
            STN3_CYL3 = BACKWARD
            btn_stn3_cyl3_bw.Image = My.Resources.button_white
            btn_stn3_cyl3_bw.Text = "Is Backward"
        ElseIf btn_stn3_cyl3_bw.Text = "Is Backward" Then
            STN3_CYL3 = IDLE
            btn_stn3_cyl3_bw.Image = My.Resources.button_silver
            btn_stn3_cyl3_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn3_cyl4_fw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl4_fw.Click
        If btn_stn3_cyl4_bw.Text = "Is Backward" Then
            btn_stn3_cyl4_bw.PerformClick()
        End If

        If btn_stn3_cyl4_fw.Text = "Forward" Then
            STN3_CYL4 = FORWARD
            btn_stn3_cyl4_fw.Image = My.Resources.button_white
            btn_stn3_cyl4_fw.Text = "Is Forward"
        ElseIf btn_stn3_cyl4_fw.Text = "Is Forward" Then
            STN3_CYL4 = IDLE
            btn_stn3_cyl4_fw.Image = My.Resources.button_silver
            btn_stn3_cyl4_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn3_cyl4_bw_Click(sender As Object, e As EventArgs) Handles btn_stn3_cyl4_bw.Click
        If btn_stn3_cyl4_fw.Text = "Is Forward" Then
            btn_stn3_cyl4_fw.PerformClick()
        End If

        If btn_stn3_cyl4_bw.Text = "Backward" Then
            STN3_CYL4 = BACKWARD
            btn_stn3_cyl4_bw.Image = My.Resources.button_white
            btn_stn3_cyl4_bw.Text = "Is Backward"
        ElseIf btn_stn3_cyl4_bw.Text = "Is Backward" Then
            STN3_CYL4 = IDLE
            btn_stn3_cyl4_bw.Image = My.Resources.button_silver
            btn_stn3_cyl4_bw.Text = "Backward"
        End If
    End Sub


    'Button Manual Station 4

    Private Sub btn_stn4_cyl1_fw_Click(sender As Object, e As EventArgs) Handles btn_stn4_cyl1_fw.Click
        If btn_stn4_cyl1_bw.Text = "Is Backward" Then
            btn_stn4_cyl1_bw.PerformClick()
        End If

        If btn_stn4_cyl1_fw.Text = "Forward" Then
            STN4_CYL1 = FORWARD
            btn_stn4_cyl1_fw.Image = My.Resources.button_white
            btn_stn4_cyl1_fw.Text = "Is Forward"
        ElseIf btn_stn4_cyl1_fw.Text = "Is Forward" Then
            STN4_CYL1 = IDLE
            btn_stn4_cyl1_fw.Image = My.Resources.button_silver
            btn_stn4_cyl1_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn4_cyl1_bw_Click(sender As Object, e As EventArgs) Handles btn_stn4_cyl1_bw.Click
        If btn_stn4_cyl1_fw.Text = "Is Forward" Then
            btn_stn4_cyl1_fw.PerformClick()
        End If

        If btn_stn4_cyl1_bw.Text = "Backward" Then
            STN4_CYL1 = BACKWARD
            btn_stn4_cyl1_bw.Image = My.Resources.button_white
            btn_stn4_cyl1_bw.Text = "Is Backward"
        ElseIf btn_stn4_cyl1_bw.Text = "Is Backward" Then
            STN4_CYL1 = IDLE
            btn_stn4_cyl1_bw.Image = My.Resources.button_silver
            btn_stn4_cyl1_bw.Text = "Backward"
        End If
    End Sub


    'Button Manual Station 5

    Private Sub btn_stn5_cyl1_fw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl1_fw.Click
        If btn_stn5_cyl1_bw.Text = "Is Backward" Then
            btn_stn5_cyl1_bw.PerformClick()
        End If

        If btn_stn5_cyl1_fw.Text = "Forward" Then
            STN5_CYL1 = FORWARD
            btn_stn5_cyl1_fw.Image = My.Resources.button_white
            btn_stn5_cyl1_fw.Text = "Is Forward"
        ElseIf btn_stn5_cyl1_fw.Text = "Is Forward" Then
            STN5_CYL1 = IDLE
            btn_stn5_cyl1_fw.Image = My.Resources.button_silver
            btn_stn5_cyl1_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn5_cyl1_bw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl1_bw.Click
        If btn_stn5_cyl1_fw.Text = "Is Forward" Then
            btn_stn5_cyl1_fw.PerformClick()
        End If

        If btn_stn5_cyl1_bw.Text = "Backward" Then
            STN5_CYL1 = BACKWARD
            btn_stn5_cyl1_bw.Image = My.Resources.button_white
            btn_stn5_cyl1_bw.Text = "Is Backward"
        ElseIf btn_stn5_cyl1_bw.Text = "Is Backward" Then
            STN5_CYL1 = IDLE
            btn_stn5_cyl1_bw.Image = My.Resources.button_silver
            btn_stn5_cyl1_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn5_cyl2_fw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl2_fw.Click
        If btn_stn5_cyl2_bw.Text = "Is Backward" Then
            btn_stn5_cyl2_bw.PerformClick()
        End If

        If btn_stn5_cyl2_fw.Text = "Forward" Then
            STN5_CYL2 = FORWARD
            btn_stn5_cyl2_fw.Image = My.Resources.button_white
            btn_stn5_cyl2_fw.Text = "Is Forward"
        ElseIf btn_stn5_cyl2_fw.Text = "Is Forward" Then
            STN5_CYL2 = IDLE
            btn_stn5_cyl2_fw.Image = My.Resources.button_silver
            btn_stn5_cyl2_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn5_cyl2_bw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl2_bw.Click
        If btn_stn5_cyl2_fw.Text = "Is Forward" Then
            btn_stn5_cyl2_fw.PerformClick()
        End If

        If btn_stn5_cyl2_bw.Text = "Backward" Then
            STN5_CYL2 = BACKWARD
            btn_stn5_cyl2_bw.Image = My.Resources.button_white
            btn_stn5_cyl2_bw.Text = "Is Backward"
        ElseIf btn_stn5_cyl2_bw.Text = "Is Backward" Then
            STN5_CYL2 = IDLE
            btn_stn5_cyl2_bw.Image = My.Resources.button_silver
            btn_stn5_cyl2_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn5_cyl3_fw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl3_fw.Click
        If btn_stn5_cyl3_bw.Text = "Is Backward" Then
            btn_stn5_cyl3_bw.PerformClick()
        End If

        If btn_stn5_cyl3_fw.Text = "Forward" Then
            STN5_CYL3 = FORWARD
            btn_stn5_cyl3_fw.Image = My.Resources.button_white
            btn_stn5_cyl3_fw.Text = "Is Forward"
        ElseIf btn_stn5_cyl3_fw.Text = "Is Forward" Then
            STN5_CYL3 = IDLE
            btn_stn5_cyl3_fw.Image = My.Resources.button_silver
            btn_stn5_cyl3_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn5_cyl3_bw_Click(sender As Object, e As EventArgs) Handles btn_stn5_cyl3_bw.Click
        If btn_stn5_cyl3_fw.Text = "Is Forward" Then
            btn_stn5_cyl3_fw.PerformClick()
        End If

        If btn_stn5_cyl3_bw.Text = "Backward" Then
            STN5_CYL3 = BACKWARD
            btn_stn5_cyl3_bw.Image = My.Resources.button_white
            btn_stn5_cyl3_bw.Text = "Is Backward"
        ElseIf btn_stn5_cyl3_bw.Text = "Is Backward" Then
            STN5_CYL3 = IDLE
            btn_stn5_cyl3_bw.Image = My.Resources.button_silver
            btn_stn5_cyl3_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn6_cyl1_fw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl1_fw.Click
        If btn_stn6_cyl1_bw.Text = "Is Backward" Then
            btn_stn6_cyl1_bw.PerformClick()
        End If

        If btn_stn6_cyl1_fw.Text = "Forward" Then
            STN6_CYL1 = FORWARD
            btn_stn6_cyl1_fw.Image = My.Resources.button_white
            btn_stn6_cyl1_fw.Text = "Is Forward"
        ElseIf btn_stn6_cyl1_fw.Text = "Is Forward" Then
            STN6_CYL1 = IDLE
            btn_stn6_cyl1_fw.Image = My.Resources.button_silver
            btn_stn6_cyl1_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn6_cyl1_bw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl1_bw.Click
        If btn_stn6_cyl1_fw.Text = "Is Forward" Then
            btn_stn6_cyl1_fw.PerformClick()
        End If

        If btn_stn6_cyl1_bw.Text = "Backward" Then
            STN6_CYL1 = BACKWARD
            btn_stn6_cyl1_bw.Image = My.Resources.button_white
            btn_stn6_cyl1_bw.Text = "Is Backward"
        ElseIf btn_stn6_cyl1_bw.Text = "Is Backward" Then
            STN6_CYL1 = IDLE
            btn_stn6_cyl1_bw.Image = My.Resources.button_silver
            btn_stn6_cyl1_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn6_cyl2_fw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl2_fw.Click
        If btn_stn6_cyl2_bw.Text = "Is Backward" Then
            btn_stn6_cyl2_bw.PerformClick()
        End If

        If btn_stn6_cyl2_fw.Text = "Forward" Then
            STN6_CYL2 = FORWARD
            btn_stn6_cyl2_fw.Image = My.Resources.button_white
            btn_stn6_cyl2_fw.Text = "Is Forward"
        ElseIf btn_stn6_cyl2_fw.Text = "Is Forward" Then
            STN6_CYL2 = IDLE
            btn_stn6_cyl2_fw.Image = My.Resources.button_silver
            btn_stn6_cyl2_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn6_cyl2_bw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl2_bw.Click
        If btn_stn6_cyl2_fw.Text = "Is Forward" Then
            btn_stn6_cyl2_fw.PerformClick()
        End If

        If btn_stn6_cyl2_bw.Text = "Backward" Then
            STN6_CYL2 = BACKWARD
            btn_stn6_cyl2_bw.Image = My.Resources.button_white
            btn_stn6_cyl2_bw.Text = "Is Backward"
        ElseIf btn_stn6_cyl2_bw.Text = "Is Backward" Then
            STN6_CYL2 = IDLE
            btn_stn6_cyl2_bw.Image = My.Resources.button_silver
            btn_stn6_cyl2_bw.Text = "Backward"
        End If
    End Sub

    Private Sub btn_stn6_cyl3_fw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl3_fw.Click
        If btn_stn6_cyl3_bw.Text = "Is Backward" Then
            btn_stn6_cyl3_bw.PerformClick()
        End If

        If btn_stn6_cyl3_fw.Text = "Forward" Then
            STN6_CYL3 = FORWARD
            btn_stn6_cyl3_fw.Image = My.Resources.button_white
            btn_stn6_cyl3_fw.Text = "Is Forward"
        ElseIf btn_stn6_cyl3_fw.Text = "Is Forward" Then
            STN6_CYL3 = IDLE
            btn_stn6_cyl3_fw.Image = My.Resources.button_silver
            btn_stn6_cyl3_fw.Text = "Forward"
        End If
    End Sub

    Private Sub btn_stn6_cyl3_bw_Click(sender As Object, e As EventArgs) Handles btn_stn6_cyl3_bw.Click
        If btn_stn6_cyl3_fw.Text = "Is Forward" Then
            btn_stn6_cyl3_fw.PerformClick()
        End If

        If btn_stn6_cyl3_bw.Text = "Backward" Then
            STN6_CYL3 = BACKWARD
            btn_stn6_cyl3_bw.Image = My.Resources.button_white
            btn_stn6_cyl3_bw.Text = "Is Backward"
        ElseIf btn_stn6_cyl3_bw.Text = "Is Backward" Then
            STN6_CYL3 = IDLE
            btn_stn6_cyl3_bw.Image = My.Resources.button_silver
            btn_stn6_cyl3_bw.Text = "Backward"
        End If
    End Sub

    'Running Mode Status
    Private Sub runningMode()
        Do
            If Connected() Then
                RUNNING_MODE = Modbus.ReadModbus(ADDR_RUNNING_MODE, 1)(0)
                Me.Invoke(Sub()
                              Select Case RUNNING_MODE
                                  Case 0
                                      lbl_auto_man.Text = "..."
                                  Case 1
                                      lbl_auto_man.Text = "AUTO"
                                  Case 2
                                      lbl_auto_man.Text = "MANUAL"
                              End Select
                          End Sub)

            End If
            Thread.Sleep(100)
        Loop
    End Sub

    'ReadPLC

    Private Sub plcReading()
        Do
            If Connected() Then

                Dim readS11 = ReadModbus(ADDR_STN1_SEN1, 1)

                Dim readS31 = ReadModbus(ADDR_STN3_SEN1, 1)
                Dim readS32 = ReadModbus(ADDR_STN3_SEN2, 1)
                Dim readS33 = ReadModbus(ADDR_STN3_SEN3, 1)
                Dim readS34 = ReadModbus(ADDR_STN3_SEN4, 1)

                Dim readS41 = ReadModbus(ADDR_STN4_SEN1, 1)

                Dim readS51 = ReadModbus(ADDR_STN5_SEN1, 1)
                Dim readS52 = ReadModbus(ADDR_STN5_SEN2, 1)
                Dim readS53 = ReadModbus(ADDR_STN5_SEN3, 1)    'STN5

                Dim readS61 = ReadModbus(ADDR_STN6_SEN1, 1)
                Dim readS62 = ReadModbus(ADDR_STN6_SEN2, 1)
                Dim readS63 = ReadModbus(ADDR_STN6_SEN3, 1)    'STN6

                Dim readLALM As Integer = ReadBit(ADDR_STN3_IND_LFESTO, 0)
                Dim readLPEND As Integer = ReadBit(ADDR_STN3_IND_LFESTO, 1)
                Dim readLHEND As Integer = ReadBit(ADDR_STN3_IND_LFESTO, 2)   'Indicator LFesto
                Dim readLSVON As Integer = ReadBit(ADDR_STN3_IND_LFESTO, 3)
                Dim readLEMG As Integer = ReadBit(ADDR_STN3_IND_LFESTO, 4)

                Dim readRALM As Integer = ReadBit(ADDR_STN3_IND_RFESTO, 0)
                Dim readRPEND As Integer = ReadBit(ADDR_STN3_IND_RFESTO, 1)
                Dim readRHEND As Integer = ReadBit(ADDR_STN3_IND_RFESTO, 2)   'Indicator RFesto
                Dim readRSVON As Integer = ReadBit(ADDR_STN3_IND_RFESTO, 3)
                Dim readREMG As Integer = ReadBit(ADDR_STN3_IND_RFESTO, 4)


                'Text Box Festo read ----------------------------------------------
                Me.Invoke(Sub()

                              tbx_Lfesto_position.Text = ReadDoubleAddrees(ADDR_STN3_PSTN_LFESTO)
                              tbx_Lfesto_speed.Text = ReadModbus(ADDR_STN3_SPD_LFESTO, 1)(0)
                              tbx_Lfesto_alarm.Text = ReadModbus(ADDR_STN3_ALM_LFESTO, 1)(0)

                              tbx_Rfesto_position.Text = ReadDoubleAddrees(ADDR_STN3_PSTN_RFESTO)
                              tbx_Rfesto_speed.Text = ReadModbus(ADDR_STN3_SPD_RFESTO, 1)(0)
                              tbx_Rfesto_alarm.Text = ReadModbus(ADDR_STN3_ALM_RFESTO, 1)(0)
                          End Sub)

                'Station 1 ----------------------------------------------
                'CylSen 1
                If readS11.Length > 0 AndAlso readS11(0) = FORWARD Then
                    man_stn1_cyl1_max.Image = My.Resources.led_green_on
                Else
                    man_stn1_cyl1_max.Image = My.Resources.led_red_on
                End If


                If readS11.Length > 0 AndAlso readS11(0) = BACKWARD Then
                    man_stn1_cyl1_min.Image = My.Resources.led_green_on
                Else
                    man_stn1_cyl1_min.Image = My.Resources.led_red_on
                End If


                'Station 3 ----------------------------------------------
                'CylSen 1
                If readS31.Length > 0 AndAlso readS31(0) = FORWARD Then
                    man_stn3_cyl1_max.Image = My.Resources.led_green_on
                Else
                    man_stn3_cyl1_max.Image = My.Resources.led_red_on
                End If


                If readS31.Length > 0 AndAlso readS31(0) = BACKWARD Then
                    man_stn3_cyl1_min.Image = My.Resources.led_green_on
                Else
                    man_stn3_cyl1_min.Image = My.Resources.led_red_on
                End If

                'CylSen 2
                If readS32.Length > 0 AndAlso readS32(0) = FORWARD Then
                    man_stn3_cyl2_max.Image = My.Resources.led_green_on
                Else
                    man_stn3_cyl2_max.Image = My.Resources.led_red_on
                End If


                If readS32.Length > 0 AndAlso readS32(0) = BACKWARD Then
                    man_stn3_cyl2_min.Image = My.Resources.led_green_on
                Else
                    man_stn3_cyl2_min.Image = My.Resources.led_red_on
                End If

                'CylSen 3
                If readS33.Length > 0 AndAlso readS33(0) = FORWARD Then
                    man_stn3_cyl3_max.Image = My.Resources.led_green_on
                Else
                    man_stn3_cyl3_max.Image = My.Resources.led_red_on
                End If


                If readS33.Length > 0 AndAlso readS33(0) = BACKWARD Then
                    man_stn3_cyl3_min.Image = My.Resources.led_green_on
                Else
                    man_stn3_cyl3_min.Image = My.Resources.led_red_on
                End If

                'CylSen 4
                If readS34.Length > 0 AndAlso readS34(0) = FORWARD Then
                    man_stn3_cyl4_max.Image = My.Resources.led_green_on
                Else
                    man_stn3_cyl4_max.Image = My.Resources.led_red_on
                End If


                If readS34.Length > 0 AndAlso readS34(0) = BACKWARD Then
                    man_stn3_cyl4_min.Image = My.Resources.led_green_on
                Else
                    man_stn3_cyl4_min.Image = My.Resources.led_red_on
                End If

                'Festo Left
                If readLALM = 1 Then
                    ind_stn3_Lfesto_alm.Image = My.Resources.led_green_on
                Else
                    ind_stn3_Lfesto_alm.Image = My.Resources.led_red_on
                End If

                If readLPEND = 1 Then
                    ind_stn3_Lfesto_pend.Image = My.Resources.led_green_on
                Else
                    ind_stn3_Lfesto_pend.Image = My.Resources.led_red_on
                End If

                If readLHEND = 1 Then
                    ind_stn3_Lfesto_hend.Image = My.Resources.led_green_on
                Else
                    ind_stn3_Lfesto_hend.Image = My.Resources.led_red_on
                End If

                If readLSVON = 1 Then
                    ind_stn3_Lfesto_svon.Image = My.Resources.led_green_on
                Else
                    ind_stn3_Lfesto_svon.Image = My.Resources.led_red_on
                End If

                If readLEMG = 1 Then
                    ind_stn3_Lfesto_emg.Image = My.Resources.led_green_on
                Else
                    ind_stn3_Lfesto_emg.Image = My.Resources.led_red_on
                End If

                'Festo Right
                If readRALM = 1 Then
                    ind_stn3_Rfesto_alm.Image = My.Resources.led_green_on
                Else
                    ind_stn3_Rfesto_alm.Image = My.Resources.led_red_on
                End If

                If readRPEND = 1 Then
                    ind_stn3_Rfesto_pend.Image = My.Resources.led_green_on
                Else
                    ind_stn3_Rfesto_pend.Image = My.Resources.led_red_on
                End If

                If readRHEND = 1 Then
                    ind_stn3_Rfesto_hend.Image = My.Resources.led_green_on
                Else
                    ind_stn3_Rfesto_hend.Image = My.Resources.led_red_on
                End If

                If readRSVON = 1 Then
                    ind_stn3_Rfesto_svon.Image = My.Resources.led_green_on
                Else
                    ind_stn3_Rfesto_svon.Image = My.Resources.led_red_on
                End If

                If readREMG = 1 Then
                    ind_stn3_Rfesto_emg.Image = My.Resources.led_green_on
                Else
                    ind_stn3_Rfesto_emg.Image = My.Resources.led_red_on
                End If



                'Station 4 ----------------------------------------------
                'CylSen 1
                If readS41.Length > 0 AndAlso readS41(0) = FORWARD Then
                    man_stn4_cyl1_max.Image = My.Resources.led_green_on
                Else
                    man_stn4_cyl1_max.Image = My.Resources.led_red_on
                End If


                If readS41.Length > 0 AndAlso readS41(0) = BACKWARD Then
                    man_stn4_cyl1_min.Image = My.Resources.led_green_on
                Else
                    man_stn4_cyl1_min.Image = My.Resources.led_red_on
                End If


                'Station 5 ----------------------------------------------
                'CylSen 1
                If readS51.Length > 0 AndAlso readS51(0) = FORWARD Then
                    man_stn5_cyl1_max.Image = My.Resources.led_green_on

                Else
                    man_stn5_cyl1_max.Image = My.Resources.led_red_on
                End If


                If readS51.Length > 0 AndAlso readS51(0) = BACKWARD Then
                    man_stn5_cyl1_min.Image = My.Resources.led_green_on
                Else
                    man_stn5_cyl1_min.Image = My.Resources.led_red_on
                End If

                'CylSen 2
                If readS52.Length > 0 AndAlso readS52(0) = FORWARD Then
                    man_stn5_cyl2_max.Image = My.Resources.led_green_on
                Else
                    man_stn5_cyl2_max.Image = My.Resources.led_red_on
                End If


                If readS52.Length > 0 AndAlso readS52(0) = BACKWARD Then
                    man_stn5_cyl2_min.Image = My.Resources.led_green_on
                Else
                    man_stn5_cyl2_min.Image = My.Resources.led_red_on
                End If

                'CylSen 3
                If readS53.Length > 0 AndAlso readS53(0) = FORWARD Then
                    man_stn5_cyl3_max.Image = My.Resources.led_green_on
                Else
                    man_stn5_cyl3_max.Image = My.Resources.led_red_on
                End If


                If readS53.Length > 0 AndAlso readS53(0) = BACKWARD Then
                    man_stn5_cyl3_min.Image = My.Resources.led_green_on
                Else
                    man_stn5_cyl3_min.Image = My.Resources.led_red_on
                End If


                'Station 6 ----------------------------------------------
                'CylSen 1
                If readS61.Length > 0 AndAlso readS61(0) = FORWARD Then
                    man_stn6_cyl1_max.Image = My.Resources.led_green_on
                Else
                    man_stn6_cyl1_max.Image = My.Resources.led_red_on
                End If


                If readS61.Length > 0 AndAlso readS61(0) = BACKWARD Then
                    man_stn6_cyl1_min.Image = My.Resources.led_green_on
                Else
                    man_stn6_cyl1_min.Image = My.Resources.led_red_on
                End If

                'CylSen 2
                If readS62.Length > 0 AndAlso readS62(0) = FORWARD Then
                    man_stn6_cyl2_max.Image = My.Resources.led_green_on
                Else
                    man_stn6_cyl2_max.Image = My.Resources.led_red_on
                End If


                If readS62.Length > 0 AndAlso readS62(0) = BACKWARD Then
                    man_stn6_cyl2_min.Image = My.Resources.led_green_on
                Else
                    man_stn6_cyl2_min.Image = My.Resources.led_red_on
                End If

                'CylSen 3
                If readS63.Length > 0 AndAlso readS63(0) = FORWARD Then
                    man_stn6_cyl3_max.Image = My.Resources.led_green_on
                Else
                    man_stn6_cyl3_max.Image = My.Resources.led_red_on
                End If


                If readS63.Length > 0 AndAlso readS63(0) = BACKWARD Then
                    man_stn6_cyl3_min.Image = My.Resources.led_green_on
                Else
                    man_stn6_cyl3_min.Image = My.Resources.led_red_on
                End If

            End If
            Thread.Sleep(100)
        Loop
    End Sub


End Class