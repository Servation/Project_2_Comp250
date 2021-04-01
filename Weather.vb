Public Class Weather

    Private Property _blnRain As Boolean
    Private Property _dblWindSpeed As Double
    Private Property _dblTempurature As Double
    Private Property _intLuminosity As Integer

    Public Sub New()
        _blnRain = vbNull
        _dblWindSpeed = ""
        _dblTempurature = -1
        _intLuminosity = -1
    End Sub
    Public Sub New(ByVal blnRain As Boolean, ByVal dblWindspeed As Double, ByVal dblTempurature As Double, ByVal intLuminosity As Integer)

        _blnRain = blnRain
        _dblWindSpeed = dblWindspeed
        _dblTempurature = -1
        _intLuminosity = -1
    End Sub
    Public Function MozartRelay()
        Dim strInfo As String
        strInfo = "Curently Raining:" & _blnRain &
            ", Windspeed:" & _dblWindSpeed &
            ", Tempurature:" & _dblTempurature &
            ", Luminosity: " & _intLuminosity

        Return strInfo
    End Function

End Class
