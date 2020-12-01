Public Class WebForm3
    Inherits System.Web.UI.Page

    Private tarefaService As New TarefaService

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim usuario = DirectCast(Session("usuario"), Usuario)

        If usuario IsNot Nothing Then

            If Not Page.IsPostBack Then

                txtTitulo.Text = "Bem-vindo " & usuario.Nome & "!"
                listaTarefas.DataSource = tarefaService.listarTarefas(usuario.Id)
                listaTarefas.DataBind()

            End If

        Else
            Response.Redirect("~/Paginas/Login")
        End If

    End Sub

    Protected Sub btnIncluirTarefa_Click(sender As Object, e As EventArgs) Handles btnIncluirTarefa.Click
        Response.Redirect("~/Paginas/TarefaEditar?Id=0")
    End Sub

    Protected Sub btnTipoTarefa_Click(sender As Object, e As EventArgs) Handles btnTipoTarefa.Click
        Response.Redirect("~/Paginas/TipoTarefa")
    End Sub

    Protected Sub listaTarefas_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles listaTarefas.RowCommand

        Dim row = listaTarefas.Rows(Convert.ToInt32(e.CommandArgument))
        Response.Redirect("~/Paginas/TarefaEditar?Id=" & row.Cells(0).Text)

    End Sub

    Protected Sub listaTarefas_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles listaTarefas.RowCreated

        If e.Row.RowType <> DataControlRowType.Pager Then
            e.Row.Cells(0).Visible = False
        End If

    End Sub

    Protected Sub listaTarefas_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles listaTarefas.RowDataBound

        For coluna = 0 To e.Row.Cells.Count - 1
            e.Row.Cells(coluna).BackColor = ConvertToRbg("#003399")
        Next

    End Sub

    Public Function ConvertToRbg(ByVal HexColor As String) As Drawing.Color
        Dim Red As String
        Dim Green As String
        Dim Blue As String
        HexColor = Replace(HexColor, "#", "")
        Red = Val("&H" & Mid(HexColor, 1, 2))
        Green = Val("&H" & Mid(HexColor, 3, 2))
        Blue = Val("&H" & Mid(HexColor, 5, 2))
        Return Drawing.Color.FromArgb(Red, Green, Blue)
    End Function

End Class