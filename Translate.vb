Public Class Form1
    Dim Mode As String = "English to Nerglish"

    Private Sub EnglishToNerglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToNerglishToolStripMenuItem.Click
        Mode = "English to Nerglish"
        ToolStripLabel1.Text = "Mode: " + Mode
    End Sub

    Private Sub NerglishToEnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NerglishToEnglishToolStripMenuItem.Click
        Mode = "Nerglish to English"
        ToolStripLabel1.Text = "Mode: " + Mode
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click
        Dim Text As String = InputBox("What text to translate?", _
                                      "Translatable Text", _
                                      "Type text here please.")
        If (Mode = "English to Nerglish") Then
            Dim A1 As String = Replace(Text, "a", "agh")
            Dim B1 As String = Replace(A1, "b", "ghu")
            Dim C1 As String = Replace(B1, "c", "'k")
            Dim D1 As String = Replace(C1, "d", "gle")
            Dim E1 As String = Replace(D1, "e", "ehg")
            Dim F1 As String = Replace(E1, "f", "elg")
            Dim G1 As String = Replace(F1, "g", "g")
            Dim H1 As String = Replace(G1, "h", "urg")
            Dim I1 As String = Replace(H1, "i", "eug")
            Dim J1 As String = Replace(I1, "j", "ga")
            Dim K1 As String = Replace(J1, "k", "kk")
            Dim L1 As String = Replace(K1, "l", "l")
            Dim M1 As String = Replace(L1, "m", "leg")
            Dim N1 As String = Replace(M1, "n", "leh")
            Dim P1 As String = Replace(N1, "p", "gg")
            Dim Q1 As String = Replace(P1, "q", "gee")
            Dim O1 As String = Replace(Q1, "o", "ouh")
            Dim R1 As String = Replace(O1, "r", "arlg")
            Dim S1 As String = Replace(R1, "s", "els")
            Dim T1 As String = Replace(S1, "t", "t")
            Dim U1 As String = Replace(T1, "u", "gew")
            Dim V1 As String = Replace(U1, "v", "geh")
            Dim W1 As String = Replace(V1, "w", "uhh")
            Dim X1 As String = Replace(W1, "x", "egs")
            Dim Y1 As String = Replace(X1, "y", "leg")
            Dim Z1 As String = Replace(Y1, "z", "z")

            

            MessageBox.Show("Translation: " + Z1, _
                              "Translated!", _
                              MessageBoxButtons.OK, _
                              MessageBoxIcon.Information)
        Else
            Dim A2 As String = Replace(Text, "agh", "a")
            Dim B2 As String = Replace(A2, "ghu", "b")
            Dim C2 As String = Replace(B2, "'k", "c")
            Dim D2 As String = Replace(C2, "gle", "d")
            Dim E2 As String = Replace(D2, "ehg", "e")
            Dim F2 As String = Replace(E2, "elg", "f")
            Dim G2 As String = Replace(F2, "g", "g")
            Dim H2 As String = Replace(G2, "urg", "h")
            Dim I2 As String = Replace(H2, "eug", "i")
            Dim J2 As String = Replace(I2, "ga", "j")
            Dim K2 As String = Replace(J2, "kk", "k")
            Dim L2 As String = Replace(K2, "l", "l")
            Dim M2 As String = Replace(L2, "leg", "m")
            Dim N2 As String = Replace(M2, "leh", "n")
            Dim P2 As String = Replace(N2, "gg", "p")
            Dim Q2 As String = Replace(P2, "gee", "q")
            Dim O2 As String = Replace(Q2, "ouh", "o")
            Dim R2 As String = Replace(O2, "arlg", "r")
            Dim S2 As String = Replace(R2, "els", "s")
            Dim T2 As String = Replace(S2, "t", "t")
            Dim U2 As String = Replace(T2, "gew", "u")
            Dim V2 As String = Replace(U2, "geh", "v")
            Dim W2 As String = Replace(V2, "uhh", "w")
            Dim X2 As String = Replace(W2, "egs", "x")
            Dim Y2 As String = Replace(X2, "leg", "y")
            Dim Z2 As String = Replace(Y2, "z", "z")

            MessageBox.Show("Translation: " + Z2, _
                              "Translated!", _
                              MessageBoxButtons.OK, _
                              MessageBoxIcon.Information)
        End If
    End Sub
End Class
