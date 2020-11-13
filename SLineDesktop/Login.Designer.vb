<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TbxUserLog = New System.Windows.Forms.TextBox()
        Me.TbxPasswordLog = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Registrar = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnMinimizeLogin = New System.Windows.Forms.Button()
        Me.BtnExitLogin = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.BtnAceptar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnAceptar.FlatAppearance.BorderSize = 0
        Me.BtnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.Color.Snow
        Me.BtnAceptar.Location = New System.Drawing.Point(0, 0)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(219, 88)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'TbxUserLog
        '
        Me.TbxUserLog.BackColor = System.Drawing.Color.LavenderBlush
        Me.TbxUserLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbxUserLog.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxUserLog.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TbxUserLog.Location = New System.Drawing.Point(12, 130)
        Me.TbxUserLog.Name = "TbxUserLog"
        Me.TbxUserLog.Size = New System.Drawing.Size(420, 24)
        Me.TbxUserLog.TabIndex = 1
        Me.TbxUserLog.Text = "Nombre de Usuario"
        '
        'TbxPasswordLog
        '
        Me.TbxPasswordLog.BackColor = System.Drawing.Color.LavenderBlush
        Me.TbxPasswordLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbxPasswordLog.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxPasswordLog.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TbxPasswordLog.Location = New System.Drawing.Point(12, 185)
        Me.TbxPasswordLog.Name = "TbxPasswordLog"
        Me.TbxPasswordLog.Size = New System.Drawing.Size(420, 24)
        Me.TbxPasswordLog.TabIndex = 2
        Me.TbxPasswordLog.Text = "Contraseña"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.BtnAceptar)
        Me.Panel2.Controls.Add(Me.Registrar)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Location = New System.Drawing.Point(0, 292)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(438, 88)
        Me.Panel2.TabIndex = 16
        '
        'Registrar
        '
        Me.Registrar.BackColor = System.Drawing.Color.Transparent
        Me.Registrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Registrar.FlatAppearance.BorderSize = 0
        Me.Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Registrar.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registrar.ForeColor = System.Drawing.Color.Snow
        Me.Registrar.Location = New System.Drawing.Point(220, 0)
        Me.Registrar.Margin = New System.Windows.Forms.Padding(0)
        Me.Registrar.Name = "Registrar"
        Me.Registrar.Size = New System.Drawing.Size(218, 88)
        Me.Registrar.TabIndex = 4
        Me.Registrar.Text = "Registrarse"
        Me.Registrar.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(438, 88)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Snow
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 219
        Me.LineShape2.X2 = 219
        Me.LineShape2.Y1 = 0
        Me.LineShape2.Y2 = 88
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 75
        Me.LineShape1.Y1 = 0
        Me.LineShape1.Y2 = 23
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(131, 228)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(174, 16)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "¿Has olvidado tu contraseña?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(147, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 58)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Inicio"
        '
        'BtnMinimizeLogin
        '
        Me.BtnMinimizeLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizeLogin.BackgroundImage = CType(resources.GetObject("BtnMinimizeLogin.BackgroundImage"), System.Drawing.Image)
        Me.BtnMinimizeLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMinimizeLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnMinimizeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizeLogin.Location = New System.Drawing.Point(654, 12)
        Me.BtnMinimizeLogin.Name = "BtnMinimizeLogin"
        Me.BtnMinimizeLogin.Size = New System.Drawing.Size(24, 24)
        Me.BtnMinimizeLogin.TabIndex = 19
        Me.BtnMinimizeLogin.UseVisualStyleBackColor = False
        '
        'BtnExitLogin
        '
        Me.BtnExitLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnExitLogin.BackgroundImage = CType(resources.GetObject("BtnExitLogin.BackgroundImage"), System.Drawing.Image)
        Me.BtnExitLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExitLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnExitLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExitLogin.Location = New System.Drawing.Point(684, 12)
        Me.BtnExitLogin.Name = "BtnExitLogin"
        Me.BtnExitLogin.Size = New System.Drawing.Size(24, 24)
        Me.BtnExitLogin.TabIndex = 20
        Me.BtnExitLogin.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 380)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnExitLogin)
        Me.Controls.Add(Me.BtnMinimizeLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.TbxPasswordLog)
        Me.Controls.Add(Me.TbxUserLog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Administrador SLine! - Log in"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TbxUserLog As TextBox
    Friend WithEvents TbxPasswordLog As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Registrar As Button
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnMinimizeLogin As Button
    Friend WithEvents BtnExitLogin As Button
End Class
