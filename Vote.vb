Public Class Vote
    'Private WithEvents pan As New Panel
    'Private WithEvents pic_candidate As New PictureBox
    ' Private WithEvents namelbl As New Label


    Private Sub Vote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        ' Load_PresidentList()

    End Sub

    ' Sub load_presidentList()

    'End Sub
    ' Sub load_Controls()


    'pan = New Panel
    'pan.Width = 80
    'pan.Height = 80
    'pan.BackColor = Color.White




    'pic_candidate = New PictureBox
    'pic_candidate.Width = 50
    'pic_candidate.Height = 50
    'pic_candidate.BackgroundImageLayout = ImageLayout.Stretch
    'pic_candidate.Dock = DockStyle.Bottom

    'namelbl = New Label
    'namelbl.ForeColor = Color.DeepSkyBlue
    'namelbl.BackColor = Color.Black
    'namelbl.TextAlign = ContentAlignment.MiddleCenter
    'namelbl.Font = New Font("franklin gothic", 9, FontStyle.Bold)
    'namelbl.Dock = DockStyle.Top

    'namelbl.Text = dr.Item("").ToString

    'Dim ms As New System.IO.MemoryStream(array)
    'Dim bitmap As New System.Drawing.Bitmap(ms)
    ' pic_candidate.BackgroundImage = bitmap


    ' End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        With Vote2
            .TopLevel = False
            Panel1.Controls.Add(Vote2)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Me.Dispose()

    End Sub
End Class