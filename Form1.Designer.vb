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
        Me.lengthInput = New System.Windows.Forms.TextBox()
        Me.widthInput = New System.Windows.Forms.TextBox()
        Me.inputText = New System.Windows.Forms.Label()
        Me.lengthInputText = New System.Windows.Forms.Label()
        Me.widthInputText = New System.Windows.Forms.Label()
        Me.typeText = New System.Windows.Forms.Label()
        Me.inchCheck = New System.Windows.Forms.CheckBox()
        Me.footCheck = New System.Windows.Forms.CheckBox()
        Me.headingText = New System.Windows.Forms.Label()
        Me.volumeText = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.volumeCu = New System.Windows.Forms.Label()
        Me.volumeYds = New System.Windows.Forms.Label()
        Me.costOfConcrete = New System.Windows.Forms.Label()
        Me.costOfConcreteText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lengthInput
        '
        Me.lengthInput.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lengthInput.Location = New System.Drawing.Point(369, 158)
        Me.lengthInput.Name = "lengthInput"
        Me.lengthInput.Size = New System.Drawing.Size(100, 30)
        Me.lengthInput.TabIndex = 2
        '
        'widthInput
        '
        Me.widthInput.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.widthInput.Location = New System.Drawing.Point(369, 242)
        Me.widthInput.Name = "widthInput"
        Me.widthInput.Size = New System.Drawing.Size(100, 30)
        Me.widthInput.TabIndex = 3
        '
        'inputText
        '
        Me.inputText.AllowDrop = True
        Me.inputText.AutoSize = True
        Me.inputText.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputText.Location = New System.Drawing.Point(47, 124)
        Me.inputText.Name = "inputText"
        Me.inputText.Size = New System.Drawing.Size(101, 33)
        Me.inputText.TabIndex = 4
        Me.inputText.Text = "Input :"
        '
        'lengthInputText
        '
        Me.lengthInputText.AutoSize = True
        Me.lengthInputText.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lengthInputText.Location = New System.Drawing.Point(365, 124)
        Me.lengthInputText.Name = "lengthInputText"
        Me.lengthInputText.Size = New System.Drawing.Size(68, 22)
        Me.lengthInputText.TabIndex = 5
        Me.lengthInputText.Text = "Length :"
        Me.lengthInputText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'widthInputText
        '
        Me.widthInputText.AutoSize = True
        Me.widthInputText.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.widthInputText.Location = New System.Drawing.Point(365, 208)
        Me.widthInputText.Name = "widthInputText"
        Me.widthInputText.Size = New System.Drawing.Size(59, 22)
        Me.widthInputText.TabIndex = 6
        Me.widthInputText.Text = "Width :"
        '
        'typeText
        '
        Me.typeText.AllowDrop = True
        Me.typeText.AutoSize = True
        Me.typeText.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeText.Location = New System.Drawing.Point(47, 301)
        Me.typeText.Name = "typeText"
        Me.typeText.Size = New System.Drawing.Size(98, 33)
        Me.typeText.TabIndex = 12
        Me.typeText.Text = "Type :"
        '
        'inchCheck
        '
        Me.inchCheck.AutoSize = True
        Me.inchCheck.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inchCheck.Location = New System.Drawing.Point(369, 308)
        Me.inchCheck.Name = "inchCheck"
        Me.inchCheck.Size = New System.Drawing.Size(62, 26)
        Me.inchCheck.TabIndex = 13
        Me.inchCheck.Text = "inch"
        Me.inchCheck.UseVisualStyleBackColor = True
        '
        'footCheck
        '
        Me.footCheck.AutoSize = True
        Me.footCheck.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.footCheck.Location = New System.Drawing.Point(485, 308)
        Me.footCheck.Name = "footCheck"
        Me.footCheck.Size = New System.Drawing.Size(61, 26)
        Me.footCheck.TabIndex = 14
        Me.footCheck.Text = "foot"
        Me.footCheck.UseVisualStyleBackColor = True
        '
        'headingText
        '
        Me.headingText.AllowDrop = True
        Me.headingText.AutoSize = True
        Me.headingText.Font = New System.Drawing.Font("Arial Black", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headingText.Location = New System.Drawing.Point(57, 9)
        Me.headingText.Name = "headingText"
        Me.headingText.Size = New System.Drawing.Size(475, 46)
        Me.headingText.TabIndex = 15
        Me.headingText.Text = "Concrete Slab Calculator"
        '
        'volumeText
        '
        Me.volumeText.AllowDrop = True
        Me.volumeText.AutoSize = True
        Me.volumeText.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volumeText.Location = New System.Drawing.Point(47, 504)
        Me.volumeText.Name = "volumeText"
        Me.volumeText.Size = New System.Drawing.Size(149, 33)
        Me.volumeText.TabIndex = 16
        Me.volumeText.Text = "Volumes :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(53, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 63)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(245, 388)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 63)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(418, 388)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 63)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Quit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'volumeCu
        '
        Me.volumeCu.AutoSize = True
        Me.volumeCu.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volumeCu.Location = New System.Drawing.Point(441, 507)
        Me.volumeCu.Name = "volumeCu"
        Me.volumeCu.Size = New System.Drawing.Size(121, 24)
        Me.volumeCu.TabIndex = 20
        Me.volumeCu.Text = " 0.00 cu. Ft "
        '
        'volumeYds
        '
        Me.volumeYds.AutoSize = True
        Me.volumeYds.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volumeYds.Location = New System.Drawing.Point(441, 560)
        Me.volumeYds.Name = "volumeYds"
        Me.volumeYds.Size = New System.Drawing.Size(132, 24)
        Me.volumeYds.TabIndex = 21
        Me.volumeYds.Text = " 0.00 cu. Yds"
        '
        'costOfConcrete
        '
        Me.costOfConcrete.AutoSize = True
        Me.costOfConcrete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costOfConcrete.Location = New System.Drawing.Point(441, 623)
        Me.costOfConcrete.Name = "costOfConcrete"
        Me.costOfConcrete.Size = New System.Drawing.Size(60, 24)
        Me.costOfConcrete.TabIndex = 23
        Me.costOfConcrete.Text = "$0.00"
        '
        'costOfConcreteText
        '
        Me.costOfConcreteText.AllowDrop = True
        Me.costOfConcreteText.AutoSize = True
        Me.costOfConcreteText.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costOfConcreteText.Location = New System.Drawing.Point(47, 620)
        Me.costOfConcreteText.Name = "costOfConcreteText"
        Me.costOfConcreteText.Size = New System.Drawing.Size(262, 33)
        Me.costOfConcreteText.TabIndex = 22
        Me.costOfConcreteText.Text = "Cost Of Concrete :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(612, 692)
        Me.Controls.Add(Me.costOfConcrete)
        Me.Controls.Add(Me.costOfConcreteText)
        Me.Controls.Add(Me.volumeYds)
        Me.Controls.Add(Me.volumeCu)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.volumeText)
        Me.Controls.Add(Me.headingText)
        Me.Controls.Add(Me.footCheck)
        Me.Controls.Add(Me.inchCheck)
        Me.Controls.Add(Me.typeText)
        Me.Controls.Add(Me.widthInputText)
        Me.Controls.Add(Me.lengthInputText)
        Me.Controls.Add(Me.inputText)
        Me.Controls.Add(Me.widthInput)
        Me.Controls.Add(Me.lengthInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lengthInput As TextBox
    Friend WithEvents widthInput As TextBox
    Friend WithEvents inputText As Label

    Private Sub WidthInputText_TextChanged(sender As Object, e As EventArgs) Handles widthInput.TextChanged

    End Sub

    Friend WithEvents lengthInputText As Label
    Friend WithEvents widthInputText As Label

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lengthInputText.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles inputText.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles lengthInput.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents typeText As Label
    Friend WithEvents inchCheck As CheckBox
    Friend WithEvents footCheck As CheckBox

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles inchCheck.CheckedChanged

    End Sub

    Friend WithEvents headingText As Label
    Friend WithEvents volumeText As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents volumeCu As Label
    Friend WithEvents volumeYds As Label
    Friend WithEvents costOfConcrete As Label
    Friend WithEvents costOfConcreteText As Label

    'i dont know how all the text above apearedd

End Class


