<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SystemMnagement
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SystemMnagement))
        Panel1 = New Panel()
        btnExit = New Button()
        btnResult = New Button()
        btnStudents = New Button()
        btbAddCandidate = New Button()
        btnAddadmin = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        lblDate = New Label()
        lblTime = New Label()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(btnResult)
        Panel1.Controls.Add(btnStudents)
        Panel1.Controls.Add(btbAddCandidate)
        Panel1.Controls.Add(btnAddadmin)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(798, 102)
        Panel1.TabIndex = 0
        ' 
        ' btnExit
        ' 
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnExit.ForeColor = SystemColors.ButtonHighlight
        btnExit.Location = New Point(673, 38)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(90, 50)
        btnExit.TabIndex = 5
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnResult
        ' 
        btnResult.FlatAppearance.BorderSize = 0
        btnResult.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnResult.FlatStyle = FlatStyle.Flat
        btnResult.Font = New Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnResult.ForeColor = SystemColors.ButtonHighlight
        btnResult.Location = New Point(555, 38)
        btnResult.Name = "btnResult"
        btnResult.Size = New Size(90, 50)
        btnResult.TabIndex = 4
        btnResult.Text = "Result"
        btnResult.UseVisualStyleBackColor = True
        ' 
        ' btnStudents
        ' 
        btnStudents.FlatAppearance.BorderSize = 0
        btnStudents.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnStudents.FlatStyle = FlatStyle.Flat
        btnStudents.Font = New Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnStudents.ForeColor = SystemColors.ButtonHighlight
        btnStudents.Location = New Point(419, 38)
        btnStudents.Name = "btnStudents"
        btnStudents.Size = New Size(90, 50)
        btnStudents.TabIndex = 3
        btnStudents.Text = "Students"
        btnStudents.UseVisualStyleBackColor = True
        ' 
        ' btbAddCandidate
        ' 
        btbAddCandidate.FlatAppearance.BorderSize = 0
        btbAddCandidate.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btbAddCandidate.FlatStyle = FlatStyle.Flat
        btbAddCandidate.Font = New Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btbAddCandidate.ForeColor = SystemColors.ButtonHighlight
        btbAddCandidate.Location = New Point(281, 27)
        btbAddCandidate.Name = "btbAddCandidate"
        btbAddCandidate.Size = New Size(90, 61)
        btbAddCandidate.TabIndex = 2
        btbAddCandidate.Text = "Add candidate"
        btbAddCandidate.UseVisualStyleBackColor = True
        ' 
        ' btnAddadmin
        ' 
        btnAddadmin.FlatAppearance.BorderSize = 0
        btnAddadmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnAddadmin.FlatStyle = FlatStyle.Flat
        btnAddadmin.Font = New Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddadmin.ForeColor = SystemColors.ButtonHighlight
        btnAddadmin.Location = New Point(141, 27)
        btnAddadmin.Name = "btnAddadmin"
        btnAddadmin.Size = New Size(90, 61)
        btnAddadmin.TabIndex = 1
        btnAddadmin.Text = "Add an admin"
        btnAddadmin.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(24, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(68, 65)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblDate)
        Panel2.Controls.Add(lblTime)
        Panel2.Location = New Point(9, 108)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(780, 520)
        Panel2.TabIndex = 1
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Franklin Gothic Demi", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblDate.ForeColor = Color.DeepSkyBlue
        lblDate.Location = New Point(299, 224)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(96, 34)
        lblDate.TabIndex = 1
        lblDate.Text = "Label2"
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Franklin Gothic Demi", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblTime.ForeColor = Color.DeepSkyBlue
        lblTime.Location = New Point(299, 172)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(130, 43)
        lblTime.TabIndex = 0
        lblTime.Text = "Label1"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' SystemMnagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        ClientSize = New Size(798, 633)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SystemMnagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SystemMnagement"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAddadmin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnResult As Button
    Friend WithEvents btnStudents As Button
    Friend WithEvents btbAddCandidate As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
End Class
