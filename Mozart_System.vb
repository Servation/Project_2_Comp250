Public Class Mozart_System
    Private Sub Mozart_System_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblOutput.Text = String.Empty
    End Sub

    Private Sub btnOfficeBarn_Click(sender As Object, e As EventArgs) Handles btnOfficeBarn.Click
        lblOutput.Text = "Mozart System = OK" &
        vbNewLine & "Maintenance system = OK" &
        vbNewLine & "Equipment Storage = OK"
    End Sub

    Private Sub btnSafetySystem_Click(sender As Object, e As EventArgs) Handles btnSafetySystem.Click
        lblOutput.Text = "All Systems Secure"
    End Sub

    Private Sub btnFieldSys_Click(sender As Object, e As EventArgs) Handles btnFieldSys.Click
        lblOutput.Text = "Flight Drone Deployed... " &
            vbNewLine & "Cameras Online: No Movement Detected" &
            vbNewLine & "Flight Drone: Field Status Clear" &
            vbNewLine & "Field Drone Tractor Deployed" &
            vbNewLine & "Pattern Plowing Initiated"
    End Sub

    Private Sub btnEquipSys_Click(sender As Object, e As EventArgs) Handles btnEquipSys.Click
        lblOutput.Text = "Equipment Systems Self-Check Initiated..." &
            vbNewLine & "Flight Drone 763 Status: OK" &
            vbNewLine & "Flight Drone 11 Status: ERROR DETECTED" &
            vbNewLine & "Flight Drone 66 Status: ONLINE, DEPLOYED: No Security Events Detected" &
            vbNewLine & "Tractor Drone 3056 Status: ONLINE, OK" &
            vbNewLine & "Combine Drone 890 Status: ONLINE, ERROR" &
            vbNewLine & "Multi-Function Rover 010 Status: ONLINE, DEPLOYED: Weed 35 Count Removed"
    End Sub
End Class
