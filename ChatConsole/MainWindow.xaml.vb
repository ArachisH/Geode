Public Class MainWindow
    Public ExtensionChild As Extension

    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        Try
            ExtensionChild = New Extension()
        Catch
            ShowCriticalError()
        End Try
    End Sub

    Private Sub ShowCriticalError()
        Environment.Exit(0)
    End Sub

End Class