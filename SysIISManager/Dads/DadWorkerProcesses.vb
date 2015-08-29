Imports Microsoft.Web.Administration

Public Class DadWorkerProcesses

    Public SiteId As Long
    Public ProcessId As Long
    Public RequestId As String
    Public ConnectionId As String

    Public ClientIPAddr As String
    Public CurrentModule As String
    Public HostName As String
    Public LocalIPAddress As String
    Public LocalPort As String
    Public PipelineState As PipelineState
    Public TimeElapsed As Long
    Public TimeInModule As Long
    Public TimeInState As Long
    Public Url As String
    Public Verb As String

    'ClientIPAddr: ::1
    'ConnectionId: f8000003600009a8 
    'CurrentModule: FastCgiModule
    'HostName: localhost
    'LocalIPAddress: ::1
    'LocalPort: 80
    'PipelineState: ExecuteRequestHandler
    'ProcessId: 18160
    'RequestId: f8000003800009ab
    'SiteId: 1
    'TimeElapsed: 3485
    'TimeInModule: 3485
    'TimeInState: 3485
    'Url: /Teste.php
    'Verb: GET

    Sub New(ByVal SiteId As Long, ByVal ProcessId As Long, ByVal RequestId As String, ByVal ConnectionId As String, ByVal ClientIPAddr As String, ByVal CurrentModule As String, ByVal HostName As String, ByVal LocalIPAddress As String, ByVal LocalPort As String, ByVal PipelineState As PipelineState, ByVal TimeElapsed As String, ByVal TimeInModule As String, ByVal TimeInState As String, ByVal Url As String, ByVal Verb As String)

        Me.SiteId = SiteId
        Me.ProcessId = ProcessId
        Me.RequestId = RequestId
        Me.ConnectionId = ConnectionId

        Me.ClientIPAddr = ClientIPAddr
        Me.CurrentModule = CurrentModule
        Me.HostName = HostName
        Me.LocalIPAddress = LocalIPAddress
        Me.LocalPort = LocalPort
        Me.PipelineState = PipelineState
        Me.TimeElapsed = TimeElapsed
        Me.TimeInModule = TimeInModule
        Me.TimeInState = TimeInState
        Me.Url = Url
        Me.Verb = Verb

    End Sub

End Class
