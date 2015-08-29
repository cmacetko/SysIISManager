Module Geral

    Sub ShowMsgError(ByVal ex As Exception)

        MsgBox("Message: " & ex.Message & " / HelpLink: " & ex.HelpLink & " / Source: " & ex.Source & " / StackTrace: " & ex.StackTrace & " / TargetSite: " & ex.TargetSite.ToString())
      
    End Sub

End Module
