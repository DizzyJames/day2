<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.search = New FontAwesome.Sharp.IconButton()
        Me.edit = New FontAwesome.Sharp.IconButton()
        Me.delete = New FontAwesome.Sharp.IconButton()
        Me.adduse = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.search)
        Me.Guna2ShadowPanel1.Controls.Add(Me.edit)
        Me.Guna2ShadowPanel1.Controls.Add(Me.delete)
        Me.Guna2ShadowPanel1.Controls.Add(Me.adduse)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2Shapes1)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.DarkSlateGray
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(-55, -3)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(285, 742)
        Me.Guna2ShadowPanel1.TabIndex = 1
        '
        'search
        '
        Me.search.BackColor = System.Drawing.Color.DarkSlateGray
        Me.search.FlatAppearance.BorderSize = 0
        Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.search.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.ForeColor = System.Drawing.Color.White
        Me.search.IconChar = FontAwesome.Sharp.IconChar.None
        Me.search.IconColor = System.Drawing.Color.Black
        Me.search.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.search.Location = New System.Drawing.Point(55, 451)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(224, 55)
        Me.search.TabIndex = 18
        Me.search.Text = "Search"
        Me.search.UseVisualStyleBackColor = False
        '
        'edit
        '
        Me.edit.BackColor = System.Drawing.Color.DarkSlateGray
        Me.edit.FlatAppearance.BorderSize = 0
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.ForeColor = System.Drawing.Color.White
        Me.edit.IconChar = FontAwesome.Sharp.IconChar.None
        Me.edit.IconColor = System.Drawing.Color.Black
        Me.edit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.edit.Location = New System.Drawing.Point(56, 390)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(224, 55)
        Me.edit.TabIndex = 17
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.DarkSlateGray
        Me.delete.FlatAppearance.BorderSize = 0
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.ForeColor = System.Drawing.Color.White
        Me.delete.IconChar = FontAwesome.Sharp.IconChar.None
        Me.delete.IconColor = System.Drawing.Color.Black
        Me.delete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.delete.Location = New System.Drawing.Point(55, 329)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(224, 55)
        Me.delete.TabIndex = 16
        Me.delete.Text = "Delete a User"
        Me.delete.UseVisualStyleBackColor = False
        '
        'adduse
        '
        Me.adduse.BackColor = System.Drawing.Color.DarkSlateGray
        Me.adduse.FlatAppearance.BorderSize = 0
        Me.adduse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adduse.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adduse.ForeColor = System.Drawing.Color.White
        Me.adduse.IconChar = FontAwesome.Sharp.IconChar.None
        Me.adduse.IconColor = System.Drawing.Color.Black
        Me.adduse.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.adduse.Location = New System.Drawing.Point(53, 271)
        Me.adduse.Name = "adduse"
        Me.adduse.Size = New System.Drawing.Size(227, 55)
        Me.adduse.TabIndex = 15
        Me.adduse.Text = "Add a New User"
        Me.adduse.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(67, 691)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 32)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tru29 Solutions Inc." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All rights reserved © 2023" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(99, 85)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(129, 124)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AnimatedGIF = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 16
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(109, 615)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(119, 34)
        Me.Guna2Button1.TabIndex = 8
        Me.Guna2Button1.Text = "Sign Out"
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.White
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.White
        Me.Guna2Shapes1.LineThickness = 2
        Me.Guna2Shapes1.Location = New System.Drawing.Point(52, 558)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Me.Guna2Shapes1.Size = New System.Drawing.Size(228, 30)
        Me.Guna2Shapes1.TabIndex = 7
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MintCream
        Me.Label2.Location = New System.Drawing.Point(247, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(444, 64)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "WELCOME BACK!"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(236, 131)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1093, 589)
        Me.Panel1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents adduse As FontAwesome.Sharp.IconButton
    Friend WithEvents search As FontAwesome.Sharp.IconButton
    Friend WithEvents edit As FontAwesome.Sharp.IconButton
    Friend WithEvents delete As FontAwesome.Sharp.IconButton
End Class
