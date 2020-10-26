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
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.SLineDesktop.My.Resources.Resources.Logo
        Me.PBLogo.Location = New System.Drawing.Point(657, 12)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(55, 55)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 5
        Me.PBLogo.TabStop = False
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.lblBienvenido.Location = New System.Drawing.Point(12, 9)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(307, 54)
        Me.lblBienvenido.TabIndex = 6
        Me.lblBienvenido.Text = "Ingrese datos"
        '
        'tbxPasswordLog
        '
        Me.tbxPasswordLog.Location = New System.Drawing.Point(225, 157)
        Me.tbxPasswordLog.Name = "tbxPasswordLog"
        Me.tbxPasswordLog.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPasswordLog.Size = New System.Drawing.Size(309, 20)
        Me.tbxPasswordLog.TabIndex = 1
        Me.tbxPasswordLog.Text = "password"
        '
        'tbxUserLog
        '
        Me.tbxUserLog.Location = New System.Drawing.Point(225, 110)
        Me.tbxUserLog.Name = "tbxUserLog"
        Me.tbxUserLog.Size = New System.Drawing.Size(309, 20)
        Me.tbxUserLog.TabIndex = 0
        Me.tbxUserLog.Text = "username"
        '
        'BtnAtras
        '
        Me.BtnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAtras.Location = New System.Drawing.Point(225, 251)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(75, 30)
        Me.BtnAtras.TabIndex = 3
        Me.BtnAtras.Text = "Atras"
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiguiente.Location = New System.Drawing.Point(353, 251)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(75, 30)
        Me.BtnSiguiente.TabIndex = 2
        Me.BtnSiguiente.Text = "Siguiente"
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'InicioADM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(724, 382)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Controls.Add(Me.BtnAtras)
        Me.Controls.Add(Me.tbxUserLog)
        Me.Controls.Add(Me.tbxPasswordLog)
        Me.Controls.Add(Me.lblBienvenido)
        Me.Controls.Add(Me.PBLogo)
        Me.Name = "InicioADM"
        Me.Text = "Administrador SLine! - Log in"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents tbxPasswordLog As TextBox
    Friend WithEvents tbxUserLog As TextBox
    Friend WithEvents BtnAtras As Button
    Friend WithEvents BtnSiguiente As Button
End Class
