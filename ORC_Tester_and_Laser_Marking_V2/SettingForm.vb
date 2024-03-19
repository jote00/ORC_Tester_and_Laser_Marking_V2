Imports System.Threading
Imports System.IO
Public Class SettingForm

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

    Private Sub SettingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetUserLevel()
        AutoConnection()

        If Connected() Then
            btn_connect_plc.Text = "Disconnect"
            ind_connect_plc.BackColor = Color.LawnGreen
            ModbusRW.Enabled = True
            MODBUS_ERR = False
        Else
            btn_connect_plc.Text = "Connect"
            ind_connect_plc.BackColor = Color.Red
            ModbusRW.Enabled = False
            MODBUS_ERR = True
        End If

        'Button Station Enable

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Name.StartsWith("btn_st") Then
                ctrl.Enabled = False
            End If
        Next
    End Sub


    'PLC Connection
    Private Sub btn_connect_plc_Click(sender As Object, e As EventArgs) Handles btn_connect_plc.Click
        If btn_connect_plc.Text = "Connect" Then
            Try
                ManualConnection()

                If Connected() Then



                    btn_connect_plc.Text = "Disconnect"
                    ind_connect_plc.BackColor = Color.LawnGreen
                    ModbusRW.Enabled = True
                    MODBUS_ERR = False


                End If



            Catch ex As Exception
                MsgBox("Failed to connect from PLC: " & ex.Message, MsgBoxStyle.Critical)
            End Try

        ElseIf btn_connect_plc.Text = "Disconnect" Then
            Try
                Disconnect()
                If Not Connected() Then

                    btn_connect_plc.Text = "Connect"
                    ind_connect_plc.BackColor = Color.Red
                    ModbusRW.Enabled = False
                End If

            Catch ex As Exception
                MsgBox("Failed to disconnect from PLC: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    'Read And Write data Modbus Button

    Private Sub btn_read_Click(sender As Object, e As EventArgs) Handles btn_read.Click
        Try
            Dim address As Integer = Integer.Parse(txtAddress.Text)
            Dim readValue As Integer = Modbus.ReadModbus(address, 1)(0)

            rtbSetting.Text = $"Value at address {address}: {readValue}"
        Catch ex As Exception
            rtbSetting.Text = $"Failed to read data : {ex.Message}"
        End Try
    End Sub

    Private Sub btn_write_Click(sender As Object, e As EventArgs) Handles btn_write.Click
        Try

            Dim address As Integer = Integer.Parse(txtAddress.Text)
            Dim value As Integer = Integer.Parse(txtValue.Text)


            Modbus.WriteModbus(address, value)

            rtbSetting.Text = $"Successfully write value {value} at Address {address}"
        Catch ex As Exception

            rtbSetting.Text = $"Failed to write data: {ex.Message}"
        End Try
    End Sub




End Class