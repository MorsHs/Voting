Imports MySql.Data.MySqlClient

Public Class adminlogin
    Private Sub adminlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If UsernameTextBox.Text = String.Empty Or PasswordTextBox.Text = String.Empty Then
            MsgBox("Missing required field")
        Else
            Try
                With command
                    .Parameters.Clear()
                    .CommandText = "prcPass"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_username", UsernameTextBox.Text)
                    .Parameters.AddWithValue("@p_password", PasswordTextBox.Text)
                    sqlAdapter = New MySqlDataAdapter
                    datatbl = New DataTable
                    sqlAdapter.SelectCommand = command
                    sqlAdapter.Fill(datatbl)

                    If datatbl.Rows.Count > 0 Then
                        Me.Hide()
                        SystemMnagement.ShowDialog()

                    Else
                        MsgBox("Password and username does not match")
                        ' End If
                    End If
                End With

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Hide()
        Studentvote.ShowDialog()
        Me.Close()
    End Sub

    Private Sub passwordbox_CheckedChanged(sender As Object, e As EventArgs) Handles passwordbox.CheckedChanged
        Dim passwordholder As String
        passwordholder = PasswordTextBox.Text.ToString
        If passwordbox.Checked = True Then
            PasswordTextBox.PasswordChar = ""
        Else
            PasswordTextBox.PasswordChar = "*"

        End If

    End Sub
End Class
