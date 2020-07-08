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
        Me.LabelSeleccion = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
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
        'LabelSeleccion
        '
        Me.LabelSeleccion.AutoSize = True
        Me.LabelSeleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.LabelSeleccion.Location = New System.Drawing.Point(224, 185)
        Me.LabelSeleccion.Name = "LabelSeleccion"
        Me.LabelSeleccion.Size = New System.Drawing.Size(296, 54)
        Me.LabelSeleccion.TabIndex = 6
        Me.LabelSeleccion.Text = "Iniciar sesión"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button1.Location = New System.Drawing.Point(295, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 42)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PantallaRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelSeleccion)
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
    Friend WithEvents LabelSeleccion As Label
    Friend WithEvents Button1 As Button
End Class
