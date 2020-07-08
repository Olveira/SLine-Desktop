<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaListar
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
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.LabelBienvenido = New System.Windows.Forms.Label()
        Me.BtnIzq = New System.Windows.Forms.Button()
        Me.BtnAcep = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(118, 118)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(421, 216)
        Me.TreeView1.TabIndex = 9
        '
        'LabelBienvenido
        '
        Me.LabelBienvenido.AutoSize = True
        Me.LabelBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.LabelBienvenido.Location = New System.Drawing.Point(109, 49)
        Me.LabelBienvenido.Name = "LabelBienvenido"
        Me.LabelBienvenido.Size = New System.Drawing.Size(199, 54)
        Me.LabelBienvenido.TabIndex = 10
        Me.LabelBienvenido.Text = "Listado: "
        '
        'BtnIzq
        '
        Me.BtnIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnIzq.Location = New System.Drawing.Point(289, 340)
        Me.BtnIzq.Name = "BtnIzq"
        Me.BtnIzq.Size = New System.Drawing.Size(118, 40)
        Me.BtnIzq.TabIndex = 12
        Me.BtnIzq.Text = "Dar de baja"
        Me.BtnIzq.UseVisualStyleBackColor = True
        '
        'BtnAcep
        '
        Me.BtnAcep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnAcep.Location = New System.Drawing.Point(118, 340)
        Me.BtnAcep.Name = "BtnAcep"
        Me.BtnAcep.Size = New System.Drawing.Size(118, 40)
        Me.BtnAcep.TabIndex = 13
        Me.BtnAcep.Text = "Listar casos"
        Me.BtnAcep.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(294, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 31)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Variable"
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.SLineDesktop.My.Resources.Resources.Logo
        Me.PBLogo.Location = New System.Drawing.Point(492, 58)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(47, 45)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 11
        Me.PBLogo.TabStop = False
        '
        'PantallaListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAcep)
        Me.Controls.Add(Me.BtnIzq)
        Me.Controls.Add(Me.PBLogo)
        Me.Controls.Add(Me.LabelBienvenido)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "PantallaListar"
        Me.Text = "Administrador SLine! - Listar"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents LabelBienvenido As Label
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents BtnIzq As Button
    Friend WithEvents BtnAcep As Button
    Friend WithEvents Label1 As Label
End Class
