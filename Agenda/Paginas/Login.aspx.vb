Public Class WebForm1
    Inherits System.Web.UI.Page
    Private usuarioService As New UsuarioService
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



    End Sub

    Protected Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Response.Redirect("~/Paginas/Cadastrar")
    End Sub

    Protected Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        Dim usuario = usuarioService.validaLogin(txtLogin.Text, txtSenha.Text)

        If usuario IsNot Nothing Then

            Session("usuario") = usuario
            Response.Redirect("~/Paginas/Principal")

        End If

    End Sub
End Class