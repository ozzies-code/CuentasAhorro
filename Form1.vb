Public Class Form1
    'Se llama al banco con el numero de sucursal y el nombre del banco
    Private banco As New Banco(1, "XYZ")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'la Propiedad Text en el formulario usara la propiedad Nombre_Banco para mostrar el nombre del banco 
        Me.Text = banco.Nombre_Banco
    End Sub

    Private Sub btnIngresarDinero_Click(sender As Object, e As EventArgs) Handles btnIngresardinero.Click

        'Se utiliza un Try Catch para capturar cualquier excepción que se pueda presentar
        'en el momento de ingresar el número de cuenta y el valor a ingresar
        'Si se presenta una excepción se muestra un mensaje de error
        'Si no se presenta ninguna excepción se ingresa el dinero a la cuenta de ahorros
        'Todo ocurre a traves de un InputBox para capturar la informacion necesaria
        'Tambien se emplea el metodo Integer.Parse para convertir el valor ingresado a un entero

        Try
            Dim numeroCuenta As Integer = Integer.Parse(InputBox("Ingrese el número de cuenta", "Ingresa Dinero", "", 500, 200))

            Dim valorIngresar As Integer = Double.Parse(InputBox("Ingrese el valor a Ingresar", "Ingresa Dinero", "", 500, 200))

            banco.ingresarDineroCuenta(numeroCuenta, valorIngresar)

        Catch ex As Exception
            MsgBox("Ha ocurrido un error, se ha ingresado un valor incorrecto")
        End Try


    End Sub

    'Limpia las cajas de texto
    Public Sub limpiarCajas()

        txtNombres.Clear()
        txtNumId.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtSaldoInicial.Clear()

    End Sub

    Private Sub btnCrearCuenta_Click(sender As Object, e As EventArgs) Handles btnCrearCuenta.Click

        'valida que los campos del formulario no esten vacios

        If txtNombres.Text <> "" And txtNumId.Text <> "" And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtSaldoInicial.Text <> "" Then

            'Crea un nuevo cliente con los datos ingresados en el formulario
            Dim cte As New Cliente(txtNombres.Text, txtNumId.Text, txtDireccion.Text, txtTelefono.Text)
            'Convierte el saldo inicial a un valor numerico
            Dim saldoInicial As Double = Double.Parse(txtSaldoInicial.Text)
            'Crea una cuenta de ahorros con el cliente y el saldo inicial
            banco.crearCuentaAhorro(cte, saldoInicial)
            'Limpia las cajas de texto
            limpiarCajas()

        Else
            'Muestra un mensaje de error si faltan datos en el formulario
            MsgBox("No se pudo crear la cuenta de ahorros, porque faltaron datos en el formulario")
        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'Limpia las cajas de texto para manejar un nuevo registro
        limpiarCajas()

    End Sub

    Private Sub btnRetirarDinero_Click(sender As Object, e As EventArgs) Handles btnRetirardinero.Click

        'Se utiliza un Try Catch para capturar cualquier excepción que se pueda presentar
        'en el momento de ingresar el número de cuenta y el valor a retirar
        'Si se presenta una excepción se muestra un mensaje de error
        'Si no se presenta ninguna excepción se retira el dinero a la cuenta de ahorros
        'Todo ocurre a traves de un InputBox para capturar la informacion necesaria
        'Tambien se emplea el metodo Integer.Parse para convertir el valor ingresado a un entero

        Try
            Dim numeroCuenta As Integer = Integer.Parse(InputBox("Ingrese el número de cuenta", "Retira Dinero", "", 500, 200))

            Dim valorRetirar As Integer = Double.Parse(InputBox("Ingrese el valor a Retirar", "Retira Dinero", "", 500, 200))

            banco.retirarDineroCuenta(numeroCuenta, valorRetirar)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error, se ha ingresado un valor incorrecto")
        End Try

    End Sub

    Private Sub btnVerSaldo_Click(sender As Object, e As EventArgs) Handles btnVerSaldo.Click

        'Se utiliza un Try Catch para capturar cualquier excepción que se pueda presentar
        'en el momento de ingresar el número de cuenta del cliente para consultar su saldo
        'Si se presenta una excepción se muestra un mensaje de error
        'Si no se presenta ninguna excepción se muestra  el dinero que hay en la cuenta de ahorros
        'Todo ocurre a traves de un InputBox para capturar la informacion necesaria
        'Tambien se emplea el metodo Integer.Parse para convertir el valor ingresado a un entero

        Try
            Dim numeroCuenta As Integer = Integer.Parse(InputBox("Ingrese el número de cuenta", "Ver Saldo", "", 500, 200))

            MsgBox("Saldo Disponible $" & banco.getSaldoCuenta(numeroCuenta))
        Catch ex As Exception
            MsgBox("Ha ocurrido un error, se ha ingresado un valor incorrecto")
        End Try

    End Sub

    Private Sub btnVerTransacciones_Click(sender As Object, e As EventArgs) Handles btnVerdetalletransacciones.Click

        'Se utiliza un Try Catch para capturar cualquier excepción que se pueda presentar
        'en el momento de ingresar el número de cuenta del cliente para consultar sus transacciones
        'Se obtiene el indice de la cuenta de ahorros que contiene el historial de ingresos del cliente
        'La informacion se agrega a la lista liIngresos a traves del metodo Add
        'Para retiros es el mismo procedimiento y la informacion se muestra en la lista liRetiros
        'Si se presenta una excepción se muestra un mensaje de error
        Try
            Dim numeroCuenta As Integer = Integer.Parse(InputBox("Ingrese el número de cuenta", "Ver Historial", "", 500, 200))

            Dim ingresosCuenta As List(Of String) = banco.getCuentaAhorro(numeroCuenta).ListaHistorialIngresos

            For i = 0 To ingresosCuenta.Count - 1 Step 1

                liIngresos.Items.Add(ingresosCuenta.Item(i))
            Next

            Dim retirosCuenta As List(Of String) = banco.getCuentaAhorro(numeroCuenta).ListaHistorialRetiros

            For i = 0 To retirosCuenta.Count - 1 Step 1

                liRetiros.Items.Add(retirosCuenta.Item(i))
            Next
        Catch ex As Exception
            MsgBox("Ha ocurrido un error, se ha ingresado un valor incorrecto")
        End Try

    End Sub

End Class
