Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Form1.Language = "English") Then
            LblSusceptible.Text = "Susceptible"
            LblInfected.Text = "Infected"
            LblRecovered.Text = "Recovered"
            LblDays.Text = "Days"
        ElseIf (Form1.Language = "Arabic") Then
            LblSusceptible.Text = "سريع التأثر"
            LblInfected.Text = "إصابة"
            LblRecovered.Text = "تعافى"
            LblDays.Text = "أيام"
        ElseIf (Form1.Language = "Kiswahili") Then
            LblSusceptible.Text = "Inapotosha"
            LblInfected.Text = "Imeambukizwa"
            LblRecovered.Text = "Imerejeshwa"
            LblDays.Text = "Siku"
        ElseIf (Form1.language = "French") Then
            LblSusceptible.Text = "Sensible"
            LblInfected.Text = "Infecté"
            LblRecovered.Text = "Rétabli"
            LblDays.Text = "Journées"
        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

    End Sub

    Private Sub LblBeta_Click(sender As Object, e As EventArgs) Handles LblBeta.Click
        My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Beita.wav", AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub LblGamma_Click(sender As Object, e As EventArgs) Handles LblGamma.Click
        My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Gamma.wav", AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub LblSusceptible_Click(sender As Object, e As EventArgs) Handles LblSusceptible.Click
        If (Form1.Language = "English") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Sus_Eng.wav", AudioPlayMode.WaitToComplete)
        ElseIf (Form1.Language = "Arabic") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Sus_Arb.wav", AudioPlayMode.WaitToComplete)
        ElseIf (Form1.Language = "French") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Sus_Fre.wav", AudioPlayMode.WaitToComplete)
        ElseIf (Form1.Language = "Kiswahili") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Sus_Kiswa.wav", AudioPlayMode.WaitToComplete)
        End If
    End Sub

    Private Sub LblInfected_Click(sender As Object, e As EventArgs) Handles LblInfected.Click
        If (Form1.Language = "English") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Infect_Eng.wav", AudioPlayMode.WaitToComplete)
        ElseIf (Form1.Language = "Arabic") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Infect_Arb.wav", AudioPlayMode.WaitToComplete)
        ElseIf (Form1.Language = "French") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Infect_Fre.wav", AudioPlayMode.WaitToComplete)
        ElseIf (Form1.Language = "Kiswahili") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Infect_Kiswa.wav", AudioPlayMode.WaitToComplete)
        End If
    End Sub

    Private Sub LblRecovered_Click(sender As Object, e As EventArgs) Handles LblRecovered.Click
        If (Form1.Language = "English") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Rec_Eng.wav", AudioPlayMode.WaitToComplete)
        ElseIf (Form1.Language = "Arabic") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Rec_Arb.wav", AudioPlayMode.WaitToComplete)
        ElseIf (Form1.Language = "French") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Rec_Fre.wav", AudioPlayMode.WaitToComplete)
        ElseIf (Form1.Language = "Kiswahili") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Rec_Kiswa.wav", AudioPlayMode.WaitToComplete)
        End If
    End Sub

    Private Sub LblDays_Click(sender As Object, e As EventArgs) Handles LblDays.Click
        If (Form1.Language = "English") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Days_Eng.wav", AudioPlayMode.WaitToComplete)
        ElseIf (Form1.Language = "Arabic") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Days_Arb.wav", AudioPlayMode.WaitToComplete)
        ElseIf (Form1.Language = "French") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Days_Fre.wav", AudioPlayMode.WaitToComplete)
        ElseIf (Form1.Language = "Kiswahili") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Days_Kiswa.wav", AudioPlayMode.WaitToComplete)
        End If
    End Sub
End Class