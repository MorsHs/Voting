Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Public Class Studentvote
    Private Sub Studentvote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub btnAdminlogin_Click(sender As Object, e As EventArgs) Handles btnAdminlogin.Click
        Me.Hide()
        adminlogin.ShowDialog()
    End Sub

    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        adminlogin.Close()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txt_sudid.Text = String.Empty Then
            lbl_info.Text = "Please enter student ID"
            lbl_info.ForeColor = Color.BlueViolet
        Else
            Try
                With command
                    .Parameters.Clear()
                    .CommandText = "prcStudentLogin"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_studentid", txt_sudid.Text)
                    sqlAdapter = New MySqlDataAdapter
                    datatbl = New DataTable
                    sqlAdapter.SelectCommand = command
                    sqlAdapter.Fill(datatbl)

                    If datatbl.Rows.Count > 0 Then
                        .Parameters.Clear()
                        .CommandText = "prcStudentstatus"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_studentid", txt_sudid.Text)
                        .Parameters.AddWithValue("@p_status", "Un-Voted")
                        sqlAdapter = New MySqlDataAdapter
                        datatbl = New DataTable
                        sqlAdapter.SelectCommand = command
                        sqlAdapter.Fill(datatbl)

                        If datatbl.Rows.Count > 0 Then
                            With Vote
                                .TopLevel = False
                                Panel1.Controls.Add(Vote)
                                .BringToFront()
                                .Show()
                            End With

                        Else
                            lbl_info.Text = "Already voted"
                            lbl_info.ForeColor = Color.BlueViolet
                        End If
                    Else
                        lbl_info.Text = "Student not found"
                        lbl_info.ForeColor = Color.BlueViolet
                    End If

                End With

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If


    End Sub

    Private Sub txt_sudid_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = Date.Now.ToString("hh:mm:ss:tt")
        lbl_date.Text = Date.Now.ToString("ddd,yyyy-MM-dd")
    End Sub
End Class