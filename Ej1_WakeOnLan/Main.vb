Public Class Main
    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.clear()
            ElseIf TypeOf c Is ComboBox Then
                c.selectedIndex = 0
            End If
        Next


        For Each c In Me.Controls
            Try
                CType(c, TextBox).Clear()
            Catch ex As System.InvalidCastException
                Try
                    CType(c, ComboBox).SelectedIndex = 0
                Catch ex2 As System.InvalidCastException
                End Try
            End Try
        Next
    End Sub
End Class