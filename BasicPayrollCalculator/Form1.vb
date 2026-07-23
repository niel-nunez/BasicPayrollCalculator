Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEmployeeName.Clear()
        txtDaysWork.Clear()
        txtOTHours.Clear()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        
        Dim dailyrate As Double
        If cmbDepartment.SelectedIndex = 0 Then
            dailyrate = 500
        ElseIf cmbDepartment.SelectedIndex = 1 Then
            dailyrate = 800
        ElseIf cmbDepartment.SelectedIndex = 2 Then
            dailyrate = 600
        ElseIf cmbDepartment.SelectedIndex = 3 Then
            dailyrate = 550
        Else
            MessageBox.Show("Invalid Department!")
            Exit Sub
        End If
        lblDailyRate1.Text = dailyrate
        Dim hourlyrate As Double
        hourlyrate = dailyrate / 8
        lblHourlyRate1.Text = hourlyrate
        Dim daysworked As Double = Val(txtDaysWork.Text)
        lblGrossPay1.Text = dailyrate * daysworked
        Dim otHours As Double = Val(txtOTHours.Text)
        lblOvertimePay1.Text = (hourlyrate * 1.5) * otHours
        lblTotalEarnings1.Text = (dailyrate * daysworked) + (hourlyrate * 1.5) * otHours
        lblSSSDeductions1.Text = ((dailyrate * daysworked) + (hourlyrate * 1.5) * otHours) * 0.12
        lblPhDeduction1.Text = ((dailyrate * daysworked) + (hourlyrate * 1.5) * otHours) * 0.03
        lblPagibigDeduction1.Text = 100
        lblTaxDeduction1.Text = ((dailyrate * daysworked) + (hourlyrate * 1.5) * otHours) * 0.1
        lblTotalDeduction1.Text = (((dailyrate * daysworked) + (hourlyrate * 1.5) * otHours) * 0.12) +
                                  (((dailyrate * daysworked) + (hourlyrate * 1.5) * otHours) * 0.03) +
                                  (((dailyrate * daysworked) + (hourlyrate * 1.5) * otHours) * 0.1) +
                                  100
        lblNetPay1.Text = ((dailyrate * daysworked) + (hourlyrate * 1.5) * otHours) -
                          ((((dailyrate * daysworked) + (hourlyrate * 1.5) * otHours) * 0.12) +
                          (((dailyrate * daysworked) + (hourlyrate * 1.5) * otHours) * 0.03) +
                          (((dailyrate * daysworked) + (hourlyrate * 1.5) * otHours) * 0.1) +
                          100)
        Dim secondform As New Form2()
        secondform.FirstForm = Me
        secondform.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmployeeName.Clear()
        txtDaysWork.Clear()
        txtOTHours.Clear()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblOvertimePay1.Click

    End Sub
End Class
