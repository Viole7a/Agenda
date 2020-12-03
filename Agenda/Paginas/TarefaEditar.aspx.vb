Public Class TarefaEditar
    Inherits System.Web.UI.Page

    Private tarefaService As New TarefaService
    Private usuario As Usuario
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        usuario = DirectCast(Session("usuario"), Usuario)

        If usuario IsNot Nothing Then

            If Not Page.IsPostBack Then

                drpTipoTarefa.DataSource = tarefaService.carregaTipoTarefa(usuario.Id)
                drpTipoTarefa.DataBind()

                drpPrioridade.DataSource = tarefaService.carregaPrioridade()
                drpPrioridade.DataBind()

                drpStatus.DataSource = tarefaService.carregaStatus()
                drpStatus.DataBind()

                If Request("id") <> "0" Then
                    btnIncluirTarefa.Visible = False

                    carregaCampos(CInt(Request("Id")))

                Else
                    btnSalvarTarefa.Visible = False
                    btnConfirmaExclusao.Visible = False
                End If

            End If

        Else
            Response.Redirect("~/Paginas/Login")
        End If

    End Sub

    Protected Sub btnIncluirTarefa_Click(sender As Object, e As EventArgs) Handles btnIncluirTarefa.Click

        MensagemUtils.limpaMensagemLabel(txtMensagem)

        If validarTarefa() Then

            Dim tarefa = New Tarefa With {.Titulo = txtTitulo.Text, .TipoTarefa = drpTipoTarefa.SelectedValue,
                                         .Descricao = txtDescricao.Value, .Status = drpStatus.SelectedValue,
                                         .Prioridade = drpPrioridade.SelectedValue, .DataInclusao = Date.Now.Date,
                                         .Usuario = usuario.Id}

            If txtPrazo.Text <> "" Then
                tarefa.Prazo = CDate(txtPrazo.Text)
            End If

            tarefaService.salvarTarefa(tarefa)
            Response.Redirect("~/Paginas/TarefaEditar?Id=" & tarefa.Id)

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

        If txtPrazo.Text <> "" Then
            If Not ValidacaoUtils.validaCampoTipo(txtPrazo.Text, txtMensagem, "Data de prazo inválida.", ValidacaoUtils.tipoCampo.data) Then
                retorno = False
            End If
        End If

        Return retorno

    End Function

    Public Sub carregaCampos(ByVal idTarefa As String)

        Dim tarefa = tarefaService.carregarTarefa(idTarefa)

        txtTitulo.Text = tarefa.Titulo
        drpTipoTarefa.SelectedValue = tarefa.TipoTarefa
        txtDescricao.Value = tarefa.Descricao

        If tarefa.Prazo IsNot Nothing Then
            txtPrazo.Text = tarefa.Prazo.Value.ToShortDateString
        End If

        drpPrioridade.SelectedValue = tarefa.Prioridade
        drpStatus.SelectedValue = tarefa.Status

    End Sub

    Protected Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Response.Redirect("~/Paginas/Principal")
    End Sub

    Protected Sub btnSalvarTarefa_Click(sender As Object, e As EventArgs) Handles btnSalvarTarefa.Click

        txtMensagem.Text = ""
        txtMensagem.Visible = False

        If validarTarefa() Then

            Dim tarefa = tarefaService.carregarTarefa(Request("Id"))

            With tarefa
                .Titulo = txtTitulo.Text
                .TipoTarefa = drpTipoTarefa.SelectedValue
                .Descricao = txtDescricao.Value
                .Status = drpStatus.SelectedValue
                .Prioridade = drpPrioridade.SelectedValue
            End With

            If txtPrazo.Text <> "" Then
                tarefa.Prazo = CDate(txtPrazo.Text)
            End If

            tarefa.Id = CInt(Request("Id"))

            tarefaService.updateTarefa(tarefa)
            Response.Redirect("~/Paginas/TarefaEditar?Id=" & tarefa.Id)

        End If

    End Sub

    Protected Sub btnExcluirTarefa_Click(sender As Object, e As EventArgs) Handles btnExcluirTarefa.Click

        tarefaService.excluirTarefa(CInt(Request("Id")))
        Response.Redirect("~/Paginas/Principal")

    End Sub
End Class