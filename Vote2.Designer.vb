<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vote2
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
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnPrev = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Gold
        Label2.Location = New Point(23, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 14
        Label2.Text = "Treasurer"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(23, 129)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 15
        Label1.Text = "Auditor"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Gold
        Label3.Location = New Point(432, 6)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 20)
        Label3.TabIndex = 16
        Label3.Text = "Assistant Treasurer"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Franklin Gothic Demi", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Gold
        Label4.Location = New Point(432, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 20)
        Label4.TabIndex = 17
        Label4.Text = "Assistant Auditor"
        ' 
        ' btnPrev
        ' 
        btnPrev.FlatAppearance.BorderSize = 0
        btnPrev.FlatAppearance.MouseOverBackColor = Color.Black
        btnPrev.FlatStyle = FlatStyle.Flat
        btnPrev.Font = New Font("Franklin Gothic Demi", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnPrev.ForeColor = Color.DeepSkyBlue
        btnPrev.Location = New Point(728, 244)
        btnPrev.Name = "btnPrev"
        btnPrev.Size = New Size(86, 21)
        btnPrev.TabIndex = 18
        btnPrev.Text = "Back"
        btnPrev.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(23, 29)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(382, 86)
        FlowLayoutPanel1.TabIndex = 29
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Location = New Point(23, 152)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(382, 86)
        FlowLayoutPanel2.TabIndex = 29
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Location = New Point(432, 29)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(382, 86)
        FlowLayoutPanel3.TabIndex = 29
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.Location = New Point(432, 152)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(382, 86)
        FlowLayoutPanel4.TabIndex = 29
        ' 
        ' Vote2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Red
        ClientSize = New Size(840, 272)
        Controls.Add(FlowLayoutPanel4)
        Controls.Add(FlowLayoutPanel3)
        Controls.Add(FlowLayoutPanel2)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(btnPrev)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        ForeColor = SystemColors.ActiveBorder
        FormBorderStyle = FormBorderStyle.None
        Name = "Vote2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Vote2"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPrev As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
End Class
