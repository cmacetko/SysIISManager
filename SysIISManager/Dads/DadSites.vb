Imports Microsoft.Web.Administration

Public Class DadSites

    Public ID As Long
    Public Name As String
    Public State As ObjectState
    Public PoolDefault As ApplicationDefaults

    Sub New(ByVal ID As Long, ByVal Name As String, ByVal State As ObjectState, ByVal PoolDefault As ApplicationDefaults)

        Me.ID = ID
        Me.Name = Name
        Me.State = State
        Me.PoolDefault = PoolDefault

    End Sub

End Class
