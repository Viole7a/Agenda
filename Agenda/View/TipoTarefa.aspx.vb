Public Class TipoTarefa1
    Inherits System.Web.UI.Page

    Private usuario As Usuario

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        usuario = DirectCast(Session("usuario"), Usuario)

    End Sub

    Protected Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click

        Dim agendaTarefa = New AgendaTarefaEntities
        Dim tipoTarefa = New TipoTarefa

        tipoTarefa.Nome = txtNome.Text
        tipoTarefa.Cor = drpCor.SelectedValue
        tipoTarefa.Usuario = usuario.Id

        agendaTarefa.TipoTarefas.Add(tipoTarefa)
        agendaTarefa.SaveChanges()

        Response.Redirect("~/View/Principal")

    End Sub
End Class