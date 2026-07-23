<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.txtDaysWork = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOTHours = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDailyRate1 = New System.Windows.Forms.Label()
        Me.lblHourlyRate1 = New System.Windows.Forms.Label()
        Me.lblGrossPay1 = New System.Windows.Forms.Label()
        Me.lblOvertimePay1 = New System.Windows.Forms.Label()
        Me.lblTotalEarnings1 = New System.Windows.Forms.Label()
        Me.lblSSSDeductions1 = New System.Windows.Forms.Label()
        Me.lblPhDeduction1 = New System.Windows.Forms.Label()
        Me.lblPagibigDeduction1 = New System.Windows.Forms.Label()
        Me.lblTaxDeduction1 = New System.Windows.Forms.Label()
        Me.lblTotalDeduction1 = New System.Windows.Forms.Label()
        Me.lblNetPay1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Location = New System.Drawing.Point(179, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Details"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Location = New System.Drawing.Point(243, 76)
        Me.txtEmployeeName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(68, 20)
        Me.txtEmployeeName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label2.Location = New System.Drawing.Point(151, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Employee Name: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label3.Location = New System.Drawing.Point(171, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Department: "
        '
        'cmbDepartment
        '
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Items.AddRange(New Object() {"HR", "IT", "Accounting", "Sales"})
        Me.cmbDepartment.Location = New System.Drawing.Point(243, 111)
        Me.cmbDepartment.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(82, 21)
        Me.cmbDepartment.TabIndex = 4
        '
        'txtDaysWork
        '
        Me.txtDaysWork.Location = New System.Drawing.Point(243, 145)
        Me.txtDaysWork.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDaysWork.Name = "txtDaysWork"
        Me.txtDaysWork.Size = New System.Drawing.Size(68, 20)
        Me.txtDaysWork.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(165, 147)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Days Worked: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label5.Location = New System.Drawing.Point(155, 183)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Overtime Hours: "
        '
        'txtOTHours
        '
        Me.txtOTHours.Location = New System.Drawing.Point(243, 181)
        Me.txtOTHours.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtOTHours.Name = "txtOTHours"
        Me.txtOTHours.Size = New System.Drawing.Size(68, 20)
        Me.txtOTHours.TabIndex = 8
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(168, 230)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 24)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate Payroll"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(307, 231)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(55, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(307, 273)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(55, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDailyRate1
        '
        Me.lblDailyRate1.AutoSize = True
        Me.lblDailyRate1.Location = New System.Drawing.Point(8, 14)
        Me.lblDailyRate1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDailyRate1.Name = "lblDailyRate1"
        Me.lblDailyRate1.Size = New System.Drawing.Size(0, 13)
        Me.lblDailyRate1.TabIndex = 12
        Me.lblDailyRate1.UseWaitCursor = True
        Me.lblDailyRate1.Visible = False
        '
        'lblHourlyRate1
        '
        Me.lblHourlyRate1.AutoSize = True
        Me.lblHourlyRate1.Location = New System.Drawing.Point(30, 94)
        Me.lblHourlyRate1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHourlyRate1.Name = "lblHourlyRate1"
        Me.lblHourlyRate1.Size = New System.Drawing.Size(0, 13)
        Me.lblHourlyRate1.TabIndex = 13
        Me.lblHourlyRate1.Visible = False
        '
        'lblGrossPay1
        '
        Me.lblGrossPay1.AutoSize = True
        Me.lblGrossPay1.Location = New System.Drawing.Point(30, 126)
        Me.lblGrossPay1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGrossPay1.Name = "lblGrossPay1"
        Me.lblGrossPay1.Size = New System.Drawing.Size(0, 13)
        Me.lblGrossPay1.TabIndex = 14
        Me.lblGrossPay1.Visible = False
        '
        'lblOvertimePay1
        '
        Me.lblOvertimePay1.AutoSize = True
        Me.lblOvertimePay1.Location = New System.Drawing.Point(30, 36)
        Me.lblOvertimePay1.Name = "lblOvertimePay1"
        Me.lblOvertimePay1.Size = New System.Drawing.Size(0, 13)
        Me.lblOvertimePay1.TabIndex = 15
        Me.lblOvertimePay1.Visible = False
        '
        'lblTotalEarnings1
        '
        Me.lblTotalEarnings1.AutoSize = True
        Me.lblTotalEarnings1.Location = New System.Drawing.Point(38, 134)
        Me.lblTotalEarnings1.Name = "lblTotalEarnings1"
        Me.lblTotalEarnings1.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalEarnings1.TabIndex = 16
        Me.lblTotalEarnings1.Visible = False
        '
        'lblSSSDeductions1
        '
        Me.lblSSSDeductions1.AutoSize = True
        Me.lblSSSDeductions1.Location = New System.Drawing.Point(46, 142)
        Me.lblSSSDeductions1.Name = "lblSSSDeductions1"
        Me.lblSSSDeductions1.Size = New System.Drawing.Size(0, 13)
        Me.lblSSSDeductions1.TabIndex = 17
        Me.lblSSSDeductions1.Visible = False
        '
        'lblPhDeduction1
        '
        Me.lblPhDeduction1.AutoSize = True
        Me.lblPhDeduction1.Location = New System.Drawing.Point(54, 150)
        Me.lblPhDeduction1.Name = "lblPhDeduction1"
        Me.lblPhDeduction1.Size = New System.Drawing.Size(0, 13)
        Me.lblPhDeduction1.TabIndex = 18
        Me.lblPhDeduction1.Visible = False
        '
        'lblPagibigDeduction1
        '
        Me.lblPagibigDeduction1.AutoSize = True
        Me.lblPagibigDeduction1.Location = New System.Drawing.Point(62, 158)
        Me.lblPagibigDeduction1.Name = "lblPagibigDeduction1"
        Me.lblPagibigDeduction1.Size = New System.Drawing.Size(0, 13)
        Me.lblPagibigDeduction1.TabIndex = 19
        Me.lblPagibigDeduction1.Visible = False
        '
        'lblTaxDeduction1
        '
        Me.lblTaxDeduction1.AutoSize = True
        Me.lblTaxDeduction1.Location = New System.Drawing.Point(70, 166)
        Me.lblTaxDeduction1.Name = "lblTaxDeduction1"
        Me.lblTaxDeduction1.Size = New System.Drawing.Size(0, 13)
        Me.lblTaxDeduction1.TabIndex = 20
        Me.lblTaxDeduction1.Visible = False
        '
        'lblTotalDeduction1
        '
        Me.lblTotalDeduction1.AutoSize = True
        Me.lblTotalDeduction1.Location = New System.Drawing.Point(78, 174)
        Me.lblTotalDeduction1.Name = "lblTotalDeduction1"
        Me.lblTotalDeduction1.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalDeduction1.TabIndex = 21
        Me.lblTotalDeduction1.Visible = False
        '
        'lblNetPay1
        '
        Me.lblNetPay1.AutoSize = True
        Me.lblNetPay1.Location = New System.Drawing.Point(86, 182)
        Me.lblNetPay1.Name = "lblNetPay1"
        Me.lblNetPay1.Size = New System.Drawing.Size(0, 13)
        Me.lblNetPay1.TabIndex = 22
        Me.lblNetPay1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(533, 341)
        Me.Controls.Add(Me.lblNetPay1)
        Me.Controls.Add(Me.lblTotalDeduction1)
        Me.Controls.Add(Me.lblTaxDeduction1)
        Me.Controls.Add(Me.lblPagibigDeduction1)
        Me.Controls.Add(Me.lblPhDeduction1)
        Me.Controls.Add(Me.lblSSSDeductions1)
        Me.Controls.Add(Me.lblTotalEarnings1)
        Me.Controls.Add(Me.lblOvertimePay1)
        Me.Controls.Add(Me.lblGrossPay1)
        Me.Controls.Add(Me.lblHourlyRate1)
        Me.Controls.Add(Me.lblDailyRate1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtOTHours)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDaysWork)
        Me.Controls.Add(Me.cmbDepartment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents txtDaysWork As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtOTHours As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDailyRate1 As Label
    Friend WithEvents lblHourlyRate1 As Label
    Friend WithEvents lblGrossPay1 As Label
    Friend WithEvents lblOvertimePay1 As Label
    Friend WithEvents lblTotalEarnings1 As Label
    Friend WithEvents lblSSSDeductions1 As Label
    Friend WithEvents lblPhDeduction1 As Label
    Friend WithEvents lblPagibigDeduction1 As Label
    Friend WithEvents lblTaxDeduction1 As Label
    Friend WithEvents lblTotalDeduction1 As Label
    Friend WithEvents lblNetPay1 As Label
End Class
