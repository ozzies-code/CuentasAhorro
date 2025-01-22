Public Class Banco

    'Atributos de la Clase Banco
    Private numSucursal As Integer
    Private nombreBanco As String
    Private cuentasAhorros As List(Of CuentaAhorro)


    'Constructor de la Clase Banco

    Public Sub New(ByVal numS As Integer, ByVal nomBanco As String)

        numSucursal = numS
        nombreBanco = nomBanco
        cuentasAhorros = New List(Of CuentaAhorro)

    End Sub

    Public ReadOnly Property NumeroSucursal As Integer
        'Propiedad de Solo Lectura para el metodo Get
        Get
            Return numSucursal
        End Get
    End Property

    Public ReadOnly Property Nombre_Banco As String
        'Propiedad de Solo Lectura para el metodo Get
        Get
            Return nombreBanco
        End Get
    End Property

    'Metodo para crear una cuenta de ahorros, pero antes verifica que el cliente no tenga una cuenta de ahorros ya creada

    Public Sub crearCuentaAhorro(ByVal cte As Cliente, ByVal saldoInicial As Double)

        Dim existe As Boolean = False

        'Verifica que el cliente no tenga una cuenta de ahorros ya creada
        For i = 0 To cuentasAhorros.Count - 1 Step 1

            Dim clienteLista As Cliente = cuentasAhorros.Item(i).ClienteCuentaAhorros

            If clienteLista.NumIdCliente.Equals(cte.NumIdCliente) Then
                existe = True
                Exit For
            End If
        Next

        If existe = False Then

            Dim cuentaAhorros As New CuentaAhorro(cte, saldoInicial)

            cuentasAhorros.Add(cuentaAhorros)

            MsgBox("Cuenta de Ahorros creada Correctamente")
        End If
    End Sub

    'Método que permite obtener el indice del objeto CuentaAhorro, de acuerdo al número de cuenta pasado por parámetro
    Public Function getIndiceCuenta(ByVal numCuenta) As Integer

        Dim indice As Integer = -1

        'Busca el indice del numCuenta pasado por parámetro en el atributo lista de la clase Banco
        For i = 0 To cuentasAhorros.Count - 1 Step 1

            Dim cuentaLista As CuentaAhorro = cuentasAhorros.Item(i)

            If cuentaLista.NumCuentaahorros = numCuenta Then

                indice = i
                Exit For
            End If
        Next

        Return indice

    End Function

    'Método que permite obtener una cuenta de ahorros especifica
    Public Function getCuentaAhorro(ByVal numCuenta As Integer) As CuentaAhorro

        Return cuentasAhorros.Item(getIndiceCuenta(numCuenta))
    End Function

    'Método que permite ingresar dinero a la cuenta de ahorros de un cliente teniendo en cuenta su número de cuenta
    Public Sub ingresarDineroCuenta(ByVal numCuenta As Integer, ByVal ingresar As Double)

        Dim indice As Integer = getIndiceCuenta(numCuenta)

        cuentasAhorros.Item(indice).IngresarDinero(ingresar)

    End Sub

    'Método que permite retirar dinero de la cuenta de ahorros de un cliente teniendo en cuenta su número de cuenta
    Public Sub retirarDineroCuenta(ByVal numCuenta As Integer, ByVal retirar As Double)

        Dim indice As Integer = getIndiceCuenta(numCuenta)

        cuentasAhorros.Item(indice).RetirarDinero(retirar)

    End Sub

    'Método que permite obtener el saldo disponible de la cuenta de ahorros de un cliente teniendo en cuenta su número de cuenta
    Public Function getSaldoCuenta(ByVal numCuenta As Integer)

        Dim indice As Integer = getIndiceCuenta(numCuenta)

        Return cuentasAhorros.Item(indice).getSaldoCuenta()

    End Function

End Class
