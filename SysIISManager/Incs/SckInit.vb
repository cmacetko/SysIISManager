Imports Microsoft.Web.Administration

Public Class SckInit

    ' Declara o Form de Origem
    Private Principal As Principal

    ' IP do Servidor
    Private ServerIP As String = "localhost"

    ' Objeto do Servidor
    Public ServerSck As New ServerManager()

    ' Ação ao Iniciar a Class
    Sub New(ByVal LPrincipal As Principal)

        Principal = LPrincipal

    End Sub

    ' Conecta ao IIS
    Public Sub ConectaIIS()

        Try

            ' Abre a conexão com o IIS
            Dim ServerSck = ServerManager.OpenRemote(ServerIP)

            ' Inicia a busca de sites
            AcTmReal_Ativar()

        Catch ex As Exception

            ShowMsgError(ex)

        End Try

    End Sub

    ' Acoes em Tempo - Ativar
    Public Sub AcTmReal_Ativar()

        Principal.TimerSckSites.Enabled = True
        Principal.TimerFrmSites.Enabled = True

        Principal.TimerSckPools.Enabled = True
        Principal.TimerFrmPools.Enabled = True

        Principal.TimerSckWorkerProcesses.Enabled = True
        Principal.TimerFrmWorkerProcesses.Enabled = True

    End Sub

    ' Acoes em Tempo - Desativar
    Public Sub AcTmReal_Desativar()

        Principal.TimerSckSites.Enabled = False
        Principal.TimerFrmSites.Enabled = False

        Principal.TimerSckPools.Enabled = False
        Principal.TimerFrmPools.Enabled = False

        Principal.TimerSckWorkerProcesses.Enabled = False
        Principal.TimerFrmWorkerProcesses.Enabled = False

    End Sub

End Class
