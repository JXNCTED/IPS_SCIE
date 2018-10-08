Public Class Form1
    Public Language As String
    Private Sub BtnEng_Click(sender As Object, e As EventArgs) Handles BtnEng.Click
        Language = "English"
        My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\English.wav", AudioPlayMode.WaitToComplete)
        Me.Hide()
        MakeSureLang.Show()
    End Sub

    Private Sub BtnFre_Click(sender As Object, e As EventArgs) Handles BtnFre.Click
        Language = "French"
        My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\French.wav", AudioPlayMode.WaitToComplete)
        Me.Hide()
        MakeSureLang.Show()
    End Sub

    Private Sub BtnArb_Click(sender As Object, e As EventArgs) Handles BtnArb.Click
        Language = "Arabic"
        My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Arabic.wav", AudioPlayMode.WaitToComplete)
        Me.Hide()
        MakeSureLang.Show()
    End Sub

    Private Sub BtnSwa_Click(sender As Object, e As EventArgs) Handles BtnSwa.Click
        Language = "Kiswahili"
        My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Kiswahili.wav", AudioPlayMode.WaitToComplete)
        Me.Hide()
        MakeSureLang.Show()
    End Sub
End Class
