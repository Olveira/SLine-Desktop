<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaOrganizacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaOrganizacion))
        Me.BtnExitMod = New System.Windows.Forms.Button()
        Me.BtnMinimizeMod = New System.Windows.Forms.Button()
        Me.lblModificarUsuario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnExitMod
        '
        Me.BtnExitMod.BackColor = System.Drawing.Color.Transparent
        Me.BtnExitMod.BackgroundImage = CType(resources.GetObject("BtnExitMod.BackgroundImage"), System.Drawing.Image)
        Me.BtnExitMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExitMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnExitMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExitMod.Location = New System.Drawing.Point(764, 12)
        Me.BtnExitMod.Name = "BtnExitMod"
        Me.BtnExitMod.Size = New System.Drawing.Size(24, 24)
        Me.BtnExitMod.TabIndex = 37
        Me.BtnExitMod.UseVisualStyleBackColor = False
        '
        'BtnMinimizeMod
        '
        Me.BtnMinimizeMod.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizeMod.BackgroundImage = CType(resources.GetObject("BtnMinimizeMod.BackgroundImage"), System.Drawing.Image)
        Me.BtnMinimizeMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMinimizeMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnMinimizeMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizeMod.Location = New System.Drawing.Point(734, 12)
        Me.BtnMinimizeMod.Name = "BtnMinimizeMod"
        Me.BtnMinimizeMod.Size = New System.Drawing.Size(24, 24)
        Me.BtnMinimizeMod.TabIndex = 36
        Me.BtnMinimizeMod.UseVisualStyleBackColor = False
        '
        'lblModificarUsuario
        '
        Me.lblModificarUsuario.AutoSize = True
        Me.lblModificarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblModificarUsuario.Font = New System.Drawing.Font("Century Gothic", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModificarUsuario.ForeColor = System.Drawing.Color.Snow
        Me.lblModificarUsuario.Location = New System.Drawing.Point(108, 32)
        Me.lblModificarUsuario.Name = "lblModificarUsuario"
        Me.lblModificarUsuario.Size = New System.Drawing.Size(383, 52)
        Me.lblModificarUsuario.TabIndex = 38
        Me.lblModificarUsuario.Text = "Modificar usuario"
        '
        'PantallaOrganizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblModificarUsuario)
        Me.Controls.Add(Me.BtnExitMod)
        Me.Controls.Add(Me.BtnMinimizeMod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaOrganizacion"
        Me.Text = "PantallaOrganizacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExitMod As Button
    Friend WithEvents BtnMinimizeMod As Button
    Friend WithEvents lblModificarUsuario As Label
End Class
