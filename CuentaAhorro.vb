Imports System.CodeDom
Imports System.Runtime.InteropServices

Public Class CuentaAhorro

    'Atributos de la Clase CuentaAhorro

    Private numCuenta As Integer
    Private cliente As Cliente
    Private saldoCuenta As Double
    Private historialIngresos As List(Of String)
    Private historialRetiros As List(Of String)
    Private Shared contadorNumCuenta As Integer = 1

    'Constructor de la Clase CuentaAhorro

    Public Sub New(ByVal cte As Cliente, ByVal saldoInicial As Double)

        numCuenta = contadorNumCuenta
        cliente = cte
        historialIngresos = New List(Of String)
        historialRetiros = New List(Of String)

        If saldoInicial > 0 Then
            saldoCuenta = saldoInicial

        Else
            saldoCuenta = 0

        End If

        contadorNumCuenta += 1

    End Sub

    Public ReadOnly Property NumCuentaahorros As Integer
        'Propiedad de Solo Lectura para el metodo Get
        Get
            Return numCuenta
        End Get
    End Property

    Public Property ClienteCuentaAhorros As Cliente
        'Devuelve o establece al cliente de la cuenta de ahorros
        Get
            Return cliente
        End Get

        Set(ByVal value As Cliente)
            cliente = value
        End Set
    End Property

    Public ReadOnly Property ListaHistorialIngresos As List(Of String)
        'Propiedad de Solo Lectura para el metodo Get
        Get
            Return historialIngresos
        End Get
    End Property

    Public ReadOnly Property ListaHistorialRetiros As List(Of String)
        'Propiedad de Solo Lectura para el metodo Get
        Get
            Return historialRetiros
        End Get
    End Property

    Public Function getSaldoCuenta() As Double
        'Devuelve el saldo de la cuenta de ahorros
        Return saldoCuenta
    End Function

    Public Sub IngresarDinero(ByVal ingresar As Double)
        If ingresar > 0 Then
            'Metodo Ingresar Dinero a la Cuenta de Ahorros y manejo del historial de ingresos
            saldoCuenta += ingresar
            MsgBox("Los $" & ingresar & " fueron agregados al saldo de la cuenta correctamente")
            MsgBox("Su nuevo saldo es $" & saldoCuenta)

            historialIngresos.Add("Valor Ingresado: $" & ingresar & " Fecha Transaccion: " & Date.Now.ToString)

        Else
            MsgBox("No puede ingresar un valor menor o igual a 0")
        End If
    End Sub

    Public Sub RetirarDinero(ByVal retirar As Double)
        'Metodo Retirar Dinero a la Cuenta de Ahorros y manejo del historial de egresos
        If retirar <= saldoCuenta Then

            saldoCuenta -= retirar
            MsgBox("Los $" & retirar & " fueron retirados de la cuenta correctamente")
            MsgBox("Su nuevo saldo es $" & saldoCuenta)

            historialRetiros.Add("Valor Retirado: $" & retirar & " Fecha Transaccion: " & Date.Now.ToString)

        Else
            MsgBox("No puede retirar un valor menor o igual a 0")
        End If
    End Sub

End Class
