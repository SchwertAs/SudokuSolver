Public Class CZeile

    Public m_feld(9) As CFeld
    Public MoeglZahlen(9) As Boolean

    Sub New(ByRef pSpf As CSpielfeld, ByRef pZeileNo As Byte)
        Dim i As Byte
        For i = 1 To 9
            MoeglZahlen(i) = True
            m_feld(i) = pSpf.m_Feld(i, pZeileNo)
        Next
    End Sub

    Sub GesetzteAusMöglichenStreichen()
        Dim spalte, gesetzteZahl As Byte
        For spalte = 1 To 9
            gesetzteZahl = m_feld(spalte).GetGesetzteZahl
            If gesetzteZahl > 0 Then
                MoeglZahlen(gesetzteZahl) = False
            End If
        Next
    End Sub

    Sub GesetzteAusFeldernStreichen()
        Dim x, k As Byte

        For x = 1 To 9
            For k = 1 To 9
                If MoeglZahlen(k) = False Then
                    m_feld(x).MöglicheZahlen(k) = False
                    m_feld(x).Mark(k) = 1
                End If
            Next
        Next
    End Sub

    Function ZwillingSuchen(ByRef x1 As Byte, ByRef x2 As Byte, ByRef k1 As Byte, ByRef k2 As Byte) As Boolean
        Dim x, k, count As Byte

        ZwillingSuchen = False
        If x1 < 9 Then
            For x = x1 + 1 To 9
                k1 = 0
                k2 = 0
                count = 0
                For k = 1 To 9
                    If m_feld(x1).MöglicheZahlen(k) = m_feld(x).MöglicheZahlen(k) And m_feld(x1).GetGesetzteZahl = 0 And m_feld(x).GetGesetzteZahl = 0 Then
                        If m_feld(x).MöglicheZahlen(k) = True And m_feld(x).GetGesetzteZahl = 0 Then
                            count += 1
                        End If
                        If count = 1 And k1 = 0 Then
                            k1 = k
                        ElseIf count = 2 And k2 = 0 Then
                            ZwillingSuchen = True
                            k2 = k
                            x2 = x
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
                    x = 9
                End If
            Next
        End If
    End Function

    Function AlleAusserZwillingStreichen(ByVal x1 As Byte, ByVal x2 As Byte, ByVal k1 As Byte, ByVal k2 As Byte, ByVal m As Byte) As Boolean
        Dim Spalte As Byte

        AlleAusserZwillingStreichen = False
        ' Zwillingsziffern aus restlicher Zeile steichen
        For Spalte = 1 To 9
            If Spalte <> x1 And Spalte <> x2 Then
                ' einmalige Zahl aus Zeile streichen
                AlleAusserZwillingStreichen = AlleAusserZwillingStreichen Or m_feld(Spalte).MöglicheZahlen(k1)
                AlleAusserZwillingStreichen = AlleAusserZwillingStreichen Or m_feld(Spalte).MöglicheZahlen(k2)
                m_feld(Spalte).MöglicheZahlen(k1) = False
                m_feld(Spalte).MöglicheZahlen(k2) = False
                m_feld(Spalte).Mark(k1) = m
                m_feld(Spalte).Mark(k2) = m
            End If
        Next
    End Function

    Function FindeAlleOffenen(ByRef Positionen() As Byte) As Byte
        Dim AnzahlOffene As Byte
        Dim Spalte As Byte

        For Spalte = 1 To 9
            If m_feld(Spalte).IstOffen() = True Then
                AnzahlOffene += 1
                Positionen(AnzahlOffene) = Spalte
            End If
        Next
        FindeAlleOffenen = AnzahlOffene
    End Function
End Class

