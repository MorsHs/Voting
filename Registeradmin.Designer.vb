<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registeradmin
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Registeradmin))
        PictureBox1 = New PictureBox()
        Admindefault = New PictureBox()
        btnBrowse = New Button()
        lblusernme = New Label()
        lbllastnm = New Label()
        lblfirstnmn = New Label()
        lblmiddlenm = New Label()
        txtUsername = New TextBox()
        txtLastname = New TextBox()
        txtFirstname = New TextBox()
        txtMiddlename = New TextBox()
        btnregisteradmin = New Button()
        Buttonx = New Button()
        OpenFileDialog2 = New OpenFileDialog()
        lblAdminpass = New Label()
        TextBox1 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Admindefault, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(219, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(283, 53)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Admindefault
        ' 
        Admindefault.Image = CType(resources.GetObject("Admindefault.Image"), Image)
        Admindefault.Location = New Point(302, 86)
        Admindefault.Name = "Admindefault"
        Admindefault.Size = New Size(114, 98)
        Admindefault.SizeMode = PictureBoxSizeMode.StretchImage
        Admindefault.TabIndex = 1
        Admindefault.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.Black
        btnBrowse.BackgroundImage = CType(resources.GetObject("btnBrowse.BackgroundImage"), Image)
        btnBrowse.BackgroundImageLayout = ImageLayout.Stretch
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Location = New Point(422, 148)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(81, 36)
        btnBrowse.TabIndex = 2
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' lblusernme
        ' 
        lblusernme.AutoSize = True
        lblusernme.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblusernme.ForeColor = SystemColors.ButtonHighlight
        lblusernme.Location = New Point(230, 223)
        lblusernme.Name = "lblusernme"
        lblusernme.Size = New Size(67, 20)
        lblusernme.TabIndex = 3
        lblusernme.Text = "Username :"
        ' 
        ' lbllastnm
        ' 
        lbllastnm.AutoSize = True
        lbllastnm.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lbllastnm.ForeColor = SystemColors.ButtonHighlight
        lbllastnm.Location = New Point(230, 267)
        lbllastnm.Name = "lbllastnm"
        lbllastnm.Size = New Size(63, 20)
        lbllastnm.TabIndex = 4
        lbllastnm.Text = "Lastname :"
        ' 
        ' lblfirstnmn
        ' 
        lblfirstnmn.AutoSize = True
        lblfirstnmn.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblfirstnmn.ForeColor = SystemColors.ButtonHighlight
        lblfirstnmn.Location = New Point(230, 319)
        lblfirstnmn.Name = "lblfirstnmn"
        lblfirstnmn.Size = New Size(65, 20)
        lblfirstnmn.TabIndex = 5
        lblfirstnmn.Text = "Firstname :"
        ' 
        ' lblmiddlenm
        ' 
        lblmiddlenm.AutoSize = True
        lblmiddlenm.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblmiddlenm.ForeColor = SystemColors.ButtonHighlight
        lblmiddlenm.Location = New Point(230, 366)
        lblmiddlenm.Name = "lblmiddlenm"
        lblmiddlenm.Size = New Size(75, 20)
        lblmiddlenm.TabIndex = 6
        lblmiddlenm.Text = "Middlename :"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(320, 220)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(182, 26)
        txtUsername.TabIndex = 7
        ' 
        ' txtLastname
        ' 
        txtLastname.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtLastname.Location = New Point(321, 268)
        txtLastname.Name = "txtLastname"
        txtLastname.Size = New Size(182, 26)
        txtLastname.TabIndex = 8
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtFirstname.Location = New Point(320, 316)
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(182, 26)
        txtFirstname.TabIndex = 9
        ' 
        ' txtMiddlename
        ' 
        txtMiddlename.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtMiddlename.Location = New Point(321, 363)
        txtMiddlename.Name = "txtMiddlename"
        txtMiddlename.Size = New Size(182, 26)
        txtMiddlename.TabIndex = 10
        ' 
        ' btnregisteradmin
        ' 
        btnregisteradmin.BackgroundImage = CType(resources.GetObject("btnregisteradmin.BackgroundImage"), Image)
        btnregisteradmin.BackgroundImageLayout = ImageLayout.Stretch
        btnregisteradmin.FlatStyle = FlatStyle.Flat
        btnregisteradmin.Location = New Point(320, 447)
        btnregisteradmin.Name = "btnregisteradmin"
        btnregisteradmin.Size = New Size(120, 43)
        btnregisteradmin.TabIndex = 11
        btnregisteradmin.UseVisualStyleBackColor = True
        ' 
        ' Buttonx
        ' 
        Buttonx.BackgroundImage = CType(resources.GetObject("Buttonx.BackgroundImage"), Image)
        Buttonx.BackgroundImageLayout = ImageLayout.Stretch
        Buttonx.FlatStyle = FlatStyle.Flat
        Buttonx.Location = New Point(717, 12)
        Buttonx.Name = "Buttonx"
        Buttonx.Size = New Size(23, 18)
        Buttonx.TabIndex = 12
        Buttonx.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog2
        ' 
        OpenFileDialog2.FileName = "OpenFileDialog2"
        ' 
        ' lblAdminpass
        ' 
        lblAdminpass.AutoSize = True
        lblAdminpass.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblAdminpass.ForeColor = SystemColors.ButtonHighlight
        lblAdminpass.Location = New Point(230, 410)
        lblAdminpass.Name = "lblAdminpass"
        lblAdminpass.Size = New Size(69, 20)
        lblAdminpass.TabIndex = 13
        lblAdminpass.Text = "Password :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(321, 404)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 26)
        TextBox1.TabIndex = 14
        TextBox1.UseSystemPasswordChar = True
        ' 
        ' Registeradmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(778, 514)
        Controls.Add(TextBox1)
        Controls.Add(lblAdminpass)
        Controls.Add(Buttonx)
        Controls.Add(btnregisteradmin)
        Controls.Add(txtMiddlename)
        Controls.Add(txtFirstname)
        Controls.Add(txtLastname)
        Controls.Add(txtUsername)
        Controls.Add(lblmiddlenm)
        Controls.Add(lblfirstnmn)
        Controls.Add(lbllastnm)
        Controls.Add(lblusernme)
        Controls.Add(btnBrowse)
        Controls.Add(Admindefault)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Registeradmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registeradmin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Admindefault, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Admindefault As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblusernme As Label
    Friend WithEvents lbllastnm As Label
    Friend WithEvents lblfirstnmn As Label
    Friend WithEvents lblmiddlenm As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtMiddlename As TextBox
    Friend WithEvents btnregisteradmin As Button
    Friend WithEvents Buttonx As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents lblAdminpass As Label
    Friend WithEvents TextBox1 As TextBox
End Class
