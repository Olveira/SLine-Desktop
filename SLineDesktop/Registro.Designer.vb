<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.btnAceptarReg = New System.Windows.Forms.Button()
        Me.TbxUserReg = New System.Windows.Forms.TextBox()
        Me.TbxEmailReg = New System.Windows.Forms.TextBox()
        Me.TbxContraseñaReg = New System.Windows.Forms.TextBox()
        Me.CbxSexo = New System.Windows.Forms.ComboBox()
        Me.DTPFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.btnback = New System.Windows.Forms.Button()
        Me.CbxRol = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnMinimizeRegistro = New System.Windows.Forms.Button()
        Me.BtnExitRegistro = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptarReg
        '
        Me.btnAceptarReg.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAceptarReg.FlatAppearance.BorderSize = 0
        Me.btnAceptarReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAceptarReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarReg.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarReg.ForeColor = System.Drawing.Color.Snow
        Me.btnAceptarReg.Location = New System.Drawing.Point(0, 0)
        Me.btnAceptarReg.Name = "btnAceptarReg"
        Me.btnAceptarReg.Size = New System.Drawing.Size(217, 88)
        Me.btnAceptarReg.TabIndex = 7
        Me.btnAceptarReg.Text = "Aceptar"
        Me.btnAceptarReg.UseVisualStyleBackColor = True
        '
        'TbxUserReg
        '
        Me.TbxUserReg.BackColor = System.Drawing.Color.LavenderBlush
        Me.TbxUserReg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbxUserReg.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxUserReg.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TbxUserReg.Location = New System.Drawing.Point(12, 100)
        Me.TbxUserReg.Name = "TbxUserReg"
        Me.TbxUserReg.Size = New System.Drawing.Size(420, 24)
        Me.TbxUserReg.TabIndex = 1
        Me.TbxUserReg.Tag = ""
        Me.TbxUserReg.Text = "Nombre de Usuario"
        '
        'TbxEmailReg
        '
        Me.TbxEmailReg.BackColor = System.Drawing.Color.LavenderBlush
        Me.TbxEmailReg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbxEmailReg.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxEmailReg.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TbxEmailReg.Location = New System.Drawing.Point(12, 137)
        Me.TbxEmailReg.Name = "TbxEmailReg"
        Me.TbxEmailReg.Size = New System.Drawing.Size(420, 24)
        Me.TbxEmailReg.TabIndex = 2
        Me.TbxEmailReg.Text = "Email"
        '
        'TbxContraseñaReg
        '
        Me.TbxContraseñaReg.BackColor = System.Drawing.Color.LavenderBlush
        Me.TbxContraseñaReg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbxContraseñaReg.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxContraseñaReg.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TbxContraseñaReg.Location = New System.Drawing.Point(12, 174)
        Me.TbxContraseñaReg.Name = "TbxContraseñaReg"
        Me.TbxContraseñaReg.Size = New System.Drawing.Size(420, 24)
        Me.TbxContraseñaReg.TabIndex = 3
        Me.TbxContraseñaReg.Text = "Contraseña"
        '
        'CbxSexo
        '
        Me.CbxSexo.BackColor = System.Drawing.Color.LavenderBlush
        Me.CbxSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxSexo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSexo.FormattingEnabled = True
        Me.CbxSexo.Location = New System.Drawing.Point(12, 211)
        Me.CbxSexo.Name = "CbxSexo"
        Me.CbxSexo.Size = New System.Drawing.Size(420, 30)
        Me.CbxSexo.TabIndex = 4
        Me.CbxSexo.Text = "Sexo"
        '
        'DTPFechaNac
        '
        Me.DTPFechaNac.CalendarMonthBackground = System.Drawing.Color.Violet
        Me.DTPFechaNac.CalendarTitleBackColor = System.Drawing.Color.Lavender
        Me.DTPFechaNac.CalendarTrailingForeColor = System.Drawing.Color.LavenderBlush
        Me.DTPFechaNac.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaNac.Location = New System.Drawing.Point(12, 283)
        Me.DTPFechaNac.Name = "DTPFechaNac"
        Me.DTPFechaNac.Size = New System.Drawing.Size(420, 31)
        Me.DTPFechaNac.TabIndex = 6
        Me.DTPFechaNac.Value = New Date(2020, 10, 29, 10, 13, 7, 0)
        '
        'btnback
        '
        Me.btnback.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnback.FlatAppearance.BorderSize = 0
        Me.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.Snow
        Me.btnback.Location = New System.Drawing.Point(220, 0)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(218, 88)
        Me.btnback.TabIndex = 8
        Me.btnback.Text = "Iniciar Sesion"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'CbxRol
        '
        Me.CbxRol.BackColor = System.Drawing.Color.LavenderBlush
        Me.CbxRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxRol.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxRol.FormattingEnabled = True
        Me.CbxRol.Location = New System.Drawing.Point(12, 247)
        Me.CbxRol.Name = "CbxRol"
        Me.CbxRol.Size = New System.Drawing.Size(420, 30)
        Me.CbxRol.TabIndex = 5
        Me.CbxRol.Text = "Rol"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BtnMinimizeRegistro)
        Me.Panel1.Controls.Add(Me.BtnExitRegistro)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(438, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(282, 420)
        Me.Panel1.TabIndex = 25
        '
        'BtnMinimizeRegistro
        '
        Me.BtnMinimizeRegistro.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizeRegistro.BackgroundImage = CType(resources.GetObject("BtnMinimizeRegistro.BackgroundImage"), System.Drawing.Image)
        Me.BtnMinimizeRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMinimizeRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnMinimizeRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizeRegistro.Location = New System.Drawing.Point(216, 12)
        Me.BtnMinimizeRegistro.Name = "BtnMinimizeRegistro"
        Me.BtnMinimizeRegistro.Size = New System.Drawing.Size(24, 24)
        Me.BtnMinimizeRegistro.TabIndex = 9
        Me.BtnMinimizeRegistro.UseVisualStyleBackColor = False
        '
        'BtnExitRegistro
        '
        Me.BtnExitRegistro.BackColor = System.Drawing.Color.Transparent
        Me.BtnExitRegistro.BackgroundImage = CType(resources.GetObject("BtnExitRegistro.BackgroundImage"), System.Drawing.Image)
        Me.BtnExitRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExitRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnExitRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExitRegistro.Location = New System.Drawing.Point(246, 12)
        Me.BtnExitRegistro.Name = "BtnExitRegistro"
        Me.BtnExitRegistro.Size = New System.Drawing.Size(24, 24)
        Me.BtnExitRegistro.TabIndex = 10
        Me.BtnExitRegistro.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Snow
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(438, 85)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Registro"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnAceptarReg)
        Me.Panel2.Controls.Add(Me.btnback)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 332)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(438, 88)
        Me.Panel2.TabIndex = 27
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(438, 88)
        Me.ShapeContainer1.TabIndex = 24
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Snow
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 218
        Me.LineShape2.X2 = 218
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
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 420)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CbxRol)
        Me.Controls.Add(Me.DTPFechaNac)
        Me.Controls.Add(Me.CbxSexo)
        Me.Controls.Add(Me.TbxContraseñaReg)
        Me.Controls.Add(Me.TbxEmailReg)
        Me.Controls.Add(Me.TbxUserReg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro"
        Me.Text = "Administrador SLine! - Registrar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptarReg As Button
    Friend WithEvents TbxUserReg As TextBox
    Friend WithEvents TbxEmailReg As TextBox
    Friend WithEvents TbxContraseñaReg As TextBox
    Friend WithEvents CbxSexo As ComboBox
    Friend WithEvents DTPFechaNac As DateTimePicker
    Friend WithEvents btnback As Button
    Friend WithEvents CbxRol As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents BtnMinimizeRegistro As Button
    Friend WithEvents BtnExitRegistro As Button
End Class
