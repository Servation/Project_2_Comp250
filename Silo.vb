Public Class Silo

    Private _blnEmpty As Boolean
    Private _dblFillLevel As Double
    Private _dblTempurature As Double
    Private _intMoistureLevel As Integer

    Public Sub New()
        _blnEmpty = vbNull
        _dblFillLevel = -1
        _dblTempurature = -1
        _intMoistureLevel = -1
    End Sub
    Public Sub New(ByVal blnEmpty As Boolean, ByVal dblFillLevel As Double, ByVal dblTempurature As Double, ByVal intMoistureLevel As Integer)

        _blnEmpty = blnEmpty
        _dblFillLevel = dblFillLevel
        _dblTempurature = dblTempurature
        _intMoistureLevel = intMoistureLevel

    End Sub

    Public Property Empty As Boolean
        Get
            Return _blnEmpty
        End Get
        Set(value As Boolean)
            _blnEmpty = value
        End Set
    End Property

    Public Property FillLevel As Double
        Get
            Return _dblFillLevel
        End Get
        Set(value As Double)
            _dblFillLevel = value
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

    Public Property MoistureLevel As Double
        Get
            Return _intMoistureLevel
        End Get
        Set(value As Double)
            _intMoistureLevel = value
        End Set
    End Property

    Public Function MozartRelay() As String

        Dim strInfo As String
        strInfo = "Curently Empty: " & _blnEmpty &
            ", Fill Level: " & _dblFillLevel &
            ", Tempurature: " & _dblTempurature &
            ", Moisture Level: " & _intMoistureLevel

        Return strInfo
    End Function
End Class
