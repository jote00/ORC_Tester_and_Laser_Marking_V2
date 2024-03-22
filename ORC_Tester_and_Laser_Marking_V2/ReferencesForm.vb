Imports System.Data.SqlClient
Imports ControlBPM
Imports System.IO
Public Class ReferencesForm
    Dim fullPath As String = System.AppDomain.CurrentDomain.BaseDirectory
    Dim projectFolder As String = fullPath.Replace("\ORC_Tester_and_Laser_Marking_V2\bin\Debug\", "").Replace("\ORC_Tester_and_Laser_Marking\bin\Release\", "")
    Dim iniPath As String = projectFolder + "\Config\Config.INI"
    Dim logFileName As String = $"Log_{Date.Now.ToString("yyyyMMdd")}.csv"

    Private Sub DateTime_Tick(sender As Object, e As EventArgs) Handles DateTime.Tick
        lbl_date.Text = Date.Now.ToString("dd-MM-yyyy")
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

    Private Sub ReferencesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetUserLevel()
        With Config
            .dbHostName = ReadINI(iniPath, "DATABASE", "Hostname")
            .dbUsername = ReadINI(iniPath, "DATABASE", "Username")
            .dbPassword = ReadINI(iniPath, "DATABASE", "Password")
            .dbDatabase = ReadINI(iniPath, "DATABASE", "Database")

        End With

        LoadTbRef() 'Harus dibawah Config

        'Button Station Enable
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Name.StartsWith("btn_st") Then
                ctrl.Enabled = False
            End If
        Next
    End Sub

    Private Sub LoadTbRef()
        Call ConnectionDB.connection_db()
        Try
            Dim sc As New SqlCommand("SELECT * FROM tbl_References order by [References] asc", ConnectionDB.Connection)
            Dim adapter As New SqlDataAdapter(sc)
            Dim ds As New DataSet

            adapter.Fill(ds)
            dgv_ref.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(Date.Now.ToString("dd/MM/yyyy - hh:mm:ss => ") + "Error: Database not found!")
        End Try

        dgv_ref.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10)
        dgv_ref.DefaultCellStyle.Font = New Font("Arial", 10)
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If tbx_ref.Text = "" And tbx_punching.Text = "" And tbx_lvl_dist.Text = "" And tbx_lvl_toler.Text = "" And tbx_oring.Text = "" And tbx_Ldist.Text = "" And tbx_Rdist.Text = "" And tbx_Lspeed.Text = "" And tbx_Rspeed.Text = "" And tbx_laser_template.Text = "" And tbx_camera_program.Text = "" Then
            MsgBox("Please Fill All Field!")
            Exit Sub

        Else
            Call ConnectionDB.connection_db()
            Dim sc As New SqlCommand("INSERT INTO tbl_References ([References], [Punching Mode], [Level Distance], [Level Tolerance], [Oring Check], [Festo LEFT Distance], [Festo Right Distance], [Festo LEFT Speed], [Festo RIGHT Speed], [Laser Template], [Camera Program]) VALUES('" & tbx_ref.Text & "', '" & tbx_punching.Text & "', '" & tbx_lvl_dist.Text & "', '" & tbx_lvl_toler.Text & "', '" & tbx_oring.Text & "', '" & tbx_Ldist.Text & "', '" & tbx_Rdist.Text & "', '" & tbx_Lspeed.Text & "', '" & tbx_Rspeed.Text & "', '" & tbx_laser_template.Text & "', '" & tbx_camera_program.Text & "')", ConnectionDB.Connection)
            Dim adapter As New SqlDataAdapter(sc)
            adapter.SelectCommand.ExecuteNonQuery()
            LoadTbRef()
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If tbx_ref.Text = "" Then
            MsgBox("Please Fill Product References")
            Exit Sub
        Else
            Call ConnectionDB.connection_db()
            Dim sc As New SqlCommand("UPDATE tbl_References SET [Punching Mode] = '" & tbx_punching.Text & "', [Level Distance] = '" & tbx_lvl_dist.Text & "', [Level Tolerance] = '" & tbx_lvl_toler.Text & "', [Oring Check] = '" & tbx_oring.Text & "', [Festo LEFT Distance] = '" & tbx_Ldist.Text & "', [Festo Right Distance] = '" & tbx_Rdist.Text & "', [Festo Left Speed] = '" & tbx_Lspeed.Text & "', [Festo RIGHT Speed] = '" & tbx_Rspeed.Text & "', [Laser Template] = '" & tbx_laser_template.Text & "', [Camera Program] = '" & tbx_camera_program.Text & "' WHERE [References] = '" & tbx_ref.Text & "'", ConnectionDB.Connection)
            Dim adapter As New SqlDataAdapter(sc)
            adapter.SelectCommand.ExecuteNonQuery()
            LoadTbRef()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If tbx_ref.Text = "" Then
            MsgBox("Please Fill Product References")
            Exit Sub
        Else
            Call ConnectionDB.connection_db()
            Dim sc As New SqlCommand("DELETE from tbl_References where [References] = '" & tbx_ref.Text & "'", ConnectionDB.Connection)
            Dim adapter As New SqlDataAdapter(sc)
            adapter.SelectCommand.ExecuteNonQuery()
            LoadTbRef()
        End If
    End Sub

    Private Sub dgv_ref_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_ref.CellDoubleClick
        Try

            Call ConnectionDB.connection_db()
            Dim sc As New SqlCommand("SELECT * FROM tbl_References WHERE [References]='" & dgv_ref.CurrentCell.Value & "'", ConnectionDB.Connection)
            Dim rd As SqlDataReader = sc.ExecuteReader
            rd.Read()

            tbx_ref.Text = dgv_ref.CurrentCell.Value
            tbx_punching.Text = rd.Item("Punching Mode")
            tbx_lvl_dist.Text = rd.Item("Level Distance")
            tbx_lvl_toler.Text = rd.Item("Level Tolerance")
            tbx_oring.Text = rd.Item("Oring Check")
            tbx_Ldist.Text = rd.Item("Festo LEFT Distance")
            tbx_Rdist.Text = rd.Item("Festo RIGHT Distance")
            tbx_Lspeed.Text = rd.Item("Festo LEFT Speed")
            tbx_Rspeed.Text = rd.Item("Festo RIGHT Speed")
            tbx_laser_template.Text = rd.Item("Laser Template")
            tbx_camera_program.Text = rd.Item("Camera Program")
        Catch ex As Exception
            MsgBox("Error " + ex.Message)
        End Try
    End Sub
End Class