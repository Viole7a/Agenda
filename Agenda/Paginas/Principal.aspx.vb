Public Class WebForm3
    Inherits System.Web.UI.Page

    Private tarefaService As New TarefaService
    Private usuario As Usuario

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        usuario = DirectCast(Session("usuario"), Usuario)

        If usuario IsNot Nothing Then

            If Not Page.IsPostBack Then

                carregaPagina()

            End If

        Else
            Response.Redirect("~/Paginas/Login")
        End If

    End Sub

    Public Sub carregaPagina()

        txtTitulo.Text = "Bem-vindo(a) " & usuario.Nome & "!"
        gridTarefasAFazer.DataSource = tarefaService.listarTarefasAFazer(usuario.Id)
        gridTarefasAFazer.DataBind()

        If gridTarefasAFazer.Rows.Count = 0 Then
            divTarefasAFazer.Visible = False
        End If

        gridTarefasFinalizadas.DataSource = tarefaService.listarTarefasFinalizadas(Usuario.Id)
        gridTarefasFinalizadas.DataBind()

        If gridTarefasFinalizadas.Rows.Count = 0 Then
            divTarefasFinalizadas.Visible = False
        End If

    End Sub

    Protected Sub btnIncluirTarefa_Click(sender As Object, e As EventArgs) Handles btnIncluirTarefa.Click
        Response.Redirect("~/Paginas/TarefaEditar?Id=0")
    End Sub

    Protected Sub btnTipoTarefa_Click(sender As Object, e As EventArgs) Handles btnTipoTarefa.Click
        Response.Redirect("~/Paginas/TipoTarefa")
    End Sub

    Protected Sub gridTarefasAFazer_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gridTarefasAFazer.RowCommand

        Dim row = gridTarefasAFazer.Rows(Convert.ToInt32(e.CommandArgument))
        Response.Redirect("~/Paginas/TarefaEditar?Id=" & row.Cells(0).Text)

    End Sub

    Protected Sub gridTarefasFinalizadas_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gridTarefasFinalizadas.RowCommand

        Dim row = gridTarefasFinalizadas.Rows(Convert.ToInt32(e.CommandArgument))
        Response.Redirect("~/Paginas/TarefaEditar?Id=" & row.Cells(0).Text)

    End Sub

    Protected Sub gridTarefasAFazer_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gridTarefasAFazer.RowCreated

        If e.Row.RowType <> DataControlRowType.Pager Then
            e.Row.Cells(0).Visible = False
            e.Row.Cells(1).Visible = False
        End If

    End Sub

    Protected Sub gridTarefasFinalizadas_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gridTarefasFinalizadas.RowCreated

        If e.Row.RowType <> DataControlRowType.Pager Then
            e.Row.Cells(0).Visible = False
            e.Row.Cells(1).Visible = False
        End If

    End Sub

    Protected Sub gridTarefasAFazer_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gridTarefasAFazer.RowDataBound

        If e.Row.RowType <> ListItemType.Header Then
            For coluna = 0 To e.Row.Cells.Count - 1
                e.Row.Cells(coluna).BackColor = CorUtils.ConvertToRbg(e.Row.Cells(1).Text)
            Next
        End If

    End Sub

    Protected Sub gridTarefasFinalizadas_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gridTarefasFinalizadas.RowDataBound

        If e.Row.RowType <> ListItemType.Header Then
            For coluna = 0 To e.Row.Cells.Count - 1
                e.Row.Cells(coluna).BackColor = CorUtils.ConvertToRbg(e.Row.Cells(1).Text)
            Next
        End If

    End Sub
End Class