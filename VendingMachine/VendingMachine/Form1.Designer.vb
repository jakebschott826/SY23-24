<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.dollarpicturebox = New System.Windows.Forms.PictureBox()
        Me.dimepicturebox = New System.Windows.Forms.PictureBox()
        Me.nickelpicturebox = New System.Windows.Forms.PictureBox()
        Me.quarterpicturebox = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.IDtextbox = New System.Windows.Forms.TextBox()
        Me.ProductControl15 = New VendingMachine.ProductControl()
        Me.ProductControl16 = New VendingMachine.ProductControl()
        Me.ProductControl13 = New VendingMachine.ProductControl()
        Me.ProductControl14 = New VendingMachine.ProductControl()
        Me.ProductControl11 = New VendingMachine.ProductControl()
        Me.ProductControl12 = New VendingMachine.ProductControl()
        Me.ProductControl9 = New VendingMachine.ProductControl()
        Me.ProductControl10 = New VendingMachine.ProductControl()
        Me.ProductControl8 = New VendingMachine.ProductControl()
        Me.ProductControl7 = New VendingMachine.ProductControl()
        Me.ProductControl6 = New VendingMachine.ProductControl()
        Me.ProductControl5 = New VendingMachine.ProductControl()
        Me.ProductControl4 = New VendingMachine.ProductControl()
        Me.ProductControl3 = New VendingMachine.ProductControl()
        Me.ProductControl2 = New VendingMachine.ProductControl()
        Me.ProductControl1 = New VendingMachine.ProductControl()
        Me.productpicturebox = New System.Windows.Forms.PictureBox()
        CType(Me.dollarpicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dimepicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nickelpicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quarterpicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productpicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 22)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Nickel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(124, 22)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Dime"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(232, 22)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 28)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Quarter"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(340, 22)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 28)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Dollar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(329, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 54)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "total"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(365, 186)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "return"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'dollarpicturebox
        '
        Me.dollarpicturebox.Image = CType(resources.GetObject("dollarpicturebox.Image"), System.Drawing.Image)
        Me.dollarpicturebox.Location = New System.Drawing.Point(391, 365)
        Me.dollarpicturebox.Margin = New System.Windows.Forms.Padding(4)
        Me.dollarpicturebox.Name = "dollarpicturebox"
        Me.dollarpicturebox.Size = New System.Drawing.Size(49, 38)
        Me.dollarpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dollarpicturebox.TabIndex = 13
        Me.dollarpicturebox.TabStop = False
        Me.dollarpicturebox.Visible = False
        '
        'dimepicturebox
        '
        Me.dimepicturebox.Image = CType(resources.GetObject("dimepicturebox.Image"), System.Drawing.Image)
        Me.dimepicturebox.Location = New System.Drawing.Point(391, 227)
        Me.dimepicturebox.Margin = New System.Windows.Forms.Padding(4)
        Me.dimepicturebox.Name = "dimepicturebox"
        Me.dimepicturebox.Size = New System.Drawing.Size(49, 38)
        Me.dimepicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dimepicturebox.TabIndex = 12
        Me.dimepicturebox.TabStop = False
        Me.dimepicturebox.Visible = False
        '
        'nickelpicturebox
        '
        Me.nickelpicturebox.Image = CType(resources.GetObject("nickelpicturebox.Image"), System.Drawing.Image)
        Me.nickelpicturebox.Location = New System.Drawing.Point(391, 273)
        Me.nickelpicturebox.Margin = New System.Windows.Forms.Padding(4)
        Me.nickelpicturebox.Name = "nickelpicturebox"
        Me.nickelpicturebox.Size = New System.Drawing.Size(49, 38)
        Me.nickelpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.nickelpicturebox.TabIndex = 11
        Me.nickelpicturebox.TabStop = False
        Me.nickelpicturebox.Visible = False
        '
        'quarterpicturebox
        '
        Me.quarterpicturebox.Image = CType(resources.GetObject("quarterpicturebox.Image"), System.Drawing.Image)
        Me.quarterpicturebox.Location = New System.Drawing.Point(391, 319)
        Me.quarterpicturebox.Margin = New System.Windows.Forms.Padding(4)
        Me.quarterpicturebox.Name = "quarterpicturebox"
        Me.quarterpicturebox.Size = New System.Drawing.Size(49, 38)
        Me.quarterpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.quarterpicturebox.TabIndex = 10
        Me.quarterpicturebox.TabStop = False
        Me.quarterpicturebox.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(340, 58)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(49, 38)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(232, 58)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(49, 38)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(124, 58)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 58)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 215)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 111)
        Me.Button6.TabIndex = 30
        Me.Button6.Text = "buy"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'IDtextbox
        '
        Me.IDtextbox.Location = New System.Drawing.Point(12, 187)
        Me.IDtextbox.Name = "IDtextbox"
        Me.IDtextbox.Size = New System.Drawing.Size(170, 22)
        Me.IDtextbox.TabIndex = 31
        '
        'ProductControl15
        '
        Me.ProductControl15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl15.Location = New System.Drawing.Point(915, 404)
        Me.ProductControl15.Name = "ProductControl15"
        Me.ProductControl15.productcount = 10
        Me.ProductControl15.productID = "D4"
        Me.ProductControl15.productimage = Global.VendingMachine.My.Resources.Resources.azsweet
        Me.ProductControl15.productname = "AZ Sweet Tea"
        Me.ProductControl15.productprice = New Decimal(New Integer() {175, 0, 0, 131072})
        Me.ProductControl15.Size = New System.Drawing.Size(147, 127)
        Me.ProductControl15.TabIndex = 29
        '
        'ProductControl16
        '
        Me.ProductControl16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl16.Location = New System.Drawing.Point(915, 271)
        Me.ProductControl16.Name = "ProductControl16"
        Me.ProductControl16.productcount = 10
        Me.ProductControl16.productID = "C4"
        Me.ProductControl16.productimage = Global.VendingMachine.My.Resources.Resources.kitkat
        Me.ProductControl16.productname = "KitKat"
        Me.ProductControl16.productprice = New Decimal(New Integer() {200, 0, 0, 131072})
        Me.ProductControl16.Size = New System.Drawing.Size(147, 127)
        Me.ProductControl16.TabIndex = 28
        '
        'ProductControl13
        '
        Me.ProductControl13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl13.Location = New System.Drawing.Point(613, 271)
        Me.ProductControl13.Name = "ProductControl13"
        Me.ProductControl13.productcount = 10
        Me.ProductControl13.productID = "C2"
        Me.ProductControl13.productimage = Global.VendingMachine.My.Resources.Resources.gummyworms
        Me.ProductControl13.productname = "Sour Gummy Worms"
        Me.ProductControl13.productprice = New Decimal(New Integer() {250, 0, 0, 131072})
        Me.ProductControl13.Size = New System.Drawing.Size(147, 127)
        Me.ProductControl13.TabIndex = 27
        '
        'ProductControl14
        '
        Me.ProductControl14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl14.Location = New System.Drawing.Point(764, 271)
        Me.ProductControl14.Name = "ProductControl14"
        Me.ProductControl14.productcount = 10
        Me.ProductControl14.productID = "C3"
        Me.ProductControl14.productimage = Global.VendingMachine.My.Resources.Resources.mandms
        Me.ProductControl14.productname = "M&Ms"
        Me.ProductControl14.productprice = New Decimal(New Integer() {175, 0, 0, 131072})
        Me.ProductControl14.Size = New System.Drawing.Size(147, 127)
        Me.ProductControl14.TabIndex = 26
        '
        'ProductControl11
        '
        Me.ProductControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl11.Location = New System.Drawing.Point(764, 404)
        Me.ProductControl11.Name = "ProductControl11"
        Me.ProductControl11.productcount = 10
        Me.ProductControl11.productID = "D3"
        Me.ProductControl11.productimage = Global.VendingMachine.My.Resources.Resources.coke
        Me.ProductControl11.productname = "CocaCola"
        Me.ProductControl11.productprice = New Decimal(New Integer() {250, 0, 0, 131072})
        Me.ProductControl11.Size = New System.Drawing.Size(147, 127)
        Me.ProductControl11.TabIndex = 25
        '
        'ProductControl12
        '
        Me.ProductControl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl12.Location = New System.Drawing.Point(613, 404)
        Me.ProductControl12.Name = "ProductControl12"
        Me.ProductControl12.productcount = 10
        Me.ProductControl12.productID = "D2"
        Me.ProductControl12.productimage = Global.VendingMachine.My.Resources.Resources.redbull
        Me.ProductControl12.productname = "RedBull"
        Me.ProductControl12.productprice = New Decimal(New Integer() {250, 0, 0, 131072})
        Me.ProductControl12.Size = New System.Drawing.Size(147, 127)
        Me.ProductControl12.TabIndex = 24
        '
        'ProductControl9
        '
        Me.ProductControl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl9.Location = New System.Drawing.Point(764, 138)
        Me.ProductControl9.Name = "ProductControl9"
        Me.ProductControl9.productcount = 10
        Me.ProductControl9.productID = "B3"
        Me.ProductControl9.productimage = Global.VendingMachine.My.Resources.Resources.Oatmeal
        Me.ProductControl9.productname = "Oatmeal Cream Pie"
        Me.ProductControl9.productprice = New Decimal(New Integer() {250, 0, 0, 131072})
        Me.ProductControl9.Size = New System.Drawing.Size(147, 127)
        Me.ProductControl9.TabIndex = 23
        '
        'ProductControl10
        '
        Me.ProductControl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl10.Location = New System.Drawing.Point(915, 138)
        Me.ProductControl10.Name = "ProductControl10"
        Me.ProductControl10.productcount = 10
        Me.ProductControl10.productID = "B4"
        Me.ProductControl10.productimage = Global.VendingMachine.My.Resources.Resources.starcrunch
        Me.ProductControl10.productname = "Star Crunch"
        Me.ProductControl10.productprice = New Decimal(New Integer() {175, 0, 0, 131072})
        Me.ProductControl10.Size = New System.Drawing.Size(147, 127)
        Me.ProductControl10.TabIndex = 22
        '
        'ProductControl8
        '
        Me.ProductControl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl8.Location = New System.Drawing.Point(613, 138)
        Me.ProductControl8.Name = "ProductControl8"
        Me.ProductControl8.productcount = 10
        Me.ProductControl8.productID = "B2"
        Me.ProductControl8.productimage = Global.VendingMachine.My.Resources.Resources.CCookie
        Me.ProductControl8.productname = "Cookie"
        Me.ProductControl8.productprice = New Decimal(New Integer() {200, 0, 0, 131072})
        Me.ProductControl8.Size = New System.Drawing.Size(147, 127)
        Me.ProductControl8.TabIndex = 21
        '
        'ProductControl7
        '
        Me.ProductControl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl7.Location = New System.Drawing.Point(462, 404)
        Me.ProductControl7.Name = "ProductControl7"
        Me.ProductControl7.productcount = 10
        Me.ProductControl7.productID = "D1"
        Me.ProductControl7.productimage = Global.VendingMachine.My.Resources.Resources.monster
        Me.ProductControl7.productname = "Monster"
        Me.ProductControl7.productprice = New Decimal(New Integer() {275, 0, 0, 131072})
        Me.ProductControl7.Size = New System.Drawing.Size(147, 127)
        Me.ProductControl7.TabIndex = 20
        '
        'ProductControl6
        '
        Me.ProductControl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl6.Location = New System.Drawing.Point(462, 271)
        Me.ProductControl6.Name = "ProductControl6"
        Me.ProductControl6.productcount = 10
        Me.ProductControl6.productID = "C1"
        Me.ProductControl6.productimage = Global.VendingMachine.My.Resources.Resources.skittles
        Me.ProductControl6.productname = "Skittles"
        Me.ProductControl6.productprice = New Decimal(New Integer() {175, 0, 0, 131072})
        Me.ProductControl6.Size = New System.Drawing.Size(147, 127)
        Me.ProductControl6.TabIndex = 19
        '
        'ProductControl5
        '
        Me.ProductControl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl5.Location = New System.Drawing.Point(462, 138)
        Me.ProductControl5.Name = "ProductControl5"
        Me.ProductControl5.productcount = 10
        Me.ProductControl5.productID = "B1"
        Me.ProductControl5.productimage = Global.VendingMachine.My.Resources.Resources.oreos
        Me.ProductControl5.productname = "Oreos"
        Me.ProductControl5.productprice = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl5.Size = New System.Drawing.Size(147, 127)
        Me.ProductControl5.TabIndex = 18
        '
        'ProductControl4
        '
        Me.ProductControl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl4.Location = New System.Drawing.Point(613, 5)
        Me.ProductControl4.Name = "ProductControl4"
        Me.ProductControl4.productcount = 10
        Me.ProductControl4.productID = "A2"
        Me.ProductControl4.productimage = Global.VendingMachine.My.Resources.Resources.download__6_
        Me.ProductControl4.productname = "Lays Classic"
        Me.ProductControl4.productprice = New Decimal(New Integer() {200, 0, 0, 131072})
        Me.ProductControl4.Size = New System.Drawing.Size(147, 127)
        Me.ProductControl4.TabIndex = 17
        '
        'ProductControl3
        '
        Me.ProductControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl3.Location = New System.Drawing.Point(764, 5)
        Me.ProductControl3.Name = "ProductControl3"
        Me.ProductControl3.productcount = 10
        Me.ProductControl3.productID = "A3"
        Me.ProductControl3.productimage = Global.VendingMachine.My.Resources.Resources.cheetos
        Me.ProductControl3.productname = "Baked Cheetos"
        Me.ProductControl3.productprice = New Decimal(New Integer() {200, 0, 0, 131072})
        Me.ProductControl3.Size = New System.Drawing.Size(147, 127)
        Me.ProductControl3.TabIndex = 16
        '
        'ProductControl2
        '
        Me.ProductControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl2.Location = New System.Drawing.Point(915, 5)
        Me.ProductControl2.Name = "ProductControl2"
        Me.ProductControl2.productcount = 10
        Me.ProductControl2.productID = "A4"
        Me.ProductControl2.productimage = Global.VendingMachine.My.Resources.Resources.S_VKettle
        Me.ProductControl2.productname = "Salt & Vinegar Kettle"
        Me.ProductControl2.productprice = New Decimal(New Integer() {200, 0, 0, 131072})
        Me.ProductControl2.Size = New System.Drawing.Size(147, 127)
        Me.ProductControl2.TabIndex = 15
        '
        'ProductControl1
        '
        Me.ProductControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl1.Location = New System.Drawing.Point(462, 5)
        Me.ProductControl1.Name = "ProductControl1"
        Me.ProductControl1.productcount = 10
        Me.ProductControl1.productID = "A1"
        Me.ProductControl1.productimage = CType(resources.GetObject("ProductControl1.productimage"), System.Drawing.Image)
        Me.ProductControl1.productname = "Doritos Sweet/Spicy Chili"
        Me.ProductControl1.productprice = New Decimal(New Integer() {200, 0, 0, 131072})
        Me.ProductControl1.Size = New System.Drawing.Size(147, 127)
        Me.ProductControl1.TabIndex = 14
        '
        'productpicturebox
        '
        Me.productpicturebox.Location = New System.Drawing.Point(462, 548)
        Me.productpicturebox.Margin = New System.Windows.Forms.Padding(4)
        Me.productpicturebox.Name = "productpicturebox"
        Me.productpicturebox.Size = New System.Drawing.Size(145, 127)
        Me.productpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.productpicturebox.TabIndex = 32
        Me.productpicturebox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 688)
        Me.Controls.Add(Me.productpicturebox)
        Me.Controls.Add(Me.IDtextbox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ProductControl15)
        Me.Controls.Add(Me.ProductControl16)
        Me.Controls.Add(Me.ProductControl13)
        Me.Controls.Add(Me.ProductControl14)
        Me.Controls.Add(Me.ProductControl11)
        Me.Controls.Add(Me.ProductControl12)
        Me.Controls.Add(Me.ProductControl9)
        Me.Controls.Add(Me.ProductControl10)
        Me.Controls.Add(Me.ProductControl8)
        Me.Controls.Add(Me.ProductControl7)
        Me.Controls.Add(Me.ProductControl6)
        Me.Controls.Add(Me.ProductControl5)
        Me.Controls.Add(Me.ProductControl4)
        Me.Controls.Add(Me.ProductControl3)
        Me.Controls.Add(Me.ProductControl2)
        Me.Controls.Add(Me.ProductControl1)
        Me.Controls.Add(Me.dollarpicturebox)
        Me.Controls.Add(Me.dimepicturebox)
        Me.Controls.Add(Me.nickelpicturebox)
        Me.Controls.Add(Me.quarterpicturebox)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dollarpicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dimepicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nickelpicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quarterpicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productpicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents quarterpicturebox As PictureBox
    Friend WithEvents nickelpicturebox As PictureBox
    Friend WithEvents dimepicturebox As PictureBox
    Friend WithEvents dollarpicturebox As PictureBox
    Friend WithEvents ProductControl1 As ProductControl
    Friend WithEvents ProductControl2 As ProductControl
    Friend WithEvents ProductControl3 As ProductControl
    Friend WithEvents ProductControl4 As ProductControl
    Friend WithEvents ProductControl5 As ProductControl
    Friend WithEvents ProductControl6 As ProductControl
    Friend WithEvents ProductControl7 As ProductControl
    Friend WithEvents ProductControl8 As ProductControl
    Friend WithEvents ProductControl9 As ProductControl
    Friend WithEvents ProductControl10 As ProductControl
    Friend WithEvents ProductControl11 As ProductControl
    Friend WithEvents ProductControl12 As ProductControl
    Friend WithEvents ProductControl13 As ProductControl
    Friend WithEvents ProductControl14 As ProductControl
    Friend WithEvents ProductControl15 As ProductControl
    Friend WithEvents ProductControl16 As ProductControl
    Friend WithEvents Button6 As Button
    Friend WithEvents IDtextbox As TextBox
    Friend WithEvents productpicturebox As PictureBox
End Class
