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
        Me.BtnTodos = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.BtnExitModerarCasos = New System.Windows.Forms.Button()
        Me.BtnMinimizeModerarCasos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BtnAcep.FlatAppearance.BorderSize = 0
        Me.BtnAcep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BtnAcep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAcep.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAcep.ForeColor = System.Drawing.Color.Snow
        Me.BtnAcep.Location = New System.Drawing.Point(201, 0)
        Me.BtnAcep.Name = "BtnAcep"
        Me.BtnAcep.Size = New System.Drawing.Size(199, 88)
        Me.BtnAcep.TabIndex = 10
        Me.BtnAcep.Text = "Verificar"
        Me.BtnAcep.UseVisualStyleBackColor = True
        '
        'BtnDec
        '
        Me.BtnDec.FlatAppearance.BorderSize = 0
        Me.BtnDec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BtnDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDec.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDec.ForeColor = System.Drawing.Color.Snow
        Me.BtnDec.Location = New System.Drawing.Point(0, 0)
        Me.BtnDec.Name = "BtnDec"
        Me.BtnDec.Size = New System.Drawing.Size(199, 88)
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
        Me.ListaCasos.Location = New System.Drawing.Point(12, 98)
        Me.ListaCasos.MultiSelect = False
        Me.ListaCasos.Name = "ListaCasos"
        Me.ListaCasos.Size = New System.Drawing.Size(716, 263)
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
        Me.Panel1.Controls.Add(Me.BtnTodos)
        Me.Panel1.Controls.Add(Me.BtnDec)
        Me.Panel1.Controls.Add(Me.BtnAcep)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(0, 377)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 88)
        Me.Panel1.TabIndex = 25
        '
        'BtnTodos
        '
        Me.BtnTodos.FlatAppearance.BorderSize = 0
        Me.BtnTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BtnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTodos.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTodos.ForeColor = System.Drawing.Color.Snow
        Me.BtnTodos.Location = New System.Drawing.Point(401, 0)
        Me.BtnTodos.Name = "BtnTodos"
        Me.BtnTodos.Size = New System.Drawing.Size(199, 88)
        Me.BtnTodos.TabIndex = 12
        Me.BtnTodos.Text = "Todos"
        Me.BtnTodos.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(600, 88)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Snow
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 400
        Me.LineShape2.X2 = 400
        Me.LineShape2.Y1 = 0
        Me.LineShape2.Y2 = 88
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Snow
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 200
        Me.LineShape1.X2 = 200
        Me.LineShape1.Y1 = 0
        Me.LineShape1.Y2 = 88
        '
        'BtnExitModerarCasos
        '
        Me.BtnExitModerarCasos.BackColor = System.Drawing.Color.Transparent
        Me.BtnExitModerarCasos.BackgroundImage = CType(resources.GetObject("BtnExitModerarCasos.BackgroundImage"), System.Drawing.Image)
        Me.BtnExitModerarCasos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExitModerarCasos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExitModerarCasos.Location = New System.Drawing.Point(704, 12)
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
        Me.BtnMinimizeModerarCasos.Location = New System.Drawing.Point(674, 12)
        Me.BtnMinimizeModerarCasos.Name = "BtnMinimizeModerarCasos"
        Me.BtnMinimizeModerarCasos.Size = New System.Drawing.Size(24, 24)
        Me.BtnMinimizeModerarCasos.TabIndex = 32
        Me.BtnMinimizeModerarCasos.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(650, 375)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'PantallaModerar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(740, 465)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnExitModerarCasos)
        Me.Controls.Add(Me.BtnMinimizeModerarCasos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListaCasos)
        Me.Controls.Add(Me.LabelBienvenido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaModerar"
        Me.Text = "Administrador SLine! - Moderar"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnTodos As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
End Class
