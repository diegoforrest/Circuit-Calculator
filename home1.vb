Imports MySql.Data.MySqlClient
Public Class home1

    Public connection As MySqlConnection

    Private Sub SERIES_Click(sender As Object, e As EventArgs) Handles SERIES.Click
        Dim SERIES As New SERIES()
        SERIES.ShowDialog()
    End Sub

    Private Sub PARALLEL_Click(sender As Object, e As EventArgs) Handles PARALLEL.Click
        Dim PARALLEL As New PARALLEL()
        PARALLEL.ShowDialog()
    End Sub

    Private Sub SP_Click(sender As Object, e As EventArgs) Handles SP.Click
        Dim SP As New SP()
        SP.ShowDialog()
    End Sub

    Dim CONNECT As MySqlConnection
    Dim CONSTRING As String = "DATA SOURCE = localhost; USERID= root; password= ; DATABASE = experiment2"
    Dim COMMAND As MySqlCommand


    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles toggle.CheckedChanged
        Try
            If toggle.Checked = True Then
                CONNECT = New MySqlConnection(CONSTRING)
                CONNECT.Open()
                SERIES.Enabled = True
                PARALLEL.Enabled = True
                SP.Enabled = True
                MsgBox("Connected to Database Experiment2", vbInformation, "Confirmation Window")
            Else
                If CONNECT IsNot Nothing AndAlso CONNECT.State = ConnectionState.Open Then
                    CONNECT.Close()
                    SERIES.Enabled = False
                    PARALLEL.Enabled = False
                    SP.Enabled = False
                    MsgBox("Disconnected from Database Experiment2", vbInformation, "Confirmation Window")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub HOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SERIES.Enabled = False
        SP.Enabled = False
        PARALLEL.Enabled = False
    End Sub
End Class