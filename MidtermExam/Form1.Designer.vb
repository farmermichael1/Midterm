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
        Me.bxConvert = New System.Windows.Forms.GroupBox()
        Me.rbtnInches = New System.Windows.Forms.RadioButton()
        Me.rbtnMeters = New System.Windows.Forms.RadioButton()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.lbValue = New System.Windows.Forms.Label()
        Me.lbResult = New System.Windows.Forms.Label()
        Me.bxConvert.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bxConvert
        '
        Me.bxConvert.Controls.Add(Me.rbtnInches)
        Me.bxConvert.Controls.Add(Me.rbtnMeters)
        Me.bxConvert.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bxConvert.Location = New System.Drawing.Point(423, 178)
        Me.bxConvert.Name = "bxConvert"
        Me.bxConvert.Size = New System.Drawing.Size(269, 100)
        Me.bxConvert.TabIndex = 0
        Me.bxConvert.TabStop = False
        Me.bxConvert.Text = "Convert Measurement"
        '
        'rbtnInches
        '
        Me.rbtnInches.AutoSize = True
        Me.rbtnInches.Location = New System.Drawing.Point(7, 67)
        Me.rbtnInches.Name = "rbtnInches"
        Me.rbtnInches.Size = New System.Drawing.Size(146, 22)
        Me.rbtnInches.TabIndex = 1
        Me.rbtnInches.TabStop = True
        Me.rbtnInches.Text = "Meters to Inches"
        Me.rbtnInches.UseVisualStyleBackColor = True
        '
        'rbtnMeters
        '
        Me.rbtnMeters.AutoSize = True
        Me.rbtnMeters.Location = New System.Drawing.Point(7, 34)
        Me.rbtnMeters.Name = "rbtnMeters"
        Me.rbtnMeters.Size = New System.Drawing.Size(146, 22)
        Me.rbtnMeters.TabIndex = 0
        Me.rbtnMeters.TabStop = True
        Me.rbtnMeters.Text = "Inches to Meters"
        Me.rbtnMeters.UseVisualStyleBackColor = True
        '
        'txtValue
        '
        Me.txtValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.Location = New System.Drawing.Point(621, 105)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(111, 26)
        Me.txtValue.TabIndex = 1
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnConvert.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(22, 398)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(194, 40)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(301, 398)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(194, 40)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnExit.Location = New System.Drawing.Point(573, 398)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(194, 40)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MidtermExam.My.Resources.Resources.building
        Me.PictureBox1.Location = New System.Drawing.Point(1, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 201)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.Location = New System.Drawing.Point(342, 28)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(223, 37)
        Me.lbTitle.TabIndex = 6
        Me.lbTitle.Text = "Converter App"
        '
        'lbValue
        '
        Me.lbValue.AutoSize = True
        Me.lbValue.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbValue.Location = New System.Drawing.Point(306, 108)
        Me.lbValue.Name = "lbValue"
        Me.lbValue.Size = New System.Drawing.Size(289, 21)
        Me.lbValue.TabIndex = 7
        Me.lbValue.Text = "Enter a value and choose conversion"
        '
        'lbResult
        '
        Me.lbResult.AutoSize = True
        Me.lbResult.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbResult.Location = New System.Drawing.Point(419, 318)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(95, 24)
        Me.lbResult.TabIndex = 8
        Me.lbResult.Text = "lbResult"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.lbValue)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.bxConvert)
        Me.Name = "Form1"
        Me.Text = "Building Plans Conversion"
        Me.bxConvert.ResumeLayout(False)
        Me.bxConvert.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bxConvert As GroupBox
    Friend WithEvents rbtnInches As RadioButton
    Friend WithEvents rbtnMeters As RadioButton
    Friend WithEvents txtValue As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbTitle As Label
    Friend WithEvents lbValue As Label
    Friend WithEvents lbResult As Label
End Class
