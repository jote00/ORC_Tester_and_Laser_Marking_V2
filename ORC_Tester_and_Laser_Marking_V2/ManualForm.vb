Public Class ManualForm
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


End Class