<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaModerar
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
        Me.LabelBienvenido = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.BtnIzq = New System.Windows.Forms.Button()
        Me.BtnAcep = New System.Windows.Forms.Button()
        Me.BtnDec = New System.Windows.Forms.Button()
        Me.BtnDer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.SLineDesktop.My.Resources.Resources.Logo
        Me.PBLogo.Location = New System.Drawing.Point(492, 58)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(47, 45)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 6
        Me.PBLogo.TabStop = False
        '
        'LabelBienvenido
        '
        Me.LabelBienvenido.AutoSize = True
        Me.LabelBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.LabelBienvenido.Location = New System.Drawing.Point(109, 49)
        Me.LabelBienvenido.Name = "LabelBienvenido"
        Me.LabelBienvenido.Size = New System.Drawing.Size(198, 54)
        Me.LabelBienvenido.TabIndex = 7
        Me.LabelBienvenido.Text = "Moderar"
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(118, 118)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(421, 216)
        Me.TreeView1.TabIndex = 8
        '
        'BtnIzq
        '
        Me.BtnIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BtnIzq.Location = New System.Drawing.Point(118, 346)
        Me.BtnIzq.Name = "BtnIzq"
        Me.BtnIzq.Size = New System.Drawing.Size(75, 40)
        Me.BtnIzq.TabIndex = 9
        Me.BtnIzq.Text = "<"
        Me.BtnIzq.UseVisualStyleBackColor = True
        '
        'BtnAcep
        '
        Me.BtnAcep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnAcep.Location = New System.Drawing.Point(232, 346)
        Me.BtnAcep.Name = "BtnAcep"
        Me.BtnAcep.Size = New System.Drawing.Size(75, 40)
        Me.BtnAcep.TabIndex = 10
        Me.BtnAcep.Text = "Aceptar"
        Me.BtnAcep.UseVisualStyleBackColor = True
        '
        'BtnDec
        '
        Me.BtnDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnDec.Location = New System.Drawing.Point(353, 346)
        Me.BtnDec.Name = "BtnDec"
        Me.BtnDec.Size = New System.Drawing.Size(75, 40)
        Me.BtnDec.TabIndex = 11
        Me.BtnDec.Text = "Declinar"
        Me.BtnDec.UseVisualStyleBackColor = True
        '
        'BtnDer
        '
        Me.BtnDer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BtnDer.Location = New System.Drawing.Point(464, 346)
        Me.BtnDer.Name = "BtnDer"
        Me.BtnDer.Size = New System.Drawing.Size(75, 40)
        Me.BtnDer.TabIndex = 12
        Me.BtnDer.Text = ">"
        Me.BtnDer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(133, 389)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Ant."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(489, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Sig."
        '
        'PantallaModerar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnDer)
        Me.Controls.Add(Me.BtnDec)
        Me.Controls.Add(Me.BtnAcep)
        Me.Controls.Add(Me.BtnIzq)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.LabelBienvenido)
        Me.Controls.Add(Me.PBLogo)
        Me.Name = "PantallaModerar"
        Me.Text = "Administrador SLine! - Moderar"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents LabelBienvenido As Label
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents BtnIzq As Button
    Friend WithEvents BtnAcep As Button
    Friend WithEvents BtnDec As Button
    Friend WithEvents BtnDer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
