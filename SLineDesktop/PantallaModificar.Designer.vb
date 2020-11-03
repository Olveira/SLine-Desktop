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
        Me.lblModificarUsuario = New System.Windows.Forms.Label()
        Me.BtnAceptarMod = New System.Windows.Forms.Button()
        Me.btnCancelarMod = New System.Windows.Forms.Button()
        Me.TbxUserMod = New System.Windows.Forms.TextBox()
        Me.TbxEmailMod = New System.Windows.Forms.TextBox()
        Me.TbxContraseñaMod = New System.Windows.Forms.TextBox()
        Me.CbxSexoMod = New System.Windows.Forms.ComboBox()
        Me.DTPFechaNacMod = New System.Windows.Forms.DateTimePicker()
        Me.CbxRolMod = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblModificarUsuario
        '
        Me.lblModificarUsuario.AutoSize = True
        Me.lblModificarUsuario.Font = New System.Drawing.Font("Century Gothic", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificarUsuario.Location = New System.Drawing.Point(12, 38)
        Me.lblModificarUsuario.Name = "lblModificarUsuario"
        Me.lblModificarUsuario.Size = New System.Drawing.Size(383, 52)
        Me.lblModificarUsuario.TabIndex = 11
        Me.lblModificarUsuario.Text = "Modificar usuario"
        '
        'BtnAceptarMod
        '
        Me.BtnAceptarMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnAceptarMod.Location = New System.Drawing.Point(300, 361)
        Me.BtnAceptarMod.Name = "BtnAceptarMod"
        Me.BtnAceptarMod.Size = New System.Drawing.Size(85, 40)
        Me.BtnAceptarMod.TabIndex = 17
        Me.BtnAceptarMod.Text = "Aceptar"
        Me.BtnAceptarMod.UseVisualStyleBackColor = True
        '
        'btnCancelarMod
        '
        Me.btnCancelarMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnCancelarMod.Location = New System.Drawing.Point(61, 361)
        Me.btnCancelarMod.Name = "btnCancelarMod"
        Me.btnCancelarMod.Size = New System.Drawing.Size(85, 40)
        Me.btnCancelarMod.TabIndex = 18
        Me.btnCancelarMod.Text = "Cancelar"
        Me.btnCancelarMod.UseVisualStyleBackColor = True
        '
        'TbxUserMod
        '
        Me.TbxUserMod.BackColor = System.Drawing.Color.LavenderBlush
        Me.TbxUserMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbxUserMod.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxUserMod.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TbxUserMod.Location = New System.Drawing.Point(12, 98)
        Me.TbxUserMod.Name = "TbxUserMod"
        Me.TbxUserMod.Size = New System.Drawing.Size(400, 31)
        Me.TbxUserMod.TabIndex = 22
        Me.TbxUserMod.Tag = ""
        Me.TbxUserMod.Text = "Nombre de Usuario"
        '
        'TbxEmailMod
        '
        Me.TbxEmailMod.BackColor = System.Drawing.Color.LavenderBlush
        Me.TbxEmailMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbxEmailMod.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxEmailMod.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TbxEmailMod.Location = New System.Drawing.Point(12, 135)
        Me.TbxEmailMod.Name = "TbxEmailMod"
        Me.TbxEmailMod.Size = New System.Drawing.Size(400, 31)
        Me.TbxEmailMod.TabIndex = 23
        Me.TbxEmailMod.Text = "Email"
        '
        'TbxContraseñaMod
        '
        Me.TbxContraseñaMod.BackColor = System.Drawing.Color.LavenderBlush
        Me.TbxContraseñaMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbxContraseñaMod.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxContraseñaMod.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TbxContraseñaMod.Location = New System.Drawing.Point(12, 172)
        Me.TbxContraseñaMod.Name = "TbxContraseñaMod"
        Me.TbxContraseñaMod.Size = New System.Drawing.Size(400, 31)
        Me.TbxContraseñaMod.TabIndex = 24
        Me.TbxContraseñaMod.Text = "Contraseña"
        '
        'CbxSexoMod
        '
        Me.CbxSexoMod.BackColor = System.Drawing.Color.LavenderBlush
        Me.CbxSexoMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxSexoMod.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSexoMod.FormattingEnabled = True
        Me.CbxSexoMod.Location = New System.Drawing.Point(12, 209)
        Me.CbxSexoMod.Name = "CbxSexoMod"
        Me.CbxSexoMod.Size = New System.Drawing.Size(400, 30)
        Me.CbxSexoMod.TabIndex = 25
        Me.CbxSexoMod.Text = "Sexo"
        '
        'DTPFechaNacMod
        '
        Me.DTPFechaNacMod.CalendarMonthBackground = System.Drawing.Color.Violet
        Me.DTPFechaNacMod.CalendarTitleBackColor = System.Drawing.Color.LavenderBlush
        Me.DTPFechaNacMod.CalendarTrailingForeColor = System.Drawing.Color.LavenderBlush
        Me.DTPFechaNacMod.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaNacMod.Location = New System.Drawing.Point(12, 281)
        Me.DTPFechaNacMod.Name = "DTPFechaNacMod"
        Me.DTPFechaNacMod.Size = New System.Drawing.Size(400, 31)
        Me.DTPFechaNacMod.TabIndex = 27
        Me.DTPFechaNacMod.Value = New Date(2020, 10, 29, 10, 13, 7, 0)
        '
        'CbxRolMod
        '
        Me.CbxRolMod.BackColor = System.Drawing.Color.LavenderBlush
        Me.CbxRolMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxRolMod.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxRolMod.FormattingEnabled = True
        Me.CbxRolMod.Location = New System.Drawing.Point(12, 245)
        Me.CbxRolMod.Name = "CbxRolMod"
        Me.CbxRolMod.Size = New System.Drawing.Size(400, 30)
        Me.CbxRolMod.TabIndex = 26
        Me.CbxRolMod.Text = "Rol"
        '
        'PantallaModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 424)
        Me.Controls.Add(Me.CbxRolMod)
        Me.Controls.Add(Me.DTPFechaNacMod)
        Me.Controls.Add(Me.CbxSexoMod)
        Me.Controls.Add(Me.TbxContraseñaMod)
        Me.Controls.Add(Me.TbxEmailMod)
        Me.Controls.Add(Me.TbxUserMod)
        Me.Controls.Add(Me.btnCancelarMod)
        Me.Controls.Add(Me.BtnAceptarMod)
        Me.Controls.Add(Me.lblModificarUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaModificar"
        Me.Text = "Administrador SLine! - Modificar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblModificarUsuario As Label
    Friend WithEvents BtnAceptarMod As Button
    Friend WithEvents btnCancelarMod As Button
    Friend WithEvents TbxUserMod As TextBox
    Friend WithEvents TbxEmailMod As TextBox
    Friend WithEvents TbxContraseñaMod As TextBox
    Friend WithEvents CbxSexoMod As ComboBox
    Friend WithEvents DTPFechaNacMod As DateTimePicker
    Friend WithEvents CbxRolMod As ComboBox
End Class
