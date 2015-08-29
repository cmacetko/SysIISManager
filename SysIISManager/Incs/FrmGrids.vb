Imports Microsoft.Web.Administration

Public Class FrmGrids

    ' Declara o Form de Origem
    Private Principal As Principal

    ' Ação ao Iniciar a Class
    Sub New(ByVal LPrincipal As Principal)

        Principal = LPrincipal

    End Sub

    '*************************************
    '* Ações
    '*************************************

    ' Monta o Grid com o Hashtable de Sites
    Public Sub Acao_CarregarSites()

        Try

            ' Limpa o Grid
            Principal.DGridSites.Rows.Clear()

            ' While na Tabela 
            For Each EleSite As DictionaryEntry In Principal.SckSites.ListSites

                Try

                    ' Carrega os Dados do Elemento
                    Dim DadSite As DadSites = CType(EleSite.Value, DadSites)

                    ' Adiciona os Dados no Grids
                    Principal.DGridSites.Rows.Add(
                                                    DadSite.ID.ToString,
                                                    DadSite.Name.ToString,
                                                    DadSite.PoolDefault.ApplicationPoolName.ToString,
                                                    DadSite.State.ToString
                                                    )

                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try

            Next

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

    ' Monta o Grid com o Hashtable de Pools
    Public Sub Acao_CarregarPools()

        Try

            ' Limpa o Grid
            Principal.DGridPools.Rows.Clear()

            ' While na Tabela 
            For Each ElePool As DictionaryEntry In Principal.SckSites.ListPools

                Try

                    ' Carrega os Dados do Elemento
                    Dim DadPool As DadPools = CType(ElePool.Value, DadPools)

                    ' Adiciona os Dados no Grids
                    Principal.DGridPools.Rows.Add(
                                                    DadPool.Name.ToString,
                                                    DadPool.QueueLength.ToString + " processos",
                                                    DadPool.State.ToString
                                                    )


                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try

            Next

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

    ' Monta o Grid com o Hashtable de WorkerProcesses
    Public Sub Acao_CarregarWorkerProcesses()

        Try

            ' Limpa o Grid
            Principal.DGridWorkerProcesses.Rows.Clear()

            ' While na Tabela 
            For Each EleProcesses As DictionaryEntry In Principal.SckSites.ListWorkerProcesses

                Try

                    ' Carrega os Dados do Elemento
                    Dim DadProcesses As DadWorkerProcesses = CType(EleProcesses.Value, DadWorkerProcesses)

                    ' Carrega os Dados do Site
                    Dim DadSite As DadSites = Principal.SckSites.ListSites.Item(DadProcesses.SiteId)

                    ' Adiciona os Dados no Grids
                    Principal.DGridWorkerProcesses.Rows.Add(
                                                            DadProcesses.RequestId.ToString,
                                                            DadSite.ID.ToString,
                                                            DadSite.Name.ToString,
                                                            DadSite.PoolDefault.ApplicationPoolName.ToString,
                                                            DadProcesses.ProcessId.ToString,
                                                            DadProcesses.Verb.ToString,
                                                            DadProcesses.TimeElapsed.ToString,
                                                            DadProcesses.TimeInModule.ToString,
                                                            DadProcesses.TimeInState.ToString,
                                                            DadProcesses.CurrentModule.ToString,
                                                            DadProcesses.PipelineState.ToString,
                                                            DadProcesses.LocalIPAddress.ToString + ":" + DadProcesses.LocalPort.ToString,
                                                            DadProcesses.ClientIPAddr.ToString,
                                                            DadProcesses.Url.ToString
                                                            )

                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try

            Next

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

    ' Monta o Grid com a Listagem de IPs que estão com processos no momento
    Public Sub Acao_CarregarIPs()

        Try

            ' Limpa o Grid
            Principal.DGridIPs.Rows.Clear()

            ' While na Tabela 
            For Each EleIP As KeyValuePair(Of String, Integer) In Principal.SckSites.ListIps

                Try

                    ' Adiciona os Dados no Grids
                    Principal.DGridIPs.Rows.Add(
                                                EleIP.Key,
                                                EleIP.Value
                                                )

                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try

            Next

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

End Class
