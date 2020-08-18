Public Class CAnzeige
    Public AnzFeld(9, 9, 10) As Windows.Forms.Label

    Sub Zeichne(ByVal pSpf As CSpielfeld)
        Dim i, j As Integer

        For i = 1 To 9
            For j = 1 To 9
               Zeichnen(pSpf.m_Feld(i, j), i, j)
            Next
        Next

    End Sub

    Sub Zeichnen(ByVal fld As CFeld, ByRef ispalte As Integer, ByRef izeile As Integer)
        Dim izahl As Integer

        If fld.GetGesetzteZahl = 0 Then
            For izahl = 1 To 9
                AnzFeld(ispalte, izeile, izahl).BackColor = Color.LightGray
                If fld.Mark(izahl) = 1 And AnzFeld(ispalte, izeile, izahl).Text <> " " Then
                    AnzFeld(ispalte, izeile, izahl).BackColor = Color.FromArgb(255, 192, 192)
                End If
                If fld.Mark(izahl) = 2 And AnzFeld(ispalte, izeile, izahl).Text <> " " Then
                    AnzFeld(ispalte, izeile, izahl).BackColor = Color.FromArgb(255, 128, 128)
                End If
                If fld.Mark(izahl) = 3 And AnzFeld(ispalte, izeile, izahl).Text <> " " Then
                    AnzFeld(ispalte, izeile, izahl).BackColor = Color.Red
                End If
                If fld.Mark(izahl) = 4 And AnzFeld(ispalte, izeile, izahl).Text <> " " Then
                    AnzFeld(ispalte, izeile, izahl).BackColor = Color.FromArgb(255, 255, 192)
                End If
                If fld.Mark(izahl) = 5 And AnzFeld(ispalte, izeile, izahl).Text <> " " Then
                    AnzFeld(ispalte, izeile, izahl).BackColor = Color.FromArgb(255, 255, 128)
                End If
                If fld.Mark(izahl) = 6 And AnzFeld(ispalte, izeile, izahl).Text <> " " Then
                    AnzFeld(ispalte, izeile, izahl).BackColor = Color.Yellow
                End If
                If fld.Mark(izahl) = 7 And AnzFeld(ispalte, izeile, izahl).Text <> " " Then
                    AnzFeld(ispalte, izeile, izahl).BackColor = Color.FromArgb(192, 255, 192)
                End If
                If fld.Mark(izahl) = 8 And AnzFeld(ispalte, izeile, izahl).Text <> " " Then
                    AnzFeld(ispalte, izeile, izahl).BackColor = Color.FromArgb(128, 255, 128)
                End If
                If fld.Mark(izahl) = 9 And AnzFeld(ispalte, izeile, izahl).Text <> " " Then
                    AnzFeld(ispalte, izeile, izahl).BackColor = Color.FromArgb(192, 255, 255)
                End If
                If fld.Mark(izahl) = 10 And AnzFeld(ispalte, izeile, izahl).Text <> " " Then
                    AnzFeld(ispalte, izeile, izahl).BackColor = Color.FromArgb(128, 255, 255)
                End If
                If fld.Mark(izahl) = 11 And AnzFeld(ispalte, izeile, izahl).Text <> " " Then
                    AnzFeld(ispalte, izeile, izahl).BackColor = Color.Cyan
                End If
                fld.Mark(izahl) = 0
                If fld.MöglicheZahlen(izahl) = True Then
                    AnzFeld(ispalte, izeile, izahl).Text = izahl
                Else
                    AnzFeld(ispalte, izeile, izahl).Text = " "
                End If
                AnzFeld(ispalte, izeile, izahl).Visible = True
                AnzFeld(ispalte, izeile, izahl).BringToFront()
            Next
            AnzFeld(ispalte, izeile, 10).Visible = False
            AnzFeld(ispalte, izeile, 10).Text = " "
        Else
            For izahl = 1 To 9
                AnzFeld(ispalte, izeile, izahl).Visible = False
            Next
            If AnzFeld(ispalte, izeile, 10).Text <> " " Then
                AnzFeld(ispalte, izeile, 10).BackColor = Color.AliceBlue
                AnzFeld(ispalte, izeile, 10).ForeColor = Color.Black
            Else
                AnzFeld(ispalte, izeile, 10).BackColor = Color.AliceBlue
                AnzFeld(ispalte, izeile, 10).ForeColor = Color.DarkOrange
            End If
            AnzFeld(ispalte, izeile, 10).Text = fld.GetGesetzteZahl.ToString()
            AnzFeld(ispalte, izeile, 10).Visible = True
            AnzFeld(ispalte, izeile, 10).BringToFront()
        End If
    End Sub

End Class
