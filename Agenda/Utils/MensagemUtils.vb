Public Class MensagemUtils

    Public Shared Sub exibeMensagemLabel(ByVal label As Label, ByVal mensagem As String)

        If label.Text <> "" Then
            label.Text &= "<br/>"
        End If
        label.Text &= mensagem
        label.Visible = True

    End Sub


End Class
