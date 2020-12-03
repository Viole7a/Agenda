Public Class TipoTarefaService

    Protected agendaTarefa As New AgendaTarefaEntities
    Public Sub salvarTipoTarefa(ByVal tipoTarefa As TipoTarefa)

        agendaTarefa.TipoTarefas.Add(tipoTarefa)
        agendaTarefa.SaveChanges()

    End Sub

    Public Function listarTiposTarefa(ByVal usuarioId As Integer) As List(Of TipoTarefa)

        Return agendaTarefa.TipoTarefas.Where(Function(tipo) tipo.Usuario1.Id = usuarioId).ToList

    End Function

    Public Sub excluirTipoTarefa(ByVal id As Integer)

        Dim tipoTarefa = agendaTarefa.TipoTarefas.Find(id)

        agendaTarefa.TipoTarefas.Remove(tipoTarefa)

        agendaTarefa.SaveChanges()

    End Sub

    Public Function existeTarefaAssociada(ByVal idTipoTareda As Integer) As Boolean

        Dim retorno = False

        If agendaTarefa.Tarefas.Where(Function(atv) atv.TipoTarefa1.Id = idTipoTareda).ToList.Count > 0 Then
            retorno = True
        End If

        Return retorno

    End Function

End Class
