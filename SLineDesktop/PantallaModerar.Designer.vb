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
        Me.BtnAcep = New System.Windows.Forms.Button()
        Me.BtnDec = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BtnModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiListar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaCasos = New System.Windows.Forms.ListView()
        Me.IDCaso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IDUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Veri = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaReg = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PBLogo
        '
        Me.PBLogo.Image = Global.SLineDesktop.My.Resources.Resources.Logo
        Me.PBLogo.Location = New System.Drawing.Point(519, 58)
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
        'BtnAcep
        '
        Me.BtnAcep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnAcep.Location = New System.Drawing.Point(491, 330)
        Me.BtnAcep.Name = "BtnAcep"
        Me.BtnAcep.Size = New System.Drawing.Size(75, 40)
        Me.BtnAcep.TabIndex = 10
        Me.BtnAcep.Text = "Verificar"
        Me.BtnAcep.UseVisualStyleBackColor = True
        '
        'BtnDec
        '
        Me.BtnDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnDec.Location = New System.Drawing.Point(118, 330)
        Me.BtnDec.Name = "BtnDec"
        Me.BtnDec.Size = New System.Drawing.Size(75, 40)
        Me.BtnDec.TabIndex = 11
        Me.BtnDec.Text = "Declinar"
        Me.BtnDec.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnModificar, Me.tsmiListar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BtnModificar
        '
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(70, 20)
        Me.BtnModificar.Text = "Modificar"
        '
        'tsmiListar
        '
        Me.tsmiListar.Name = "tsmiListar"
        Me.tsmiListar.Size = New System.Drawing.Size(47, 20)
        Me.tsmiListar.Text = "Listar"
        '
        'ListaCasos
        '
        Me.ListaCasos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IDCaso, Me.Desc, Me.IDUsuario, Me.Veri, Me.FechaReg})
        Me.ListaCasos.FullRowSelect = True
        Me.ListaCasos.GridLines = True
        Me.ListaCasos.HideSelection = False
        Me.ListaCasos.Location = New System.Drawing.Point(118, 106)
        Me.ListaCasos.MultiSelect = False
        Me.ListaCasos.Name = "ListaCasos"
        Me.ListaCasos.Size = New System.Drawing.Size(415, 192)
        Me.ListaCasos.TabIndex = 24
        Me.ListaCasos.UseCompatibleStateImageBehavior = False
        Me.ListaCasos.View = System.Windows.Forms.View.Details
        '
        'IDCaso
        '
        Me.IDCaso.Text = "ID Caso"
        '
        'Desc
        '
        Me.Desc.Text = "Descripción"
        '
        'IDUsuario
        '
        Me.IDUsuario.Text = "ID Usuario"
        '
        'Veri
        '
        Me.Veri.Text = "Verificado"
        '
        'FechaReg
        '
        Me.FechaReg.Text = "Fecha de registro"
        '
        'PantallaModerar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.ListaCasos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BtnDec)
        Me.Controls.Add(Me.BtnAcep)
        Me.Controls.Add(Me.LabelBienvenido)
        Me.Controls.Add(Me.PBLogo)
        Me.Name = "PantallaModerar"
        Me.Text = "Administrador SLine! - Moderar"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBLogo As PictureBox
    Friend WithEvents LabelBienvenido As Label
    Friend WithEvents BtnAcep As Button
    Friend WithEvents BtnDec As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BtnModificar As ToolStripMenuItem
    Friend WithEvents tsmiListar As ToolStripMenuItem
    Friend WithEvents ListaCasos As ListView
    Friend WithEvents IDCaso As ColumnHeader
    Friend WithEvents Desc As ColumnHeader
    Friend WithEvents IDUsuario As ColumnHeader
    Friend WithEvents Veri As ColumnHeader
    Friend WithEvents FechaReg As ColumnHeader
End Class
