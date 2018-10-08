Public Class Form2
    Dim Password As String = "1234567"
    Dim counter As Integer = 0

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim InPassword As String

        InPassword = TextBox1.Text

        If (InPassword = Password) Then
            Hide()
            Form3.Show()
        Else
            ErrMesg.Text = "Wrong Password, you have attemped"
            ErrMesg.Visible = True
            counter = counter + 1
        End If
        If (counter = 5) Then
            End

        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Form1.Language = "English") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\InPass_Eng.wav", AudioPlayMode.WaitToComplete)
            TxtInputPw.Text = "Please input your password"
            BtnSubmit.Text = "Submit"
            BtnQuit.Text = "Quit"
            ErrMesg.Text = "You have attempted 5 times"

        ElseIf (Form1.Language = "Arabic") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\InPass_Arb.wav", AudioPlayMode.WaitToComplete)
            TxtInputPw.Text = "يرجى إدخال كلمة المرور الخاصة بك"
            BtnSubmit.Text = "خضع"
            BtnQuit.Text = "استقال"
            ErrMesg.Text = "لقد حاولت 5 مرات"

        ElseIf (Form1.Language = "French") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\InPass_Fre.wav", AudioPlayMode.WaitToComplete)
            TxtInputPw.Text = "Veuillez saisir votre mot de passe"
            BtnSubmit.Text = "Soumettre"
            BtnQuit.Text = "Quitter"
            ErrMesg.Text = "Vous avez tenté 5 fois"

        ElseIf (Form1.Language = "Kiswahili") Then
            My.Computer.Audio.Play("C:\Users\Ted\Desktop\学习\visual basic\IPS_GUI_VB\TTSVoice\InPass_Kiswa.wav", AudioPlayMode.WaitToComplete)
            TxtInputPw.Text = "Tafadhali ingiza nenosiri lako"
            BtnSubmit.Text = "Tuma"
            BtnQuit.Text = "Ondoa"
            ErrMesg.Text = "Umejaribu mara 5"

        End If

    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        End
    End Sub
End Class