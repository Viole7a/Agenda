Imports Agenda.AgendaTarefaEntities
Public Class SiteMaster
    Inherits MasterPage
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Session.Remove("Usuario")
        Response.Redirect("~/Paginas/Login")
    End Sub
End Class