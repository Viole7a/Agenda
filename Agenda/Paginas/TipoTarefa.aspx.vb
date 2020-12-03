Public Class TipoTarefa1
    Inherits System.Web.UI.Page

    Private usuario As Usuario
    Private tipoTarefaService As New TipoTarefaService

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        usuario = DirectCast(Session("usuario"), Usuario)

        If usuario Is Nothing Then
            Response.Redirect("~/Paginas/Login")
        End If

        If Not Page.IsPostBack Then
            carregaGridTipoTarefa()
        End If

    End Sub

    Protected Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click

        MensagemUtils.limpaMensagemLabel(txtMensagem)

        If validarTipoTarefa() Then

            Dim tipoTarefa = New TipoTarefa With {.Nome = txtNome.Text, .Cor = inputColor.Value, .Usuario = usuario.Id}
            tipoTarefaService.salvarTipoTarefa(tipoTarefa)
            carregaGridTipoTarefa()

        End If


    End Sub

    Public Function validarTipoTarefa() As Boolean

        Dim retorno = True

        If Not ValidacaoUtils.validaCampoObrigatorio(txtNome.Text, txtMensagem, "Nome do tipo de tarefa deve ser informado.") Then
            retorno = False
        End If

        Return retorno

    End Function

    Protected Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Response.Redirect("~/Paginas/Principal")
    End Sub

    Public Sub carregaGridTipoTarefa()

        gridTipoTarefa.DataSource = tipoTarefaService.listarTiposTarefa(usuario.Id)
        gridTipoTarefa.DataBind()

    End Sub

    Protected Sub gridTipoTarefa_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gridTipoTarefa.RowCreated

        If e.Row.RowType <> DataControlRowType.Pager Then
            e.Row.Cells(0).Visible = False
            e.Row.Cells(1).Visible = False
        End If

    End Sub

    Protected Sub gridTipoTarefa_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gridTipoTarefa.RowDataBound

        If Not (e.Row.RowType = ListItemType.Header Or e.Row.Cells(1).Text.Trim = "") Then
            e.Row.Cells(3).BackColor = CorUtils.ConvertToRbg(e.Row.Cells(1).Text)
        End If

    End Sub

    Protected Sub gridTipoTarefa_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gridTipoTarefa.RowCommand

        MensagemUtils.limpaMensagemLabel(txtMensagem)
        Dim row = gridTipoTarefa.Rows(Convert.ToInt32(e.CommandArgument))

        If tipoTarefaService.existeTarefaAssociada(CInt(row.Cells(0).Text)) Then
            MensagemUtils.exibeMensagemLabel(txtMensagem, "Exclusão não permitida: existe atividade associada!")
        Else
            tipoTarefaService.excluirTipoTarefa(CInt(row.Cells(0).Text))
            carregaGridTipoTarefa()
        End If

    End Sub
End Class