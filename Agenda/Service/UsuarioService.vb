Public Class UsuarioService

    Public Sub salvarUsuario(ByVal usuario As Usuario)

        Dim agendaTarefa = New AgendaTarefaEntities

        agendaTarefa.Usuarios.Add(usuario)
        agendaTarefa.SaveChanges()

    End Sub
    Public Shared Function existeLoginCadastrado(ByVal login As String) As Boolean

        Dim retorno = False
        Dim agendaTarefa = New AgendaTarefaEntities

        If agendaTarefa.Usuarios.Where(Function(user) user.Login = login).ToList.Count > 0 Then
            retorno = True
        End If

        Return retorno

    End Function

    Public Function validaLogin(ByVal login As String, ByVal senha As String) As Usuario

        Dim usuarioLogado = New Usuario
        Dim agendaTarefa = New AgendaTarefaEntities

        Try
            usuarioLogado = agendaTarefa.Usuarios.Where(Function(user) user.Login = login And user.Senha = senha).First
            Return usuarioLogado

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

End Class
