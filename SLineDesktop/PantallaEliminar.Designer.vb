﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaEliminar
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
        Me.lblModificarUsuario = New System.Windows.Forms.Label()
        Me.BtnAceptarMod = New System.Windows.Forms.Button()
        Me.btnCancelarMod = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModerarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblRolMod = New System.Windows.Forms.Label()
        Me.cbxRolMod = New System.Windows.Forms.ComboBox()
        Me.DTPFechaNacMod = New System.Windows.Forms.DateTimePicker()
        Me.cbxSexoMod = New System.Windows.Forms.ComboBox()
        Me.tbxContraseñaMod = New System.Windows.Forms.TextBox()
        Me.tbxEmailMod = New System.Windows.Forms.TextBox()
        Me.tbxUserMod = New System.Windows.Forms.TextBox()
        Me.lblFechaNacRegMod = New System.Windows.Forms.Label()
        Me.lblSexoMod = New System.Windows.Forms.Label()
        Me.lblPasswordMod = New System.Windows.Forms.Label()
        Me.lblEmailMod = New System.Windows.Forms.Label()
        Me.lblUserMod = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblModificarUsuario
        '
        Me.lblModificarUsuario.AutoSize = True
        Me.lblModificarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.lblModificarUsuario.Location = New System.Drawing.Point(170, 48)
        Me.lblModificarUsuario.Name = "lblModificarUsuario"
        Me.lblModificarUsuario.Size = New System.Drawing.Size(379, 54)
        Me.lblModificarUsuario.TabIndex = 11
        Me.lblModificarUsuario.Text = "Modificar usuario"
        '
        'BtnAceptarMod
        '
        Me.BtnAceptarMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnAceptarMod.Location = New System.Drawing.Point(492, 355)
        Me.BtnAceptarMod.Name = "BtnAceptarMod"
        Me.BtnAceptarMod.Size = New System.Drawing.Size(85, 40)
        Me.BtnAceptarMod.TabIndex = 17
        Me.BtnAceptarMod.Text = "Aceptar"
        Me.BtnAceptarMod.UseVisualStyleBackColor = True
        '
        'btnCancelarMod
        '
        Me.btnCancelarMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnCancelarMod.Location = New System.Drawing.Point(111, 355)
        Me.btnCancelarMod.Name = "btnCancelarMod"
        Me.btnCancelarMod.Size = New System.Drawing.Size(85, 40)
        Me.btnCancelarMod.TabIndex = 18
        Me.btnCancelarMod.Text = "Cancelar"
        Me.btnCancelarMod.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModerarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModerarToolStripMenuItem
        '
        Me.ModerarToolStripMenuItem.Name = "ModerarToolStripMenuItem"
        Me.ModerarToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ModerarToolStripMenuItem.Text = "Moderar"
        '
        'lblRolMod
        '
        Me.lblRolMod.AutoSize = True
        Me.lblRolMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRolMod.Location = New System.Drawing.Point(281, 238)
        Me.lblRolMod.Name = "lblRolMod"
        Me.lblRolMod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRolMod.Size = New System.Drawing.Size(33, 25)
        Me.lblRolMod.TabIndex = 37
        Me.lblRolMod.Text = "rol"
        '
        'cbxRolMod
        '
        Me.cbxRolMod.FormattingEnabled = True
        Me.cbxRolMod.Location = New System.Drawing.Point(320, 242)
        Me.cbxRolMod.Name = "cbxRolMod"
        Me.cbxRolMod.Size = New System.Drawing.Size(121, 21)
        Me.cbxRolMod.TabIndex = 36
        '
        'DTPFechaNacMod
        '
        Me.DTPFechaNacMod.Location = New System.Drawing.Point(320, 268)
        Me.DTPFechaNacMod.Name = "DTPFechaNacMod"
        Me.DTPFechaNacMod.Size = New System.Drawing.Size(200, 20)
        Me.DTPFechaNacMod.TabIndex = 35
        '
        'cbxSexoMod
        '
        Me.cbxSexoMod.FormattingEnabled = True
        Me.cbxSexoMod.Location = New System.Drawing.Point(320, 217)
        Me.cbxSexoMod.Name = "cbxSexoMod"
        Me.cbxSexoMod.Size = New System.Drawing.Size(121, 21)
        Me.cbxSexoMod.TabIndex = 34
        '
        'tbxContraseñaMod
        '
        Me.tbxContraseñaMod.Location = New System.Drawing.Point(320, 193)
        Me.tbxContraseñaMod.Name = "tbxContraseñaMod"
        Me.tbxContraseñaMod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxContraseñaMod.Size = New System.Drawing.Size(100, 20)
        Me.tbxContraseñaMod.TabIndex = 33
        '
        'tbxEmailMod
        '
        Me.tbxEmailMod.Location = New System.Drawing.Point(320, 168)
        Me.tbxEmailMod.Name = "tbxEmailMod"
        Me.tbxEmailMod.Size = New System.Drawing.Size(100, 20)
        Me.tbxEmailMod.TabIndex = 32
        '
        'tbxUserMod
        '
        Me.tbxUserMod.Location = New System.Drawing.Point(320, 143)
        Me.tbxUserMod.Name = "tbxUserMod"
        Me.tbxUserMod.Size = New System.Drawing.Size(100, 20)
        Me.tbxUserMod.TabIndex = 31
        '
        'lblFechaNacRegMod
        '
        Me.lblFechaNacRegMod.AutoSize = True
        Me.lblFechaNacRegMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacRegMod.Location = New System.Drawing.Point(121, 263)
        Me.lblFechaNacRegMod.Name = "lblFechaNacRegMod"
        Me.lblFechaNacRegMod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaNacRegMod.Size = New System.Drawing.Size(193, 25)
        Me.lblFechaNacRegMod.TabIndex = 30
        Me.lblFechaNacRegMod.Text = "Fecha de nacimiento"
        '
        'lblSexoMod
        '
        Me.lblSexoMod.AutoSize = True
        Me.lblSexoMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexoMod.Location = New System.Drawing.Point(256, 213)
        Me.lblSexoMod.Name = "lblSexoMod"
        Me.lblSexoMod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSexoMod.Size = New System.Drawing.Size(58, 25)
        Me.lblSexoMod.TabIndex = 29
        Me.lblSexoMod.Text = "Sexo"
        '
        'lblPasswordMod
        '
        Me.lblPasswordMod.AutoSize = True
        Me.lblPasswordMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordMod.Location = New System.Drawing.Point(200, 188)
        Me.lblPasswordMod.Name = "lblPasswordMod"
        Me.lblPasswordMod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPasswordMod.Size = New System.Drawing.Size(114, 25)
        Me.lblPasswordMod.TabIndex = 28
        Me.lblPasswordMod.Text = "Contraseña"
        '
        'lblEmailMod
        '
        Me.lblEmailMod.AutoSize = True
        Me.lblEmailMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailMod.Location = New System.Drawing.Point(256, 163)
        Me.lblEmailMod.Name = "lblEmailMod"
        Me.lblEmailMod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEmailMod.Size = New System.Drawing.Size(58, 25)
        Me.lblEmailMod.TabIndex = 27
        Me.lblEmailMod.Text = "email"
        '
        'lblUserMod
        '
        Me.lblUserMod.AutoSize = True
        Me.lblUserMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserMod.Location = New System.Drawing.Point(212, 138)
        Me.lblUserMod.Name = "lblUserMod"
        Me.lblUserMod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUserMod.Size = New System.Drawing.Size(102, 25)
        Me.lblUserMod.TabIndex = 26
        Me.lblUserMod.Text = "Username"
        '
        'PantallaEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 424)
        Me.Controls.Add(Me.lblRolMod)
        Me.Controls.Add(Me.cbxRolMod)
        Me.Controls.Add(Me.DTPFechaNacMod)
        Me.Controls.Add(Me.cbxSexoMod)
        Me.Controls.Add(Me.tbxContraseñaMod)
        Me.Controls.Add(Me.tbxEmailMod)
        Me.Controls.Add(Me.tbxUserMod)
        Me.Controls.Add(Me.lblFechaNacRegMod)
        Me.Controls.Add(Me.lblSexoMod)
        Me.Controls.Add(Me.lblPasswordMod)
        Me.Controls.Add(Me.lblEmailMod)
        Me.Controls.Add(Me.lblUserMod)
        Me.Controls.Add(Me.btnCancelarMod)
        Me.Controls.Add(Me.BtnAceptarMod)
        Me.Controls.Add(Me.lblModificarUsuario)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PantallaEliminar"
        Me.Text = "Administrador SLine! - Eliminar"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblModificarUsuario As Label
    Friend WithEvents BtnAceptarMod As Button
    Friend WithEvents btnCancelarMod As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ModerarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblRolMod As Label
    Friend WithEvents cbxRolMod As ComboBox
    Friend WithEvents DTPFechaNacMod As DateTimePicker
    Friend WithEvents cbxSexoMod As ComboBox
    Friend WithEvents tbxContraseñaMod As TextBox
    Friend WithEvents tbxEmailMod As TextBox
    Friend WithEvents tbxUserMod As TextBox
    Friend WithEvents lblFechaNacRegMod As Label
    Friend WithEvents lblSexoMod As Label
    Friend WithEvents lblPasswordMod As Label
    Friend WithEvents lblEmailMod As Label
    Friend WithEvents lblUserMod As Label
End Class
