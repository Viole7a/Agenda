Public Class WebForm3
    Inherits System.Web.UI.Page

    Private tarefaService As New TarefaService

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim usuario = DirectCast(Session("usuario"), Usuario)

        If Not Page.IsPostBack Then

            txtTitulo.Text = "Bem-vindo " & usuario.Nome & "!"
            listaTarefas.DataSource = tarefaService.listarTarefas(usuario.Id)
            listaTarefas.DataBind()

        End If

    End Sub

    Protected Sub btnIncluirTarefa_Click(sender As Object, e As EventArgs) Handles btnIncluirTarefa.Click
        Response.Redirect("~/View/TarefaEditar?Id=0")
    End Sub

    Protected Sub btnTipoTarefa_Click(sender As Object, e As EventArgs) Handles btnTipoTarefa.Click
        Response.Redirect("~/View/TipoTarefa")
    End Sub

    Protected Sub testlistaTarefas_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles listaTarefas.RowCommand

        Dim row = listaTarefas.Rows(Convert.ToInt32(e.CommandArgument))
        Response.Redirect("~/View/TarefaEditar?Id=" & row.Cells(0).Text)

    End Sub
End Class