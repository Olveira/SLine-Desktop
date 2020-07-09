<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaRegistro
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
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.LabelEsquina = New System.Windows.Forms.Label()
        Me.lblReg = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblUserReg = New System.Windows.Forms.Label()
        Me.lblEmailReg = New System.Windows.Forms.Label()
        Me.lblPasswordReg1 = New System.Windows.Forms.Label()
        Me.lblPasswordReg2 = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblFechaNacReg = New System.Windows.Forms.Label()
        Me.tbxUserReg = New System.Windows.Forms.TextBox()
        Me.tbxEmailReg = New System.Windows.Forms.TextBox()
        Me.tbxContraseñaReg1 = New System.Windows.Forms.TextBox()
        Me.tbxContraseñaReg2 = New System.Windows.Forms.TextBox()
        Me.cbxSexo = New System.Windows.Forms.ComboBox()
        Me.DTPFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button1.Location = New System.Drawing.Point(538, 380)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 42)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblUserReg
        '
        Me.lblUserReg.AutoSize = True
        Me.lblUserReg.Location = New System.Drawing.Point(259, 146)
        Me.lblUserReg.Name = "lblUserReg"
        Me.lblUserReg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUserReg.Size = New System.Drawing.Size(55, 13)
        Me.lblUserReg.TabIndex = 11
        Me.lblUserReg.Text = "Username"
        '
        'lblEmailReg
        '
        Me.lblEmailReg.AutoSize = True
        Me.lblEmailReg.Location = New System.Drawing.Point(283, 169)
        Me.lblEmailReg.Name = "lblEmailReg"
        Me.lblEmailReg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEmailReg.Size = New System.Drawing.Size(31, 13)
        Me.lblEmailReg.TabIndex = 12
        Me.lblEmailReg.Text = "email"
        '
        'lblPasswordReg1
        '
        Me.lblPasswordReg1.AutoSize = True
        Me.lblPasswordReg1.Location = New System.Drawing.Point(253, 193)
        Me.lblPasswordReg1.Name = "lblPasswordReg1"
        Me.lblPasswordReg1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPasswordReg1.Size = New System.Drawing.Size(61, 13)
        Me.lblPasswordReg1.TabIndex = 13
        Me.lblPasswordReg1.Text = "Contraseña"
        '
        'lblPasswordReg2
        '
        Me.lblPasswordReg2.AutoSize = True
        Me.lblPasswordReg2.Location = New System.Drawing.Point(206, 215)
        Me.lblPasswordReg2.Name = "lblPasswordReg2"
        Me.lblPasswordReg2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPasswordReg2.Size = New System.Drawing.Size(108, 13)
        Me.lblPasswordReg2.TabIndex = 14
        Me.lblPasswordReg2.Text = "Confirmar Contraseña"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(283, 237)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSexo.Size = New System.Drawing.Size(31, 13)
        Me.lblSexo.TabIndex = 15
        Me.lblSexo.Text = "Sexo"
        '
        'lblFechaNacReg
        '
        Me.lblFechaNacReg.AutoSize = True
        Me.lblFechaNacReg.Location = New System.Drawing.Point(208, 259)
        Me.lblFechaNacReg.Name = "lblFechaNacReg"
        Me.lblFechaNacReg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFechaNacReg.Size = New System.Drawing.Size(106, 13)
        Me.lblFechaNacReg.TabIndex = 16
        Me.lblFechaNacReg.Text = "Fecha de nacimiento"
        '
        'tbxUserReg
        '
        Me.tbxUserReg.Location = New System.Drawing.Point(320, 143)
        Me.tbxUserReg.Name = "tbxUserReg"
        Me.tbxUserReg.Size = New System.Drawing.Size(100, 20)
        Me.tbxUserReg.TabIndex = 17
        '
        'tbxEmailReg
        '
        Me.tbxEmailReg.Location = New System.Drawing.Point(320, 166)
        Me.tbxEmailReg.Name = "tbxEmailReg"
        Me.tbxEmailReg.Size = New System.Drawing.Size(100, 20)
        Me.tbxEmailReg.TabIndex = 18
        '
        'tbxContraseñaReg1
        '
        Me.tbxContraseñaReg1.Location = New System.Drawing.Point(320, 190)
        Me.tbxContraseñaReg1.Name = "tbxContraseñaReg1"
        Me.tbxContraseñaReg1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxContraseñaReg1.Size = New System.Drawing.Size(100, 20)
        Me.tbxContraseñaReg1.TabIndex = 19
        '
        'tbxContraseñaReg2
        '
        Me.tbxContraseñaReg2.Location = New System.Drawing.Point(320, 212)
        Me.tbxContraseñaReg2.Name = "tbxContraseñaReg2"
        Me.tbxContraseñaReg2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxContraseñaReg2.Size = New System.Drawing.Size(100, 20)
        Me.tbxContraseñaReg2.TabIndex = 20
        '
        'cbxSexo
        '
        Me.cbxSexo.FormattingEnabled = True
        Me.cbxSexo.Location = New System.Drawing.Point(320, 234)
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.Size = New System.Drawing.Size(121, 21)
        Me.cbxSexo.TabIndex = 21
        '
        'DTPFechaNac
        '
        Me.DTPFechaNac.Location = New System.Drawing.Point(320, 259)
        Me.DTPFechaNac.Name = "DTPFechaNac"
        Me.DTPFechaNac.Size = New System.Drawing.Size(200, 20)
        Me.DTPFechaNac.TabIndex = 22
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button2.Location = New System.Drawing.Point(12, 380)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 42)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Atras"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PantallaRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DTPFechaNac)
        Me.Controls.Add(Me.cbxSexo)
        Me.Controls.Add(Me.tbxContraseñaReg2)
        Me.Controls.Add(Me.tbxContraseñaReg1)
        Me.Controls.Add(Me.tbxEmailReg)
        Me.Controls.Add(Me.tbxUserReg)
        Me.Controls.Add(Me.lblFechaNacReg)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblPasswordReg2)
        Me.Controls.Add(Me.lblPasswordReg1)
        Me.Controls.Add(Me.lblEmailReg)
        Me.Controls.Add(Me.lblUserReg)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblReg)
        Me.Controls.Add(Me.LabelEsquina)
        Me.Controls.Add(Me.PBLogo)
        Me.Name = "PantallaRegistro"
        Me.Text = "Pantalla Inicio de sesión"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents LabelEsquina As Label
    Friend WithEvents lblReg As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblUserReg As Label
    Friend WithEvents lblEmailReg As Label
    Friend WithEvents lblPasswordReg1 As Label
    Friend WithEvents lblPasswordReg2 As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblFechaNacReg As Label
    Friend WithEvents tbxUserReg As TextBox
    Friend WithEvents tbxEmailReg As TextBox
    Friend WithEvents tbxContraseñaReg1 As TextBox
    Friend WithEvents tbxContraseñaReg2 As TextBox
    Friend WithEvents cbxSexo As ComboBox
    Friend WithEvents DTPFechaNac As DateTimePicker
    Friend WithEvents Button2 As Button
End Class
