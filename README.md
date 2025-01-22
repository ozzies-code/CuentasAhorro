 # Project Title: CuentasAhorro
 
Este proyecto consiste en una aplicacion que gestiona procesos 
y movimientos bancarios de un cliente a partir de la creacion 
de una cuenta y el manejo de sus movimientos bancarios.

# Descripcion

 Este proyecto consiste en el desarrollo de una aplicacion que lleva
 a cabo una serie de moviimientos a traves de una plataforma
 bancaria para gestionar la informacion del cliente desde la apertura
 de la cuenta, la consulta del saldo disponible, el ingreso de dinero,
 el retiro de dinero y los movimientos son observados en detalle 
 a traves de dos objetos ListBox donde se aprecia el manejo de las tran
 sacciones del cliente tanto para ingreso de dinero como retiro de 
 dinero.
 
 # Actualizacion: 21/01/2025
 # Hora: 20:17

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

## Autores

- [@ozzies-code](https://www.github.com/ozzies-code)

## Contribuciones

¡Las contribuciones son siempre bienvenidas!

Consulta `contributing.md` para conocer cómo comenzar.

Por favor, respeta el `código de conducta` de este proyecto.

## Despliegue

Para implementar este proyecto, descargue los archivos del proyecto
del repositorio y el código del proyecto que se encuentra
en el archivo README.md

## 🚀 Acerca de Mi
Soy un apasionado desarrollador fullstack de Venezuela 🇻🇪 y Países Bajos 🇳🇱


🔭 Actualmente estoy trabajando en .NET Framework

🔭 Actualmente estoy trabajando en desarrollo web

🔭 Actualmente estoy trabajando en proyectos de .Console

🔭 Actualmente estoy trabajando en bases de datos .SQL

🌱 Actualmente estoy aprendiendo sobre frameworks, cursos, tutoriales y libros electrónicos

💬 Pregúntame sobre desarrollo de software

📫 Cómo contactarme oswaldojmp.nl@proton.me

👨‍💻 Todos mis proyectos están disponibles en https://developerandtechnologyozziescode.blogspot.com/ (mi sitio web)

📝 Escribo artículos regularmente en Medium.com/Ozzies.Code

    ## 🔗 Links
[![portfolio](https://img.shields.io/badge/my_portfolio-000?style=for-the-badge&logo=ko-fi&logoColor=white)]( https://developerandtechnologyozziescode.blogspot.com)
[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](www.linkedin.com/in/oswaldo-jesús-marín-pagés-ab4499a4)
[![twitter](https://img.shields.io/badge/twitter-1DA1F2?style=for-the-badge&logo=twitter&logoColor=white)](https://twitter.com/ozzies_code)

## Lecciones Aprendidas

- Manejo de listas y groupbox
- eventos
- manejo del Message Box
- manejo de InputBox Box
- Manejo de Listas como
colecciones de objetos

## image of the Project

![imagen](https://github.com/user-attachments/assets/4fb3bf56-6722-4443-88a7-1aafd15cbb4c)

## Soporte

Para soporte, email oswaldojmp.nl@proton.me

## Pila de tecnología

**Plataforma:** Visual studio 2022

**Lenguaje:** Visual Basic.NET

Codigo del Proyecto:

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

    Public Class Cliente

    'Atributos de la Clase Cliente

    Private nombre As String
    Private numIdentificacion As String
    Private direccion As String
    Private telefono As String

    'Constructor por defecto
    Public Sub New()

    End Sub

    Public Sub New(ByVal nom As String, ByVal numId As String, ByVal dire As String, ByVal tel As String)

        nombre = nom
        numIdentificacion = numId
        direccion = dire
        telefono = tel

    End Sub

    Public Property NombreCliente As String

        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Public Property NumIdCliente As String

        Get
            Return numIdentificacion
        End Get
        Set(ByVal value As String)
            numIdentificacion = value
        End Set
    End Property

    Public Property DireccionCliente As String
        Get
            Return direccion
        End Get
        Set(ByVal value As String)
            direccion = value
        End Set
    End Property

    Public Property TelefonoCliente As String
        Get
            Return telefono
        End Get
        Set(ByVal value As String)
            telefono = value
        End Set
    End Property

End Class

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


End Class
