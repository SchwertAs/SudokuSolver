
Public Class Form1
    Public Spf As New CSpielfeld
    Public SpfSave(9, 9), SpfSave2(9, 9) As Byte
    Public SpfSavePoint(9, 9) As Byte
    Public Disp As New CAnzeige


    Public Sub New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Dim tb As Windows.Forms.Label
        Dim izeile, ispalte, iziff, xoffs, yoffs
        Const Abstand As Integer = 24
        Const DickeLinie As Integer = 3
        Const DünneLinie As Integer = 3

        For izeile = 1 To 9
            yoffs = (((izeile - 1) \ 3) + 1) * DickeLinie + (izeile) * DünneLinie + PanelHauptZahlenFeld.Location.Y + 1
            For ispalte = 1 To 9
                ' Offset durch Dicke linien und Anfangsoffset des Panels mit 
                xoffs = (((ispalte - 1) \ 3) + 1) * DickeLinie + (ispalte) * DünneLinie + PanelHauptZahlenFeld.Location.X + 1
                For iziff = 1 To 10
                    tb = New System.Windows.Forms.Label
                    tb.Name = "Mögl" + ispalte.ToString() + izeile.ToString() + iziff.ToString()
                    tb.Text = " "
                    tb.TabIndex = 0
                    tb.Text = izeile.ToString() + ispalte.ToString() + iziff.ToString()
                    tb.BackColor = Color.AliceBlue
                    tb.TextAlign = ContentAlignment.MiddleCenter
                    If iziff >= 1 And iziff <= 3 Then
                        Me.Controls.Add(tb)
                        tb.Location = New System.Drawing.Point(((ispalte - 1) * 3 + (iziff - 1)) * Abstand + xoffs, _
                                                               (3 * (izeile - 1) * Abstand) + yoffs)
                    ElseIf iziff >= 4 And iziff <= 6 Then
                        Me.Controls.Add(tb)
                        tb.Location = New System.Drawing.Point(((ispalte - 1) * 3 + (iziff - 4)) * Abstand + xoffs, _
                                                               (3 * (izeile - 1) + 1) * Abstand + yoffs)
                    ElseIf iziff >= 7 And iziff <= 9 Then
                        Me.Controls.Add(tb)
                        tb.Location = New System.Drawing.Point(((ispalte - 1) * 3 + (iziff - 7)) * Abstand + xoffs, _
                                                               (3 * (izeile - 1) + 2) * Abstand + yoffs)
                    Else
                        Me.Controls.Add(tb)
                        tb.Location = New System.Drawing.Point(((ispalte - 1) * 3) * Abstand + xoffs, _
                                                               (3 * (izeile - 1) * Abstand) + yoffs)
                    End If
                    If iziff < 10 Then
                        tb.Size = New System.Drawing.Size(Abstand - 1, Abstand - 1)
                        tb.BringToFront()
                    Else
                        tb.Font = New Font("Microsoft Sans Serif", 38, FontStyle.Bold)
                        tb.Width = 3 * Abstand - 1
                        tb.Height = 3 * Abstand - 1
                        tb.Visible = False
                        tb.SendToBack()
                    End If
                    Disp.AnzFeld(ispalte, izeile, iziff) = tb
                    AddHandler tb.Click, AddressOf Spf.m_Feld(ispalte, izeile).TextBox_Click
                    ToolTip1.SetToolTip(tb, "Zahl " + iziff.ToString + " setzen durch Linksklick; Streichen durch Rechtsklick")
                Next
            Next
        Next
        PanelHauptZahlenFeld.Size = New Size(27 * Abstand + 4 * DickeLinie + 10 * DünneLinie + 1, 27 * Abstand + 4 * DickeLinie + 10 * DünneLinie + 1)
        AddHandler Spf.Zeichne, AddressOf Zeichnen
        AddHandler Spf.AutoStreiche, AddressOf AutoStreichen
        ToolTip1.SetToolTip(btnMerken, "Zwischenstand speichern (nur während der Laufzeit)")
        ToolTip1.SetToolTip(btnHolen, "gespeicherten Zwischenstand wieder herstellen")
        ToolTip1.SetToolTip(btnSpeichern, "Spiel auf Dateisystem abspeichern")
        ToolTip1.SetToolTip(btnLaden, "Spiel aus Datei laden")
        ToolTip1.SetToolTip(btnLeeren, "Spielfeld leeren")
        ToolTip1.SetToolTip(btnHinweis, "Automatisches Lösen eines bereits eingegebenen oder evtl. geladenen Spielfeldes")
        ToolTip1.SetToolTip(btnErzeugen, "Erstellen eines neuen Spielfeldes mit Hilfe von Zufallszahlen")
        ToolTip1.SetToolTip(btnLösung, "Gesamtes Spiel lösen")
        ToolTip1.SetToolTip(btnFeldSingle, "Das Programm füllt automatisch alle Felder mit nur einer möglichen Zahl")
        ToolTip1.SetToolTip(btnZeilenSingle, "Das Programm füllt automatisch alle Felder, die innerhalb der Zeile einmalig sind")
        ToolTip1.SetToolTip(btnCarreeSingle, "Das Programm füllt automatisch alle Felder, die innerhalb des Neunerblocks (Carree) einmalig sind")
        ToolTip1.SetToolTip(btnSpaltenSingle, "Das Programm füllt automatisch alle Felder, die innerhalb der Spalte einmalig sind")
        ToolTip1.SetToolTip(CheckBoxZeileStreichen, "Bereits in der Zeile gesetzte Zahlen automatisch streichen")
        ToolTip1.SetToolTip(CheckBoxSpalteStreichen, "Bereits in der Spalte gesetzte Zahlen automatisch streichen")
        ToolTip1.SetToolTip(CheckBoxCarreeStreichen, "Bereits im Quadrat gesetzte Zahlen automatisch streichen")
        ToolTip1.SetToolTip(CheckBoxZwillingZeile, "Wenn zwei Felder der selben Zeile nur noch zwei gleiche mögliche Zahlen haben, diese Zahlen im Rest der Zeile streichen")
        ToolTip1.SetToolTip(CheckBoxZwillingSpalte, "Wenn zwei Felder der selben Spalte nur noch zwei gleiche mögliche Zahlen haben, diese Zahlen im Rest der Spalte streichen")
        ToolTip1.SetToolTip(CheckBoxZwillingCarree, "Wenn zwei Felder des selben Quadrats nur noch zwei gleiche mögliche Zahlen haben, diese Zahlen im Rest des Quadrats streichen")
        ToolTip1.SetToolTip(CheckBoxNurInEinerZeileImCarree, "Wenn in einem Quadrat eine Ziffer ausschliesslich in einer Zeile vorkommt, in der restlichen Zeile ausserhalb des Quadrats die gefundene Ziffer streichen")
        ToolTip1.SetToolTip(CheckBoxNurInEinerSpalteImCarree, "Wenn in einem Quadrat eine Ziffer ausschliesslich in einer Spalte vorkommt, in der restlichen Spalte ausserhalb des Quadrats die gefundene Ziffer streichen")
        ToolTip1.SetToolTip(CheckBoxVersteckterZwillingZeile, "Versteckter Zwilling Zeile")
        ToolTip1.SetToolTip(CheckBoxVersteckterZwillingSpalte, "Versteckter Zwilling Spalte")

        ToolTip1.SetToolTip(PanelHauptZahlenFeld, "Zahlen setzen durch durch Linksklick; Streichen durch Rechtsklick")
        Zeichnen()
    End Sub

    Sub Zeichnen()
        Disp.Zeichne(Spf)
    End Sub

    Sub SpfToSpfSave(ByVal pSpfSave(,) As Byte)
        Dim i, j As Byte

        For i = 1 To 9
            For j = 1 To 9
                SpfSave(i, j) = Spf.m_Feld(i, j).GetGesetzteZahl
            Next
        Next
    End Sub

    Sub SpfSaveToSpf(ByVal pSpfSave(,) As Byte)
        Dim i, j As Byte

        For i = 1 To 9
            For j = 1 To 9
                Spf.m_Feld(i, j).SetGesetzteZahl(SpfSave(i, j))
            Next
        Next
    End Sub

    Private Sub Hinweis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHinweis.Click
        Dim x, y As Byte
        Dim xx, yy, zahl As Byte
        Dim abbruch As Boolean = False
        Dim ergebnis As CSpielfeld.Spielzustand
        Dim i, j As Byte

        x = 1
        y = 1
        SpfToSpfSave(SpfSave)

        Spf.Bewerte()
        ergebnis = Spf.Search()
        If ergebnis = CSpielfeld.Spielzustand.KeineEinfacheLösung Then
            MsgBox("Lösung wird ausprobiert", MsgBoxStyle.OkOnly, "Information")
            While Not abbruch
                If Not Spf.FindNextFieldWithNPossibilities(2, x, y, xx, yy) Then
                    Zeichnen()
                    abbruch = True
                Else
                    If x = 9 Then
                        If y < 9 Then
                            y = yy + 1
                            x = 1
                        Else
                            abbruch = True
                        End If
                    Else
                        y = yy
                        x = xx + 1
                    End If
                    For zahl = 1 To 9
                        If Spf.m_Feld(xx, yy).MöglicheZahlen(zahl) Then
                            ' Spielfeldkopie 
                            SpfToSpfSave(SpfSave2)
                            ' Testweise Zahl setzen
                            Spf.m_Feld(xx, yy).SetGesetzteZahl(zahl)
                            Spf.m_Feld(xx, yy).MöglicheZahlen(zahl) = False
                            Dim Suchergebnis As Boolean
                            Suchergebnis = Spf.SearchToEnd()
                            ' Alten Spielstand wieder herstellen
                            SpfSaveToSpf(SpfSave2)
                            If Suchergebnis Then
                                Spf.m_Feld(xx, yy).SetGesetzteZahl(zahl)
                                abbruch = True
                            End If
                            Spf.Bewerte()
                            Zeichnen()
                        End If
                    Next
                End If
            End While
        ElseIf ergebnis = CSpielfeld.Spielzustand.unlösbar Then
            MsgBox("keine Lösung möglich", MsgBoxStyle.OkOnly, "Information")
            ' Alten Spielstand wieder herstellen
            For i = 1 To 9
                For j = 1 To 9
                    Spf.m_Feld(i, j).SetGesetzteZahl(SpfSave(i, j))
                Next
            Next
        Else
            Zeichnen()
        End If
    End Sub


    Private Sub Erzeugen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnErzeugen.Click
        Dim NSpf, TstSpf As New CSpielfeld
        Dim zahl As Byte
        Dim BerechneteSpielFelder As New Stack
        Const Retries = 7
        Dim CountdownDoubleBacktrack As Byte = Retries

        Dim OldCursor As Cursor

        OldCursor = Cursor
        Cursor = Cursors.WaitCursor

        'bis alle Zahlen besetzt
        Do
            ' Jede Ziffer getrennt verteilen
            For zahl = 1 To 9
                BerechneteSpielFelder.Push(NSpf)
                NSpf = New CSpielfeld(NSpf)
                If Not NSpf.VerteileZahl(zahl) Then
                    ' Wenn die Zahl nicht verteilt werden konnte dann backtracking
                    CountdownDoubleBacktrack -= 1
                    If CountdownDoubleBacktrack = 0 Then
                        BerechneteSpielFelder.Pop()
                        zahl -= 1
                        CountdownDoubleBacktrack = Retries
                    End If
                    NSpf = BerechneteSpielFelder.Pop()
                    zahl -= 1
                Else
                    CountdownDoubleBacktrack = Retries
                End If
            Next
        Loop Until NSpf.IsGelöst()
        NSpf.Trace()
        ' Lösung im Stack merken
        BerechneteSpielFelder.Clear()
        BerechneteSpielFelder.Push(NSpf)

        ' Ab hier Zahlen herausschiessen, bis es keine Lösung über Singlebestimmung mehr gibt
        Dim ZuLösendeZiffern
        ZuLösendeZiffern = 0
        Const kickRetryFactor = 1.1
        Dim kickRetry As Integer = 91 * kickRetryFactor
        CountdownDoubleBacktrack = kickRetry
        Do
            Dim SpielfeldUnique As Boolean
            SpielfeldUnique = True
            While SpielfeldUnique = True
                ' letzten Stand von Stack holen
                NSpf = BerechneteSpielFelder.Peek
                ' Kopie erzeugen
                NSpf = New CSpielfeld(NSpf)
                NSpf.KillFieldByRandom()
                ' Testspielfeld zur Manipulation durch Lösungsalgorithmus anlegen
                TstSpf = New CSpielfeld(NSpf)
                SpielfeldUnique = TstSpf.SearchToEnd()
                If SpielfeldUnique = True Then
                    BerechneteSpielFelder.Push(NSpf)
                    ZuLösendeZiffern += 1
                    kickRetry = (91 - ZuLösendeZiffern) * kickRetryFactor
                End If
            End While
            CountdownDoubleBacktrack -= 1
            ' zweites Backtracking, wenn neues KillFieldByRandom retries mal versagt
            If CountdownDoubleBacktrack = 0 Then
                NSpf = BerechneteSpielFelder.Pop
                CountdownDoubleBacktrack = kickRetry
                ZuLösendeZiffern -= 1
            End If
        Loop Until ZuLösendeZiffern >= 57
        NSpf = BerechneteSpielFelder.Pop

        Dim i, j As Integer
        Spf.init()
        For i = 1 To 9
            For j = 1 To 9
                Spf.m_Feld(i, j).SetGesetzteZahl(NSpf.m_Feld(i, j).GetGesetzteZahl)
            Next
        Next
        AutoStreichen()
        Zeichnen()
        Cursor = OldCursor
    End Sub

    Private Sub FeldSingle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFeldSingle.Click
        FeldSingle()
    End Sub

    Sub FeldSingle()
        If Not Spf.CheckSingleInField() Then
            'MsgBox("kein eindeutiges Feld gefunden", MsgBoxStyle.OkOnly, "Information")
        Else
            AutoStreichen()
            Zeichnen()
        End If
    End Sub

    Private Sub ZeilenSingle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnZeilenSingle.Click
        ZeilenSingle()
    End Sub

    Private Sub ZeilenSingle()
        If Not Spf.CheckSingleInZeile() Then
            'MsgBox("kein eindeutiges Feld in Zeile gefunden", MsgBoxStyle.OkOnly, "Information")
        Else
            AutoStreichen()
            Zeichnen()
        End If
    End Sub

    Private Sub SpaltenSingle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSpaltenSingle.Click
        SpaltenSingle()
    End Sub

    Private Sub SpaltenSingle()
        If Not Spf.CheckSingleInSpalte() Then
            'MsgBox("kein eindeutiges Feld in Spalte gefunden", MsgBoxStyle.OkOnly, "Information")
        Else
            AutoStreichen()
            Zeichnen()
        End If
    End Sub

    Private Sub CarreeSingle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCarreeSingle.Click
        CarreeSingle()
    End Sub

    Private Sub CarreeSingle()
        If Not Spf.CheckSingleInCarree() Then
            'MsgBox("kein eindeutiges Feld in Carree gefunden", MsgBoxStyle.OkOnly, "Information")
        Else
            AutoStreichen()
            Zeichnen()
        End If
    End Sub

    Private Sub Merken_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMerken.Click
        Merken()
    End Sub

    Private Sub Merken()
        Dim i, j As Byte

        ' Annahme
        For i = 1 To 9
            For j = 1 To 9
                SpfSavePoint(i, j) = Spf.m_Feld(i, j).GetGesetzteZahl
            Next
        Next

        btnHolen.Enabled = True
    End Sub

    Private Sub Holen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHolen.Click
        Holen()
    End Sub

    Private Sub Holen()
        Dim i, j, k As Byte

        'rückrollen
        Spf.init()
        For i = 1 To 9
            For j = 1 To 9
                If (SpfSavePoint(i, j) > 0) Then
                    Spf.m_Feld(i, j).SetGesetzteZahl(SpfSavePoint(i, j))
                    For k = 1 To 9
                        Spf.m_Feld(i, j).MöglicheZahlen(k) = False
                    Next
                End If
            Next
        Next
        AutoStreichen()
        Zeichnen()
    End Sub

    Private Sub Speichern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpeichern.Click
        Speichern()
    End Sub

    Private Sub Speichern()
        Dim result As DialogResult
        Dim fileStream As System.IO.Stream
        Dim buffer(81) As Byte
        Dim i, j As Integer

        result = SaveFileDialog1.ShowDialog()
        If (result = DialogResult.OK) Then
            fileStream = SaveFileDialog1.OpenFile()
            For i = 1 To 9
                For j = 1 To 9
                    buffer((i - 1) * 9 + (j - 1)) = Spf.m_Feld(i, j).GetGesetzteZahl
                Next
            Next
            fileStream.Write(buffer, 0, 81)
            fileStream.Close()
        End If
    End Sub

    Private Sub Laden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaden.Click
        Laden()
    End Sub

    Private Sub Laden()
        Dim result As DialogResult
        Dim fileStream As System.IO.Stream
        Dim buffer(81) As Byte
        Dim i, j As Integer

        result = OpenFileDialog1.ShowDialog()
        If (result = DialogResult.OK) Then
            fileStream = OpenFileDialog1.OpenFile()
            fileStream.Read(buffer, 0, 81)
            fileStream.Close()
            Spf.Init()
            For i = 1 To 9
                For j = 1 To 9
                    Spf.m_Feld(i, j).SetGesetzteZahl(buffer((i - 1) * 9 + (j - 1)))
                Next
            Next
            AutoStreichen()
            Zeichnen()
        End If
    End Sub

    Private Sub Leeren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeeren.Click
        Leeren()
    End Sub

    Private Sub Leeren()
        Dim i, j As Integer

        Spf.init()
        For i = 1 To 9
            For j = 1 To 9
                Spf.m_Feld(i, j).SetGesetzteZahl(0)
            Next
        Next
        Zeichnen()
    End Sub


    Private Sub Lösung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLösung.Click
        Lösung()
    End Sub

    Private Sub Lösung()
        Dim x, y As Byte
        Dim xx, yy, zahl As Byte
        Dim abbruch As Boolean = False
        Dim ergebnis As CSpielfeld.Spielzustand

        x = 1
        y = 1
        SpfToSpfSave(SpfSave)

        Spf.Bewerte()
        ergebnis = Spf.SearchToEnd()
        If ergebnis = False Then
            While Not abbruch
                If Not Spf.FindNextFieldWithNPossibilities(2, x, y, xx, yy) Then
                    MsgBox("Das Programm kann die Lösung nicht berechnen ", MsgBoxStyle.OkOnly, "Information")
                    abbruch = True
                    SpfSaveToSpf(SpfSave)
                    Zeichnen()
                Else
                    If x = 9 Then
                        If y < 9 Then
                            y = yy + 1
                            x = 1
                        Else
                            abbruch = True
                        End If
                    Else
                        y = yy
                        x = xx + 1
                    End If
                    For zahl = 1 To 9
                        If Spf.m_Feld(xx, yy).MöglicheZahlen(zahl) Then
                            SpfToSpfSave(SpfSave2)
                            ' Testweise Zahl setzen
                            Spf.m_Feld(xx, yy).SetGesetzteZahl(zahl)
                            Spf.m_Feld(xx, yy).MöglicheZahlen(zahl) = False
                            Dim Suchergebnis As Boolean
                            Suchergebnis = Spf.SearchToEnd()
                            If Suchergebnis Then
                                abbruch = True
                                Zeichnen()
                            Else
                                ' Alten Spielstand wieder herstellen
                                SpfSaveToSpf(SpfSave2)
                            End If
                            Spf.Bewerte()
                        End If
                    Next
                End If
            End While
        Else
            ' Einfache Lösung gefunden
            Zeichnen()
        End If
    End Sub

    Private Sub ZeileStreichen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZeileStreichen.Click
        ZeileStreichen()
        Zeichnen()
    End Sub

    Private Sub ZeileStreichen()
        Dim y As Byte

        For y = 1 To 9
            Spf.m_Zeile(y).GesetzteAusMöglichenStreichen()
            Spf.m_Zeile(y).GesetzteAusFeldernStreichen()
        Next
    End Sub

    Private Sub SpalteStreichen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpalteStreichen.Click
        SpalteStreichen()
        Zeichnen()
    End Sub

    Private Sub SpalteStreichen()
        Dim x As Byte

        For x = 1 To 9
            Spf.m_Spalte(x).GesetzteAusMöglichenStreichen()
            Spf.m_Spalte(x).GesetzteAusFeldernStreichen()
        Next
    End Sub

    Private Sub CarreeStreichen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarreeStreichen.Click
        CarreeStreichen()
        Zeichnen()
    End Sub

    Private Sub CarreeStreichen()
        Dim x, y As Byte

        For x = 1 To 3
            For y = 1 To 3
                Spf.m_Carree(x, y).GesetzteAusMöglichenStreichen()
                Spf.m_Carree(x, y).GesetzteAusFeldernStreichen()
            Next
        Next
    End Sub

    Private Sub AlleStrategieen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlleStrategieen.Click
        Spf.Bewerte()
        Zeichnen()
    End Sub

    Private Sub NurInEinerZeileImCarree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNurInEinerZeileImCarree.Click
        NurInEinerZeileImCarree()
        Zeichnen()
    End Sub

    Private Sub NurInEinerZeileImCarree()
        Spf.ZifferImCarreeNurInEinerZeile()
    End Sub

    Private Sub ZeilenZwilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZeilenZwilling.Click
        ZeilenZwilling()
        Zeichnen()
    End Sub

    Private Sub ZeilenZwilling()
        Spf.ZwillingeInZeile()
    End Sub

    Private Sub SpaltenZwilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpaltenZwilling.Click
        SpaltenZwilling()
        Zeichnen()
    End Sub

    Private Sub SpaltenZwilling()
        Spf.ZwillingeInSpalte()
    End Sub

    Private Sub NurInEinerSpalteImCarree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNurInEinerSpalteImCarree.Click
        NurInEinerSpalteImCarree()
        Zeichnen()
    End Sub

    Private Sub NurInEinerSpalteImCarree()
        Spf.ZifferImCarreeNurInEinerSpalte()
    End Sub

    Private Sub CarreeZwilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarreeZwilling.Click
        CarreeZwilling()
        Zeichnen()
    End Sub

    Private Sub CarreeZwilling()
        Spf.ZwillingImCarreeStreichen()
    End Sub

    Private Sub AusschliessendeGruppeZeile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAusschliessendeGruppeZeile.Click
        AusschliessendeGruppeInZeile()
        Zeichnen()
    End Sub

    Private Sub AusschliessendeGruppeInZeile()
        Spf.AusschliessendeGruppeInZeile()
    End Sub

    Private Sub AusschliessendeGruppeSpalte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAusschliessendeGruppeSpalte.Click
        AusschliessendeGruppeInSpalte()
        Zeichnen()
    End Sub

    Private Sub AusschliessendeGruppeInSpalte()
        Spf.AusschliessendeGruppeInSpalte()
    End Sub

    Private Sub AutoStreichen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxAutoStreichen.CheckedChanged
        If CheckBoxAutoStreichen.Checked = True Then
            CheckBoxZeileStreichen.Checked = True
            CheckBoxSpalteStreichen.Checked = True
            CheckBoxCarreeStreichen.Checked = True
            CheckBoxNurInEinerZeileImCarree.Checked = True
            CheckBoxNurInEinerSpalteImCarree.Checked = True
            CheckBoxZwillingCarree.Checked = True
            CheckBoxZwillingSpalte.Checked = True
            CheckBoxZwillingZeile.Checked = True
            CheckBoxVersteckterZwillingZeile.Checked = True
            CheckBoxVersteckterZwillingSpalte.Checked = True
        Else
            CheckBoxZeileStreichen.Checked = False
            CheckBoxSpalteStreichen.Checked = False
            CheckBoxCarreeStreichen.Checked = False
            CheckBoxNurInEinerZeileImCarree.Checked = False
            CheckBoxNurInEinerSpalteImCarree.Checked = False
            CheckBoxZwillingCarree.Checked = False
            CheckBoxZwillingSpalte.Checked = False
            CheckBoxZwillingZeile.Checked = False
            CheckBoxVersteckterZwillingZeile.Checked = False
            CheckBoxVersteckterZwillingSpalte.Checked = False

        End If
    End Sub

    Private Sub AutoStreichen()
        If CheckBoxZeileStreichen.Checked = True Then
            ZeileStreichen()
        End If
        If CheckBoxSpalteStreichen.Checked = True Then
            SpalteStreichen()
        End If
        If CheckBoxCarreeStreichen.Checked = True Then
            CarreeStreichen()
        End If
        If CheckBoxNurInEinerZeileImCarree.Checked = True Then
            NurInEinerZeileImCarree()
        End If
        If CheckBoxNurInEinerSpalteImCarree.Checked = True Then
            NurInEinerSpalteImCarree()
        End If
        If CheckBoxZwillingCarree.Checked = True Then

        End If
        If CheckBoxZwillingSpalte.Checked = True Then
            SpaltenZwilling()
        End If
        If CheckBoxZwillingZeile.Checked = True Then
            ZeilenZwilling()
        End If
        If CheckBoxVersteckterZwillingZeile.Checked = True Then
            AusschliessendeGruppeInZeile()
        End If
        If CheckBoxVersteckterZwillingSpalte.Checked = True Then
            AusschliessendeGruppeInSpalte()
        End If
    End Sub
End Class
