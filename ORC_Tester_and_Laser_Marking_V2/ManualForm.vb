﻿Public Class ManualForm
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
    End Sub
End Class