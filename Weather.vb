Public Class Weather

    Private _blnRain As Boolean
    Private _dblWindSpeed As Double
    Private _dblTempurature As Double
    Private _intLuminosity As Integer

    Public Sub New()
        _blnRain = vbNull
        _dblWindSpeed = -1
        _dblTempurature = -1
        _intLuminosity = -1
    End Sub
    Public Sub New(ByVal blnRain As Boolean, ByVal dblWindspeed As Double, ByVal dblTempurature As Double, ByVal intLuminosity As Integer)

        _blnRain = blnRain
        _dblWindSpeed = dblWindspeed
        _dblTempurature = dblTempurature
        _intLuminosity = intLuminosity

    End Sub

    Public Property Raining As Boolean
        Get
            Return _blnRain
        End Get
        Set(value As Boolean)
            _blnRain = value
        End Set
    End Property

    Public Property WindSpeed As Double
        Get
            Return _dblWindSpeed
        End Get
        Set(value As Double)
            _dblWindSpeed = value
        End Set
    End Property

    Public Property Temperature As Double
        Get
            Return _dblTempurature
        End Get
        Set(value As Double)
            _dblTempurature = value
        End Set
    End Property

    Public Property Luminosity As Double
        Get
            Return _intLuminosity
        End Get
        Set(value As Double)
            _intLuminosity = value
        End Set
    End Property

    Public Function MozartRelay()

        Dim strInfo As String
        strInfo = "Curently Raining:" & _blnRain &
            ", Windspeed:" & _dblWindSpeed &
            ", Tempurature:" & _dblTempurature &
            ", Luminosity: " & _intLuminosity

        Return strInfo
    End Function
End Class
