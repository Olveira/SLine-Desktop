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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaListar))
        Me.LVListadoUsuarios = New System.Windows.Forms.ListView()
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaNac = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnExitListarPersonas = New System.Windows.Forms.Button()
        Me.BtnMinimizeListarPersonas = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.BtnModerar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LVListadoUsuarios
        '
        Me.LVListadoUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LVListadoUsuarios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Username, Me.Email, Me.Password, Me.sexo, Me.FechaNac, Me.rol, Me.id})
        Me.LVListadoUsuarios.FullRowSelect = True
        Me.LVListadoUsuarios.GridLines = True
        Me.LVListadoUsuarios.HideSelection = False
        Me.LVListadoUsuarios.Location = New System.Drawing.Point(12, 98)
        Me.LVListadoUsuarios.MultiSelect = False
        Me.LVListadoUsuarios.Name = "LVListadoUsuarios"
        Me.LVListadoUsuarios.Size = New System.Drawing.Size(716, 263)
        Me.LVListadoUsuarios.TabIndex = 22
        Me.LVListadoUsuarios.UseCompatibleStateImageBehavior = False
        Me.LVListadoUsuarios.View = System.Windows.Forms.View.Details
        '
        'Username
        '
        Me.Username.Text = "Username"
        Me.Username.Width = 100
        '
        'Email
        '
        Me.Email.Text = "Email"
        Me.Email.Width = 190
        '
        'Password
        '
        Me.Password.Text = "Password"
        Me.Password.Width = 122
        '
        'sexo
        '
        Me.sexo.Text = "Sexo"
        Me.sexo.Width = 93
        '
        'FechaNac
        '
        Me.FechaNac.Text = "FechaNac"
        Me.FechaNac.Width = 93
        '
        'rol
        '
        Me.rol.Text = "rol"
        Me.rol.Width = 55
        '
        'id
        '
        Me.id.Text = "id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(68, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 58)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Listar Personas"
        '
        'BtnExitListarPersonas
        '
        Me.BtnExitListarPersonas.BackColor = System.Drawing.Color.Transparent
        Me.BtnExitListarPersonas.BackgroundImage = CType(resources.GetObject("BtnExitListarPersonas.BackgroundImage"), System.Drawing.Image)
        Me.BtnExitListarPersonas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExitListarPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExitListarPersonas.Location = New System.Drawing.Point(704, 9)
        Me.BtnExitListarPersonas.Name = "BtnExitListarPersonas"
        Me.BtnExitListarPersonas.Size = New System.Drawing.Size(24, 24)
        Me.BtnExitListarPersonas.TabIndex = 31
        Me.BtnExitListarPersonas.UseVisualStyleBackColor = False
        '
        'BtnMinimizeListarPersonas
        '
        Me.BtnMinimizeListarPersonas.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizeListarPersonas.BackgroundImage = CType(resources.GetObject("BtnMinimizeListarPersonas.BackgroundImage"), System.Drawing.Image)
        Me.BtnMinimizeListarPersonas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMinimizeListarPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizeListarPersonas.Location = New System.Drawing.Point(674, 9)
        Me.BtnMinimizeListarPersonas.Name = "BtnMinimizeListarPersonas"
        Me.BtnMinimizeListarPersonas.Size = New System.Drawing.Size(24, 24)
        Me.BtnMinimizeListarPersonas.TabIndex = 30
        Me.BtnMinimizeListarPersonas.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BtnModerar)
        Me.Panel1.Controls.Add(Me.BtnEliminar)
        Me.Panel1.Controls.Add(Me.BtnEditar)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(0, 377)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 88)
        Me.Panel1.TabIndex = 32
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(600, 88)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 200
        Me.LineShape1.X2 = 200
        Me.LineShape1.Y1 = 0
        Me.LineShape1.Y2 = 88
        '
        'BtnEditar
        '
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Location = New System.Drawing.Point(201, 0)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(199, 88)
        Me.BtnEditar.TabIndex = 1
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Location = New System.Drawing.Point(0, 0)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(199, 88)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 400
        Me.LineShape2.X2 = 400
        Me.LineShape2.Y1 = 0
        Me.LineShape2.Y2 = 88
        '
        'BtnModerar
        '
        Me.BtnModerar.FlatAppearance.BorderSize = 0
        Me.BtnModerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModerar.Location = New System.Drawing.Point(401, 0)
        Me.BtnModerar.Name = "BtnModerar"
        Me.BtnModerar.Size = New System.Drawing.Size(199, 88)
        Me.BtnModerar.TabIndex = 3
        Me.BtnModerar.Text = "Moderar"
        Me.BtnModerar.UseVisualStyleBackColor = True
        '
        'PantallaListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(740, 465)
        Me.Controls.Add(Me.BtnExitListarPersonas)
        Me.Controls.Add(Me.BtnMinimizeListarPersonas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LVListadoUsuarios)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaListar"
        Me.Text = "s"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LVListadoUsuarios As ListView
    Friend WithEvents Username As ColumnHeader
    Friend WithEvents Email As ColumnHeader
    Friend WithEvents Password As ColumnHeader
    Friend WithEvents sexo As ColumnHeader
    Friend WithEvents FechaNac As ColumnHeader
    Friend WithEvents rol As ColumnHeader
    Friend WithEvents id As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnExitListarPersonas As Button
    Friend WithEvents BtnMinimizeListarPersonas As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents BtnModerar As Button
End Class
