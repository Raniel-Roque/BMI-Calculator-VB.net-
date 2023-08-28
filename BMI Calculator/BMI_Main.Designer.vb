<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BMI_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BMI_Main))
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeightBox = New System.Windows.Forms.TextBox()
        Me.HeightConvert = New System.Windows.Forms.ComboBox()
        Me.WeightConvert = New System.Windows.Forms.ComboBox()
        Me.WeightTxT = New System.Windows.Forms.Label()
        Me.WeightBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BMIBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BMICatBox = New System.Windows.Forms.TextBox()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Compute = New System.Windows.Forms.Button()
        Me.HeightTxT = New System.Windows.Forms.Label()
        Me.Exp_Col = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuBar.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'MenuBar
        '
        Me.MenuBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuBar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Padding = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.MenuBar.ShowItemToolTips = True
        Me.MenuBar.Size = New System.Drawing.Size(308, 36)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BackToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BackToolStripMenuItem.Image = CType(resources.GetObject("BackToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Padding = New System.Windows.Forms.Padding(5)
        Me.BackToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(30, 30)
        '
        'HeightBox
        '
        Me.HeightBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeightBox.Location = New System.Drawing.Point(94, 51)
        Me.HeightBox.Name = "HeightBox"
        Me.HeightBox.Size = New System.Drawing.Size(146, 26)
        Me.HeightBox.TabIndex = 1
        '
        'HeightConvert
        '
        Me.HeightConvert.DisplayMember = "1"
        Me.HeightConvert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HeightConvert.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeightConvert.FormattingEnabled = True
        Me.HeightConvert.Items.AddRange(New Object() {"cm", "in", "m"})
        Me.HeightConvert.Location = New System.Drawing.Point(246, 51)
        Me.HeightConvert.Name = "HeightConvert"
        Me.HeightConvert.Size = New System.Drawing.Size(50, 26)
        Me.HeightConvert.TabIndex = 3
        '
        'WeightConvert
        '
        Me.WeightConvert.DisplayMember = "1"
        Me.WeightConvert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WeightConvert.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightConvert.FormattingEnabled = True
        Me.WeightConvert.Items.AddRange(New Object() {"kg", "lbs"})
        Me.WeightConvert.Location = New System.Drawing.Point(246, 86)
        Me.WeightConvert.Name = "WeightConvert"
        Me.WeightConvert.Size = New System.Drawing.Size(50, 26)
        Me.WeightConvert.TabIndex = 6
        '
        'WeightTxT
        '
        Me.WeightTxT.AutoSize = True
        Me.WeightTxT.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightTxT.Location = New System.Drawing.Point(12, 88)
        Me.WeightTxT.Name = "WeightTxT"
        Me.WeightTxT.Size = New System.Drawing.Size(76, 24)
        Me.WeightTxT.TabIndex = 5
        Me.WeightTxT.Text = "Weight"
        '
        'WeightBox
        '
        Me.WeightBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightBox.Location = New System.Drawing.Point(94, 86)
        Me.WeightBox.Name = "WeightBox"
        Me.WeightBox.Size = New System.Drawing.Size(146, 26)
        Me.WeightBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "BMI"
        '
        'BMIBox
        '
        Me.BMIBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMIBox.Location = New System.Drawing.Point(94, 121)
        Me.BMIBox.Name = "BMIBox"
        Me.BMIBox.ReadOnly = True
        Me.BMIBox.Size = New System.Drawing.Size(202, 26)
        Me.BMIBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "BMI Category:"
        '
        'BMICatBox
        '
        Me.BMICatBox.BackColor = System.Drawing.SystemColors.Control
        Me.BMICatBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMICatBox.Location = New System.Drawing.Point(12, 187)
        Me.BMICatBox.Name = "BMICatBox"
        Me.BMICatBox.ReadOnly = True
        Me.BMICatBox.Size = New System.Drawing.Size(284, 26)
        Me.BMICatBox.TabIndex = 9
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Clear.FlatAppearance.BorderSize = 2
        Me.Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.Location = New System.Drawing.Point(12, 226)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(135, 36)
        Me.Clear.TabIndex = 11
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'Compute
        '
        Me.Compute.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Compute.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Compute.FlatAppearance.BorderSize = 2
        Me.Compute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Compute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Compute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Compute.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Compute.Location = New System.Drawing.Point(153, 226)
        Me.Compute.Name = "Compute"
        Me.Compute.Size = New System.Drawing.Size(143, 36)
        Me.Compute.TabIndex = 12
        Me.Compute.Text = "Compute"
        Me.Compute.UseVisualStyleBackColor = False
        '
        'HeightTxT
        '
        Me.HeightTxT.AutoSize = True
        Me.HeightTxT.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeightTxT.Location = New System.Drawing.Point(12, 53)
        Me.HeightTxT.Name = "HeightTxT"
        Me.HeightTxT.Size = New System.Drawing.Size(69, 24)
        Me.HeightTxT.TabIndex = 13
        Me.HeightTxT.Text = "Height"
        '
        'Exp_Col
        '
        Me.Exp_Col.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Exp_Col.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Exp_Col.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Exp_Col.FlatAppearance.BorderSize = 0
        Me.Exp_Col.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exp_Col.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exp_Col.ForeColor = System.Drawing.Color.Transparent
        Me.Exp_Col.Location = New System.Drawing.Point(0, 281)
        Me.Exp_Col.Name = "Exp_Col"
        Me.Exp_Col.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Exp_Col.Size = New System.Drawing.Size(308, 28)
        Me.Exp_Col.TabIndex = 14
        Me.Exp_Col.Text = "BMI Table (Expand)"
        Me.Exp_Col.UseCompatibleTextRendering = True
        Me.Exp_Col.UseMnemonic = False
        Me.Exp_Col.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(104, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 25)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Very Severely Underweight"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "> 15"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BMI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "15 - 16"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(104, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(176, 25)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Severely Underweight"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 25)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "16.1 - 18.5"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(104, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 25)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Underweight"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 25)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "18.5 - 25"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(104, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(176, 25)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Normal (Healthy Weight)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 25)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "25.1 - 30"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(104, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(176, 25)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Overweight"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 150)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 25)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "30.1 - 35"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(104, 150)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(176, 25)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Obese"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 175)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 25)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "35.1 - 40"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(104, 175)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(176, 25)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Severely Obese"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 200)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 31)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "< 40.1"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(104, 200)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(176, 31)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "Very Severely Obese"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.0424!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.9576!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 1)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 281)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(283, 231)
        Me.TableLayoutPanel1.TabIndex = 15
        Me.TableLayoutPanel1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "BMI Category"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BMI_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(308, 309)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Exp_Col)
        Me.Controls.Add(Me.HeightTxT)
        Me.Controls.Add(Me.Compute)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BMICatBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BMIBox)
        Me.Controls.Add(Me.WeightConvert)
        Me.Controls.Add(Me.WeightTxT)
        Me.Controls.Add(Me.WeightBox)
        Me.Controls.Add(Me.HeightConvert)
        Me.Controls.Add(Me.HeightBox)
        Me.Controls.Add(Me.MenuBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuBar
        Me.Name = "BMI_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BMI Calculator"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents MenuBar As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HeightBox As TextBox
    Friend WithEvents HeightConvert As ComboBox
    Friend WithEvents WeightConvert As ComboBox
    Friend WithEvents WeightTxT As Label
    Friend WithEvents WeightBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BMICatBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BMIBox As TextBox
    Friend WithEvents Compute As Button
    Friend WithEvents Clear As Button
    Friend WithEvents HeightTxT As Label
    Friend WithEvents Exp_Col As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
End Class
