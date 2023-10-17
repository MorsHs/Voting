Public Class Registeradmin
    Private Sub Registeradmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
    End Sub

    Private Sub Buttonx_Click(sender As Object, e As EventArgs) Handles Buttonx.Click
        Me.Dispose()

    End Sub

    Private Sub btnregisteradmin_Click(sender As Object, e As EventArgs) Handles btnregisteradmin.Click
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcAddAdmin"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_username", txtUsername.Text)
                .Parameters.AddWithValue("@p_Lastname", txtLastname.Text)
                .Parameters.AddWithValue("@p_Firstname", txtFirstname.Text)
                .Parameters.AddWithValue("@p_Middlename", txtMiddlename.Text)
                .Parameters.AddWithValue("@p_picture", studentPhotopath)
                .Parameters.AddWithValue("@p_password", TextBox1.Text)
                .ExecuteNonQuery()
                Me.Dispose()



            End With
        Catch ex As Exception
            MessageBox.Show("record Save Successfully", "Saving records", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            With OpenFileDialog2
                .Title = "Select Photo"
                .FileName = ""
                If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    Admindefault.Image = Image.FromFile(.FileName)
                    studentPhotopath = .FileName
                End If
            End With



        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
End Class