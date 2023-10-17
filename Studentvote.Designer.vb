<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Studentvote
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Studentvote))
        btnAdminlogin = New Button()
        btnExt = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        lbl_date = New Label()
        lbl_time = New Label()
        txt_sudid = New TextBox()
        btnLogin = New Button()
        lbl_info = New Label()
        Timer1 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAdminlogin
        ' 
        btnAdminlogin.BackgroundImageLayout = ImageLayout.None
        btnAdminlogin.FlatAppearance.BorderSize = 0
        btnAdminlogin.FlatAppearance.MouseOverBackColor = Color.Black
        btnAdminlogin.FlatStyle = FlatStyle.Flat
        btnAdminlogin.Font = New Font("Franklin Gothic Demi", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdminlogin.ForeColor = Color.DeepSkyBlue
        btnAdminlogin.Location = New Point(576, 12)
        btnAdminlogin.Name = "btnAdminlogin"
        btnAdminlogin.Size = New Size(126, 66)
        btnAdminlogin.TabIndex = 3
        btnAdminlogin.Text = "Admin Login"
        btnAdminlogin.UseVisualStyleBackColor = True
        ' 
        ' btnExt
        ' 
        btnExt.FlatAppearance.BorderSize = 0
        btnExt.FlatAppearance.MouseOverBackColor = Color.Black
        btnExt.FlatStyle = FlatStyle.Flat
        btnExt.Font = New Font("Franklin Gothic Demi", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnExt.ForeColor = Color.DeepSkyBlue
        btnExt.Location = New Point(727, 9)
        btnExt.Name = "btnExt"
        btnExt.Size = New Size(126, 69)
        btnExt.TabIndex = 4
        btnExt.Text = "Exit"
        btnExt.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(58, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(143, 69)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(12, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(57, 53)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        Panel1.Controls.Add(lbl_date)
        Panel1.Controls.Add(lbl_time)
        Panel1.Controls.Add(txt_sudid)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(lbl_info)
        Panel1.Font = New Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Panel1.Location = New Point(6, 87)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(864, 434)
        Panel1.TabIndex = 7
        ' 
        ' lbl_date
        ' 
        lbl_date.AutoSize = True
        lbl_date.Font = New Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_date.ForeColor = Color.DeepSkyBlue
        lbl_date.Location = New Point(28, 68)
        lbl_date.Name = "lbl_date"
        lbl_date.Size = New Size(46, 24)
        lbl_date.TabIndex = 13
        lbl_date.Text = "date"
        ' 
        ' lbl_time
        ' 
        lbl_time.AutoSize = True
        lbl_time.Font = New Font("Franklin Gothic Medium", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_time.ForeColor = Color.DeepSkyBlue
        lbl_time.Location = New Point(28, 34)
        lbl_time.Name = "lbl_time"
        lbl_time.Size = New Size(73, 34)
        lbl_time.TabIndex = 12
        lbl_time.Text = "Time"
        ' 
        ' txt_sudid
        ' 
        txt_sudid.Font = New Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txt_sudid.Location = New Point(297, 207)
        txt_sudid.Name = "txt_sudid"
        txt_sudid.Size = New Size(298, 25)
        txt_sudid.TabIndex = 10
        txt_sudid.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.BlueViolet
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.Location = New Point(297, 259)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(298, 31)
        btnLogin.TabIndex = 11
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lbl_info
        ' 
        lbl_info.AutoSize = True
        lbl_info.Font = New Font("Franklin Gothic Demi", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_info.ForeColor = Color.DeepSkyBlue
        lbl_info.Location = New Point(365, 170)
        lbl_info.Name = "lbl_info"
        lbl_info.Size = New Size(148, 24)
        lbl_info.TabIndex = 9
        lbl_info.Text = "Enter Student ID"
        lbl_info.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Studentvote
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(874, 533)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(btnExt)
        Controls.Add(btnAdminlogin)
        FormBorderStyle = FormBorderStyle.None
        Name = "Studentvote"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Studentvote"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnAdminlogin As Button
    Friend WithEvents btnExt As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents txt_sudid As TextBox
    Friend WithEvents lbl_info As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents Timer1 As Timer
End Class
