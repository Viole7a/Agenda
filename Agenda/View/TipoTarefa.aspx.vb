Public Class TipoTarefa1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click

        Dim agendaTarefa = New AgendaTarefaEntities
        Dim tipoTarefa = New TipoTarefa

        tipoTarefa.Nome = txtNome.Text
        tipoTarefa.Cor = drpCor.SelectedValue
        tipoTarefa.Usuario = CInt(Session("id"))

        agendaTarefa.TipoTarefas.Add(tipoTarefa)
        agendaTarefa.SaveChanges()

        Response.Redirect("~/View/Principal")

    End Sub
End Class