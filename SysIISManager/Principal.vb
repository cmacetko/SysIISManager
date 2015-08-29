Imports System
Imports System.Text
Imports Microsoft.Web.Administration
Imports System.Globalization

Public Class Principal

    Public SckInit As SckInit = New SckInit(Me)
    Public SckSites As SckSites = New SckSites(Me)
    Public FrmGrids As FrmGrids = New FrmGrids(Me)
    Public SckFormUtil As SckFormUtil = New SckFormUtil(Me)

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SckInit.ConectaIIS()

    End Sub

    Private Sub TimerSites_Tick(sender As Object, e As EventArgs) Handles TimerSckSites.Tick

        SckSites.Acao_CarregarSites()

    End Sub

    Private Sub TimerFrmSites_Tick(sender As Object, e As EventArgs) Handles TimerFrmSites.Tick

        FrmGrids.Acao_CarregarSites()

    End Sub

    Private Sub TimerSckPools_Tick(sender As Object, e As EventArgs) Handles TimerSckPools.Tick

        SckSites.Acao_CarregarPools()

    End Sub

    Private Sub TimerFrmPools_Tick(sender As Object, e As EventArgs) Handles TimerFrmPools.Tick

        FrmGrids.Acao_CarregarPools()

    End Sub

    Private Sub TimerSckWorkerProcesses_Tick(sender As Object, e As EventArgs) Handles TimerSckWorkerProcesses.Tick

        SckSites.Acao_CarregarWorkerProcesses()

    End Sub

    Private Sub TimerFrmWorkerProcesses_Tick(sender As Object, e As EventArgs) Handles TimerFrmWorkerProcesses.Tick

        FrmGrids.Acao_CarregarWorkerProcesses()
        FrmGrids.Acao_CarregarIPs()

    End Sub

    
End Class
