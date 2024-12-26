﻿Imports MySql.Data.MySqlClient
Public Class PARALLEL

    Public connection As MySqlConnection
    Dim R1 As Double
    Dim R2 As Double
    Dim R3 As Double
    Dim Vin As Double
    Dim IT As Double
    Dim I1 As Double
    Dim I2 As Double
    Dim I3 As Double

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Hide()
        home1.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            R1 = Val(TextBox1.Text)
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
        Else
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
        End If
    End Sub


    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            R1 = Val(TextBox1.Text) * 1000
            CheckBox1.Enabled = False
            CheckBox3.Enabled = False
        Else
            CheckBox1.Enabled = True
            CheckBox3.Enabled = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            R1 = Val(TextBox1.Text) * 1000000
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
        Else
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            R2 = Val(TextBox2.Text)
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
        Else
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            R2 = Val(TextBox2.Text) * 1000
            CheckBox4.Enabled = False
            CheckBox6.Enabled = False
        Else
            CheckBox4.Enabled = True
            CheckBox6.Enabled = True
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then
            R2 = Val(TextBox2.Text) * 1000000
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
        Else
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked Then
            R3 = Val(TextBox3.Text)
            CheckBox8.Enabled = False
            CheckBox9.Enabled = False
        Else
            CheckBox8.Enabled = True
            CheckBox9.Enabled = True
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked Then
            R3 = Val(TextBox3.Text) * 1000
            CheckBox7.Enabled = False
            CheckBox9.Enabled = False
        Else
            CheckBox7.Enabled = True
            CheckBox9.Enabled = True
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked Then
            R3 = Val(TextBox3.Text) * 1000000
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
        Else
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked Then
            Vin = Val(TextBox4.Text)
            CheckBox11.Enabled = False
            CheckBox12.Enabled = False
        Else
            CheckBox11.Enabled = True
            CheckBox12.Enabled = True
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked Then
            Vin = Val(TextBox4.Text) / 1000
            CheckBox10.Enabled = False
            CheckBox12.Enabled = False
        Else
            CheckBox10.Enabled = True
            CheckBox12.Enabled = True
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked Then
            Vin = Val(TextBox4.Text) / 1000000
            CheckBox10.Enabled = False
            CheckBox11.Enabled = False
        Else
            CheckBox10.Enabled = True
            CheckBox11.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Res1 As Double = R1
            Dim Res2 As Double = R2
            Dim Res3 As Double = R3
            Dim Vin1 As Double = Vin

            IT = Vin1 / (1 / ((1 / Res1) + (1 / Res2) + (1 / Res3)))
            I1 = Vin1 / Res1
            I2 = Vin1 / Res2
            I3 = Vin1 / Res3


            Dim formattedR1 As String = FormatResistance(R1)
            Dim formattedR2 As String = FormatResistance(R2)
            Dim formattedR3 As String = FormatResistance(R3)

            Label9.Text = "R1 = " + FormatResistance(R1)
            Label8.Text = "R2 = " + FormatResistance(R2)
            Label7.Text = "R3 = " + FormatResistance(R3)
            Label6.Text = "V = " + Vin.ToString("F2") + " V"


            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()

            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            CheckBox5.Checked = False
            CheckBox6.Checked = False
            CheckBox7.Checked = False
            CheckBox8.Checked = False
            CheckBox9.Checked = False
            CheckBox10.Checked = False
            CheckBox11.Checked = False
            CheckBox12.Checked = False



            Select Case I1
                Case Is >= 1
                    Label1.Text = " " + I1.ToString("F2") + " A"
                Case Is >= 0.001
                    Label1.Text = " " + (I1 * 1000).ToString("F2") + " mA"
                Case Else
                    Label1.Text = " " + (I2 * 1000000).ToString("F2") + " uV"
            End Select

            Select Case I2
                Case Is >= 1
                    Label2.Text = " " + I2.ToString("F2") + " A"
                Case Is >= 0.001
                    Label2.Text = " " + (I2 * 1000).ToString("F2") + " mA"
                Case Else
                    Label2.Text = " " + (I2 * 1000000).ToString("F2") + " uV"
            End Select

            Select Case I3
                Case Is >= 1
                    Label3.Text = " " + I3.ToString("F2") + " A"
                Case Is >= 0.001
                    Label3.Text = " " + (I3 * 1000).ToString("F2") + " mA"
                Case Else
                    Label3.Text = " " + (I3 * 1000000).ToString("F2") + " uA"
            End Select

            Select Case IT
                Case Is >= 1
                    Label4.Text = " " + IT.ToString("F2") + " A"
                Case Is >= 0.001
                    Label4.Text = " " + (IT * 1000).ToString("F2") + " mA"
                Case Else
                    Label4.Text = " " + (IT * 1000000).ToString("F2") + " uV"
            End Select

        Catch ex As Exception
            MsgBox("Error in calculation: " & ex.Message)
        End Try
    End Sub

    Private Function FormatResistance(resistance As Double) As String
        If resistance >= 1000000 Then
            Return (resistance / 1000000).ToString("F2") + "MΩ"
        ElseIf resistance >= 1000 Then
            Return (resistance / 1000).ToString("F2") + "kΩ"
        Else
            Return resistance.ToString("F2") + "Ω"
        End If
    End Function

    Private Function FormatResistanced(resistance As Double) As String
        If resistance >= 1000000 Then
            Return (resistance / 1000000).ToString("F2") + "MOhms"
        ElseIf resistance >= 1000 Then
            Return (resistance / 1000).ToString("F2") + "kOhms"
        Else
            Return resistance.ToString("F2") + "Ohms"
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            connection = New MySqlConnection
            connection.ConnectionString = "server=localhost;username=root;password=;database=experiment2"
            connection.Open()

            Dim Vind As String
            Dim I1d As String
            Dim I2d As String
            Dim I3d As String
            Dim ITd As String

            Select Case IT
                Case Is >= 1
                    ITd = IT.ToString("F2") + " A"
                Case Is >= 0.001
                    ITd = (IT * 1000).ToString("F2") + " mA"
                Case Else
                    ITd = (IT * 1000000).ToString("F2") + " uA"
            End Select

            Select Case I1
                Case Is >= 1
                    I1d = I1.ToString("F2") + " A"
                Case Is >= 0.001
                    I1d = (I1 * 1000).ToString("F2") + " mA"
                Case Else
                    I1d = (I1 * 1000000).ToString("F2") + " uA"
            End Select

            Select Case I2
                Case Is >= 1
                    I2d = I2.ToString("F2") + " A"
                Case Is >= 0.001
                    I2d = (I2 * 1000).ToString("F2") + " mA"
                Case Else
                    I2d = (I2 * 1000000).ToString("F2") + " uA"
            End Select

            Select Case I3
                Case Is >= 1
                    I3d = I3.ToString("F2") + " A"
                Case Is >= 0.001
                    I3d = (I3 * 1000).ToString("F2") + " mA"
                Case Else
                    I3d = (I3 * 1000000).ToString("F2") + " uA"
            End Select

            Select Case Vin
                Case Is >= 1
                    Vind = Vin.ToString("F2") + " V"
                Case Is >= 0.001
                    Vind = (Vin * 1000).ToString("F2") + " mV"
                Case Else
                    Vind = (Vin * 1000000).ToString("F2") + " uV"
            End Select



            Dim command As New MySqlCommand("INSERT INTO PARALLEL (R1, R2, R3, VIN, IT, I1, I2, I3) VALUES (@R1, @R2, @R3, @VIN, @IT, @I1, @I2, @I3)", connection)


            command.Parameters.AddWithValue("@R1", FormatResistanced(R1))
            command.Parameters.AddWithValue("@R2", FormatResistanced(R2))
            command.Parameters.AddWithValue("@R3", FormatResistanced(R3))
            command.Parameters.AddWithValue("@VIN", Vind)
            command.Parameters.AddWithValue("@IT", ITd)
            command.Parameters.AddWithValue("@I1", I1d)
            command.Parameters.AddWithValue("@I2", I2d)
            command.Parameters.AddWithValue("@I3", I3d)

            command.ExecuteNonQuery()
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            MsgBox("Successfully Added Record!")
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class

