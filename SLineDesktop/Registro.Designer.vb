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
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.LabelEsquina = New System.Windows.Forms.Label()
        Me.lblReg = New System.Windows.Forms.Label()
        Me.btnSiguienteReg = New System.Windows.Forms.Button()
        Me.tbxUserReg = New System.Windows.Forms.TextBox()
        Me.tbxEmailReg = New System.Windows.Forms.TextBox()
        Me.tbxContraseñaReg1 = New System.Windows.Forms.TextBox()
        Me.cbxSexo = New System.Windows.Forms.ComboBox()
        Me.DTPFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.btnback = New System.Windows.Forms.Button()
        Me.cbxRol = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.SLineDesktop.My.Resources.Resources.Logo
        Me.PBLogo.Location = New System.Drawing.Point(12, 12)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(47, 45)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 4
        Me.PBLogo.TabStop = False
        '
        'LabelEsquina
        '
        Me.LabelEsquina.AutoSize = True
        Me.LabelEsquina.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LabelEsquina.Location = New System.Drawing.Point(65, 12)
        Me.LabelEsquina.Name = "LabelEsquina"
        Me.LabelEsquina.Size = New System.Drawing.Size(69, 25)
        Me.LabelEsquina.TabIndex = 5
        Me.LabelEsquina.Text = "SLine!"
        '
        'lblReg
        '
        Me.lblReg.AutoSize = True
        Me.lblReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.lblReg.Location = New System.Drawing.Point(286, 31)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(214, 54)
        Me.lblReg.TabIndex = 6
        Me.lblReg.Text = "Registrar"
        '
        'btnSiguienteReg
        '
        Me.btnSiguienteReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteReg.Location = New System.Drawing.Point(538, 335)
        Me.btnSiguienteReg.Name = "btnSiguienteReg"
        Me.btnSiguienteReg.Size = New System.Drawing.Size(180, 40)
        Me.btnSiguienteReg.TabIndex = 9
        Me.btnSiguienteReg.Text = "Registrar"
        Me.btnSiguienteReg.UseVisualStyleBackColor = True
        '
        'tbxUserReg
        '
        Me.tbxUserReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxUserReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUserReg.Location = New System.Drawing.Point(222, 107)
        Me.tbxUserReg.Margin = New System.Windows.Forms.Padding(5)
        Me.tbxUserReg.Name = "tbxUserReg"
        Me.tbxUserReg.Size = New System.Drawing.Size(278, 26)
        Me.tbxUserReg.TabIndex = 17
        Me.tbxUserReg.Tag = ""
        Me.tbxUserReg.Text = "Nombre de Usuario"
        '
        'tbxEmailReg
        '
        Me.tbxEmailReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxEmailReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxEmailReg.Location = New System.Drawing.Point(222, 139)
        Me.tbxEmailReg.Name = "tbxEmailReg"
        Me.tbxEmailReg.Size = New System.Drawing.Size(278, 26)
        Me.tbxEmailReg.TabIndex = 18
        Me.tbxEmailReg.Text = "Email"
        '
        'tbxContraseñaReg1
        '
        Me.tbxContraseñaReg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxContraseñaReg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxContraseñaReg1.Location = New System.Drawing.Point(222, 171)
        Me.tbxContraseñaReg1.Name = "tbxContraseñaReg1"
        Me.tbxContraseñaReg1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxContraseñaReg1.Size = New System.Drawing.Size(278, 26)
        Me.tbxContraseñaReg1.TabIndex = 19
        Me.tbxContraseñaReg1.Text = "Password"
        '
        'cbxSexo
        '
        Me.cbxSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSexo.FormattingEnabled = True
        Me.cbxSexo.Location = New System.Drawing.Point(222, 203)
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.Size = New System.Drawing.Size(278, 28)
        Me.cbxSexo.TabIndex = 21
        Me.cbxSexo.Text = "Sexo"
        '
        'DTPFechaNac
        '
        Me.DTPFechaNac.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DTPFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaNac.Location = New System.Drawing.Point(222, 271)
        Me.DTPFechaNac.Name = "DTPFechaNac"
        Me.DTPFechaNac.Size = New System.Drawing.Size(278, 26)
        Me.DTPFechaNac.TabIndex = 22
        Me.DTPFechaNac.Value = New Date(2020, 10, 26, 8, 26, 29, 0)
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(12, 335)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(180, 40)
        Me.btnback.TabIndex = 23
        Me.btnback.Text = "Atras"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'cbxRol
        '
        Me.cbxRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRol.FormattingEnabled = True
        Me.cbxRol.Location = New System.Drawing.Point(222, 237)
        Me.cbxRol.Name = "cbxRol"
        Me.cbxRol.Size = New System.Drawing.Size(278, 28)
        Me.cbxRol.TabIndex = 24
        Me.cbxRol.Text = "Rol"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Label1"
        '
        'PantallaRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxRol)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.DTPFechaNac)
        Me.Controls.Add(Me.cbxSexo)
        Me.Controls.Add(Me.tbxContraseñaReg1)
        Me.Controls.Add(Me.tbxEmailReg)
        Me.Controls.Add(Me.tbxUserReg)
        Me.Controls.Add(Me.btnSiguienteReg)
        Me.Controls.Add(Me.lblReg)
        Me.Controls.Add(Me.LabelEsquina)
        Me.Controls.Add(Me.PBLogo)
        Me.Name = "PantallaRegistro"
        Me.Text = "Administrador SLine! - Registrar"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents LabelEsquina As Label
    Friend WithEvents lblReg As Label
    Friend WithEvents btnSiguienteReg As Button
    Friend WithEvents tbxUserReg As TextBox
    Friend WithEvents tbxEmailReg As TextBox
    Friend WithEvents tbxContraseñaReg1 As TextBox
    Friend WithEvents cbxSexo As ComboBox
    Friend WithEvents DTPFechaNac As DateTimePicker
    Friend WithEvents btnback As Button
    Friend WithEvents cbxRol As ComboBox
    Friend WithEvents Label1 As Label
End Class
