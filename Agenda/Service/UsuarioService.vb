Public Class UsuarioService

    Protected agendaTarefa As New AgendaTarefaEntities

    Public Sub salvarUsuario(ByVal usuario As Usuario)

        usuario.Senha = CodificaUtil.converteParaBase64(usuario.Senha)

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

        Dim senhaBase64 = CodificaUtil.converteParaBase64(senha)

        Try
            usuarioLogado = agendaTarefa.Usuarios.Where(Function(user) user.Login = login And user.Senha = senhaBase64).First
            Return usuarioLogado

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function carregaUsuario(ByVal id As Integer) As Usuario

        Return agendaTarefa.Usuarios.Find(id)

    End Function

End Class
