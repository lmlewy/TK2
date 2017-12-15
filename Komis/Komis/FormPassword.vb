Public Class FormPassword

    Private JestOK As Boolean
    Private Pass As String


    Private Sub FormPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        JestOK = False
        Pass = vbNullString
        TextBoxPass.Focus()
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Pass = TextBoxPass.Text
        JestOK = True
        Close()

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Pass = vbNullString
        JestOK = False
        Close()
    End Sub

    Public Function OK()
        Return JestOK
    End Function

    Public Function Password()
        Return Pass
    End Function


End Class