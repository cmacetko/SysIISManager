Imports Microsoft.Web.Administration

Public Class SckSites

    ' Declara o Form de Origem
    Private Principal As Principal

    ' Declara o Objeto que ira armazenar a listagem de Sites
    Public ListSites As New Hashtable()

    ' Declara o Objeto que ira armazenar a listagem de Pools
    Public ListPools As New Hashtable()

    ' Declara o Objeto que ira armazenar a listagem de WorkerProcesses
    Public ListWorkerProcesses As New Hashtable()

    ' Declara o Objeto que ira armazenar os ips e suas ocorrencias
    Public ListIps As New Dictionary(Of String, Integer)

    ' Indica se os Sites e os Poolsforam carregados
    Public IsSites As Boolean = False
    Public IsPools As Boolean = False

    ' Ação ao Iniciar a Class
    Sub New(ByVal LPrincipal As Principal)

        Principal = LPrincipal

    End Sub

    '*************************************
    '* Ações
    '*************************************

    ' Mantem um Hashtable atualizado com os dados dos Sites
    Public Sub Acao_CarregarSites()

        Try

            ' Limpa o Hashtable
            ListSites.Clear()

            ' Carrega a Listagem de Sites
            For Each EleSite As Site In Principal.SckInit.ServerSck.Sites

                ' Preencha o Hashtable com os Sites
                ListSites.Add(EleSite.Id, New DadSites(EleSite.Id, EleSite.Name, EleSite.State, EleSite.ApplicationDefaults))

            Next

            ' Atualizaa data da última atualização
            Principal.LblUltimaAtualizacao.Text = Date.Now.ToString

            ' Atualiza Contador
            Principal.SckFormUtil.ContadorSites()

            ' Indica que o carregamento finalizou
            IsSites = True

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

    ' Mantem um Hashtable atualizado com os dados dos Pools
    Public Sub Acao_CarregarPools()

        Try

            ' Limpa o Hashtable
            ListPools.Clear()

            ' Carrega a Listagem de Pools
            For Each ElePool As ApplicationPool In Principal.SckInit.ServerSck.ApplicationPools

                ' Preencha o Hashtable com os Sites
                ListPools.Add(ElePool.Name, New DadPools(ElePool.Name, ElePool.QueueLength, ElePool.State))

            Next

            ' Atualizaa data da última atualização
            Principal.LblUltimaAtualizacao.Text = Date.Now.ToString

            ' Atualiza Contador
            Principal.SckFormUtil.ContadorPools()

            ' Indica que o carregamento finalizou
            IsPools = True

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

    ' Mantem um Hashtable atualizado com os dados dos Processos em Atividade
    Public Sub Acao_CarregarWorkerProcesses()

        Try

            ' Apenas executa caso os sites e pools foram carregados
            If IsSites = True And IsPools = True Then

                ' Limpa o Hashtable de WorkerProcesses
                ListWorkerProcesses.Clear()

                ' Limpa o Dictionary de IPs
                ListIps.Clear()

                ' Carrega a Listagem de Processos em Atividade
                For Each EleProcesses As WorkerProcess In Principal.SckInit.ServerSck.WorkerProcesses

                    ' Carrega a Lista de Requisitações neste Processo
                    For Each EleRequest As Request In EleProcesses.GetRequests(0)

                        ' Preencha o Hashtable com os Sites
                        ListWorkerProcesses.Add(EleRequest.RequestId, New DadWorkerProcesses(EleRequest.SiteId, EleRequest.ProcessId, EleRequest.RequestId, EleRequest.ConnectionId, EleRequest.ClientIPAddr, EleRequest.CurrentModule, EleRequest.HostName, EleRequest.LocalIPAddress, EleRequest.LocalPort, EleRequest.PipelineState, EleRequest.TimeElapsed, EleRequest.TimeInModule, EleRequest.TimeInState, EleRequest.Url, EleRequest.Verb))

                        ' Adiciona o IP no contador
                        Acao_AdicionaIP(EleRequest.ClientIPAddr.ToString)

                    Next

                Next

                ' Atualizaa data da última atualização
                Principal.LblUltimaAtualizacao.Text = Date.Now.ToString

                ' Atualiza Contador de WorkerProcesses
                Principal.SckFormUtil.ContadorWorkerProcesses()

                ' Atualiza Contador de IPs
                Principal.SckFormUtil.ContadorIPs()

            End If

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

    ' Cria um contador com a quantidade de ocorrencias de um IP
    Public Sub Acao_AdicionaIP(ByVal IP As String)


        Try

            ' Adiciona o IP no contador
            If ListIps.ContainsKey(IP) Then

                Dim TmpCount As Integer = ListIps.Item(IP) + 1

                ListIps.Item(IP) = TmpCount

            Else

                ListIps.Add(IP, 1)

            End If

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

End Class
