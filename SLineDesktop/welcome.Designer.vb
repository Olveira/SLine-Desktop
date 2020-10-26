<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(welcome))
        Me.btnGoRegistrar = New System.Windows.Forms.Button()
        Me.btnGoLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGoRegistrar
        '
        Me.btnGoRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoRegistrar.Location = New System.Drawing.Point(669, 411)
        Me.btnGoRegistrar.Name = "btnGoRegistrar"
        Me.btnGoRegistrar.Size = New System.Drawing.Size(112, 27)
        Me.btnGoRegistrar.TabIndex = 0
        Me.btnGoRegistrar.Text = "Registrar"
        Me.btnGoRegistrar.UseVisualStyleBackColor = True
        '
        'btnGoLogin
        '
        Me.btnGoLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoLogin.Location = New System.Drawing.Point(43, 411)
        Me.btnGoLogin.Name = "btnGoLogin"
        Me.btnGoLogin.Size = New System.Drawing.Size(123, 27)
        Me.btnGoLogin.TabIndex = 1
        Me.btnGoLogin.Text = "Entrar"
        Me.btnGoLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 55)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bienvenido"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(205, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(417, 383)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGoLogin)
        Me.Controls.Add(Me.btnGoRegistrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "welcome"
        Me.Text = "Administrador SLine! - Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGoRegistrar As Button
    Friend WithEvents btnGoLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
