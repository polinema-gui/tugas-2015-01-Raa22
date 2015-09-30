Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MyBase.BackColor = Color.White Then
            MyBase.BackColor = Color.Black
        Else : MyBase.BackColor = Color.White

        End If

    End Sub
End Class
