Public Class CSpalte

    Public MoeglZahlen(9) As Boolean
    Public m_feld(9) As CFeld

    Sub New(ByRef pSpf As CSpielfeld, ByRef pSpalteNo As Byte)
        Dim i As Byte
        For i = 1 To 9
            MoeglZahlen(i) = True
            m_feld(i) = pSpf.m_Feld(pSpalteNo, i)
        Next
    End Sub

    Sub GesetzteAusMöglichenStreichen()
        Dim i As Byte

        For i = 1 To 9
            If m_feld(i).GetGesetzteZahl > 0 Then
                MoeglZahlen(m_feld(i).GetGesetzteZahl) = False
            End If
        Next
    End Sub

    Sub GesetzteAusFeldernStreichen()
        Dim y, k As Byte

        For y = 1 To 9
            For k = 1 To 9
                If MoeglZahlen(k) = False Then
                    m_feld(y).MöglicheZahlen(k) = False
                    m_feld(y).Mark(k) = 2
                End If
            Next
        Next

    End Sub

    Function ZwillingSuchen(ByVal y1 As Byte, ByRef y2 As Byte, ByRef k1 As Byte, ByRef k2 As Byte) As Boolean
        Dim y, k, count As Byte

        ZwillingSuchen = False
        If y1 < 9 Then
            For y = y1 + 1 To 9
                k1 = 0
                k2 = 0
                count = 0
                For k = 1 To 9
                    If m_feld(y1).MöglicheZahlen(k) = m_feld(y).MöglicheZahlen(k) And m_feld(y1).GetGesetzteZahl = 0 And m_feld(y).GetGesetzteZahl = 0 Then
                        If m_feld(y).MöglicheZahlen(k) = True Then
                            count += 1
                        End If
                        If count = 1 And k1 = 0 Then
                            k1 = k
                        ElseIf count = 2 And k2 = 0 Then
                            ZwillingSuchen = True
                            k2 = k
                            y2 = y
                        ElseIf count > 2 Then
                            ZwillingSuchen = False
                            k = 9
                        End If
                    Else
                        ZwillingSuchen = False
                        k = 9
                    End If
                Next
                If ZwillingSuchen Then
                    y = 9
                End If
            Next
        End If
    End Function

    Function AlleAusserZwillingStreichen(ByVal y1 As Byte, ByVal y2 As Byte, ByVal k1 As Byte, ByVal k2 As Byte, ByVal m As Byte) As Boolean

        Dim Zeile As Byte
        AlleAusserZwillingStreichen = False

        ' Zwillingsziffern aus restlicher Spalte steichen
        For Zeile = 1 To 9
            If Zeile <> y1 And Zeile <> y2 Then
                ' einmalige Zahl aus Spalte streichen
                AlleAusserZwillingStreichen = AlleAusserZwillingStreichen Or m_feld(Zeile).MöglicheZahlen(k1)
                AlleAusserZwillingStreichen = AlleAusserZwillingStreichen Or m_feld(Zeile).MöglicheZahlen(k2)
                m_feld(Zeile).MöglicheZahlen(k1) = False
                m_feld(Zeile).MöglicheZahlen(k2) = False
                m_feld(Zeile).Mark(k1) = m
                m_feld(Zeile).Mark(k2) = m
            End If
        Next
    End Function

    Function FindeAlleOffenen(ByRef Positionen() As Byte) As Byte
        Dim AnzahlOffene As Byte
        Dim Zeile As Byte

        For Zeile = 1 To 9
            If m_feld(Zeile).IstOffen() = True Then
                AnzahlOffene += 1
                Positionen(AnzahlOffene) = Zeile
            End If
        Next
        FindeAlleOffenen = AnzahlOffene
    End Function

End Class
