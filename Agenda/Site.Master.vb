Imports Agenda.AgendaTarefaEntities
Public Class SiteMaster
    Inherits MasterPage
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Dim teste = New AgendaTarefaEntities

        Dim teste2 = teste.Usuarios.Where(Function(o) o.Id = 1).ToList



        Dim teste3 = 1

    End Sub
End Class