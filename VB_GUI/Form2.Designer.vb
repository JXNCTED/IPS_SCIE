<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtInputPw = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ErrMesg = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtInputPw
        '
        Me.TxtInputPw.AutoSize = True
        Me.TxtInputPw.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInputPw.Location = New System.Drawing.Point(45, 46)
        Me.TxtInputPw.Name = "TxtInputPw"
        Me.TxtInputPw.Size = New System.Drawing.Size(466, 39)
        Me.TxtInputPw.TabIndex = 0
        Me.TxtInputPw.Text = "Please Input Your Password"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("宋体", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(52, 115)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(459, 41)
        Me.TextBox1.TabIndex = 1
        '
        'ErrMesg
        '
        Me.ErrMesg.AutoSize = True
        Me.ErrMesg.Font = New System.Drawing.Font("宋体", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ErrMesg.ForeColor = System.Drawing.Color.Red
        Me.ErrMesg.Location = New System.Drawing.Point(56, 292)
        Me.ErrMesg.Name = "ErrMesg"
        Me.ErrMesg.Size = New System.Drawing.Size(362, 27)
        Me.ErrMesg.TabIndex = 2
        Me.ErrMesg.Text = "You have attemped 5 times"
        Me.ErrMesg.Visible = False
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnSubmit.Location = New System.Drawing.Point(52, 187)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(156, 57)
        Me.BtnSubmit.TabIndex = 3
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        Me.BtnQuit.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnQuit.Location = New System.Drawing.Point(359, 187)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(152, 57)
        Me.BtnQuit.TabIndex = 4
        Me.BtnQuit.Text = "Quit"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 411)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.ErrMesg)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TxtInputPw)
        Me.Name = "Form2"
        Me.Text = "Infectous Predict System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtInputPw As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ErrMesg As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnQuit As Button
End Class
