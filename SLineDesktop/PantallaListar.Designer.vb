<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PantallaListar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelBienvenido = New System.Windows.Forms.Label()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmiModerar = New System.Windows.Forms.ToolStripMenuItem()
        Me.LVListadoUsuarios = New System.Windows.Forms.ListView()
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaNac = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelBienvenido
        '
        Me.LabelBienvenido.AutoSize = True
        Me.LabelBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.LabelBienvenido.Location = New System.Drawing.Point(50, 49)
        Me.LabelBienvenido.Name = "LabelBienvenido"
        Me.LabelBienvenido.Size = New System.Drawing.Size(436, 54)
        Me.LabelBienvenido.TabIndex = 10
        Me.LabelBienvenido.Text = "Listado de Usuarios"
        '
        'BtnEditar
        '
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnEditar.Location = New System.Drawing.Point(172, 370)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(118, 40)
        Me.BtnEditar.TabIndex = 12
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.SLineDesktop.My.Resources.Resources.Logo
        Me.PBLogo.Location = New System.Drawing.Point(492, 58)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(47, 45)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 11
        Me.PBLogo.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiModerar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmiModerar
        '
        Me.tsmiModerar.Name = "tsmiModerar"
        Me.tsmiModerar.Size = New System.Drawing.Size(64, 20)
        Me.tsmiModerar.Text = "moderar"
        '
        'LVListadoUsuarios
        '
        Me.LVListadoUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LVListadoUsuarios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Username, Me.Email, Me.Password, Me.sexo, Me.FechaNac, Me.rol, Me.id})
        Me.LVListadoUsuarios.FullRowSelect = True
        Me.LVListadoUsuarios.GridLines = True
        Me.LVListadoUsuarios.HideSelection = False
        Me.LVListadoUsuarios.Location = New System.Drawing.Point(59, 122)
        Me.LVListadoUsuarios.MultiSelect = False
        Me.LVListadoUsuarios.Name = "LVListadoUsuarios"
        Me.LVListadoUsuarios.Size = New System.Drawing.Size(610, 192)
        Me.LVListadoUsuarios.TabIndex = 22
        Me.LVListadoUsuarios.UseCompatibleStateImageBehavior = False
        Me.LVListadoUsuarios.View = System.Windows.Forms.View.Details
        '
        'Username
        '
        Me.Username.Text = "Username"
        Me.Username.Width = 68
        '
        'Email
        '
        Me.Email.Text = "Email"
        Me.Email.Width = 125
        '
        'Password
        '
        Me.Password.Text = "Password"
        Me.Password.Width = 122
        '
        'sexo
        '
        Me.sexo.Text = "Sexo"
        Me.sexo.Width = 78
        '
        'FechaNac
        '
        Me.FechaNac.Text = "FechaNac"
        Me.FechaNac.Width = 93
        '
        'rol
        '
        Me.rol.Text = "rol"
        '
        'id
        '
        Me.id.Text = "id"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(401, 370)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(118, 40)
        Me.btnEliminar.TabIndex = 23
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'PantallaListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.LVListadoUsuarios)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.PBLogo)
        Me.Controls.Add(Me.LabelBienvenido)
        Me.Name = "PantallaListar"
        Me.Text = "Administrador SLine! - Listar"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelBienvenido As Label
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmiModerar As ToolStripMenuItem
    Friend WithEvents LVListadoUsuarios As ListView
    Friend WithEvents Username As ColumnHeader
    Friend WithEvents Email As ColumnHeader
    Friend WithEvents Password As ColumnHeader
    Friend WithEvents sexo As ColumnHeader
    Friend WithEvents FechaNac As ColumnHeader
    Friend WithEvents rol As ColumnHeader
    Friend WithEvents id As ColumnHeader
    Friend WithEvents btnEliminar As Button
End Class
