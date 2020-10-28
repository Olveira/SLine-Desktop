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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioADM))
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TbxUserLog = New System.Windows.Forms.TextBox()
        Me.TbxPasswordLog = New System.Windows.Forms.TextBox()
        Me.BtnMinimizeLogin = New System.Windows.Forms.Button()
        Me.BtnExitLogin = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.BtnAceptar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnAceptar.FlatAppearance.BorderSize = 0
        Me.BtnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(0, 291)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(438, 90)
        Me.BtnAceptar.TabIndex = 2
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BtnMinimizeLogin)
        Me.Panel1.Controls.Add(Me.BtnExitLogin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(438, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(282, 381)
        Me.Panel1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(438, 85)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TbxUserLog
        '
        Me.TbxUserLog.BackColor = System.Drawing.Color.LavenderBlush
        Me.TbxUserLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbxUserLog.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxUserLog.Location = New System.Drawing.Point(12, 130)
        Me.TbxUserLog.Name = "TbxUserLog"
        Me.TbxUserLog.Size = New System.Drawing.Size(420, 24)
        Me.TbxUserLog.TabIndex = 14
        Me.TbxUserLog.Text = "Username"
        '
        'TbxPasswordLog
        '
        Me.TbxPasswordLog.BackColor = System.Drawing.Color.LavenderBlush
        Me.TbxPasswordLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbxPasswordLog.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxPasswordLog.Location = New System.Drawing.Point(12, 185)
        Me.TbxPasswordLog.Name = "TbxPasswordLog"
        Me.TbxPasswordLog.Size = New System.Drawing.Size(420, 24)
        Me.TbxPasswordLog.TabIndex = 15
        Me.TbxPasswordLog.Text = "Password"
        '
        'BtnMinimizeLogin
        '
        Me.BtnMinimizeLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizeLogin.BackgroundImage = CType(resources.GetObject("BtnMinimizeLogin.BackgroundImage"), System.Drawing.Image)
        Me.BtnMinimizeLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMinimizeLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnMinimizeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizeLogin.Location = New System.Drawing.Point(216, 12)
        Me.BtnMinimizeLogin.Name = "BtnMinimizeLogin"
        Me.BtnMinimizeLogin.Size = New System.Drawing.Size(24, 24)
        Me.BtnMinimizeLogin.TabIndex = 14
        Me.BtnMinimizeLogin.UseVisualStyleBackColor = False
        '
        'BtnExitLogin
        '
        Me.BtnExitLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnExitLogin.BackgroundImage = CType(resources.GetObject("BtnExitLogin.BackgroundImage"), System.Drawing.Image)
        Me.BtnExitLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExitLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnExitLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExitLogin.Location = New System.Drawing.Point(246, 12)
        Me.BtnExitLogin.Name = "BtnExitLogin"
        Me.BtnExitLogin.Size = New System.Drawing.Size(24, 24)
        Me.BtnExitLogin.TabIndex = 13
        Me.BtnExitLogin.UseVisualStyleBackColor = False
        '
        'InicioADM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 381)
        Me.Controls.Add(Me.TbxPasswordLog)
        Me.Controls.Add(Me.TbxUserLog)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InicioADM"
        Me.Text = "Administrador SLine! - Log in"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TbxUserLog As TextBox
    Friend WithEvents TbxPasswordLog As TextBox
    Friend WithEvents BtnMinimizeLogin As Button
    Friend WithEvents BtnExitLogin As Button
End Class
