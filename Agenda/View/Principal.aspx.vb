Public Class WebForm3
    Inherits System.Web.UI.Page

    Private tarefaService As New TarefaService

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim id = CInt(Session("id"))

        If Not Page.IsPostBack Then

            txtTitulo.Text = "Bem-vindo " & Session("nomeUsuario") & "!"
            listaTarefas.DataSource = tarefaService.listarTarefas(id)
            listaTarefas.DataBind()

        End If

    End Sub

    Protected Sub btnIncluirTarefa_Click(sender As Object, e As EventArgs) Handles btnIncluirTarefa.Click
        Response.Redirect("~/View/TarefaIncluir")
    End Sub

    Protected Sub btnTipoTarefa_Click(sender As Object, e As EventArgs) Handles btnTipoTarefa.Click
        Response.Redirect("~/View/TipoTarefa")
    End Sub
End Class