﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaEliminar
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
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.BtnAcep = New System.Windows.Forms.Button()
        Me.BtnIzq = New System.Windows.Forms.Button()
        Me.cbxEliminar = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModerarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(139, 123)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(360, 171)
        Me.TreeView1.TabIndex = 10
        '
        'LabelBienvenido
        '
        Me.LabelBienvenido.AutoSize = True
        Me.LabelBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.LabelBienvenido.Location = New System.Drawing.Point(109, 49)
        Me.LabelBienvenido.Name = "LabelBienvenido"
        Me.LabelBienvenido.Size = New System.Drawing.Size(199, 54)
        Me.LabelBienvenido.TabIndex = 11
        Me.LabelBienvenido.Text = "Listado: "
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.SLineDesktop.My.Resources.Resources.Logo
        Me.PBLogo.Location = New System.Drawing.Point(492, 58)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(47, 45)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 16
        Me.PBLogo.TabStop = False
        '
        'BtnAcep
        '
        Me.BtnAcep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnAcep.Location = New System.Drawing.Point(312, 241)
        Me.BtnAcep.Name = "BtnAcep"
        Me.BtnAcep.Size = New System.Drawing.Size(85, 40)
        Me.BtnAcep.TabIndex = 17
        Me.BtnAcep.Text = "Aceptar"
        Me.BtnAcep.UseVisualStyleBackColor = True
        '
        'BtnIzq
        '
        Me.BtnIzq.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnIzq.Location = New System.Drawing.Point(403, 241)
        Me.BtnIzq.Name = "BtnIzq"
        Me.BtnIzq.Size = New System.Drawing.Size(85, 40)
        Me.BtnIzq.TabIndex = 18
        Me.BtnIzq.Text = "Cancelar"
        Me.BtnIzq.UseVisualStyleBackColor = True
        '
        'cbxEliminar
        '
        Me.cbxEliminar.FormattingEnabled = True
        Me.cbxEliminar.Items.AddRange(New Object() {"Usuarios", "Casos"})
        Me.cbxEliminar.Location = New System.Drawing.Point(314, 69)
        Me.cbxEliminar.Name = "cbxEliminar"
        Me.cbxEliminar.Size = New System.Drawing.Size(131, 21)
        Me.cbxEliminar.TabIndex = 19
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarToolStripMenuItem, Me.ModerarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ListarToolStripMenuItem.Text = "listar"
        '
        'ModerarToolStripMenuItem
        '
        Me.ModerarToolStripMenuItem.Name = "ModerarToolStripMenuItem"
        Me.ModerarToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ModerarToolStripMenuItem.Text = "moderar"
        '
        'PantallaEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.cbxEliminar)
        Me.Controls.Add(Me.BtnIzq)
        Me.Controls.Add(Me.BtnAcep)
        Me.Controls.Add(Me.PBLogo)
        Me.Controls.Add(Me.LabelBienvenido)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PantallaEliminar"
        Me.Text = "Administrador SLine! - Eliminar"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents LabelBienvenido As Label
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents BtnAcep As Button
    Friend WithEvents BtnIzq As Button
    Friend WithEvents cbxEliminar As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ListarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModerarToolStripMenuItem As ToolStripMenuItem
End Class
