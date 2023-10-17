<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class adminlogin
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
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents OK As Button
    Friend WithEvents Cancel As Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(adminlogin))
        LogoPictureBox = New PictureBox()
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        UsernameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        OK = New Button()
        Cancel = New Button()
        PictureBox1 = New PictureBox()
        passwordbox = New CheckBox()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.BackColor = SystemColors.ActiveCaptionText
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(141, 83)
        LogoPictureBox.Name = "LogoPictureBox"
        LogoPictureBox.Size = New Size(130, 119)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        LogoPictureBox.TabIndex = 0
        LogoPictureBox.TabStop = False
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Font = New Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point)
        UsernameLabel.ForeColor = SystemColors.ButtonHighlight
        UsernameLabel.Location = New Point(81, 205)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(220, 25)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "&User name"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Font = New Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PasswordLabel.ForeColor = SystemColors.ButtonHighlight
        PasswordLabel.Location = New Point(81, 262)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(220, 25)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "&Password"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point)
        UsernameTextBox.Location = New Point(83, 233)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(220, 26)
        UsernameTextBox.TabIndex = 1
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Font = New Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PasswordTextBox.Location = New Point(83, 282)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(220, 26)
        PasswordTextBox.TabIndex = 3
        ' 
        ' OK
        ' 
        OK.BackgroundImage = CType(resources.GetObject("OK.BackgroundImage"), Image)
        OK.BackgroundImageLayout = ImageLayout.Stretch
        OK.FlatAppearance.MouseOverBackColor = Color.Green
        OK.FlatStyle = FlatStyle.Flat
        OK.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        OK.Location = New Point(106, 333)
        OK.Name = "OK"
        OK.Size = New Size(94, 34)
        OK.TabIndex = 4
        OK.Text = "&OK"
        ' 
        ' Cancel
        ' 
        Cancel.BackgroundImage = CType(resources.GetObject("Cancel.BackgroundImage"), Image)
        Cancel.BackgroundImageLayout = ImageLayout.Stretch
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.FlatAppearance.MouseOverBackColor = Color.Green
        Cancel.FlatStyle = FlatStyle.Flat
        Cancel.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Cancel.Location = New Point(209, 333)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 34)
        Cancel.TabIndex = 5
        Cancel.Text = "&Cancel"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(81, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(240, 56)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' passwordbox
        ' 
        passwordbox.AutoSize = True
        passwordbox.Location = New Point(326, 287)
        passwordbox.Name = "passwordbox"
        passwordbox.Size = New Size(85, 19)
        passwordbox.TabIndex = 7
        passwordbox.Text = "CheckBox1"
        passwordbox.UseVisualStyleBackColor = True
        ' 
        ' adminlogin
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = Cancel
        ClientSize = New Size(401, 390)
        Controls.Add(passwordbox)
        Controls.Add(PictureBox1)
        Controls.Add(Cancel)
        Controls.Add(OK)
        Controls.Add(PasswordTextBox)
        Controls.Add(UsernameTextBox)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        Controls.Add(LogoPictureBox)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "adminlogin"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "adminlogin"
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents passwordbox As CheckBox
End Class
