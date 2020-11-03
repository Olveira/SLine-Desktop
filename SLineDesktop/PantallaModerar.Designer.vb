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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaModerar))
        Me.LabelBienvenido = New System.Windows.Forms.Label()
        Me.BtnAcep = New System.Windows.Forms.Button()
        Me.BtnDec = New System.Windows.Forms.Button()
        Me.ListaCasos = New System.Windows.Forms.ListView()
        Me.IDCaso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IDUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Veri = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaReg = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnExitModerarCasos = New System.Windows.Forms.Button()
        Me.BtnMinimizeModerarCasos = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelBienvenido
        '
        Me.LabelBienvenido.AutoSize = True
        Me.LabelBienvenido.BackColor = System.Drawing.Color.Transparent
        Me.LabelBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.LabelBienvenido.ForeColor = System.Drawing.Color.Snow
        Me.LabelBienvenido.Location = New System.Drawing.Point(118, 22)
        Me.LabelBienvenido.Name = "LabelBienvenido"
        Me.LabelBienvenido.Size = New System.Drawing.Size(198, 54)
        Me.LabelBienvenido.TabIndex = 7
        Me.LabelBienvenido.Text = "Moderar"
        '
        'BtnAcep
        '
        Me.BtnAcep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAcep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAcep.Location = New System.Drawing.Point(216, 26)
        Me.BtnAcep.Name = "BtnAcep"
        Me.BtnAcep.Size = New System.Drawing.Size(180, 40)
        Me.BtnAcep.TabIndex = 10
        Me.BtnAcep.Text = "Verificar"
        Me.BtnAcep.UseVisualStyleBackColor = True
        '
        'BtnDec
        '
        Me.BtnDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDec.Location = New System.Drawing.Point(3, 15)
        Me.BtnDec.Name = "BtnDec"
        Me.BtnDec.Size = New System.Drawing.Size(180, 40)
        Me.BtnDec.TabIndex = 11
        Me.BtnDec.Text = "Declinar"
        Me.BtnDec.UseVisualStyleBackColor = True
        '
        'ListaCasos
        '
        Me.ListaCasos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IDCaso, Me.Desc, Me.IDUsuario, Me.Veri, Me.FechaReg})
        Me.ListaCasos.FullRowSelect = True
        Me.ListaCasos.GridLines = True
        Me.ListaCasos.HideSelection = False
        Me.ListaCasos.Location = New System.Drawing.Point(0, 88)
        Me.ListaCasos.MultiSelect = False
        Me.ListaCasos.Name = "ListaCasos"
        Me.ListaCasos.Size = New System.Drawing.Size(734, 217)
        Me.ListaCasos.TabIndex = 24
        Me.ListaCasos.UseCompatibleStateImageBehavior = False
        Me.ListaCasos.View = System.Windows.Forms.View.Details
        '
        'IDCaso
        '
        Me.IDCaso.Text = "ID Caso"
        Me.IDCaso.Width = 73
        '
        'Desc
        '
        Me.Desc.Text = "Descripción"
        Me.Desc.Width = 355
        '
        'IDUsuario
        '
        Me.IDUsuario.Text = "ID Usuario"
        Me.IDUsuario.Width = 98
        '
        'Veri
        '
        Me.Veri.Text = "Verificado"
        Me.Veri.Width = 78
        '
        'FechaReg
        '
        Me.FechaReg.Text = "Fecha de registro"
        Me.FechaReg.Width = 116
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BtnDec)
        Me.Panel1.Controls.Add(Me.BtnAcep)
        Me.Panel1.Location = New System.Drawing.Point(0, 329)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 100)
        Me.Panel1.TabIndex = 25
        '
        'BtnExitModerarCasos
        '
        Me.BtnExitModerarCasos.BackColor = System.Drawing.Color.Transparent
        Me.BtnExitModerarCasos.BackgroundImage = CType(resources.GetObject("BtnExitModerarCasos.BackgroundImage"), System.Drawing.Image)
        Me.BtnExitModerarCasos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExitModerarCasos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExitModerarCasos.Location = New System.Drawing.Point(698, 12)
        Me.BtnExitModerarCasos.Name = "BtnExitModerarCasos"
        Me.BtnExitModerarCasos.Size = New System.Drawing.Size(24, 24)
        Me.BtnExitModerarCasos.TabIndex = 33
        Me.BtnExitModerarCasos.UseVisualStyleBackColor = False
        '
        'BtnMinimizeModerarCasos
        '
        Me.BtnMinimizeModerarCasos.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimizeModerarCasos.BackgroundImage = CType(resources.GetObject("BtnMinimizeModerarCasos.BackgroundImage"), System.Drawing.Image)
        Me.BtnMinimizeModerarCasos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMinimizeModerarCasos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizeModerarCasos.Location = New System.Drawing.Point(668, 12)
        Me.BtnMinimizeModerarCasos.Name = "BtnMinimizeModerarCasos"
        Me.BtnMinimizeModerarCasos.Size = New System.Drawing.Size(24, 24)
        Me.BtnMinimizeModerarCasos.TabIndex = 32
        Me.BtnMinimizeModerarCasos.UseVisualStyleBackColor = False
        '
        'PantallaModerar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 407)
        Me.Controls.Add(Me.BtnExitModerarCasos)
        Me.Controls.Add(Me.BtnMinimizeModerarCasos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListaCasos)
        Me.Controls.Add(Me.LabelBienvenido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaModerar"
        Me.Text = "Administrador SLine! - Moderar"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelBienvenido As Label
    Friend WithEvents BtnAcep As Button
    Friend WithEvents BtnDec As Button
    Friend WithEvents ListaCasos As ListView
    Friend WithEvents IDCaso As ColumnHeader
    Friend WithEvents Desc As ColumnHeader
    Friend WithEvents IDUsuario As ColumnHeader
    Friend WithEvents Veri As ColumnHeader
    Friend WithEvents FechaReg As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnExitModerarCasos As Button
    Friend WithEvents BtnMinimizeModerarCasos As Button
End Class
