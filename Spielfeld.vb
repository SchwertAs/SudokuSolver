Public Class CSpielfeld
    Event Zeichne()
    Event AutoStreiche()
    Public m_Feld(9, 9) As CFeld
    Public m_Carree(3, 3) As CCarree
    Public m_Spalte(9) As CSpalte
    Public m_Zeile(9) As CZeile

    Public Enum Spielzustand As Byte
        ungelöst = 0
        unlösbar = 1
        fertig = 2
        KeineEinfacheLösung = 3
    End Enum

    Sub New()
        Construct()
    End Sub

    Sub New(ByRef pspf As CSpielfeld)
        Construct()
        Dim x, y As Byte

        For x = 1 To 9
            For y = 1 To 9
                m_Feld(x, y).SetGesetzteZahl(pspf.m_Feld(x, y).GetGesetzteZahl)
            Next
        Next
        Bewerte()
    End Sub

    Sub Construct()
        Dim Spalte, Zeile As Byte

        For Spalte = 1 To 9
            For Zeile = 1 To 9
                m_Feld(Spalte, Zeile) = New CFeld
                AddHandler m_Feld(Spalte, Zeile).Neuzeichnen, AddressOf Me.Zeichnen
                AddHandler m_Feld(Spalte, Zeile).AutoStreichen, AddressOf Me.AutoStreichen
            Next
        Next
        For Spalte = 1 To 9
            m_Spalte(Spalte) = New CSpalte(Me, Spalte)
        Next
        For Zeile = 1 To 9
            m_Zeile(Zeile) = New CZeile(Me, Zeile)
        Next
        For Spalte = 1 To 3
            For Zeile = 1 To 3
                m_Carree(Spalte, Zeile) = New CCarree(Me, Spalte, Zeile)
            Next
        Next
    End Sub

    Public Sub Init()
        Dim i, j, k As Integer

        For i = 1 To 9
            For j = 1 To 9
                m_Feld(i, j).SetGesetzteZahl(0)
                For k = 1 To 9
                    m_Feld(i, j).MöglicheZahlen(k) = True
                    m_Feld(i, j).Mark(k) = 0
                Next
                m_Zeile(i).MoeglZahlen(j) = True
                m_Spalte(j).MoeglZahlen(i) = True
            Next
        Next
        Dim carreeSpalte, carreeZeile As Byte
        For carreeSpalte = 1 To 3
            For carreeZeile = 1 To 3
                For k = 1 To 9
                    m_Carree(carreeSpalte, carreeZeile).m_MoeglZahlen(k) = True
                Next
            Next
        Next

    End Sub

    Sub Trace()
        Dim x, y, zahl As Byte

        Debug.Print("--------------------------------+--------------------------------+--------------------------------+")
        For x = 1 To 9
            For y = 1 To 9
                If m_Feld(x, y).GetGesetzteZahl <> 0 Then
                    Debug.Write("         " & m_Feld(x, y).GetGesetzteZahl)
                Else
                    For zahl = 0 To 9
                        If m_Feld(x, y).MöglicheZahlen(zahl) Then
                            Debug.Write(zahl)
                        Else
                            Debug.Write("0")
                        End If
                    Next
                End If
                If y Mod 3 = 0 Then
                    Debug.Write("|")
                Else
                    Debug.Write(" ")
                End If
            Next
            Debug.Print("")
            If x Mod 3 = 0 Then
                Debug.Print("--------------------------------+--------------------------------+--------------------------------+")
            End If
        Next
    End Sub

    Function FindNextFieldWithNPossibilities(ByVal NPossi As Byte, ByVal FromX As Byte, ByVal FromY As Byte, _
                                         ByRef outX As Byte, ByRef outY As Byte) As Boolean
        Dim x, y, zahl, count As Byte
        FindNextFieldWithNPossibilities = False
        For y = FromY To 9
            For x = FromX To 9
                If m_Feld(x, y).GetGesetzteZahl = 0 Then
                    count = 0
                    For zahl = 1 To 9
                        If m_Feld(x, y).MöglicheZahlen(zahl) Then
                            count = count + 1
                        End If
                    Next
                    If count = NPossi Then
                        outX = x
                        outY = y
                        x = 9
                        y = 9
                        FindNextFieldWithNPossibilities = True
                    End If
                End If
            Next
            FromX = 1
        Next
    End Function

    Function SearchToEnd() As Boolean
        Dim ergebnis As Spielzustand

        ergebnis = Search()
        Do While ergebnis = Spielzustand.ungelöst
            ergebnis = Search()
        Loop
        If ergebnis = Spielzustand.fertig Then
            SearchToEnd = True
        Else
            SearchToEnd = False
            'TraceField()
        End If
    End Function

    Function Search() As Spielzustand

        Search = Spielzustand.ungelöst
        If Bewerte() = True Then
            If CheckSingleInField() = False Then
                If CheckSingleInZeile() = False Then
                    If CheckSingleInSpalte() = False Then
                        If CheckSingleInCarree() = False Then
                            Search = Spielzustand.KeineEinfacheLösung
                        End If
                    End If
                End If
            End If
        Else
            'Holzweg (ein Feld ohne eine Möglichkeit exitstiert)
            Search = Spielzustand.unlösbar
        End If
        If IsGelöst() Then
            Search = Spielzustand.fertig
        End If
        Return Search
    End Function

    Function IsGelöst() As Boolean
        Dim x, y As Byte
        Dim AlleAusgefüllt As Boolean

        AlleAusgefüllt = True
        For x = 1 To 9
            For y = 1 To 9
                If m_Feld(x, y).GetGesetzteZahl = 0 Then
                    AlleAusgefüllt = False
                    y = 9
                    x = 9
                End If
            Next
        Next
        IsGelöst = AlleAusgefüllt
    End Function


    Function Bewerte() As Boolean
        Dim i, j As Byte
        Dim spalte, zeile As Byte
        Bewerte = True
        ' Erst ist alles möglich

        For i = 1 To 9
            m_Zeile(i).GesetzteAusMöglichenStreichen()
            m_Zeile(i).GesetzteAusFeldernStreichen()
            m_Spalte(i).GesetzteAusMöglichenStreichen()
            m_Spalte(i).GesetzteAusFeldernStreichen()
        Next
        For i = 1 To 3
            For j = 1 To 3
                m_Carree(i, j).GesetzteAusMöglichenStreichen()
                m_Carree(i, j).GesetzteAusFeldernStreichen()
            Next
        Next

        Dim streichung As Boolean

        streichung = True
        While streichung = True
            streichung = False
            streichung = streichung Or ZifferImCarreeNurInEinerZeile()
            streichung = streichung Or ZifferImCarreeNurInEinerSpalte()
            streichung = streichung Or ZwillingeInZeile()
            streichung = streichung Or ZwillingeInSpalte()
            streichung = streichung Or ZwillingImCarreeStreichen()
            streichung = streichung Or AusschliessendeGruppeInZeile()
            streichung = streichung Or AusschliessendeGruppeInSpalte()
        End While

        'Unmögliches Feld finden
        For zeile = 1 To 9
            For spalte = 1 To 9
                If m_Feld(spalte, zeile).IstUnmoeglich Then
                    Bewerte = False
                End If
            Next
        Next
    End Function

    Function ZifferImCarreeNurInEinerZeile() As Boolean
        Dim carreeSpalte, carreeZeile, suchZiffer, Zeile, Spalte As Byte

        ZifferImCarreeNurInEinerZeile = False
        For carreeSpalte = 1 To 3
            For carreeZeile = 1 To 3
                ' Zusatzstreichung wenn Ziffer nur in einer Linie
                ' Streichzeilen suchen
                For suchZiffer = 1 To 9
                    If m_Carree(carreeSpalte, carreeZeile).ZifferNurInDieserZeileImCarree(suchZiffer, Zeile) Then
                        For Spalte = 1 To 9
                            If (Spalte - 1) \ 3 <> carreeSpalte - 1 Then
                                ' einmalige Zahl aus Spalte streichen
                                ZifferImCarreeNurInEinerZeile = m_Feld(Spalte, (carreeZeile - 1) * 3 + Zeile).MöglicheZahlen(suchZiffer)
                                m_Feld(Spalte, (carreeZeile - 1) * 3 + Zeile).MöglicheZahlen(suchZiffer) = False
                                m_Feld(Spalte, (carreeZeile - 1) * 3 + Zeile).Mark(suchZiffer) = 7
                            End If
                        Next
                    End If
                Next
            Next
        Next
    End Function

    Function ZifferImCarreeNurInEinerSpalte() As Boolean
        Dim carreeX, carreeY, carreeZiffer, Zeile, Spalte As Byte

        ZifferImCarreeNurInEinerSpalte = False
        For carreeX = 1 To 3
            For carreeY = 1 To 3
                ' Streichspalten suchen
                For carreeZiffer = 1 To 9
                    If m_Carree(carreeX, carreeY).ZifferNurInDieserSpalteImCarree(carreeZiffer, Spalte) Then
                        ' wenn Ziffer nur in einer Spalte vorkommt
                        For Zeile = 1 To 9
                            If (Zeile - 1) \ 3 <> carreeY - 1 Then
                                ' einmalige Zahl aus Spalte streichen
                                ZifferImCarreeNurInEinerSpalte = m_Feld((carreeX - 1) * 3 + Spalte, Zeile).MöglicheZahlen(carreeZiffer)
                                m_Feld((carreeX - 1) * 3 + Spalte, Zeile).MöglicheZahlen(carreeZiffer) = False
                                m_Feld((carreeX - 1) * 3 + Spalte, Zeile).Mark(carreeZiffer) = 8
                            End If
                        Next
                    End If
                Next
            Next
        Next
    End Function

    Function ZwillingImCarreeStreichen() As Boolean
        Dim i, j As Byte
        Dim SpalteErsterZwilling, ZeileErsterZwilling, SpalteZweiterZwilling, ZeileZweiterZwilling, ErsteMoeglicheZahl, ZweiteMoeglicheZahl As Byte

        ZwillingImCarreeStreichen = False
        For i = 1 To 3
            For j = 1 To 3
                ' Zwillinge in Carree suchen
                For ZeileErsterZwilling = 1 To 3
                    For SpalteErsterZwilling = 1 To 3
                        If m_Carree(i, j).ZwillingSuchen(SpalteErsterZwilling, ZeileErsterZwilling, SpalteZweiterZwilling, ZeileZweiterZwilling, ErsteMoeglicheZahl, ZweiteMoeglicheZahl) Then
                            ' Aus Carree streichen
                            ZwillingImCarreeStreichen = m_Carree(i, j).StreicheZahlAusserZwilling(SpalteErsterZwilling, ZeileErsterZwilling, SpalteZweiterZwilling, ZeileZweiterZwilling, ErsteMoeglicheZahl, 6)
                            ZwillingImCarreeStreichen = ZwillingImCarreeStreichen Or m_Carree(i, j).StreicheZahlAusserZwilling(SpalteErsterZwilling, ZeileErsterZwilling, SpalteZweiterZwilling, ZeileZweiterZwilling, ZweiteMoeglicheZahl, 6)
                            ' gefundenen Zwilling überspringen
                            If SpalteZweiterZwilling < 3 Then
                                SpalteErsterZwilling = SpalteZweiterZwilling + 1
                                ZeileErsterZwilling = ZeileZweiterZwilling
                            ElseIf ZeileZweiterZwilling < 3 Then
                                SpalteErsterZwilling = 1
                                ZeileErsterZwilling = ZeileZweiterZwilling + 1
                            Else
                                SpalteErsterZwilling = 3
                                ZeileErsterZwilling = 3
                            End If
                        End If
                    Next
                Next
            Next
        Next
    End Function

    Function ZwillingeInZeile() As Boolean
        Dim Zeile, AnfangsSpalte, ZweiterZwillingSpalte, ErsteMoeglicheZahl, ZweiteMoeglicheZahl As Byte

        ZwillingeInZeile = False
        'Zwillinge in Zeilen suchen
        For Zeile = 1 To 9
            For AnfangsSpalte = 1 To 9
                If m_Zeile(Zeile).ZwillingSuchen(AnfangsSpalte, ZweiterZwillingSpalte, ErsteMoeglicheZahl, ZweiteMoeglicheZahl) Then
                    ZwillingeInZeile = m_Zeile(Zeile).AlleAusserZwillingStreichen(AnfangsSpalte, ZweiterZwillingSpalte, ErsteMoeglicheZahl, ZweiteMoeglicheZahl, 4)
                End If
            Next
        Next
    End Function

    Function ZwillingeInSpalte() As Boolean
        Dim spalte, AnfangsZeile, ZweiterZwillingZeile, ErsteMoeglicheZahl, ZweiteMoeglicheZahl As Byte

        ZwillingeInSpalte = False
        ' Zwillingsziffern aus restlicher Spalte streichen
        For spalte = 1 To 9
            For AnfangsZeile = 1 To 9
                If m_Spalte(spalte).ZwillingSuchen(AnfangsZeile, ZweiterZwillingZeile, ErsteMoeglicheZahl, ZweiteMoeglicheZahl) Then
                    ZwillingeInSpalte = m_Spalte(spalte).AlleAusserZwillingStreichen(AnfangsZeile, ZweiterZwillingZeile, ErsteMoeglicheZahl, ZweiteMoeglicheZahl, 5)

                End If
            Next
        Next

    End Function

    Function AusschliessendeGruppeInZeile() As Boolean
        Dim Zeile As Byte
        Dim AnzahlOffene As Integer

        AusschliessendeGruppeInZeile = False
        ' Wenn alle offenen Zahlen einer Zeile im gleichen Carree liegen
        For Zeile = 1 To 9
            Dim PositionenOffeneZahlen(9) As Byte
            ' suche Positionen aller offenen Zahlen
            AnzahlOffene = m_Zeile(Zeile).FindeAlleOffenen(PositionenOffeneZahlen)
            ' wenn alle offenen Zahlen im gleichen Quadrat
            If (AnzahlOffene = 3 _
                And (PositionenOffeneZahlen(1) - 1) \ 3 = (PositionenOffeneZahlen(2) - 1) \ 3 _
                And (PositionenOffeneZahlen(2) - 1) \ 3 = (PositionenOffeneZahlen(3) - 1) \ 3 _
               ) Then
                Dim MöglicheZahlen(9) As Boolean

                'offene Zahlen der Zeile ermitteln und
                m_Feld(PositionenOffeneZahlen(1), Zeile).ErgänzeMöglicheZahlen(MöglicheZahlen)
                Dim CarreeSpalte, CarreeZeile As Byte
                Dim ZeileInCarree As Byte
                Dim IndexMöglicheZahl As Byte

                CarreeSpalte = (PositionenOffeneZahlen(1) - 1) \ 3 + 1
                CarreeZeile = (Zeile - 1) \ 3 + 1
                ZeileInCarree = Zeile - (CarreeZeile - 1) * 3

                'aus den restlichen offenen Feldern des Carees steichen
                For IndexMöglicheZahl = 1 To 9
                    If MöglicheZahlen(IndexMöglicheZahl) = True Then
                        AusschliessendeGruppeInZeile = m_Carree(CarreeSpalte, CarreeZeile).StreicheZahlAusserZeile(ZeileInCarree, IndexMöglicheZahl, 9)
                    End If
                Next
            End If
        Next

    End Function

    Function AusschliessendeGruppeInSpalte() As Boolean
        Dim Spalte As Byte
        Dim AnzahlOffene As Integer

        AusschliessendeGruppeInSpalte = False
        ' Wenn alle offenen Zahlen einer Zeile im gleichen Carree liegen
        For Spalte = 1 To 9
            Dim PositionenOffeneZahlen(9) As Byte
            ' suche Positionen aller offenen Zahlen
            AnzahlOffene = m_Spalte(Spalte).FindeAlleOffenen(PositionenOffeneZahlen)
            ' wenn alle offenen Zahlen im gleichen Quadrat
            If (AnzahlOffene = 3 _
                And (PositionenOffeneZahlen(1) - 1) \ 3 = (PositionenOffeneZahlen(2) - 1) \ 3 _
                And (PositionenOffeneZahlen(2) - 1) \ 3 = (PositionenOffeneZahlen(3) - 1) \ 3 _
               ) Then
                Dim MöglicheZahlen(9) As Boolean

                'offene Zahlen der Zeile ermitteln und
                m_Feld(Spalte, PositionenOffeneZahlen(1)).ErgänzeMöglicheZahlen(MöglicheZahlen)
                Dim CarreeZeile, CarreeSpalte As Byte
                Dim SpalteInCarree As Byte
                Dim IndexMöglicheZahl As Byte

                CarreeZeile = (PositionenOffeneZahlen(1) - 1) \ 3 + 1
                CarreeSpalte = (Spalte - 1) \ 3 + 1
                SpalteInCarree = Spalte - (CarreeSpalte - 1) * 3

                'aus den restlichen offenen Feldern des Carees steichen
                For IndexMöglicheZahl = 1 To 9
                    If MöglicheZahlen(IndexMöglicheZahl) = True Then
                        AusschliessendeGruppeInSpalte = m_Carree(CarreeSpalte, CarreeZeile).StreicheZahlAusserSpalte(SpalteInCarree, IndexMöglicheZahl, 10)
                    End If
                Next
            End If
        Next
    End Function

    Function CheckSingleInField() As Boolean
        Dim i, j, k As Byte
        Dim EinzigeZahl As Byte

        CheckSingleInField = False
        ' Felder bewerten (Restmenge nur eine Ziffer pro Feld)
        For i = 1 To 9
            For j = 1 To 9
                If m_Feld(i, j).GetGesetzteZahl = 0 Then
                    EinzigeZahl = 0
                    For k = 1 To 9
                        If m_Feld(i, j).MöglicheZahlen(k) = True Then
                            If EinzigeZahl = 0 Then
                                EinzigeZahl = k
                            Else
                                EinzigeZahl = 0
                                k = 9
                            End If
                        End If
                    Next
                    If EinzigeZahl <> 0 Then
                        m_Feld(i, j).SetGesetzteZahl(EinzigeZahl)
                        m_Feld(i, j).MöglicheZahlen(EinzigeZahl) = False
                        Debug.Print("Feld " & i & ", " & j & " hat Wert " & EinzigeZahl)
                        CheckSingleInField = True
                        Exit Function
                    End If
                End If
            Next
        Next
    End Function

    Function CheckSingleInCarree() As Boolean
        ' Wenn es in einem Carree nur noch ein Feld gibt in das eine bestimmte Ziffer gesetzt werden kann
        Dim CarreeX, CarreeY, Zahl, FeldX, FeldY As Byte
        Dim EinzigeZahlX, EinzigeZahlY As Byte
        Dim EinzigeZahl As Byte

        CheckSingleInCarree = False
        For CarreeX = 1 To 3
            For CarreeY = 1 To 3
                For Zahl = 1 To 9
                    EinzigeZahl = 0
                    For FeldX = 1 To 3
                        For FeldY = 1 To 3
                            If m_Carree(CarreeX, CarreeY).m_Feld(FeldX, FeldY).GetGesetzteZahl = 0 Then
                                If m_Carree(CarreeX, CarreeY).m_Feld(FeldX, FeldY).MöglicheZahlen(Zahl) = True Then
                                    If EinzigeZahl = 0 Then
                                        EinzigeZahl = Zahl
                                        EinzigeZahlX = FeldX
                                        EinzigeZahlY = FeldY
                                    Else
                                        EinzigeZahl = 0
                                        FeldY = 3
                                        FeldX = 3
                                    End If
                                End If
                            End If
                        Next
                    Next
                    If EinzigeZahl <> 0 Then
                        m_Carree(CarreeX, CarreeY).m_Feld(EinzigeZahlX, EinzigeZahlY).SetGesetzteZahl(EinzigeZahl)
                        Debug.Print("Carrree " & CarreeX & ", " & CarreeY & " Feld " & EinzigeZahlX & ", " & EinzigeZahlY & " hat Wert " & EinzigeZahl)
                        CheckSingleInCarree = True
                        Exit Function
                    End If

                Next
            Next
        Next
    End Function

    Function CheckSingleInZeile() As Boolean
        ' Wenn es in einer Zeile / Spalte nur noch ein Feld gibt in das eine bestimmte Zahl gesetzt werden kann
        Dim ZeileNo As Byte
        Dim EinzigeZahlX, EinzigeZahlY, FeldX As Byte
        Dim Zahl, EinzigeZahl As Byte

        CheckSingleInZeile = False
        For Zahl = 1 To 9
            For ZeileNo = 1 To 9
                EinzigeZahl = 0
                For FeldX = 1 To 9
                    If m_Zeile(ZeileNo).m_feld(FeldX).GetGesetzteZahl = 0 Then
                        If m_Zeile(ZeileNo).m_feld(FeldX).MöglicheZahlen(Zahl) = True Then
                            If EinzigeZahl = 0 Then
                                EinzigeZahl = Zahl
                                EinzigeZahlX = FeldX
                                EinzigeZahlY = ZeileNo
                            Else
                                EinzigeZahl = 0
                                FeldX = 9
                            End If
                        End If
                    End If
                Next
                If EinzigeZahl <> 0 Then
                    m_Zeile(EinzigeZahlY).m_feld(EinzigeZahlX).SetGesetzteZahl(EinzigeZahl)
                    Debug.Print("Zeile " & EinzigeZahlY & " Feld " & EinzigeZahlX & " hat Wert " & EinzigeZahl)
                    CheckSingleInZeile = True
                    Exit Function
                End If
            Next
        Next
    End Function

    Function CheckSingleInSpalte() As Boolean
        Dim SpalteNo As Byte
        Dim EinzigeZahlX, EinzigeZahlY, FeldY As Byte
        Dim Zahl, EinzigeZahl As Byte

        CheckSingleInSpalte = False
        For Zahl = 1 To 9
            EinzigeZahl = 0
            For SpalteNo = 1 To 9
                EinzigeZahl = 0
                For FeldY = 1 To 9
                    If m_Spalte(SpalteNo).m_feld(FeldY).GetGesetzteZahl = 0 Then
                        If m_Spalte(SpalteNo).m_feld(FeldY).MöglicheZahlen(Zahl) = True Then
                            If EinzigeZahl = 0 Then
                                EinzigeZahl = Zahl
                                EinzigeZahlX = SpalteNo
                                EinzigeZahlY = FeldY
                            Else
                                EinzigeZahl = 0
                                FeldY = 9
                            End If
                        End If
                    End If
                Next
                If EinzigeZahl <> 0 Then
                    m_Spalte(EinzigeZahlX).m_feld(EinzigeZahlY).SetGesetzteZahl(EinzigeZahl)
                    Debug.Print("Spalte " & EinzigeZahlX & " Feld " & EinzigeZahlY & " hat Wert " & EinzigeZahl)
                    CheckSingleInSpalte = True
                    Exit Function
                End If
            Next
        Next
    End Function

    Function VerteileZahl(ByVal Zahl As Byte) As Boolean
        Dim x, y, carreex, carreey As Byte

        Randomize()
        VerteileZahl = True
        For carreex = 1 To 3
            For carreey = 1 To 3
                'Zufallszahl (nur eine mögliche) setzen
                If m_Carree(carreex, carreey).IsPossible(Zahl) Then
                    ' Nur wenn Zahl noch im Carree gesetzt werden kann suchen
                    Do
                        x = CInt(Rnd() * 2) + 1
                        y = CInt(Rnd() * 2) + 1
                    Loop Until m_Carree(carreex, carreey).m_Feld(x, y).GetGesetzteZahl = 0 And
                    m_Carree(carreex, carreey).m_Feld(x, y).MöglicheZahlen(Zahl) = True

                    m_Carree(carreex, carreey).m_Feld(x, y).SetGesetzteZahl(Zahl)
                    'evaluate
                    Bewerte()
                Else
                    VerteileZahl = False
                    carreex = 3
                    carreey = 3
                End If
            Next
        Next

    End Function

    Sub KillFieldByRandom()
        Dim x, y As Byte

        Randomize()
        Do
            x = CInt(Rnd() * 8) + 1
            y = CInt(Rnd() * 8) + 1
        Loop While m_Feld(x, y).GetGesetzteZahl = 0
        m_Feld(x, y).SetGesetzteZahl(0)
        Bewerte()
    End Sub

    Sub Zeichnen()
        RaiseEvent Zeichne()
    End Sub

    Sub AutoStreichen()
        RaiseEvent AutoStreiche()
    End Sub
End Class
