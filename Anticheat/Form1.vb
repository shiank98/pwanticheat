Imports System.IO
Imports System
Imports System.Diagnostics
Imports System.ComponentModel
Public Class PWReforged

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If System.Diagnostics.Process.
             GetProcessesByName("AIRobot").Length > 0 Then
            For Each Process In System.Diagnostics.Process.GetProcessesByName("elementclient")
                Process.Kill()
            Next
        End If
        If System.Diagnostics.Process.
     GetProcessesByName("K25").Length > 0 Then
            For Each Process In System.Diagnostics.Process.GetProcessesByName("elementclient")
                Process.Kill()
            Next
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim p() As Process
        p = Process.GetProcessesByName("elementclient")
        If p.Count > 0 Then
            ' Process is running
        Else
            ' Process is not running
            Application.Exit()
        End If
    End Sub

End Class