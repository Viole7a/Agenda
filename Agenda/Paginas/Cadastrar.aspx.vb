Public Class WebForm2
    Inherits System.Web.UI.Page

    Private usuarioService As New UsuarioService

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Response.Redirect("~/Paginas/Login")
    End Sub

    Protected Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click

        MensagemUtils.limpaMensagemLabel(txtMensagem)

        If validaUsuario() Then
            Dim usuario = New Usuario With {.Login = txtLogin.Text, .Senha = txtSenha.Text, .Nome = txtNome.Text}
            usuarioService.salvarUsuario(usuario)
            Response.Redirect("~/Paginas/Login")
        End If

    End Sub

    Public Function validaUsuario() As Boolean

        Dim retorno = True

        If Not ValidacaoUtils.validaCampoObrigatorio(txtLogin.Text, txtMensagem, "Login deve ser informado.") Then
            retorno = False
        ElseIf Not ValidacaoUtils.validaUsuarioCadastro(txtLogin.Text, txtMensagem) Then
            retorno = False
        End If

        If Not ValidacaoUtils.validaCampoObrigatorio(txtSenha.Text, txtMensagem, "Senha deve ser informada.") Then
            retorno = False
        End If

        If Not ValidacaoUtils.validaCampoObrigatorio(txtNome.Text, txtMensagem, "Nome deve ser informado.") Then
            retorno = False
        End If

        Return retorno

    End Function
End Class