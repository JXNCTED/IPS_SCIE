Public Class MakeSureLang
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Hide()
        Form2.Show()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Hide()
        Form1.Show()
    End Sub

    Private Sub MakeSureLang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Form1.Language = "English") Then
            LblConfirm.Text = "Choose English as your system language"
            BtnSubmit.Text = "Submit"
            BtnCancel.Text = "Cancel"
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Confirm_Eng.wav", AudioPlayMode.WaitToComplete)
        ElseIf (Form1.Language = "Arabic") Then
            LblConfirm.Text = "اختر اللغة العربية كلغة النظام الخاصة بك"
            BtnSubmit.Text = "خضع"
            BtnCancel.Text = "إلغاء"
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Confirm_Arb.wav", AudioPlayMode.WaitToComplete)
        ElseIf (Form1.Language = "French") Then
            LblConfirm.Text = "Choisissez le français comme langue système"
            BtnSubmit.Text = "Soumettre"
            BtnCancel.Text = "Annuler"
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Confirm_Fre.wav", AudioPlayMode.WaitToComplete)
        ElseIf (Form1.Language = "Kiswahili") Then
            LblConfirm.Text = "Chagua Kiswahili lugha yako ya mfumo"
            BtnSubmit.Text = "Tuma"
            BtnCancel.Text = "Futa"
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\Confirm_Kiswa.wav", AudioPlayMode.WaitToComplete)
        End If
    End Sub
End Class