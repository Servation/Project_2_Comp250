Public Class Crop
    Private strType As String
    Public Property SoilMoisture As Double
    Public Property Temperature As Double
    Public Property Days As Integer
    Public Property AvgHeight As Double
    Public Property ReadyPlant As Boolean = False
    Public Property ReadyHarvest As Boolean = False

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
        _SoilMoisture = 100
        _Days = 0
        _AvgHeight = 0
    End Sub

    Private Function Plant() As Boolean
        If strType = "Corn" Then
            If _SoilMoisture >= 25 And _SoilMoisture <= 50 Then
                If _Temperature >= 60 And _Temperature <= 90 Then
                    Return True
                End If
            End If
        ElseIf strType = "SoyBean" Then
            If _Temperature >= 60 Then
                Return True
            End If
        ElseIf strType = "Wheat" Then
            Return True
        End If
        Return False
    End Function
    Private Function Harvest() As Boolean
        If strType = "Corn" Then
            If Days >= 60 Or AvgHeight >= 8 * 12 Then
                If AvgHeight >= 4 * 12 Then
                    Return True
                End If
            End If
        ElseIf strType = "SoyBean" Then
            If Days >= 45 Or AvgHeight >= 24 Then
                If AvgHeight >= 12 Then
                    Return True
                End If
            End If
        ElseIf strType = "Wheat" Then
        End If
        Return False
    End Function


End Class
