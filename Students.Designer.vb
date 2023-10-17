<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Students
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Students))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        tabAddstudent = New TabControl()
        tabStudentList = New TabPage()
        lblTotalRecord = New Label()
        exitbutton = New Button()
        chckAutoComplete = New CheckBox()
        btnSearch = New Button()
        cmbFilter = New ComboBox()
        txtSearch = New TextBox()
        Label4 = New Label()
        lblTotalRecords = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        TabPage2 = New TabPage()
        xbtn = New Button()
        TxtMiddlenm = New TextBox()
        Label9 = New Label()
        btnAddstudent = New Button()
        cmbYearlevel = New ComboBox()
        cmbCourse = New ComboBox()
        cmbGender = New ComboBox()
        txtFirstnm = New TextBox()
        txtLastnm = New TextBox()
        txtStudentid = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        browsebtn = New Button()
        StudentDefault = New PictureBox()
        OpenFileDialog3 = New OpenFileDialog()
        tabAddstudent.SuspendLayout()
        tabStudentList.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(StudentDefault, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tabAddstudent
        ' 
        tabAddstudent.Controls.Add(tabStudentList)
        tabAddstudent.Controls.Add(TabPage2)
        resources.ApplyResources(tabAddstudent, "tabAddstudent")
        tabAddstudent.Name = "tabAddstudent"
        tabAddstudent.SelectedIndex = 0
        tabAddstudent.Tag = ""
        ' 
        ' tabStudentList
        ' 
        tabStudentList.BackColor = Color.Black
        tabStudentList.Controls.Add(lblTotalRecord)
        tabStudentList.Controls.Add(exitbutton)
        tabStudentList.Controls.Add(chckAutoComplete)
        tabStudentList.Controls.Add(btnSearch)
        tabStudentList.Controls.Add(cmbFilter)
        tabStudentList.Controls.Add(txtSearch)
        tabStudentList.Controls.Add(Label4)
        tabStudentList.Controls.Add(lblTotalRecords)
        tabStudentList.Controls.Add(DataGridView1)
        resources.ApplyResources(tabStudentList, "tabStudentList")
        tabStudentList.Name = "tabStudentList"
        ' 
        ' lblTotalRecord
        ' 
        resources.ApplyResources(lblTotalRecord, "lblTotalRecord")
        lblTotalRecord.ForeColor = SystemColors.ButtonHighlight
        lblTotalRecord.Name = "lblTotalRecord"
        ' 
        ' exitbutton
        ' 
        resources.ApplyResources(exitbutton, "exitbutton")
        exitbutton.Name = "exitbutton"
        exitbutton.UseVisualStyleBackColor = True
        ' 
        ' chckAutoComplete
        ' 
        resources.ApplyResources(chckAutoComplete, "chckAutoComplete")
        chckAutoComplete.ForeColor = SystemColors.ButtonHighlight
        chckAutoComplete.Name = "chckAutoComplete"
        chckAutoComplete.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        resources.ApplyResources(btnSearch, "btnSearch")
        btnSearch.Name = "btnSearch"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' cmbFilter
        ' 
        resources.ApplyResources(cmbFilter, "cmbFilter")
        cmbFilter.FormattingEnabled = True
        cmbFilter.Items.AddRange(New Object() {resources.GetString("cmbFilter.Items"), resources.GetString("cmbFilter.Items1"), resources.GetString("cmbFilter.Items2"), resources.GetString("cmbFilter.Items3"), resources.GetString("cmbFilter.Items4"), resources.GetString("cmbFilter.Items5"), resources.GetString("cmbFilter.Items6")})
        cmbFilter.Name = "cmbFilter"
        ' 
        ' txtSearch
        ' 
        resources.ApplyResources(txtSearch, "txtSearch")
        txtSearch.Name = "txtSearch"
        ' 
        ' Label4
        ' 
        resources.ApplyResources(Label4, "Label4")
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Name = "Label4"
        ' 
        ' lblTotalRecords
        ' 
        resources.ApplyResources(lblTotalRecords, "lblTotalRecords")
        lblTotalRecords.Name = "lblTotalRecords"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column7, Column8, Column9})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(DataGridView1, "DataGridView1")
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        ' 
        ' Column1
        ' 
        resources.ApplyResources(Column1, "Column1")
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        resources.ApplyResources(Column2, "Column2")
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        resources.ApplyResources(Column3, "Column3")
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        resources.ApplyResources(Column4, "Column4")
        Column4.Name = "Column4"
        ' 
        ' Column7
        ' 
        resources.ApplyResources(Column7, "Column7")
        Column7.Name = "Column7"
        ' 
        ' Column8
        ' 
        resources.ApplyResources(Column8, "Column8")
        Column8.Name = "Column8"
        ' 
        ' Column9
        ' 
        resources.ApplyResources(Column9, "Column9")
        Column9.Name = "Column9"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Black
        TabPage2.Controls.Add(xbtn)
        TabPage2.Controls.Add(TxtMiddlenm)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(btnAddstudent)
        TabPage2.Controls.Add(cmbYearlevel)
        TabPage2.Controls.Add(cmbCourse)
        TabPage2.Controls.Add(cmbGender)
        TabPage2.Controls.Add(txtFirstnm)
        TabPage2.Controls.Add(txtLastnm)
        TabPage2.Controls.Add(txtStudentid)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(Label1)
        TabPage2.Controls.Add(browsebtn)
        TabPage2.Controls.Add(StudentDefault)
        resources.ApplyResources(TabPage2, "TabPage2")
        TabPage2.Name = "TabPage2"
        ' 
        ' xbtn
        ' 
        resources.ApplyResources(xbtn, "xbtn")
        xbtn.Name = "xbtn"
        xbtn.UseVisualStyleBackColor = True
        ' 
        ' TxtMiddlenm
        ' 
        resources.ApplyResources(TxtMiddlenm, "TxtMiddlenm")
        TxtMiddlenm.Name = "TxtMiddlenm"
        ' 
        ' Label9
        ' 
        resources.ApplyResources(Label9, "Label9")
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Name = "Label9"
        ' 
        ' btnAddstudent
        ' 
        resources.ApplyResources(btnAddstudent, "btnAddstudent")
        btnAddstudent.Name = "btnAddstudent"
        btnAddstudent.UseVisualStyleBackColor = True
        ' 
        ' cmbYearlevel
        ' 
        resources.ApplyResources(cmbYearlevel, "cmbYearlevel")
        cmbYearlevel.FormattingEnabled = True
        cmbYearlevel.Items.AddRange(New Object() {resources.GetString("cmbYearlevel.Items"), resources.GetString("cmbYearlevel.Items1"), resources.GetString("cmbYearlevel.Items2"), resources.GetString("cmbYearlevel.Items3")})
        cmbYearlevel.Name = "cmbYearlevel"
        ' 
        ' cmbCourse
        ' 
        resources.ApplyResources(cmbCourse, "cmbCourse")
        cmbCourse.FormattingEnabled = True
        cmbCourse.Items.AddRange(New Object() {resources.GetString("cmbCourse.Items"), resources.GetString("cmbCourse.Items1"), resources.GetString("cmbCourse.Items2"), resources.GetString("cmbCourse.Items3")})
        cmbCourse.Name = "cmbCourse"
        ' 
        ' cmbGender
        ' 
        resources.ApplyResources(cmbGender, "cmbGender")
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {resources.GetString("cmbGender.Items"), resources.GetString("cmbGender.Items1")})
        cmbGender.Name = "cmbGender"
        ' 
        ' txtFirstnm
        ' 
        resources.ApplyResources(txtFirstnm, "txtFirstnm")
        txtFirstnm.Name = "txtFirstnm"
        ' 
        ' txtLastnm
        ' 
        resources.ApplyResources(txtLastnm, "txtLastnm")
        txtLastnm.Name = "txtLastnm"
        ' 
        ' txtStudentid
        ' 
        resources.ApplyResources(txtStudentid, "txtStudentid")
        txtStudentid.Name = "txtStudentid"
        ' 
        ' Label8
        ' 
        resources.ApplyResources(Label8, "Label8")
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Name = "Label8"
        ' 
        ' Label7
        ' 
        resources.ApplyResources(Label7, "Label7")
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Name = "Label7"
        ' 
        ' Label6
        ' 
        resources.ApplyResources(Label6, "Label6")
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Name = "Label6"
        ' 
        ' Label3
        ' 
        resources.ApplyResources(Label3, "Label3")
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Name = "Label3"
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Name = "Label2"
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Name = "Label1"
        ' 
        ' browsebtn
        ' 
        resources.ApplyResources(browsebtn, "browsebtn")
        browsebtn.Name = "browsebtn"
        browsebtn.UseVisualStyleBackColor = True
        ' 
        ' StudentDefault
        ' 
        resources.ApplyResources(StudentDefault, "StudentDefault")
        StudentDefault.Name = "StudentDefault"
        StudentDefault.TabStop = False
        ' 
        ' OpenFileDialog3
        ' 
        OpenFileDialog3.FileName = "OpenFileDialog3"
        ' 
        ' Students
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(29), CByte(29), CByte(29))
        Controls.Add(tabAddstudent)
        ForeColor = SystemColors.ActiveCaptionText
        FormBorderStyle = FormBorderStyle.None
        Name = "Students"
        tabAddstudent.ResumeLayout(False)
        tabStudentList.ResumeLayout(False)
        tabStudentList.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(StudentDefault, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents tabAddstudent As TabControl
    Friend WithEvents tabStudentList As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents StudentDefault As PictureBox
    Friend WithEvents browsebtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbYearlevel As ComboBox
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents txtFirstnm As TextBox
    Friend WithEvents txtLastnm As TextBox
    Friend WithEvents txtStudentid As TextBox
    Friend WithEvents btnAddstudent As Button
    Friend WithEvents OpenFileDialog3 As OpenFileDialog
    Friend WithEvents TxtMiddlenm As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents xbtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblTotalRecords As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents chckAutoComplete As CheckBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents exitbutton As Button
    Friend WithEvents lblTotalRecord As Label
End Class
