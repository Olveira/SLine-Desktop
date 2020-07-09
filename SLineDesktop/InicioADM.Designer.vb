<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioADM
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
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.tbxPasswordLog = New System.Windows.Forms.TextBox()
        Me.tbxUserLog = New System.Windows.Forms.TextBox()
        Me.lblUsernameLog = New System.Windows.Forms.Label()
        Me.lblPasswoedLog = New System.Windows.Forms.Label()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
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
        Me.PBLogo.TabIndex = 5
        Me.PBLogo.TabStop = False
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.lblBienvenido.Location = New System.Drawing.Point(216, 97)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(307, 54)
        Me.lblBienvenido.TabIndex = 6
        Me.lblBienvenido.Text = "Ingrese datos"
        '
        'tbxPasswordLog
        '
        Me.tbxPasswordLog.Location = New System.Drawing.Point(328, 213)
        Me.tbxPasswordLog.Name = "tbxPasswordLog"
        Me.tbxPasswordLog.Size = New System.Drawing.Size(100, 20)
        Me.tbxPasswordLog.TabIndex = 8
        '
        'tbxUserLog
        '
        Me.tbxUserLog.Location = New System.Drawing.Point(328, 175)
        Me.tbxUserLog.Name = "tbxUserLog"
        Me.tbxUserLog.Size = New System.Drawing.Size(100, 20)
        Me.tbxUserLog.TabIndex = 9
        '
        'lblUsernameLog
        '
        Me.lblUsernameLog.AutoSize = True
        Me.lblUsernameLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblUsernameLog.Location = New System.Drawing.Point(220, 170)
        Me.lblUsernameLog.Name = "lblUsernameLog"
        Me.lblUsernameLog.Size = New System.Drawing.Size(102, 25)
        Me.lblUsernameLog.TabIndex = 10
        Me.lblUsernameLog.Text = "Username"
        '
        'lblPasswoedLog
        '
        Me.lblPasswoedLog.AutoSize = True
        Me.lblPasswoedLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblPasswoedLog.Location = New System.Drawing.Point(220, 208)
        Me.lblPasswoedLog.Name = "lblPasswoedLog"
        Me.lblPasswoedLog.Size = New System.Drawing.Size(98, 25)
        Me.lblPasswoedLog.TabIndex = 11
        Me.lblPasswoedLog.Text = "Password"
        '
        'BtnAtras
        '
        Me.BtnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnAtras.Location = New System.Drawing.Point(225, 251)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(75, 30)
        Me.BtnAtras.TabIndex = 12
        Me.BtnAtras.Text = "Atras"
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnSiguiente.Location = New System.Drawing.Point(353, 251)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(75, 30)
        Me.BtnSiguiente.TabIndex = 13
        Me.BtnSiguiente.Text = "Siguiente"
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'InicioADM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Controls.Add(Me.BtnAtras)
        Me.Controls.Add(Me.lblPasswoedLog)
        Me.Controls.Add(Me.lblUsernameLog)
        Me.Controls.Add(Me.tbxUserLog)
        Me.Controls.Add(Me.tbxPasswordLog)
        Me.Controls.Add(Me.lblBienvenido)
        Me.Controls.Add(Me.PBLogo)
        Me.Name = "InicioADM"
        Me.Text = "Inicio de sesión ADM"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents tbxPasswordLog As TextBox
    Friend WithEvents tbxUserLog As TextBox
    Friend WithEvents lblUsernameLog As Label
    Friend WithEvents lblPasswoedLog As Label
    Friend WithEvents BtnAtras As Button
    Friend WithEvents BtnSiguiente As Button
End Class
