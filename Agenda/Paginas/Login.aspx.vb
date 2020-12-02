Public Class WebForm1
    Inherits System.Web.UI.Page
    Private usuarioService As New UsuarioService
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



    End Sub

    Protected Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Response.Redirect("~/Paginas/Cadastrar")
    End Sub

    Protected Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        MensagemUtils.limpaMensagemLabel(txtMensagem)

        If validaCampos() Then
            realizaLogin()
        End If

    End Sub

    Public Sub realizaLogin()

        Dim usuario = usuarioService.validaLogin(txtLogin.Text, txtSenha.Text)

        If usuario IsNot Nothing Then

            Session("usuario") = usuario
            Response.Redirect("~/Paginas/Principal")

        Else

            MensagemUtils.exibeMensagemLabel(txtMensagem, "Login ou senha inválidos.")

        End If

    End Sub

    Public Function validaCampos() As Boolean

        Dim retorno = True

        If Not ValidacaoUtils.validaCampoObrigatorio(txtLogin.Text, txtMensagem, "Login deve ser informado.") Then
            retorno = False
        End If

        If Not ValidacaoUtils.validaCampoObrigatorio(txtSenha.Text, txtMensagem, "Senha deve ser informada.") Then
            retorno = False
        End If

        Return retorno

    End Function

End Class