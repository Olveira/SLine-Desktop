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
        Me.tsmlEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiListar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListCasos = New System.Windows.Forms.ListView()
        Me.idCaso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fechaR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.BtnAcep.Text = "Aceptar"
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmlEliminar, Me.tsmiListar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmlEliminar
        '
        Me.tsmlEliminar.Name = "tsmlEliminar"
        Me.tsmlEliminar.Size = New System.Drawing.Size(70, 20)
        Me.tsmlEliminar.Text = "Modificar"
        '
        'tsmiListar
        '
        Me.tsmiListar.Name = "tsmiListar"
        Me.tsmiListar.Size = New System.Drawing.Size(47, 20)
        Me.tsmiListar.Text = "Listar"
        '
        'ListCasos
        '
        Me.ListCasos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idCaso, Me.desc, Me.idUsuario, Me.fechaR})
        Me.ListCasos.HideSelection = False
        Me.ListCasos.Location = New System.Drawing.Point(118, 109)
        Me.ListCasos.Name = "ListCasos"
        Me.ListCasos.Size = New System.Drawing.Size(448, 203)
        Me.ListCasos.TabIndex = 24
        Me.ListCasos.UseCompatibleStateImageBehavior = False
        Me.ListCasos.View = System.Windows.Forms.View.Details
        '
        'idCaso
        '
        Me.idCaso.Text = "ID Caso"
        Me.idCaso.Width = 55
        '
        'desc
        '
        Me.desc.Text = "Descripción"
        Me.desc.Width = 71
        '
        'idUsuario
        '
        Me.idUsuario.Text = "ID Usuario"
        Me.idUsuario.Width = 66
        '
        'fechaR
        '
        Me.fechaR.Text = "Fecha registro"
        Me.fechaR.Width = 87
        '
        'PantallaModerar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 461)
        Me.Controls.Add(Me.ListCasos)
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
    Friend WithEvents tsmlEliminar As ToolStripMenuItem
    Friend WithEvents tsmiListar As ToolStripMenuItem
    Friend WithEvents ListCasos As ListView
    Friend WithEvents idCaso As ColumnHeader
    Friend WithEvents desc As ColumnHeader
    Friend WithEvents idUsuario As ColumnHeader
    Friend WithEvents fechaR As ColumnHeader
End Class
