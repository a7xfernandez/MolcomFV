Imports System.ComponentModel.DataAnnotations

Public Class RegisterModel

    Private _email As String
    <Required>
    <DataType(DataType.EmailAddress)>
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set
            _email = Value
        End Set
    End Property

    Private _password As String
    <Required>
    <DataType(DataType.Password)>
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set
            _password = Value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _apellido As String
    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

End Class