<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudent
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(AddStudent))
        StudentDefault = New PictureBox()
        browsebtn = New Button()
        xbtn = New Button()
        lblStudentID = New Label()
        lblLastname = New Label()
        lblFirstname = New Label()
        lblMiddlename = New Label()
        lblGender = New Label()
        lblCourse = New Label()
        lblYearlevel = New Label()
        txtStudentID = New TextBox()
        txtLastname = New TextBox()
        txtFirstname = New TextBox()
        txtMiddlename = New TextBox()
        cmbGender = New ComboBox()
        cmbCourse = New ComboBox()
        cmbYearlevel = New ComboBox()
        btnAddstudent = New Button()
        CType(StudentDefault, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' StudentDefault
        ' 
        StudentDefault.Image = CType(resources.GetObject("StudentDefault.Image"), Image)
        StudentDefault.Location = New Point(219, 55)
        StudentDefault.Name = "StudentDefault"
        StudentDefault.Size = New Size(116, 106)
        StudentDefault.SizeMode = PictureBoxSizeMode.StretchImage
        StudentDefault.TabIndex = 1
        StudentDefault.TabStop = False
        ' 
        ' browsebtn
        ' 
        browsebtn.BackgroundImage = CType(resources.GetObject("browsebtn.BackgroundImage"), Image)
        browsebtn.BackgroundImageLayout = ImageLayout.Stretch
        browsebtn.FlatAppearance.MouseOverBackColor = Color.Blue
        browsebtn.FlatStyle = FlatStyle.Flat
        browsebtn.Location = New Point(354, 124)
        browsebtn.Name = "browsebtn"
        browsebtn.Size = New Size(72, 37)
        browsebtn.TabIndex = 2
        browsebtn.UseVisualStyleBackColor = True
        ' 
        ' xbtn
        ' 
        xbtn.BackgroundImage = CType(resources.GetObject("xbtn.BackgroundImage"), Image)
        xbtn.BackgroundImageLayout = ImageLayout.Stretch
        xbtn.FlatStyle = FlatStyle.Flat
        xbtn.Location = New Point(564, 12)
        xbtn.Name = "xbtn"
        xbtn.Size = New Size(29, 22)
        xbtn.TabIndex = 23
        xbtn.UseVisualStyleBackColor = True
        ' 
        ' lblStudentID
        ' 
        lblStudentID.AutoSize = True
        lblStudentID.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblStudentID.ForeColor = SystemColors.ButtonHighlight
        lblStudentID.Location = New Point(81, 196)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(66, 20)
        lblStudentID.TabIndex = 24
        lblStudentID.Text = "Student ID :"
        ' 
        ' lblLastname
        ' 
        lblLastname.AutoSize = True
        lblLastname.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblLastname.ForeColor = SystemColors.ButtonHighlight
        lblLastname.Location = New Point(81, 236)
        lblLastname.Name = "lblLastname"
        lblLastname.Size = New Size(63, 20)
        lblLastname.TabIndex = 25
        lblLastname.Text = "Lastname :"
        ' 
        ' lblFirstname
        ' 
        lblFirstname.AutoSize = True
        lblFirstname.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblFirstname.ForeColor = SystemColors.ButtonHighlight
        lblFirstname.Location = New Point(81, 285)
        lblFirstname.Name = "lblFirstname"
        lblFirstname.Size = New Size(65, 20)
        lblFirstname.TabIndex = 26
        lblFirstname.Text = "Firstname :"
        ' 
        ' lblMiddlename
        ' 
        lblMiddlename.AutoSize = True
        lblMiddlename.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblMiddlename.ForeColor = SystemColors.ButtonHighlight
        lblMiddlename.Location = New Point(81, 330)
        lblMiddlename.Name = "lblMiddlename"
        lblMiddlename.Size = New Size(78, 20)
        lblMiddlename.TabIndex = 27
        lblMiddlename.Text = "Middlename : "
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblGender.ForeColor = SystemColors.ButtonHighlight
        lblGender.Location = New Point(315, 196)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(52, 20)
        lblGender.TabIndex = 28
        lblGender.Text = "Gender :"
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblCourse.ForeColor = SystemColors.ButtonHighlight
        lblCourse.Location = New Point(315, 241)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(52, 20)
        lblCourse.TabIndex = 29
        lblCourse.Text = "Course :"
        ' 
        ' lblYearlevel
        ' 
        lblYearlevel.AutoSize = True
        lblYearlevel.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblYearlevel.ForeColor = SystemColors.ButtonHighlight
        lblYearlevel.Location = New Point(315, 285)
        lblYearlevel.Name = "lblYearlevel"
        lblYearlevel.Size = New Size(68, 20)
        lblYearlevel.TabIndex = 30
        lblYearlevel.Text = "Year level :"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Font = New Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtStudentID.Location = New Point(153, 193)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(128, 25)
        txtStudentID.TabIndex = 31
        ' 
        ' txtLastname
        ' 
        txtLastname.Font = New Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtLastname.Location = New Point(153, 236)
        txtLastname.Name = "txtLastname"
        txtLastname.Size = New Size(128, 25)
        txtLastname.TabIndex = 32
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Font = New Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtFirstname.Location = New Point(153, 282)
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(128, 25)
        txtFirstname.TabIndex = 33
        ' 
        ' txtMiddlename
        ' 
        txtMiddlename.Font = New Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtMiddlename.Location = New Point(153, 327)
        txtMiddlename.Name = "txtMiddlename"
        txtMiddlename.Size = New Size(128, 25)
        txtMiddlename.TabIndex = 34
        ' 
        ' cmbGender
        ' 
        cmbGender.Font = New Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Female", "Male"})
        cmbGender.Location = New Point(389, 193)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(139, 25)
        cmbGender.TabIndex = 35
        ' 
        ' cmbCourse
        ' 
        cmbCourse.Font = New Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmbCourse.FormattingEnabled = True
        cmbCourse.Items.AddRange(New Object() {"Computer Science", "Psychology", "IT", "AB English"})
        cmbCourse.Location = New Point(389, 239)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(139, 25)
        cmbCourse.TabIndex = 36
        ' 
        ' cmbYearlevel
        ' 
        cmbYearlevel.Font = New Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cmbYearlevel.FormattingEnabled = True
        cmbYearlevel.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th year"})
        cmbYearlevel.Location = New Point(389, 282)
        cmbYearlevel.Name = "cmbYearlevel"
        cmbYearlevel.Size = New Size(139, 25)
        cmbYearlevel.TabIndex = 37
        ' 
        ' btnAddstudent
        ' 
        btnAddstudent.BackgroundImage = CType(resources.GetObject("btnAddstudent.BackgroundImage"), Image)
        btnAddstudent.BackgroundImageLayout = ImageLayout.Stretch
        btnAddstudent.FlatAppearance.MouseOverBackColor = Color.Blue
        btnAddstudent.FlatStyle = FlatStyle.Flat
        btnAddstudent.Location = New Point(246, 374)
        btnAddstudent.Name = "btnAddstudent"
        btnAddstudent.Size = New Size(89, 44)
        btnAddstudent.TabIndex = 38
        btnAddstudent.UseVisualStyleBackColor = True
        ' 
        ' AddStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(605, 487)
        Controls.Add(btnAddstudent)
        Controls.Add(cmbYearlevel)
        Controls.Add(cmbCourse)
        Controls.Add(cmbGender)
        Controls.Add(txtMiddlename)
        Controls.Add(txtFirstname)
        Controls.Add(txtLastname)
        Controls.Add(txtStudentID)
        Controls.Add(lblYearlevel)
        Controls.Add(lblCourse)
        Controls.Add(lblGender)
        Controls.Add(lblMiddlename)
        Controls.Add(lblFirstname)
        Controls.Add(lblLastname)
        Controls.Add(lblStudentID)
        Controls.Add(xbtn)
        Controls.Add(browsebtn)
        Controls.Add(StudentDefault)
        FormBorderStyle = FormBorderStyle.None
        Location = New Point(470, 170)
        Name = "AddStudent"
        StartPosition = FormStartPosition.Manual
        Text = "AddStudent"
        CType(StudentDefault, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StudentDefault As PictureBox
    Friend WithEvents browsebtn As Button
    Friend WithEvents xbtn As Button
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblLastname As Label
    Friend WithEvents lblFirstname As Label
    Friend WithEvents lblMiddlename As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblYearlevel As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtMiddlename As TextBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents cmbYearlevel As ComboBox
    Friend WithEvents btnAddstudent As Button
End Class
