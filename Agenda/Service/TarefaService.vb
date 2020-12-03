Public Class TarefaService

    Protected agendaTarefa As New AgendaTarefaEntities
    Public Function carregaTipoTarefa(ByVal id As Integer) As List(Of TipoTarefa)

        Return agendaTarefa.TipoTarefas.Where(Function(tipo) tipo.Usuario = id).ToList

    End Function

    Public Function carregaStatus() As List(Of Status)

        Return agendaTarefa.Status.ToList

    End Function

    Public Function carregaPrioridade() As List(Of Prioridade)

        Return agendaTarefa.Prioridades.ToList

    End Function

    Public Function validaTarefa(ByVal tarefa As Tarefa) As Boolean

        Dim retorno = False

        If tarefa.Titulo.Trim = "" Then
            Return False
        End If

        If Not tarefa.TipoTarefa > 0 Then

        End If

        If Not tarefa.Status > 0 Then
            retorno = True
        End If

        Return retorno

    End Function

    Public Sub salvarTarefa(ByVal tarefa As Tarefa)


        agendaTarefa.Tarefas.Add(tarefa)
        agendaTarefa.SaveChanges()

    End Sub

    Public Sub updateTarefa(ByVal tarefa As Tarefa)

        Dim tarefaAnterior = agendaTarefa.Tarefas.Find(tarefa.Id)

        agendaTarefa.Entry(tarefaAnterior).CurrentValues.SetValues(tarefa)
        agendaTarefa.SaveChanges()

    End Sub

    Public Function listarTarefasAFazer(ByVal usuarioId As Integer) As List(Of Tarefa)

        Return agendaTarefa.Tarefas.Where(Function(atv) atv.Usuario1.Id = usuarioId And (atv.Status = 1 Or atv.Status = 2 Or atv.Status = 3)).OrderByDescending(Function(atv) atv.Prioridade).ToList

    End Function

    Public Function listarTarefasFinalizadas(ByVal usuarioId As Integer) As List(Of Tarefa)

        Return agendaTarefa.Tarefas.Where(Function(atv) atv.Usuario1.Id = usuarioId And (atv.Status = 4 Or atv.Status = 5)).ToList

    End Function

    Public Function carregarTarefa(ByVal id As Integer) As Tarefa

        Return agendaTarefa.Tarefas.Find(id)

    End Function

    Public Sub excluirTarefa(ByVal id As Integer)

        Dim tarefa = agendaTarefa.Tarefas.Find(id)

        agendaTarefa.Tarefas.Remove(tarefa)

        agendaTarefa.SaveChanges()

    End Sub

End Class
