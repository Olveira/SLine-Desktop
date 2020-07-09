<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DesktopWellcome
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
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.LabelBienvenido = New System.Windows.Forms.Label()
        Me.Label2Esquina = New System.Windows.Forms.Label()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BtnSiguiente.Location = New System.Drawing.Point(632, 379)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(90, 70)
        Me.BtnSiguiente.TabIndex = 0
        Me.BtnSiguiente.Text = "Prox."
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'LabelBienvenido
        '
        Me.LabelBienvenido.AutoSize = True
        Me.LabelBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.LabelBienvenido.Location = New System.Drawing.Point(242, 287)
        Me.LabelBienvenido.Name = "LabelBienvenido"
        Me.LabelBienvenido.Size = New System.Drawing.Size(254, 54)
        Me.LabelBienvenido.TabIndex = 1
        Me.LabelBienvenido.Text = "Bienvenido"
        '
        'Label2Esquina
        '
        Me.Label2Esquina.AutoSize = True
        Me.Label2Esquina.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2Esquina.Location = New System.Drawing.Point(12, 9)
        Me.Label2Esquina.Name = "Label2Esquina"
        Me.Label2Esquina.Size = New System.Drawing.Size(69, 25)
        Me.Label2Esquina.TabIndex = 2
        Me.Label2Esquina.Text = "SLine!"
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.SLineDesktop.My.Resources.Resources.Logo
        Me.PBLogo.Location = New System.Drawing.Point(218, 20)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(293, 264)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 3
        Me.PBLogo.TabStop = False
        '
        'DesktopWellcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.PBLogo)
        Me.Controls.Add(Me.Label2Esquina)
        Me.Controls.Add(Me.LabelBienvenido)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Name = "DesktopWellcome"
        Me.Text = " "
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSiguiente As Button
    Friend WithEvents LabelBienvenido As Label
    Friend WithEvents Label2Esquina As Label
    Friend WithEvents PBLogo As PictureBox
End Class
