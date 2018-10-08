<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LangSelect = New System.Windows.Forms.Label()
        Me.BtnEng = New System.Windows.Forms.Button()
        Me.BtnFre = New System.Windows.Forms.Button()
        Me.BtnArb = New System.Windows.Forms.Button()
        Me.BtnSwa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LangSelect
        '
        Me.LangSelect.AutoSize = True
        Me.LangSelect.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LangSelect.Location = New System.Drawing.Point(12, 9)
        Me.LangSelect.Name = "LangSelect"
        Me.LangSelect.Size = New System.Drawing.Size(538, 43)
        Me.LangSelect.TabIndex = 0
        Me.LangSelect.Text = "Please Choose Your Language"
        '
        'BtnEng
        '
        Me.BtnEng.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEng.Location = New System.Drawing.Point(66, 94)
        Me.BtnEng.Name = "BtnEng"
        Me.BtnEng.Size = New System.Drawing.Size(202, 101)
        Me.BtnEng.TabIndex = 1
        Me.BtnEng.Text = "English"
        Me.BtnEng.UseVisualStyleBackColor = True
        '
        'BtnFre
        '
        Me.BtnFre.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFre.Location = New System.Drawing.Point(359, 94)
        Me.BtnFre.Name = "BtnFre"
        Me.BtnFre.Size = New System.Drawing.Size(202, 101)
        Me.BtnFre.TabIndex = 2
        Me.BtnFre.Text = "Français"
        Me.BtnFre.UseVisualStyleBackColor = True
        '
        'BtnArb
        '
        Me.BtnArb.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnArb.Location = New System.Drawing.Point(66, 247)
        Me.BtnArb.Name = "BtnArb"
        Me.BtnArb.Size = New System.Drawing.Size(202, 101)
        Me.BtnArb.TabIndex = 3
        Me.BtnArb.Text = "عربى"
        Me.BtnArb.UseVisualStyleBackColor = True
        '
        'BtnSwa
        '
        Me.BtnSwa.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSwa.Location = New System.Drawing.Point(359, 247)
        Me.BtnSwa.Name = "BtnSwa"
        Me.BtnSwa.Size = New System.Drawing.Size(202, 101)
        Me.BtnSwa.TabIndex = 4
        Me.BtnSwa.Text = "Kiswahili"
        Me.BtnSwa.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 411)
        Me.Controls.Add(Me.BtnSwa)
        Me.Controls.Add(Me.BtnArb)
        Me.Controls.Add(Me.BtnFre)
        Me.Controls.Add(Me.BtnEng)
        Me.Controls.Add(Me.LangSelect)
        Me.Name = "Form1"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LangSelect As Label
    Friend WithEvents BtnEng As Button
    Friend WithEvents BtnFre As Button
    Friend WithEvents BtnArb As Button
    Friend WithEvents BtnSwa As Button
End Class
