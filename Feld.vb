
Public Class CFeld
    Event Neuzeichnen()
    Event AutoStreichen()
    Private GesetzteZahl As Byte
    Public M�glicheZahlen(9) As Boolean
    Public Mark(9) As Byte

    Sub New()
        GesetzteZahl = 0
        Dim i As Byte
        For i = 1 To 9
            M�glicheZahlen(i) = True
            Mark(i) = 0
        Next
    End Sub

    Sub SetGesetzteZahl(pZahl As Byte)
        GesetzteZahl = pZahl
    End Sub

    Function GetGesetzteZahl() As Byte
        Return GesetzteZahl
    End Function

    Function IstUnmoeglich() As Boolean
        Dim zahl As Byte
        If GesetzteZahl <> 0 Then
            IstUnmoeglich = False
        Else
            IstUnmoeglich = True
            For zahl = 1 To 9
                If M�glicheZahlen(zahl) = True Then
                    IstUnmoeglich = False
                    Exit For
                End If
            Next
        End If
    End Function

    Function IstOffen() As Boolean
        Return GesetzteZahl = 0
    End Function

    Sub Erg�nzeM�glicheZahlen(ByRef pM�glicheZahlen)
        Dim IndexM�glicheZahl As Byte

        For IndexM�glicheZahl = 1 To 9
            If M�glicheZahlen(IndexM�glicheZahl) = True Then
                pM�glicheZahlen(IndexM�glicheZahl) = True
            End If
        Next
    End Sub

    Sub TextBox_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim zeile, spalte, ziff As Integer

        spalte = Mid(sender.Name, 5, 1)
        zeile = Mid(sender.Name, 6, 1)
        ziff = Mid(sender.Name, 7)
        If e.Button = MouseButtons.Right And ziff < 10 Then
            Me.M�glicheZahlen(ziff) = Not Me.M�glicheZahlen(ziff)
        Else
            If ziff < 10 Then
                If Me.M�glicheZahlen(ziff) = False Then
                    MsgBox("Bitte nur m�gliche Zahlen anklicken", MsgBoxStyle.OkOnly, "Fehlerinformation")
                    Exit Sub
                Else
                    Me.GesetzteZahl = ziff
                End If
            Else
                Me.GesetzteZahl = 0
            End If
        End If
        RaiseEvent AutoStreichen()
        RaiseEvent Neuzeichnen()
    End Sub


End Class
