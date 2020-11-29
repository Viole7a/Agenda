Public Class TarefaEditar
    Inherits System.Web.UI.Page

    Private tarefaService As New TarefaService
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then

            Dim idUsuario = CInt(Session("Id"))

            drpTipoTarefa.DataSource = tarefaService.carregaTipoTarefa(idUsuario)
            drpTipoTarefa.DataBind()

            drpPrioridade.DataSource = tarefaService.carregaPrioridade()
            drpPrioridade.DataBind()

            drpStatus.DataSource = tarefaService.carregaStatus()
            drpStatus.DataBind()

        End If

    End Sub

    Protected Sub btnIncluirTarefa_Click(sender As Object, e As EventArgs) Handles btnIncluirTarefa.Click

        If validarTarefa() Then

            Dim tarefa = New Tarefa With {.Titulo = txtTitulo.Text, .TipoTarefa = drpTipoTarefa.SelectedValue,
                                         .Descricao = txtDescricao.Value, .Prazo = CDate(txtPrazo.Text),
                                         .Status = drpStatus.SelectedValue, .Prioridade = drpPrioridade.SelectedValue,
                                         .DataInclusao = Date.Now, .Usuario = CInt(Session("Id"))}

            tarefaService.salvarTarefa(tarefa)

        End If


    End Sub

    Public Function validarTarefa() As Boolean

        Dim retorno = True

        If Not ValidacaoUtils.validaCampoObrigatorio(txtTitulo.Text, txtMensagem, "Título deve ser informado.") Then
            retorno = False
        End If

        If Not ValidacaoUtils.validaCampoObrigatorio(drpTipoTarefa.SelectedValue, txtMensagem, "Tipo de tarefa deve ser informado.") Then
            retorno = False
        End If

        If Not ValidacaoUtils.validaCampoObrigatorio(drpPrioridade.SelectedValue, txtMensagem, "Prioridade deve ser informada.") Then
            retorno = False
        End If

        If Not ValidacaoUtils.validaCampoObrigatorio(drpStatus.SelectedValue, txtMensagem, "Status deve ser infromado.") Then
            retorno = False
        End If

        If Not ValidacaoUtils.validaCampoTipo(txtPrazo.Text, txtMensagem, "Data de prazo inválida.", ValidacaoUtils.tipoCampo.data) Then
            retorno = False
        End If

        Return retorno

    End Function

    Protected Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Response.Redirect("~/View/Principal")
    End Sub
End Class