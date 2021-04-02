Public Class Employee
    Private _strName As String
    Private _strAddress As String
    Private _blnClockedIn As Boolean
    Private _dblWages As Double
    Private _dblWorkHours As Double
    'Employee Abilities
    Private _blnEmpMgt As Boolean
    Private _blnAgMgt As Boolean
    Private _blnMaint As Boolean
    Private _blnTech As Boolean
    Private _blnDroneOps As Boolean
    Private _blnSecurity As Boolean

    Public Sub New(ByVal arg1 As String, ByVal arg2 As String, ByVal arg3 As String, ByVal arg4 As Double, ByVal arg5 As Double)

        _strName = arg1
        _strAddress = arg2
        _blnClockedIn = arg3
        _dblWages = arg4
        _dblWorkHours = arg5

        'Employee Abilities
        _blnEmpMgt = False
        _blnAgMgt = False
        _blnMaint = False
        _blnTech = False
        _blnDroneOps = False
        _blnSecurity = False

    End Sub

    Public Property Name As String
        Get
            Return _strName
        End Get
        Set(value As String)
            _strName = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return _strAddress
        End Get
        Set(value As String)
            _strAddress = value
        End Set
    End Property

    Public Property ClockedIn As Boolean
        Get
            Return _blnClockedIn
        End Get
        Set(value As Boolean)
            _blnClockedIn = value
        End Set
    End Property

    Public Property Wages As Double
        Get
            Return _dblWages
        End Get
        Set(value As Double)
            _dblWages = value
        End Set
    End Property

    Public Property WorkHours As Double
        Get
            Return _dblWorkHours
        End Get
        Set(value As Double)
            _dblWorkHours = value
        End Set
    End Property

    Public Property EmployeeManagement As Boolean
        Get
            Return _blnEmpMgt
        End Get
        Set(value As Boolean)
            _blnEmpMgt = value
        End Set
    End Property

    Public Property AgManagement As Boolean
        Get
            Return _blnAgMgt
        End Get
        Set(value As Boolean)
            _blnAgMgt = value
        End Set
    End Property

    Public Property Maintenance As Boolean
        Get
            Return _blnMaint
        End Get
        Set(value As Boolean)
            _blnMaint = value
        End Set
    End Property

    Public Property Technician As Boolean
        Get
            Return _blnTech
        End Get
        Set(value As Boolean)
            _blnTech = value
        End Set
    End Property

    Public Property DroneOps As Boolean
        Get
            Return _blnDroneOps
        End Get
        Set(value As Boolean)
            _blnDroneOps = value
        End Set
    End Property

    Public Property Security As Boolean
        Get
            Return _blnSecurity
        End Get
        Set(value As Boolean)
            _blnSecurity = value
        End Set
    End Property

    Public Function strReport() As String
        Dim strInfo As String
        strInfo = "Name: " & Name & ", Address: " & Address & ", Clocked In: " & ClockedIn & ", Wages: " & Wages & ", Work Hours: " & WorkHours & ", Abilities: "
        strInfo &= If(EmployeeManagement, "Empolyee Management ", "")
        strInfo &= If(AgManagement, "AgManagement ", "")
        strInfo &= If(Maintenance, "Maintenance ", "")
        strInfo &= If(Technician, "Technician ", "")
        strInfo &= If(DroneOps, "DroneOps ", "")
        strInfo &= If(Security, "Security ", "")
        Return strInfo
    End Function

    Public Function ListAbilities() As String
        Return "EmployeeManagement, AgManagement, Maintenance, Technician, DroneOps, Security"
    End Function

End Class
