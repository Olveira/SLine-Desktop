<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGoRegistrar = New System.Windows.Forms.Button()
        Me.btnGoLogin = New System.Windows.Forms.Button()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Sline = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnGoRegistrar)
        Me.Panel1.Controls.Add(Me.btnGoLogin)
        Me.Panel1.Controls.Add(Me.ShapeContainer2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 350)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 100)
        Me.Panel1.TabIndex = 7
        '
        'btnGoRegistrar
        '
        Me.btnGoRegistrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnGoRegistrar.FlatAppearance.BorderSize = 0
        Me.btnGoRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGoRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush
        Me.btnGoRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoRegistrar.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoRegistrar.Location = New System.Drawing.Point(370, 0)
        Me.btnGoRegistrar.Name = "btnGoRegistrar"
        Me.btnGoRegistrar.Size = New System.Drawing.Size(370, 100)
        Me.btnGoRegistrar.TabIndex = 2
        Me.btnGoRegistrar.Text = "Registrarte"
        Me.btnGoRegistrar.UseVisualStyleBackColor = True
        '
        'btnGoLogin
        '
        Me.btnGoLogin.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGoLogin.FlatAppearance.BorderSize = 0
        Me.btnGoLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGoLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush
        Me.btnGoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoLogin.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoLogin.Location = New System.Drawing.Point(0, 0)
        Me.btnGoLogin.Name = "btnGoLogin"
        Me.btnGoLogin.Size = New System.Drawing.Size(369, 100)
        Me.btnGoLogin.TabIndex = 3
        Me.btnGoLogin.Text = "Iniciar Seccion"
        Me.btnGoLogin.UseVisualStyleBackColor = True
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(740, 100)
        Me.ShapeContainer2.TabIndex = 4
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 316
        Me.LineShape2.X2 = 391
        Me.LineShape2.Y1 = 19
        Me.LineShape2.Y2 = 42
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 369
        Me.LineShape1.X2 = 369
        Me.LineShape1.Y1 = 0
        Me.LineShape1.Y2 = 100
        '
        'Sline
        '
        Me.Sline.AutoSize = True
        Me.Sline.BackColor = System.Drawing.Color.Transparent
        Me.Sline.Font = New System.Drawing.Font("Century Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sline.Location = New System.Drawing.Point(74, 118)
        Me.Sline.Margin = New System.Windows.Forms.Padding(0)
        Me.Sline.Name = "Sline"
        Me.Sline.Size = New System.Drawing.Size(311, 115)
        Me.Sline.TabIndex = 6
        Me.Sline.Text = "SLine!"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(458, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(282, 350)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.BackgroundImage = CType(resources.GetObject("BtnExit.BackgroundImage"), System.Drawing.Image)
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Location = New System.Drawing.Point(704, 12)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(24, 24)
        Me.BtnExit.TabIndex = 11
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnMinimize
        '
        Me.BtnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.BtnMinimize.BackgroundImage = CType(resources.GetObject("BtnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimize.Location = New System.Drawing.Point(674, 12)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(24, 24)
        Me.BtnMinimize.TabIndex = 12
        Me.BtnMinimize.UseVisualStyleBackColor = False
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(740, 450)
        Me.Controls.Add(Me.BtnMinimize)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Sline)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Welcome"
        Me.Text = "Welcome3"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGoRegistrar As Button
    Friend WithEvents btnGoLogin As Button
    Friend WithEvents Sline As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnMinimize As Button
End Class
