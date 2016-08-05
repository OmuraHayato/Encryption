<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EncDec
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.InputTextBox = New System.Windows.Forms.RichTextBox()
        Me.OutPutTextBox = New System.Windows.Forms.RichTextBox()
        Me.Encryption_Button = New System.Windows.Forms.Button()
        Me.Decryption_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'InputTextBox
        '
        Me.InputTextBox.Location = New System.Drawing.Point(67, 27)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(166, 92)
        Me.InputTextBox.TabIndex = 1
        Me.InputTextBox.Text = ""
        '
        'OutPutTextBox
        '
        Me.OutPutTextBox.Location = New System.Drawing.Point(68, 144)
        Me.OutPutTextBox.Name = "OutPutTextBox"
        Me.OutPutTextBox.Size = New System.Drawing.Size(165, 92)
        Me.OutPutTextBox.TabIndex = 2
        Me.OutPutTextBox.Text = ""
        '
        'Encryption_Button
        '
        Me.Encryption_Button.Location = New System.Drawing.Point(248, 27)
        Me.Encryption_Button.Name = "Encryption_Button"
        Me.Encryption_Button.Size = New System.Drawing.Size(64, 28)
        Me.Encryption_Button.TabIndex = 3
        Me.Encryption_Button.Text = "暗号化"
        Me.Encryption_Button.UseVisualStyleBackColor = True
        '
        'Decryption_Button
        '
        Me.Decryption_Button.Location = New System.Drawing.Point(248, 74)
        Me.Decryption_Button.Name = "Decryption_Button"
        Me.Decryption_Button.Size = New System.Drawing.Size(64, 28)
        Me.Decryption_Button.TabIndex = 4
        Me.Decryption_Button.Text = "復号化"
        Me.Decryption_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "入力"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "出力"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(324, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Decryption_Button)
        Me.Controls.Add(Me.Encryption_Button)
        Me.Controls.Add(Me.OutPutTextBox)
        Me.Controls.Add(Me.InputTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InputTextBox As RichTextBox
    Friend WithEvents OutPutTextBox As RichTextBox
    Friend WithEvents Encryption_Button As Button
    Friend WithEvents Decryption_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
