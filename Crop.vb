Public Class Crop
    Private strType As String
    Public Property dblSoilMoisture As Double
    Public Property dblTemperature As Double
    Public Property intDays As Integer
    Public Property dblAvgHeight As Double
    Public Property blnReadyPlant As Boolean
    Public Property blnReadyHarvest As Boolean
    Public Property dblAcres As Double

    Public Property Type As String
        Get
            Return strType
        End Get
        Set(value As String)
            value = value.ToLower
            If value = "corn" Then
                strType = "Corn"
            ElseIf value = "soybean" Then
                strType = "Soybean"
            ElseIf value = "wheat" Then
                strType = "Wheat"
            Else
                strType = "Invalid"
            End If
        End Set
    End Property

    Public Sub New()
        strType = "Invalid"
        _dblSoilMoisture = 100
        _intDays = 0
        _dblAvgHeight = 0
    End Sub

    Public Sub New(ByVal arg1 As String, ByVal arg2 As Double, ByVal arg3 As Integer, ByVal arg4 As Double, ByVal arg5 As Boolean, ByVal arg6 As Boolean, ByVal arg7 As Double)

        strType = arg1
        _dblSoilMoisture = arg2
        _intDays = arg3
        _dblAvgHeight = arg4
        _blnReadyPlant = arg5
        _blnReadyHarvest = arg6
        _dblAcres = arg7

    End Sub

    Public Function PrintOut() As String
        Dim strTemp As String
        strTemp = "Crop Type: " & strType & vbNewLine & "Acres: " & dblAcres & vbNewLine & "Soil Moisture: " & dblSoilMoisture & vbNewLine & "Days Since Planted: " & intDays & vbNewLine & "Average Height: " & dblAvgHeight &
            vbNewLine & If(blnReadyPlant, " Can Be Planted ", " Cannot Be Planted ") & vbNewLine & If(blnReadyHarvest, " Can Be Harvested ", " Cannot Be Harvested ")
        Return strTemp
    End Function

    Private Function Plant() As Boolean
        If strType = "Corn" Then
            If _dblSoilMoisture >= 25 And _dblSoilMoisture <= 50 Then
                If _dblTemperature >= 60 And _dblTemperature <= 90 Then
                    Return True
                End If
            End If
        ElseIf strType = "SoyBean" Then
            If _dblTemperature >= 60 Then
                Return True
            End If
        ElseIf strType = "Wheat" Then

            Return True
        End If
        Return False
    End Function
    Private Function Harvest() As Boolean
        If blnReadyPlant Then
            If strType = "Corn" Then
                If intDays >= 60 Or dblAvgHeight >= 8 * 12 Then
                    If dblAvgHeight >= 4 * 12 Then
                        Return True
                    End If
                End If
            ElseIf strType = "SoyBean" Then
                If intDays >= 45 Or dblAvgHeight >= 24 Then
                    If dblAvgHeight >= 12 Then
                        Return True
                    End If
                End If
            ElseIf strType = "Wheat" Then
                If dblAvgHeight >= 12 Then
                    Return True
                End If
            End If
        End If
        Return False
    End Function



End Class
