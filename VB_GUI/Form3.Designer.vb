<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.LblBeta = New System.Windows.Forms.Label()
        Me.LblGamma = New System.Windows.Forms.Label()
        Me.LblSusceptible = New System.Windows.Forms.Label()
        Me.LblInfected = New System.Windows.Forms.Label()
        Me.LblRecovered = New System.Windows.Forms.Label()
        Me.LblDays = New System.Windows.Forms.Label()
        Me.TxtBeta = New System.Windows.Forms.TextBox()
        Me.TxtGamma = New System.Windows.Forms.TextBox()
        Me.TxtSusceptible = New System.Windows.Forms.TextBox()
        Me.TxtInfected = New System.Windows.Forms.TextBox()
        Me.TxtRecovered = New System.Windows.Forms.TextBox()
        Me.TxtDays = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PicResult = New System.Windows.Forms.PictureBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        CType(Me.PicResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblBeta
        '
        Me.LblBeta.AutoSize = True
        Me.LblBeta.Font = New System.Drawing.Font("SOLIDWORKS GDT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBeta.Location = New System.Drawing.Point(24, 23)
        Me.LblBeta.Name = "LblBeta"
        Me.LblBeta.Size = New System.Drawing.Size(32, 33)
        Me.LblBeta.TabIndex = 0
        Me.LblBeta.Text = "β"
        '
        'LblGamma
        '
        Me.LblGamma.AutoSize = True
        Me.LblGamma.Font = New System.Drawing.Font("SOLIDWORKS GDT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGamma.Location = New System.Drawing.Point(24, 73)
        Me.LblGamma.Name = "LblGamma"
        Me.LblGamma.Size = New System.Drawing.Size(31, 33)
        Me.LblGamma.TabIndex = 1
        Me.LblGamma.Text = "γ"
        '
        'LblSusceptible
        '
        Me.LblSusceptible.AutoSize = True
        Me.LblSusceptible.Font = New System.Drawing.Font("SOLIDWORKS GDT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSusceptible.Location = New System.Drawing.Point(24, 128)
        Me.LblSusceptible.Name = "LblSusceptible"
        Me.LblSusceptible.Size = New System.Drawing.Size(165, 33)
        Me.LblSusceptible.TabIndex = 5
        Me.LblSusceptible.Text = "Susceptible"
        '
        'LblInfected
        '
        Me.LblInfected.AutoSize = True
        Me.LblInfected.Font = New System.Drawing.Font("SOLIDWORKS GDT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfected.Location = New System.Drawing.Point(24, 178)
        Me.LblInfected.Name = "LblInfected"
        Me.LblInfected.Size = New System.Drawing.Size(123, 33)
        Me.LblInfected.TabIndex = 7
        Me.LblInfected.Text = "Infected"
        '
        'LblRecovered
        '
        Me.LblRecovered.AutoSize = True
        Me.LblRecovered.Font = New System.Drawing.Font("SOLIDWORKS GDT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRecovered.Location = New System.Drawing.Point(24, 228)
        Me.LblRecovered.Name = "LblRecovered"
        Me.LblRecovered.Size = New System.Drawing.Size(154, 33)
        Me.LblRecovered.TabIndex = 8
        Me.LblRecovered.Text = "Recovered"
        '
        'LblDays
        '
        Me.LblDays.AutoSize = True
        Me.LblDays.Font = New System.Drawing.Font("SOLIDWORKS GDT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDays.Location = New System.Drawing.Point(24, 278)
        Me.LblDays.Name = "LblDays"
        Me.LblDays.Size = New System.Drawing.Size(80, 33)
        Me.LblDays.TabIndex = 9
        Me.LblDays.Text = "Days"
        '
        'TxtBeta
        '
        Me.TxtBeta.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtBeta.Location = New System.Drawing.Point(253, 25)
        Me.TxtBeta.Name = "TxtBeta"
        Me.TxtBeta.Size = New System.Drawing.Size(100, 35)
        Me.TxtBeta.TabIndex = 10
        '
        'TxtGamma
        '
        Me.TxtGamma.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtGamma.Location = New System.Drawing.Point(253, 75)
        Me.TxtGamma.Name = "TxtGamma"
        Me.TxtGamma.Size = New System.Drawing.Size(100, 35)
        Me.TxtGamma.TabIndex = 11
        '
        'TxtSusceptible
        '
        Me.TxtSusceptible.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtSusceptible.Location = New System.Drawing.Point(253, 130)
        Me.TxtSusceptible.Name = "TxtSusceptible"
        Me.TxtSusceptible.Size = New System.Drawing.Size(100, 35)
        Me.TxtSusceptible.TabIndex = 15
        '
        'TxtInfected
        '
        Me.TxtInfected.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtInfected.Location = New System.Drawing.Point(253, 180)
        Me.TxtInfected.Name = "TxtInfected"
        Me.TxtInfected.Size = New System.Drawing.Size(100, 35)
        Me.TxtInfected.TabIndex = 17
        '
        'TxtRecovered
        '
        Me.TxtRecovered.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtRecovered.Location = New System.Drawing.Point(253, 230)
        Me.TxtRecovered.Name = "TxtRecovered"
        Me.TxtRecovered.Size = New System.Drawing.Size(100, 35)
        Me.TxtRecovered.TabIndex = 18
        '
        'TxtDays
        '
        Me.TxtDays.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtDays.Location = New System.Drawing.Point(253, 280)
        Me.TxtDays.Name = "TxtDays"
        Me.TxtDays.Size = New System.Drawing.Size(100, 35)
        Me.TxtDays.TabIndex = 19
        '
        'PicResult
        '
        Me.PicResult.Location = New System.Drawing.Point(370, 25)
        Me.PicResult.Name = "PicResult"
        Me.PicResult.Size = New System.Drawing.Size(312, 290)
        Me.PicResult.TabIndex = 20
        Me.PicResult.TabStop = False
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Font = New System.Drawing.Font("SOLIDWORKS GDT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.Location = New System.Drawing.Point(30, 325)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(652, 38)
        Me.BtnSubmit.TabIndex = 21
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 375)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.PicResult)
        Me.Controls.Add(Me.TxtDays)
        Me.Controls.Add(Me.TxtRecovered)
        Me.Controls.Add(Me.TxtInfected)
        Me.Controls.Add(Me.TxtSusceptible)
        Me.Controls.Add(Me.TxtGamma)
        Me.Controls.Add(Me.TxtBeta)
        Me.Controls.Add(Me.LblDays)
        Me.Controls.Add(Me.LblRecovered)
        Me.Controls.Add(Me.LblInfected)
        Me.Controls.Add(Me.LblSusceptible)
        Me.Controls.Add(Me.LblGamma)
        Me.Controls.Add(Me.LblBeta)
        Me.Name = "Form3"
        Me.Text = "Infecteous Predict System"
        CType(Me.PicResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblBeta As Label
    Friend WithEvents LblGamma As Label
    Friend WithEvents LblSusceptible As Label
    Friend WithEvents LblInfected As Label
    Friend WithEvents LblRecovered As Label
    Friend WithEvents LblDays As Label
    Friend WithEvents TxtBeta As TextBox
    Friend WithEvents TxtGamma As TextBox
    Friend WithEvents TxtSusceptible As TextBox
    Friend WithEvents TxtInfected As TextBox
    Friend WithEvents TxtRecovered As TextBox
    Friend WithEvents TxtDays As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PicResult As PictureBox
    Friend WithEvents BtnSubmit As Button
End Class
