Public Class Tarefas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim agendaTarefa = New AgendaTarefaEntities


        listAtividades.DataSource = agendaTarefa.Tarefas.Where(Function(o) o.Id = Session("Id")).ToList
        listAtividades.DataBind()

    End Sub

End Class