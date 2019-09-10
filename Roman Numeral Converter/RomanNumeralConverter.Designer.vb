<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RomanNumeralConverter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RomanNumeralConverter))
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnSwitch = New System.Windows.Forms.Button()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNum
        '
        Me.txtNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNum.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.Location = New System.Drawing.Point(121, 111)
        Me.txtNum.MaxLength = 4
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(233, 37)
        Me.txtNum.TabIndex = 2
        Me.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.lblResult.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.Black
        Me.lblResult.Location = New System.Drawing.Point(214, 209)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(35, 23)
        Me.lblResult.TabIndex = 5
        Me.lblResult.Text = "- - -"
        '
        'btnConvert
        '
        Me.btnConvert.BackgroundImage = CType(resources.GetObject("btnConvert.BackgroundImage"), System.Drawing.Image)
        Me.btnConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConvert.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(67, 162)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(107, 34)
        Me.btnConvert.TabIndex = 3
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnSwitch
        '
        Me.btnSwitch.BackgroundImage = CType(resources.GetObject("btnSwitch.BackgroundImage"), System.Drawing.Image)
        Me.btnSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSwitch.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSwitch.Location = New System.Drawing.Point(180, 162)
        Me.btnSwitch.Name = "btnSwitch"
        Me.btnSwitch.Size = New System.Drawing.Size(215, 34)
        Me.btnSwitch.TabIndex = 4
        Me.btnSwitch.Text = "Switch Converter Mode"
        Me.btnSwitch.UseVisualStyleBackColor = True
        '
        'picBackground
        '
        Me.picBackground.BackgroundImage = CType(resources.GetObject("picBackground.BackgroundImage"), System.Drawing.Image)
        Me.picBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBackground.Location = New System.Drawing.Point(0, 0)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(479, 265)
        Me.picBackground.TabIndex = 9
        Me.picBackground.TabStop = False
        '
        'RomanNumeralConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 265)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.btnSwitch)
        Me.Controls.Add(Me.picBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(495, 304)
        Me.MinimumSize = New System.Drawing.Size(495, 304)
        Me.Name = "RomanNumeralConverter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roman Numeral Converter"
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNum As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnSwitch As Button
    Friend WithEvents picBackground As PictureBox
End Class
