﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PantallaListar
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
        Me.LabelBienvenido = New System.Windows.Forms.Label()
        Me.BtnIzq = New System.Windows.Forms.Button()
        Me.BtnAcep = New System.Windows.Forms.Button()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiModerar = New System.Windows.Forms.ToolStripMenuItem()
        Me.LVListadoUsuarios = New System.Windows.Forms.ListView()
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaNac = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelBienvenido
        '
        Me.LabelBienvenido.AutoSize = True
        Me.LabelBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.LabelBienvenido.Location = New System.Drawing.Point(50, 49)
        Me.LabelBienvenido.Name = "LabelBienvenido"
        Me.LabelBienvenido.Size = New System.Drawing.Size(436, 54)
        Me.LabelBienvenido.TabIndex = 10
        Me.LabelBienvenido.Text = "Listado de Usuarios"
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiEliminar, Me.tsmiModerar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmiEliminar
        '
        Me.tsmiEliminar.Name = "tsmiEliminar"
        Me.tsmiEliminar.Size = New System.Drawing.Size(62, 20)
        Me.tsmiEliminar.Text = "Eliminar"
        '
        'tsmiModerar
        '
        Me.tsmiModerar.Name = "tsmiModerar"
        Me.tsmiModerar.Size = New System.Drawing.Size(64, 20)
        Me.tsmiModerar.Text = "moderar"
        '
        'LVListadoUsuarios
        '
        Me.LVListadoUsuarios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Username, Me.Email, Me.Password, Me.sexo, Me.FechaNac, Me.rol})
        Me.LVListadoUsuarios.HideSelection = False
        Me.LVListadoUsuarios.Location = New System.Drawing.Point(77, 126)
        Me.LVListadoUsuarios.Name = "LVListadoUsuarios"
        Me.LVListadoUsuarios.Size = New System.Drawing.Size(462, 192)
        Me.LVListadoUsuarios.TabIndex = 22
        Me.LVListadoUsuarios.UseCompatibleStateImageBehavior = False
        Me.LVListadoUsuarios.View = System.Windows.Forms.View.Details
        '
        'Username
        '
        Me.Username.Text = "Username"
        '
        'Email
        '
        Me.Email.Text = "Email"
        '
        'Password
        '
        Me.Password.Text = "Password"
        '
        'sexo
        '
        Me.sexo.Text = "Sexo"
        '
        'FechaNac
        '
        Me.FechaNac.Text = "FechaNac"
        '
        'rol
        '
        Me.rol.Text = "rol"
        '
        'PantallaListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.LVListadoUsuarios)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BtnAcep)
        Me.Controls.Add(Me.BtnIzq)
        Me.Controls.Add(Me.PBLogo)
        Me.Controls.Add(Me.LabelBienvenido)
        Me.Name = "PantallaListar"
        Me.Text = "Administrador SLine! - Listar"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelBienvenido As Label
    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents BtnIzq As Button
    Friend WithEvents BtnAcep As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmiEliminar As ToolStripMenuItem
    Friend WithEvents tsmiModerar As ToolStripMenuItem
    Friend WithEvents LVListadoUsuarios As ListView
    Friend WithEvents Username As ColumnHeader
    Friend WithEvents Email As ColumnHeader
    Friend WithEvents Password As ColumnHeader
    Friend WithEvents sexo As ColumnHeader
    Friend WithEvents FechaNac As ColumnHeader
    Friend WithEvents rol As ColumnHeader
End Class
