<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addcandidate
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Addcandidate))
        PictureBox1 = New PictureBox()
        Candidatedefault = New PictureBox()
        Buttonbrowse = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtStudid = New TextBox()
        txtLastname = New TextBox()
        txtFirstname = New TextBox()
        txtMiddlename = New TextBox()
        cmbPosition = New ComboBox()
        cmbCourse = New ComboBox()
        cmbYearlevel = New ComboBox()
        btnRegisterCandidate = New Button()
        btnExit = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Candidatedefault, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(252, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(221, 57)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Candidatedefault
        ' 
        Candidatedefault.Image = CType(resources.GetObject("Candidatedefault.Image"), Image)
        Candidatedefault.Location = New Point(304, 84)
        Candidatedefault.Name = "Candidatedefault"
        Candidatedefault.Size = New Size(118, 111)
        Candidatedefault.SizeMode = PictureBoxSizeMode.StretchImage
        Candidatedefault.TabIndex = 1
        Candidatedefault.TabStop = False
        ' 
        ' Buttonbrowse
        ' 
        Buttonbrowse.BackgroundImage = CType(resources.GetObject("Buttonbrowse.BackgroundImage"), Image)
        Buttonbrowse.BackgroundImageLayout = ImageLayout.Stretch
        Buttonbrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Buttonbrowse.FlatStyle = FlatStyle.Flat
        Buttonbrowse.Location = New Point(428, 151)
        Buttonbrowse.Name = "Buttonbrowse"
        Buttonbrowse.Size = New Size(86, 44)
        Buttonbrowse.TabIndex = 2
        Buttonbrowse.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(91, 233)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 20)
        Label1.TabIndex = 3
        Label1.Text = "Student ID :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(91, 280)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 20)
        Label2.TabIndex = 4
        Label2.Text = "Lastname :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(91, 327)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 20)
        Label3.TabIndex = 5
        Label3.Text = "Firstname :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(91, 378)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 20)
        Label4.TabIndex = 6
        Label4.Text = "Middlename :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(428, 233)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 20)
        Label5.TabIndex = 7
        Label5.Text = "Position :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(427, 280)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 20)
        Label6.TabIndex = 8
        Label6.Text = "Course :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(427, 327)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 20)
        Label7.TabIndex = 9
        Label7.Text = "Year level :"
        ' 
        ' txtStudid
        ' 
        txtStudid.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtStudid.Location = New Point(180, 230)
        txtStudid.Name = "txtStudid"
        txtStudid.Size = New Size(189, 26)
        txtStudid.TabIndex = 10
        ' 
        ' txtLastname
        ' 
        txtLastname.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtLastname.Location = New Point(180, 280)
        txtLastname.Name = "txtLastname"
        txtLastname.Size = New Size(189, 26)
        txtLastname.TabIndex = 11
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtFirstname.Location = New Point(180, 328)
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(189, 26)
        txtFirstname.TabIndex = 12
        ' 
        ' txtMiddlename
        ' 
        txtMiddlename.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtMiddlename.Location = New Point(180, 378)
        txtMiddlename.Name = "txtMiddlename"
        txtMiddlename.Size = New Size(189, 26)
        txtMiddlename.TabIndex = 13
        ' 
        ' cmbPosition
        ' 
        cmbPosition.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmbPosition.FormattingEnabled = True
        cmbPosition.Items.AddRange(New Object() {"President", "Vice President", "Secretary", "Assistan Secretary", "Treasurer", "Assistant Treasurer", "Auditor", "Assistant Auditor", "P.I.O"})
        cmbPosition.Location = New Point(501, 230)
        cmbPosition.Name = "cmbPosition"
        cmbPosition.Size = New Size(187, 29)
        cmbPosition.TabIndex = 14
        ' 
        ' cmbCourse
        ' 
        cmbCourse.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmbCourse.FormattingEnabled = True
        cmbCourse.Items.AddRange(New Object() {"Computer Science", "Psychology", "AB English", "IT"})
        cmbCourse.Location = New Point(501, 280)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(187, 29)
        cmbCourse.TabIndex = 15
        ' 
        ' cmbYearlevel
        ' 
        cmbYearlevel.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmbYearlevel.FormattingEnabled = True
        cmbYearlevel.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        cmbYearlevel.Location = New Point(501, 324)
        cmbYearlevel.Name = "cmbYearlevel"
        cmbYearlevel.Size = New Size(187, 29)
        cmbYearlevel.TabIndex = 16
        ' 
        ' btnRegisterCandidate
        ' 
        btnRegisterCandidate.BackgroundImage = CType(resources.GetObject("btnRegisterCandidate.BackgroundImage"), Image)
        btnRegisterCandidate.BackgroundImageLayout = ImageLayout.Stretch
        btnRegisterCandidate.FlatAppearance.MouseOverBackColor = Color.Fuchsia
        btnRegisterCandidate.FlatStyle = FlatStyle.Flat
        btnRegisterCandidate.Location = New Point(313, 436)
        btnRegisterCandidate.Name = "btnRegisterCandidate"
        btnRegisterCandidate.Size = New Size(109, 44)
        btnRegisterCandidate.TabIndex = 17
        btnRegisterCandidate.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), Image)
        btnExit.BackgroundImageLayout = ImageLayout.Stretch
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(717, 12)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(23, 20)
        btnExit.TabIndex = 18
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Addcandidate
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(778, 514)
        Controls.Add(btnExit)
        Controls.Add(btnRegisterCandidate)
        Controls.Add(cmbYearlevel)
        Controls.Add(cmbCourse)
        Controls.Add(cmbPosition)
        Controls.Add(txtMiddlename)
        Controls.Add(txtFirstname)
        Controls.Add(txtLastname)
        Controls.Add(txtStudid)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Buttonbrowse)
        Controls.Add(Candidatedefault)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Addcandidate"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Addcandidate"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Candidatedefault, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Candidatedefault As PictureBox
    Friend WithEvents Buttonbrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStudid As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtMiddlename As TextBox
    Friend WithEvents cmbPosition As ComboBox
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents cmbYearlevel As ComboBox
    Friend WithEvents btnRegisterCandidate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
