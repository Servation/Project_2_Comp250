Public Class Mozart_System
    Private arrNames() As String = {"John", "Andrew", "Mike", "Micheal", "Kelly"}
    Private arrAdd() As String = {"Walnut St", "Jefferson Ave", " Jerk St", "Valencia Blvd", "Mooney Blvd"}
    Private arrClocked() As Boolean = {True, True, False, True, False}
    Private arrWage() As Double = {40, 33, 25, 25, 25}
    Private arrWorkHours() As Double = {40, 40, 40, 20, 20}
    Private worker(4) As Employee
    Private corn As New Crop
    Private silo(2) As Silo
    Private today As Weather
    Private Sub Mozart_System_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblOutput.BackColor = Color.FromArgb(200, 0, 150, 0)
        lblOutput.Text = String.Empty
        For i As Integer = 0 To worker.Count - 1
            worker(i) = New Employee(arrNames(i), arrAdd(i), arrClocked(i), arrWage(i), arrWorkHours(i))
        Next i
        worker(0).EmployeeManagement = True
        worker(0).AgManagement = True
        worker(1).DroneOps = True
        worker(2).Technician = True
        worker(3).Maintenance = True
        worker(4).Security = True
        corn = New Crop("Corn", 35, 75, 10 * 12, True, True, 1)

        silo(0) = New Silo(False, 60, 99.8, 10)
        silo(1) = New Silo(True, 0, 83, 15)
        today = New Weather(True, 1, 75, 60)


    End Sub

    Private Sub btnOfficeBarn_Click(sender As Object, e As EventArgs) Handles btnOfficeBarn.Click
        lblOutput.Visible = True
        lblOutput.Text = "Mozart System = OK" &
        vbNewLine & "Maintenance system = OK" &
        vbNewLine & "Equipment Storage = OK"
    End Sub

    Private Sub btnSafetySystem_Click(sender As Object, e As EventArgs) Handles btnSafetySystem.Click
        lblOutput.Visible = True
        lblOutput.Text = "All Systems Secure"
    End Sub

    Private Sub btnFieldSys_Click(sender As Object, e As EventArgs) Handles btnFieldSys.Click
        lblOutput.Visible = True
        lblOutput.Text = "Flight Drone Deployed... " &
            vbNewLine & "Cameras Online: No Movement Detected" &
            vbNewLine & "Flight Drone: Field Status Clear" &
            vbNewLine & "Field Drone Tractor Deployed" &
            vbNewLine & "Pattern Plowing Initiated"
    End Sub

    Private Sub btnEquipSys_Click(sender As Object, e As EventArgs) Handles btnEquipSys.Click
        lblOutput.Visible = True
        lblOutput.Text = "Equipment Systems Self-Check Initiated..." &
            vbNewLine & "Flight Drone 763 Status: OK" &
            vbNewLine & "Flight Drone 11 Status: ERROR DETECTED" &
            vbNewLine & "Flight Drone 66 Status: ONLINE, DEPLOYED: No Security Events Detected" &
            vbNewLine & "Tractor Drone 3056 Status: ONLINE, OK" &
            vbNewLine & "Combine Drone 890 Status: ONLINE, ERROR" &
            vbNewLine & "Multi-Function Rover 010 Status: ONLINE, DEPLOYED: Weed 35 Count Removed"
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        lblOutput.Visible = True
        Dim strOut As String = ""
        For i As Integer = 0 To worker.Count - 1
            strOut &= worker(i).strReport() & vbNewLine & vbNewLine

        Next i
        lblOutput.Text = strOut
    End Sub

    Private Sub btnCrops_Click(sender As Object, e As EventArgs) Handles btnCrops.Click
        lblOutput.Visible = True
        lblOutput.Text = corn.PrintOut()
    End Sub

    Private Sub btnWeatherSys_Click(sender As Object, e As EventArgs) Handles btnWeatherSys.Click
        lblOutput.Visible = True
        lblOutput.Text = today.MozartRelay()
    End Sub

    Private Sub btnProductSys_Click(sender As Object, e As EventArgs) Handles btnProductSys.Click
        lblOutput.Visible = True
        Dim strTem As String = ""
        For i As Integer = 0 To 1
            strTem &= silo(i).MozartRelay() & vbNewLine
        Next i

        lblOutput.Text = strTem
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        MessageBox.Show("Data Import & Integrity Check: Complete", "Data Import", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
