<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BMI_Loading
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BMI_Loading))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LoadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Title = New System.Windows.Forms.Label()
        Me.SubTitle = New System.Windows.Forms.Label()
        Me.Enter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(20, 143)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(244, 38)
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.Tag = ""
        Me.ProgressBar1.UseWaitCursor = True
        '
        'LoadTimer
        '
        Me.LoadTimer.Enabled = True
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(25, 35)
        Me.Title.Name = "Title"
        Me.Title.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Title.Size = New System.Drawing.Size(237, 42)
        Me.Title.TabIndex = 1
        Me.Title.Text = "Body Mass Index" & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'SubTitle
        '
        Me.SubTitle.AutoSize = True
        Me.SubTitle.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTitle.Location = New System.Drawing.Point(65, 75)
        Me.SubTitle.Name = "SubTitle"
        Me.SubTitle.Size = New System.Drawing.Size(149, 32)
        Me.SubTitle.TabIndex = 2
        Me.SubTitle.Text = "Calculator"
        Me.SubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Enter
        '
        Me.Enter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Enter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Enter.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Enter.FlatAppearance.BorderSize = 2
        Me.Enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Enter.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enter.Location = New System.Drawing.Point(20, 143)
        Me.Enter.Name = "Enter"
        Me.Enter.Size = New System.Drawing.Size(244, 38)
        Me.Enter.TabIndex = 3
        Me.Enter.Text = "Enter"
        Me.Enter.UseVisualStyleBackColor = False
        Me.Enter.Visible = False
        '
        'BMI_Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 211)
        Me.Controls.Add(Me.Enter)
        Me.Controls.Add(Me.SubTitle)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BMI_Loading"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 30)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BMI Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents LoadTimer As Timer
    Friend WithEvents Title As Label
    Friend WithEvents SubTitle As Label
    Friend WithEvents Enter As Button
End Class
