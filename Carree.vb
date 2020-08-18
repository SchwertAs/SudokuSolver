Public Class CCarree

    Public m_MoeglZahlen(9) As Boolean
    Public m_Feld(3, 3) As CFeld

    Sub New(ByRef pSpf As CSpielfeld, ByRef carreeSpalte As Byte, ByRef carreeZeile As Byte)
        Dim xx, yy As Byte
        init()

        For xx = 1 To 3
            For yy = 1 To 3
                m_Feld(xx, yy) = pSpf.m_Feld(3 * (carreeSpalte - 1) + xx, 3 * (carreeZeile - 1) + yy)
            Next
        Next
    End Sub

    Sub init()
        Dim i As Byte
        For i = 1 To 9
            m_MoeglZahlen(i) = True
        Next

    End Sub
    Sub GesetzteAusMöglichenStreichen()
        Dim i, j As Byte

        ' streicht in allen Feldern im eigenen Carree die gesetzte Zahl des Feldes 
        For i = 1 To 3
            For j = 1 To 3
                If m_Feld(i, j).GetGesetzteZahl > 0 Then
                    m_MoeglZahlen(m_Feld(i, j).GetGesetzteZahl) = False
                End If
            Next
        Next
    End Sub

    Sub GesetzteAusFeldernStreichen()
        Dim i, j, k As Byte

        ' streicht alle gesetzten Zahlen des Carree in den Feldern des Carree
        For i = 1 To 3
            For j = 1 To 3
                For k = 1 To 9
                    If m_MoeglZahlen(k) = False Then
                        m_Feld(i, j).MöglicheZahlen(k) = False
                        m_Feld(i, j).Mark(k) = 3
                    End If
                Next
            Next
        Next
    End Sub

    Function IsPossible(ByVal zahl) As Boolean
        Dim i, j As Byte

        ' gibt false true zurück wenn keine möglichen mehr da sind
        IsPossible = False
        For i = 1 To 3
            For j = 1 To 3
                If m_Feld(i, j).GetGesetzteZahl = 0 And m_Feld(i, j).MöglicheZahlen(zahl) = True Then
                    IsPossible = True
                    j = 3
                    i = 3
                End If
            Next
        Next
    End Function

    Function ZifferNurInDieserZeileImCarree(ByVal suchZiffer As Byte, ByRef Zeile As Integer) As Boolean
        Dim BasisSpalte As Integer
        Dim VergleichsSpalte As Integer
        Dim DrittSpalte As Integer
        Dim KommtInBasisVor, KommtInVergleichVor, KommtInDrittVor As Boolean
        Dim AnzahlVorkommenInBasis As Integer

        ' streicht alle Zahlen einer Zeile ausserhalb des Carree, 
        ' wenn im carre eine Ziffer nur innerhalb einer Zeile auftaucht
        ' wenn die Suchziffer in der
        KommtInBasisVor = False
        AnzahlVorkommenInBasis = 0
        KommtInVergleichVor = False
        KommtInDrittVor = False

        For BasisSpalte = 1 To 3
            If m_Feld(BasisSpalte, 1).GetGesetzteZahl = 0 Then
                If m_Feld(BasisSpalte, 1).MöglicheZahlen(suchZiffer) = True Then
                    KommtInBasisVor = True
                    AnzahlVorkommenInBasis = AnzahlVorkommenInBasis + 1
                End If
            End If
        Next
        For VergleichsSpalte = 1 To 3
            If m_Feld(VergleichsSpalte, 2).GetGesetzteZahl = 0 Then
                If m_Feld(VergleichsSpalte, 2).MöglicheZahlen(suchZiffer) = True Then
                    KommtInVergleichVor = True
                End If
            End If
        Next
        For DrittSpalte = 1 To 3
            If m_Feld(DrittSpalte, 3).GetGesetzteZahl = 0 Then
                If m_Feld(DrittSpalte, 3).MöglicheZahlen(suchZiffer) = True Then
                    KommtInDrittVor = True
                End If
            End If
        Next
        If (KommtInBasisVor And Not KommtInVergleichVor And Not KommtInDrittVor And AnzahlVorkommenInBasis > 1) Then
            Zeile = 1
            ZifferNurInDieserZeileImCarree = True
        ElseIf (Not KommtInBasisVor And KommtInVergleichVor And Not KommtInDrittVor And AnzahlVorkommenInBasis > 1) Then
            Zeile = 2
            ZifferNurInDieserZeileImCarree = True
        ElseIf (Not KommtInBasisVor And Not KommtInVergleichVor And KommtInDrittVor And AnzahlVorkommenInBasis > 1) Then
            Zeile = 3
            ZifferNurInDieserZeileImCarree = True
        Else
            ZifferNurInDieserZeileImCarree = False
        End If

    End Function

    Function ZifferNurInDieserSpalteImCarree(ByVal Ziffer As Byte, ByRef Spalte As Integer) As Boolean
        Dim BasisZeile As Integer
        Dim VergleichsZeile As Integer
        Dim DrittZeile As Integer
        Dim KommtInBasisVor, KommtInVergleichVor, KommtInDrittVor As Boolean
        Dim AnzahlVorkommenInBasis As Integer

        ' streicht alle Zahlen einer Spalte ausserhalb des Carree, 
        ' wenn im carre eine Ziffer nur innerhalb einer Spalte auftaucht
        KommtInBasisVor = False
        KommtInVergleichVor = False
        KommtInDrittVor = False
        AnzahlVorkommenInBasis = 0

        For BasisZeile = 1 To 3
            If m_Feld(1, BasisZeile).GetGesetzteZahl = 0 Then
                If m_Feld(1, BasisZeile).MöglicheZahlen(Ziffer) = True Then
                    KommtInBasisVor = True
                    AnzahlVorkommenInBasis = AnzahlVorkommenInBasis + 1
                End If
            End If
        Next
        For VergleichsZeile = 1 To 3
            If m_Feld(2, VergleichsZeile).GetGesetzteZahl = 0 Then
                If m_Feld(2, VergleichsZeile).MöglicheZahlen(Ziffer) = True Then
                    KommtInVergleichVor = True
                End If
            End If
        Next
        For DrittZeile = 1 To 3
            If m_Feld(3, DrittZeile).GetGesetzteZahl = 0 Then
                If m_Feld(3, DrittZeile).MöglicheZahlen(Ziffer) = True Then
                    KommtInDrittVor = True
                End If
            End If
        Next
        If (KommtInBasisVor And Not KommtInVergleichVor And Not KommtInDrittVor And AnzahlVorkommenInBasis > 1) Then
            Spalte = 1
            ZifferNurInDieserSpalteImCarree = True
        ElseIf (Not KommtInBasisVor And KommtInVergleichVor And Not KommtInDrittVor And AnzahlVorkommenInBasis > 1) Then
            Spalte = 2
            ZifferNurInDieserSpalteImCarree = True
        ElseIf (Not KommtInBasisVor And Not KommtInVergleichVor And KommtInDrittVor And AnzahlVorkommenInBasis > 1) Then
            Spalte = 3
            ZifferNurInDieserSpalteImCarree = True
        Else
            ZifferNurInDieserSpalteImCarree = False
        End If
    End Function

    Function ZwillingSuchen(ByVal x1 As Byte, ByVal y1 As Byte, ByRef x2 As Byte, ByRef y2 As Byte, ByRef k1 As Byte, ByRef k2 As Byte) As Boolean
        Dim i, j, ziff, count As Byte

        ' Zwilling ist eine Gruppe von zwei Feldern die genau zwei gleiche Möglichkeiten haben.
        ' Sucht eine dieser Gruppen. Wenn gefunden steht
        ' dadurch fest, dass diese beiden möglichen Zahlen genau in dieser Gruppe liegen müssen
        ' die Ziffern können im Rest des Carree gestrichen werden
        ' Nächsten Zwilling suchen
        ZwillingSuchen = False
        x2 = x1
        y2 = y1
        k1 = 0
        k2 = 0
        For i = y1 To 3
            For j = x1 To 3
                If m_Feld(j, i).GetGesetzteZahl = 0 And (i <> y1 Or j <> x1) Then
                    count = 0
                    For ziff = 1 To 9
                        If m_Feld(j, i).MöglicheZahlen(ziff) = m_Feld(x1, y1).MöglicheZahlen(ziff) And m_Feld(j, i).GetGesetzteZahl = 0 And m_Feld(x1, y1).GetGesetzteZahl = 0 Then
                            If m_Feld(j, i).MöglicheZahlen(ziff) = True Then
                                count += 1
                            End If
                            If count = 1 And k1 = 0 Then
                                k1 = ziff
                            ElseIf count = 2 And k2 = 0 Then
                                ZwillingSuchen = True
                                k2 = ziff
                            ElseIf count > 2 Then
                                ZwillingSuchen = False
                                ziff = 9
                            End If
                        Else
                            ZwillingSuchen = False
                            ziff = 9
                        End If
                    Next
                End If
                If ZwillingSuchen Then
                    x2 = j
                    y2 = i
                    Exit Function
                End If
            Next
        Next
    End Function

    Function StreicheZahlAusserZwilling(ByVal SpalteErsterZwilling As Byte, ByVal ZeileErsterZwilling As Byte, ByVal SpalteZweiterZwilling As Byte, ByVal ZeileZweiterZwilling As Byte, ByVal ZuStreichendeZahl As Byte, ByVal Farbe As Byte) As Boolean
        Dim Spalte, Zeile As Byte

        StreicheZahlAusserZwilling = False
        For Spalte = 1 To 3
            For Zeile = 1 To 3
                If Not ((Spalte = SpalteErsterZwilling And Zeile = ZeileErsterZwilling) Or (Spalte = SpalteZweiterZwilling And Zeile = ZeileZweiterZwilling)) Then
                    StreicheZahlAusserZwilling = StreicheZahlAusserZwilling Or m_Feld(Spalte, Zeile).MöglicheZahlen(ZuStreichendeZahl)
                    m_Feld(Spalte, Zeile).MöglicheZahlen(ZuStreichendeZahl) = False
                    m_Feld(Spalte, Zeile).Mark(ZuStreichendeZahl) = Farbe
                End If
            Next
        Next
    End Function

    Function StreicheZahlAusserZeile(ByVal ZeileInCarree As Byte, ByVal ZustreichendeZahl As Byte, ByVal Farbe As Byte) As Boolean

        Dim Spalte, Zeile As Byte
        StreicheZahlAusserZeile = False

        For Spalte = 1 To 3
            For Zeile = 1 To 3
                If Not (Zeile = ZeileInCarree) Then
                    StreicheZahlAusserZeile = StreicheZahlAusserZeile Or m_Feld(Spalte, Zeile).MöglicheZahlen(ZustreichendeZahl)
                    m_Feld(Spalte, Zeile).MöglicheZahlen(ZustreichendeZahl) = False
                    m_Feld(Spalte, Zeile).Mark(ZustreichendeZahl) = Farbe
                End If
            Next
        Next

    End Function

    Function StreicheZahlAusserSpalte(ByVal SpalteInCarree As Byte, ByVal ZustreichendeZahl As Byte, ByVal Farbe As Byte) As Boolean
        Dim Zeile, Spalte As Byte
        StreicheZahlAusserSpalte = False

        For Zeile = 1 To 3
            For Spalte = 1 To 3
                If Not (Spalte = SpalteInCarree) Then
                    StreicheZahlAusserSpalte = StreicheZahlAusserSpalte Or m_Feld(Spalte, Zeile).MöglicheZahlen(ZustreichendeZahl)
                    m_Feld(Spalte, Zeile).MöglicheZahlen(ZustreichendeZahl) = False
                    m_Feld(Spalte, Zeile).Mark(ZustreichendeZahl) = Farbe
                End If
            Next
        Next

    End Function
End Class
