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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ElementHost1 = New System.Windows.Forms.Integration.ElementHost()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PythonInstall = New System.Windows.Forms.TextBox()
        Me.mbal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFile = New System.Windows.Forms.Button()
        Me.SaveFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(991, 635)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 31)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Info"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ElementHost1
        '
        Me.ElementHost1.Location = New System.Drawing.Point(719, 538)
        Me.ElementHost1.Name = "ElementHost1"
        Me.ElementHost1.Size = New System.Drawing.Size(190, 72)
        Me.ElementHost1.TabIndex = 3
        Me.ElementHost1.Text = "ElementHost1"
        Me.ElementHost1.Child = Nothing
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(13, 69)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1117, 560)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'PythonInstall
        '
        Me.PythonInstall.Location = New System.Drawing.Point(13, 13)
        Me.PythonInstall.Name = "PythonInstall"
        Me.PythonInstall.Size = New System.Drawing.Size(269, 22)
        Me.PythonInstall.TabIndex = 5
        Me.PythonInstall.Text = "Python Executable"
        Me.PythonInstall.Visible = False
        '
        'mbal
        '
        Me.mbal.Location = New System.Drawing.Point(12, 41)
        Me.mbal.Name = "mbal"
        Me.mbal.Size = New System.Drawing.Size(269, 22)
        Me.mbal.TabIndex = 5
        Me.mbal.Text = "shell.py"
        Me.mbal.Visible = False
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(301, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 52)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(848, 13)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(282, 50)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Visible = False
        '
        'OpenFile
        '
        Me.OpenFile.Location = New System.Drawing.Point(13, 635)
        Me.OpenFile.Name = "OpenFile"
        Me.OpenFile.Size = New System.Drawing.Size(130, 31)
        Me.OpenFile.TabIndex = 8
        Me.OpenFile.Text = "Open File"
        Me.OpenFile.UseVisualStyleBackColor = True
        '
        'SaveFile
        '
        Me.SaveFile.Location = New System.Drawing.Point(149, 635)
        Me.SaveFile.Name = "SaveFile"
        Me.SaveFile.Size = New System.Drawing.Size(130, 31)
        Me.SaveFile.TabIndex = 8
        Me.SaveFile.Text = "Save File"
        Me.SaveFile.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(464, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 39)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Welcome to mbal editor"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 678)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveFile)
        Me.Controls.Add(Me.OpenFile)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mbal)
        Me.Controls.Add(Me.PythonInstall)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ElementHost1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form1"
        Me.Text = "mbal editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents ElementHost1 As Integration.ElementHost
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PythonInstall As TextBox
    Friend WithEvents mbal As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents OpenFile As Button
    Friend WithEvents SaveFile As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label1 As Label
End Class
