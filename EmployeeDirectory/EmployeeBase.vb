Public Class EmployeeBase
    Private _lastname As String
    Public Property LastName() As String
        Get
            Return _lastname
        End Get
        Set(ByVal value As String)
            _lastname = value
        End Set
    End Property


End Class
