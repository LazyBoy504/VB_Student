Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Snum As Integer
        Snum = TextBox1.Text

        Dim Sname As String
        Sname = TextBox2.Text

        Dim Sknow As String
        If RadioButton1.Checked Then
            Sknow = "Beginner Level"
        ElseIf RadioButton2.Checked Then
            Sknow = "Intermediate Level"
        ElseIf RadioButton3.Checked Then
            Sknow = "High Level"
        End If

        Dim Sfaci As String
        If (CheckBox1.Checked) Then
            Sfaci = Sfaci + "Internet, "
        End If
        If (CheckBox2.Checked) Then
            Sfaci = Sfaci + "Books, "
        End If
        If (CheckBox3.Checked) Then
            Sfaci = Sfaci + "Personal Computer"
        End If

        Dim Squali As String
        Squali = ComboBox1.Text

        Dim SprogLang As String
        SprogLang = ListBox1.Items(ListBox1.SelectedIndex)

        Dim Smsg As String
        Smsg = "Student Number:- " & Snum & vbCrLf & "Student Name:- " & Sname & vbCrLf & "Student Knowledge:- " & Sknow & vbCrLf & "Student Facilites:- " & Sfaci & vbCrLf & "Student Qualification:- " & Squali
        MsgBox(Smsg)

    End Sub
End Class
