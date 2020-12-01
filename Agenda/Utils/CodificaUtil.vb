Public Class CodificaUtil

    Public Shared Function converteParaBase64(ByVal texto As String) As String

        Return Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(texto))

    End Function


End Class
