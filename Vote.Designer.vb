<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vote
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Vote))
        exitbutton = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnNext = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        DataGridView5 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        btnvote = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' exitbutton
        ' 
        exitbutton.BackgroundImage = CType(resources.GetObject("exitbutton.BackgroundImage"), Image)
        exitbutton.BackgroundImageLayout = ImageLayout.Stretch
        exitbutton.FlatAppearance.BorderSize = 0
        exitbutton.FlatAppearance.MouseOverBackColor = Color.Black
        exitbutton.FlatStyle = FlatStyle.Flat
        exitbutton.ImeMode = ImeMode.NoControl
        exitbutton.Location = New Point(823, 7)
        exitbutton.Name = "exitbutton"
        exitbutton.Size = New Size(29, 17)
        exitbutton.TabIndex = 24
        exitbutton.Text = "  "
        exitbutton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Franklin Gothic Demi", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.DeepSkyBlue
        Label1.Location = New Point(12, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 24)
        Label1.TabIndex = 25
        Label1.Text = "CANDIDATES LIST"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        Panel1.Controls.Add(FlowLayoutPanel4)
        Panel1.Controls.Add(FlowLayoutPanel3)
        Panel1.Controls.Add(FlowLayoutPanel2)
        Panel1.Controls.Add(FlowLayoutPanel1)
        Panel1.Controls.Add(btnNext)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(12, 35)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(840, 283)
        Panel1.TabIndex = 26
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.Location = New Point(435, 33)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(382, 86)
        FlowLayoutPanel4.TabIndex = 29
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Location = New Point(25, 33)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(382, 86)
        FlowLayoutPanel3.TabIndex = 29
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Location = New Point(25, 160)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(382, 86)
        FlowLayoutPanel2.TabIndex = 29
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(435, 160)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(382, 86)
        FlowLayoutPanel1.TabIndex = 28
        ' 
        ' btnNext
        ' 
        btnNext.FlatAppearance.BorderSize = 0
        btnNext.FlatAppearance.MouseOverBackColor = Color.Black
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Font = New Font("Franklin Gothic Heavy", 9.75F, FontStyle.Italic, GraphicsUnit.Point)
        btnNext.ForeColor = Color.DeepSkyBlue
        btnNext.Location = New Point(731, 252)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(86, 21)
        btnNext.TabIndex = 10
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Gold
        Label5.Location = New Point(435, 137)
        Label5.Name = "Label5"
        Label5.Size = New Size(134, 20)
        Label5.TabIndex = 7
        Label5.Text = "Assistant secretary"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Gold
        Label4.Location = New Point(25, 137)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 20)
        Label4.TabIndex = 6
        Label4.Text = "Secretary"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Gold
        Label3.Location = New Point(435, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 20)
        Label3.TabIndex = 5
        Label3.Text = "Vice-President"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Gold
        Label2.Location = New Point(25, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 20)
        Label2.TabIndex = 4
        Label2.Text = "President"
        ' 
        ' DataGridView5
        ' 
        DataGridView5.AllowUserToAddRows = False
        DataGridView5.AllowUserToDeleteRows = False
        DataGridView5.BackgroundColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView5.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView5.GridColor = SystemColors.MenuHighlight
        DataGridView5.Location = New Point(12, 324)
        DataGridView5.Name = "DataGridView5"
        DataGridView5.ReadOnly = True
        DataGridView5.RowHeadersVisible = False
        DataGridView5.RowTemplate.Height = 25
        DataGridView5.Size = New Size(466, 98)
        DataGridView5.TabIndex = 27
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Name"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "Course"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 69
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Year"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 54
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Position"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 75
        ' 
        ' btnvote
        ' 
        btnvote.BackgroundImage = CType(resources.GetObject("btnvote.BackgroundImage"), Image)
        btnvote.BackgroundImageLayout = ImageLayout.Stretch
        btnvote.FlatAppearance.BorderSize = 0
        btnvote.FlatAppearance.MouseOverBackColor = Color.Lime
        btnvote.FlatStyle = FlatStyle.Flat
        btnvote.Location = New Point(493, 338)
        btnvote.Name = "btnvote"
        btnvote.Size = New Size(208, 84)
        btnvote.TabIndex = 28
        btnvote.UseVisualStyleBackColor = True
        ' 
        ' Vote
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        ClientSize = New Size(864, 434)
        Controls.Add(btnvote)
        Controls.Add(DataGridView5)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(exitbutton)
        FormBorderStyle = FormBorderStyle.None
        Name = "Vote"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Vote"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents exitbutton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btnvote As Button
End Class
