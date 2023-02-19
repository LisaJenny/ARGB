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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxRGBITEMS = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBoxName_HEX = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RichTextBoxSeeColor = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RGB"
        '
        'ComboBoxRGBITEMS
        '
        Me.ComboBoxRGBITEMS.FormattingEnabled = True
        Me.ComboBoxRGBITEMS.Location = New System.Drawing.Point(12, 29)
        Me.ComboBoxRGBITEMS.Name = "ComboBoxRGBITEMS"
        Me.ComboBoxRGBITEMS.Size = New System.Drawing.Size(121, 25)
        Me.ComboBoxRGBITEMS.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name/HEX"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "载入"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 137)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "保存"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBoxName_HEX
        '
        Me.ComboBoxName_HEX.FormattingEnabled = True
        Me.ComboBoxName_HEX.Location = New System.Drawing.Point(12, 77)
        Me.ComboBoxName_HEX.Name = "ComboBoxName_HEX"
        Me.ComboBoxName_HEX.Size = New System.Drawing.Size(121, 25)
        Me.ComboBoxName_HEX.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 166)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "打开"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RichTextBoxSeeColor
        '
        Me.RichTextBoxSeeColor.Enabled = False
        Me.RichTextBoxSeeColor.Location = New System.Drawing.Point(12, 195)
        Me.RichTextBoxSeeColor.Name = "RichTextBoxSeeColor"
        Me.RichTextBoxSeeColor.Size = New System.Drawing.Size(138, 125)
        Me.RichTextBoxSeeColor.TabIndex = 9
        Me.RichTextBoxSeeColor.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RichTextBoxSeeColor)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxName_HEX)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxRGBITEMS)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxRGBITEMS As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBoxName_HEX As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents RichTextBoxSeeColor As RichTextBox
End Class
