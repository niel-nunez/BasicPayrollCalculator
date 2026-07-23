Public Class Form2
    Public FirstForm As Form1
    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles lblRatePerHour.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        FirstForm.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblEmployeeName.Text = FirstForm.txtEmployeeName.Text
        lblDepartment.Text = FirstForm.cmbDepartment.SelectedItem.ToString()

        lblDailyRate.Text = "₱" & Format(CDbl(FirstForm.lblDailyRate1.Text), "#,##0.00")
        lblRatePerHour.Text = "₱" & Format(CDbl(FirstForm.lblHourlyRate1.Text), "#,##0.00")
        lblGrossPay.Text = "₱" & Format(CDbl(FirstForm.lblGrossPay1.Text), "#,##0.00")
        lblOvertimePay.Text = "₱" & Format(CDbl(FirstForm.lblOvertimePay1.Text), "#,##0.00")
        lblTotalEarnings.Text = "₱" & Format(CDbl(FirstForm.lblTotalEarnings1.Text), "#,##0.00")
        lblSSSDeduction.Text = "₱" & Format(CDbl(FirstForm.lblSSSDeductions1.Text), "#,##0.00")
        lblPhDeduction.Text = "₱" & Format(CDbl(FirstForm.lblPhDeduction1.Text), "#,##0.00")
        lblPagibigDeduc.Text = "₱" & Format(CDbl(FirstForm.lblPagibigDeduction1.Text), "#,##0.00")
        lblTaxDeduc.Text = "₱" & Format(CDbl(FirstForm.lblTaxDeduction1.Text), "#,##0.00")
        lblTotalDeduc.Text = "₱" & Format(CDbl(FirstForm.lblTotalDeduction1.Text), "#,##0.00")
        lblNetPay.Text = "₱" & Format(CDbl(FirstForm.lblNetPay1.Text), "#,##0.00")

    End Sub

    Private Sub lblDailyRate_Click(sender As Object, e As EventArgs) Handles lblDailyRate.Click

    End Sub

    Private Sub lblTotalEarnings_Click(sender As Object, e As EventArgs) Handles lblTotalEarnings.Click

    End Sub
End Class