Imports Microsoft.Web.Administration

Public Class DadPools

    Public Name As String
    Public QueueLength As Long
    Public State As ObjectState

    Sub New(ByVal Name As String, ByVal QueueLength As Long, ByVal State As ObjectState)

        Me.Name = Name
        Me.QueueLength = QueueLength
        Me.State = State

    End Sub

End Class
