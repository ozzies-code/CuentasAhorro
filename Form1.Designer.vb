<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCrearCuenta = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtSaldoInicial = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNumId = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnVerdetalletransacciones = New System.Windows.Forms.Button()
        Me.btnVerSaldo = New System.Windows.Forms.Button()
        Me.btnRetirardinero = New System.Windows.Forms.Button()
        Me.btnIngresardinero = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.liRetiros = New System.Windows.Forms.ListBox()
        Me.liIngresos = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.btnCrearCuenta)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtSaldoInicial)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtNumId)
        Me.GroupBox1.Controls.Add(Me.txtNombres)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(884, 125)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crear Cuenta"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.DarkRed
        Me.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNuevo.Location = New System.Drawing.Point(237, 71)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(122, 37)
        Me.btnNuevo.TabIndex = 11
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnCrearCuenta
        '
        Me.btnCrearCuenta.BackColor = System.Drawing.Color.DarkRed
        Me.btnCrearCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCrearCuenta.Location = New System.Drawing.Point(20, 71)
        Me.btnCrearCuenta.Name = "btnCrearCuenta"
        Me.btnCrearCuenta.Size = New System.Drawing.Size(182, 37)
        Me.btnCrearCuenta.TabIndex = 10
        Me.btnCrearCuenta.Text = "Crear Cuenta"
        Me.btnCrearCuenta.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(779, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Saldo Inicial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(656, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(472, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Direccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Numero de Identificacion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombres"
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtTelefono.Location = New System.Drawing.Point(633, 45)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 4
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSaldoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoInicial.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtSaldoInicial.Location = New System.Drawing.Point(762, 45)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldoInicial.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtDireccion.Location = New System.Drawing.Point(394, 45)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(213, 20)
        Me.txtDireccion.TabIndex = 2
        '
        'txtNumId
        '
        Me.txtNumId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNumId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumId.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtNumId.Location = New System.Drawing.Point(237, 45)
        Me.txtNumId.Name = "txtNumId"
        Me.txtNumId.Size = New System.Drawing.Size(122, 20)
        Me.txtNumId.TabIndex = 1
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtNombres.Location = New System.Drawing.Point(20, 45)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(182, 20)
        Me.txtNombres.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnVerdetalletransacciones)
        Me.GroupBox2.Controls.Add(Me.btnVerSaldo)
        Me.GroupBox2.Controls.Add(Me.btnRetirardinero)
        Me.GroupBox2.Controls.Add(Me.btnIngresardinero)
        Me.GroupBox2.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(884, 104)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transacciones"
        '
        'btnVerdetalletransacciones
        '
        Me.btnVerdetalletransacciones.BackColor = System.Drawing.Color.DarkRed
        Me.btnVerdetalletransacciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnVerdetalletransacciones.Location = New System.Drawing.Point(680, 36)
        Me.btnVerdetalletransacciones.Name = "btnVerdetalletransacciones"
        Me.btnVerdetalletransacciones.Size = New System.Drawing.Size(182, 47)
        Me.btnVerdetalletransacciones.TabIndex = 3
        Me.btnVerdetalletransacciones.Text = "Ver Detalle Transacciones"
        Me.btnVerdetalletransacciones.UseVisualStyleBackColor = False
        '
        'btnVerSaldo
        '
        Me.btnVerSaldo.BackColor = System.Drawing.Color.DarkRed
        Me.btnVerSaldo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnVerSaldo.Location = New System.Drawing.Point(463, 36)
        Me.btnVerSaldo.Name = "btnVerSaldo"
        Me.btnVerSaldo.Size = New System.Drawing.Size(182, 47)
        Me.btnVerSaldo.TabIndex = 2
        Me.btnVerSaldo.Text = "Ver Saldo Disponible"
        Me.btnVerSaldo.UseVisualStyleBackColor = False
        '
        'btnRetirardinero
        '
        Me.btnRetirardinero.BackColor = System.Drawing.Color.DarkRed
        Me.btnRetirardinero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRetirardinero.Location = New System.Drawing.Point(237, 36)
        Me.btnRetirardinero.Name = "btnRetirardinero"
        Me.btnRetirardinero.Size = New System.Drawing.Size(182, 47)
        Me.btnRetirardinero.TabIndex = 1
        Me.btnRetirardinero.Text = "Retirar Dinero"
        Me.btnRetirardinero.UseVisualStyleBackColor = False
        '
        'btnIngresardinero
        '
        Me.btnIngresardinero.BackColor = System.Drawing.Color.DarkRed
        Me.btnIngresardinero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnIngresardinero.Location = New System.Drawing.Point(20, 36)
        Me.btnIngresardinero.Name = "btnIngresardinero"
        Me.btnIngresardinero.Size = New System.Drawing.Size(182, 47)
        Me.btnIngresardinero.TabIndex = 0
        Me.btnIngresardinero.Text = "Ingresar Dinero"
        Me.btnIngresardinero.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.liRetiros)
        Me.GroupBox3.Controls.Add(Me.liIngresos)
        Me.GroupBox3.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 272)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(884, 166)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial de Transacciones Cuenta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(191, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Ingresos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(630, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Retiros"
        '
        'liRetiros
        '
        Me.liRetiros.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.liRetiros.ForeColor = System.Drawing.Color.Blue
        Me.liRetiros.FormattingEnabled = True
        Me.liRetiros.ItemHeight = 15
        Me.liRetiros.Location = New System.Drawing.Point(448, 40)
        Me.liRetiros.Name = "liRetiros"
        Me.liRetiros.Size = New System.Drawing.Size(414, 94)
        Me.liRetiros.TabIndex = 1
        '
        'liIngresos
        '
        Me.liIngresos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.liIngresos.ForeColor = System.Drawing.Color.Blue
        Me.liIngresos.FormattingEnabled = True
        Me.liIngresos.ItemHeight = 15
        Me.liIngresos.Location = New System.Drawing.Point(12, 40)
        Me.liIngresos.Name = "liIngresos"
        Me.liIngresos.Size = New System.Drawing.Size(416, 94)
        Me.liIngresos.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(908, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Text = "Aplicacion de Cuentas de Ahorro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtSaldoInicial As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNumId As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCrearCuenta As Button
    Friend WithEvents btnVerdetalletransacciones As Button
    Friend WithEvents btnVerSaldo As Button
    Friend WithEvents btnRetirardinero As Button
    Friend WithEvents btnIngresardinero As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents liRetiros As ListBox
    Friend WithEvents liIngresos As ListBox
End Class
