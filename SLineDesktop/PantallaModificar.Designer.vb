<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PantallaModificar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaModificar))
        Me.lblModificarUsuario = New System.Windows.Forms.Label()
        Me.BtnAceptarMod = New System.Windows.Forms.Button()
        Me.TbxUserMod = New System.Windows.Forms.TextBox()
        Me.TbxEmailMod = New System.Windows.Forms.TextBox()
        Me.TbxContraseñaMod = New System.Windows.Forms.TextBox()
        Me.CbxSexoMod = New System.Windows.Forms.ComboBox()
        Me.DTPFechaNacMod = New System.Windows.Forms.DateTimePicker()
        Me.CbxRolMod = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnBuscarMod = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.BtnExitMod = New System.Windows.Forms.Button()
        Me.BtnMinimizeMod = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblModificarUsuario
        '
        Me.lblModificarUsuario.AutoSize = True
        Me.lblModificarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblModificarUsuario.Font = New System.Drawing.Font("Century Gothic", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificarUsuario.ForeColor = System.Drawing.Color.Snow
        Me.lblModificarUsuario.Location = New System.Drawing.Point(30, 20)
        Me.lblModificarUsuario.Name = "lblModificarUsuario"
        Me.lblModificarUsuario.Size = New System.Drawing.Size(383, 52)
        Me.lblModificarUsuario.TabIndex = 11
        Me.lblModificarUsuario.Text = "Modificar usuario"
        '
        'BtnAceptarMod
        '
        Me.BtnAceptarMod.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnAceptarMod.FlatAppearance.BorderSize = 0
        Me.BtnAceptarMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BtnAceptarMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptarMod.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptarMod.ForeColor = System.Drawing.Color.Snow
        Me.BtnAceptarMod.Location = New System.Drawing.Point(0, 0)
        Me.BtnAceptarMod.Name = "BtnAceptarMod"
        Me.BtnAceptarMod.Size = New System.Drawing.Size(218, 88)
        Me.BtnAceptarMod.TabIndex = 17
        Me.BtnAceptarMod.Text = "Modificar"
        Me.BtnAceptarMod.UseVisualStyleBackColor = True
        '
        'TbxUserMod
        '
        Me.TbxUserMod.BackColor = System.Drawing.Color.LavenderBlush
        Me.TbxUserMod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbxUserMod.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxUserMod.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TbxUserMod.Location = New System.Drawing.Point(12, 100)
        Me.TbxUserMod.Name = "TbxUserMod"
        Me.TbxUserMod.Size = New System.Drawing.Size(420, 24)
        Me.TbxUserMod.TabIndex = 22
        Me.TbxUserMod.Tag = ""
        Me.TbxUserMod.Text = "Nombre de Usuario"
        '
        'TbxEmailMod
        '
        Me.TbxEmailMod.BackColor = System.Drawing.Color.LavenderBlush
        Me.TbxEmailMod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbxEmailMod.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxEmailMod.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TbxEmailMod.Location = New System.Drawing.Point(12, 137)
        Me.TbxEmailMod.Name = "TbxEmailMod"
        Me.TbxEmailMod.Size = New System.Drawing.Size(420, 24)
        Me.TbxEmailMod.TabIndex = 23
        Me.TbxEmailMod.Text = "Email"
        '
        'TbxContraseñaMod
        '
        Me.TbxContraseñaMod.BackColor = System.Drawing.Color.LavenderBlush
        Me.TbxContraseñaMod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbxContraseñaMod.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxContraseñaMod.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TbxContraseñaMod.Location = New System.Drawing.Point(12, 174)
        Me.TbxContraseñaMod.Name = "TbxContraseñaMod"
        Me.TbxContraseñaMod.Size = New System.Drawing.Size(420, 24)
        Me.TbxContraseñaMod.TabIndex = 24
        Me.TbxContraseñaMod.Text = "Contraseña"
        '
        'CbxSexoMod
        '
        Me.CbxSexoMod.BackColor = System.Drawing.Color.LavenderBlush
        Me.CbxSexoMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxSexoMod.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSexoMod.FormattingEnabled = True
        Me.CbxSexoMod.Location = New System.Drawing.Point(12, 211)
        Me.CbxSexoMod.Name = "CbxSexoMod"
        Me.CbxSexoMod.Size = New System.Drawing.Size(420, 30)
        Me.CbxSexoMod.TabIndex = 25
        Me.CbxSexoMod.Text = "Sexo"
        '
        'DTPFechaNacMod
        '
        Me.DTPFechaNacMod.CalendarMonthBackground = System.Drawing.Color.Violet
        Me.DTPFechaNacMod.CalendarTitleBackColor = System.Drawing.Color.LavenderBlush
        Me.DTPFechaNacMod.CalendarTrailingForeColor = System.Drawing.Color.LavenderBlush
        Me.DTPFechaNacMod.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaNacMod.Location = New System.Drawing.Point(12, 283)
        Me.DTPFechaNacMod.Name = "DTPFechaNacMod"
        Me.DTPFechaNacMod.Size = New System.Drawing.Size(420, 31)
        Me.DTPFechaNacMod.TabIndex = 27
        Me.DTPFechaNacMod.Value = New Date(2020, 10, 29, 10, 13, 7, 0)
        '
        'CbxRolMod
        '
        Me.CbxRolMod.BackColor = System.Drawing.Color.LavenderBlush
        Me.CbxRolMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxRolMod.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxRolMod.FormattingEnabled = True
        Me.CbxRolMod.Location = New System.Drawing.Point(12, 247)
        Me.CbxRolMod.Name = "CbxRolMod"
        Me.CbxRolMod.Size = New System.Drawing.Size(420, 30)
        Me.CbxRolMod.TabIndex = 26
        Me.CbxRolMod.Text = "Rol"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BtnBuscarMod)
        Me.Panel1.Controls.Add(Me.BtnAceptarMod)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(0, 332)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 88)
        Me.Panel1.TabIndex = 28
        '
        'BtnBuscarMod
        '
        Me.BtnBuscarMod.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnBuscarMod.FlatAppearance.BorderSize = 0
        Me.BtnBuscarMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BtnBuscarMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarMod.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarMod.ForeColor = System.Drawing.Color.Snow
        Me.BtnBuscarMod.Location = New System.Drawing.Point(219, 0)
        Me.BtnBuscarMod.Name = "BtnBuscarMod"
        Me.BtnBuscarMod.Size = New System.Drawing.Size(219, 88)
        Me.BtnBuscarMod.TabIndex = 18
        Me.BtnBuscarMod.Text = "Buscar(Un, Em)"
        Me.BtnBuscarMod.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(438, 88)
        Me.ShapeContainer1.TabIndex = 19
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Snow
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 218
        Me.LineShape1.X2 = 218
        Me.LineShape1.Y1 = 0
        Me.LineShape1.Y2 = 88
        '
        'BtnExitMod
        '
        Me.BtnExitMod.BackColor = System.Drawing.Color.Transparent
        Me.BtnExitMod.BackgroundImage = CType(resources.GetObject("BtnExitMod.BackgroundImage"), System.Drawing.Image)
        Me.BtnExitMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExitMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnExitMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExitMod.Location = New System.Drawing.Point(684, 12)
        Me.BtnExitMod.Name = "BtnExitMod"
        Me.BtnExitMod.Size = New System.Drawing.Size(24, 24)
        Me.BtnExitMod.TabIndex = 35
        Me.BtnExitMod.UseVisualStyleBackColor = False
        '
        'BtnMinimizeMod
        '
        Me.BtnMinimizeMod.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizeMod.BackgroundImage = CType(resources.GetObject("BtnMinimizeMod.BackgroundImage"), System.Drawing.Image)
        Me.BtnMinimizeMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMinimizeMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnMinimizeMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizeMod.Location = New System.Drawing.Point(654, 12)
        Me.BtnMinimizeMod.Name = "BtnMinimizeMod"
        Me.BtnMinimizeMod.Size = New System.Drawing.Size(24, 24)
        Me.BtnMinimizeMod.TabIndex = 34
        Me.BtnMinimizeMod.UseVisualStyleBackColor = False
        '
        'PantallaModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 420)
        Me.Controls.Add(Me.BtnExitMod)
        Me.Controls.Add(Me.BtnMinimizeMod)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CbxRolMod)
        Me.Controls.Add(Me.DTPFechaNacMod)
        Me.Controls.Add(Me.CbxSexoMod)
        Me.Controls.Add(Me.TbxContraseñaMod)
        Me.Controls.Add(Me.TbxEmailMod)
        Me.Controls.Add(Me.TbxUserMod)
        Me.Controls.Add(Me.lblModificarUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaModificar"
        Me.Text = "Administrador SLine! - Modificar"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblModificarUsuario As Label
    Friend WithEvents BtnAceptarMod As Button
    Friend WithEvents TbxUserMod As TextBox
    Friend WithEvents TbxEmailMod As TextBox
    Friend WithEvents TbxContraseñaMod As TextBox
    Friend WithEvents CbxSexoMod As ComboBox
    Friend WithEvents DTPFechaNacMod As DateTimePicker
    Friend WithEvents CbxRolMod As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnExitMod As Button
    Friend WithEvents BtnMinimizeMod As Button
    Friend WithEvents BtnBuscarMod As Button
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
End Class
