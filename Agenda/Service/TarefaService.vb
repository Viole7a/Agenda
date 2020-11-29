Public Class TarefaService

    Public Function carregaTipoTarefa(ByVal id As Integer) As List(Of TipoTarefa)

        Dim agendaTarefa = New AgendaTarefaEntities

        Return agendaTarefa.TipoTarefas.Where(Function(tipo) tipo.Usuario = id).ToList

    End Function

    Public Function carregaStatus() As List(Of Status)

        Dim agendaTarefa = New AgendaTarefaEntities

        Return agendaTarefa.Status.ToList

    End Function

    Public Function carregaPrioridade() As List(Of Prioridade)

        Dim agendaTarefa = New AgendaTarefaEntities

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

        Dim agendaTarefa = New AgendaTarefaEntities

        agendaTarefa.Tarefas.Add(tarefa)
        agendaTarefa.SaveChanges()

    End Sub

    Public Function listarTarefas(ByVal id As Integer) As List(Of Tarefa)

        Dim agendaTarefa = New AgendaTarefaEntities

        Return agendaTarefa.Tarefas.Where(Function(atv) atv.Usuario1.Id = id).ToList

    End Function

End Class
