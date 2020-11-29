Public Class ValidacaoUtils

    Public Enum tipoCampo As Byte
        data
        int
    End Enum

    Public Shared Function validaCampoObrigatorio(ByVal texto As String, ByVal label As Label, ByVal mensagem As String) As Boolean

        Dim retorno = False

        If texto <> "" Then
            retorno = True
        Else
            MensagemUtils.exibeMensagemLabel(label, mensagem)
        End If

        Return retorno

    End Function

    Public Shared Function validaUsuarioCadastro(ByVal login As String, ByVal label As Label) As Boolean

        Dim retorno = False

        If usuarioService.existeLoginCadastrado(login) Then
            MensagemUtils.exibeMensagemLabel(label, "Login já cadastrado.")
        Else
            retorno = True
        End If

        Return retorno

    End Function

    Public Shared Function validaCampoTipo(ByVal texto As String, ByVal label As Label, ByVal mensagem As String, ByVal tipo As Byte) As Boolean

        Dim retorno = False

        Select Case (tipo)
            Case tipoCampo.data
                Dim data As Date
                If Date.TryParse(texto, data) Then
                    retorno = True
                Else
                    MensagemUtils.exibeMensagemLabel(label, mensagem)
                End If
            Case tipoCampo.int
                Dim inteiro As Integer
                If Integer.TryParse(texto, inteiro) Then
                    retorno = True
                Else
                    MensagemUtils.exibeMensagemLabel(label, mensagem)
                End If
        End Select


        Return retorno

    End Function


End Class
