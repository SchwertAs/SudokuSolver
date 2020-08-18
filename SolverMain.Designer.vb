<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnHinweis = New System.Windows.Forms.Button
        Me.btnErzeugen = New System.Windows.Forms.Button
        Me.btnFeldSingle = New System.Windows.Forms.Button
        Me.btnZeilenSingle = New System.Windows.Forms.Button
        Me.btnSpaltenSingle = New System.Windows.Forms.Button
        Me.btnCarreeSingle = New System.Windows.Forms.Button
        Me.PanelHauptZahlenFeld = New System.Windows.Forms.Panel
        Me.btnMerken = New System.Windows.Forms.Button
        Me.btnHolen = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btnSpeichern = New System.Windows.Forms.Button
        Me.btnLaden = New System.Windows.Forms.Button
        Me.btnLeeren = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBoxSingles = New System.Windows.Forms.GroupBox
        Me.GroupBoxDaten = New System.Windows.Forms.GroupBox
        Me.GroupBoxSudoku = New System.Windows.Forms.GroupBox
        Me.btnLösung = New System.Windows.Forms.Button
        Me.btnZeileStreichen = New System.Windows.Forms.Button
        Me.GroupBoxStreichen1 = New System.Windows.Forms.GroupBox
        Me.btnCarreeStreichen = New System.Windows.Forms.Button
        Me.btnSpalteStreichen = New System.Windows.Forms.Button
        Me.AlleStrategieen = New System.Windows.Forms.Button
        Me.GroupBoxStreichen2 = New System.Windows.Forms.GroupBox
        Me.btnZeilenZwilling = New System.Windows.Forms.Button
        Me.btnSpaltenZwilling = New System.Windows.Forms.Button
        Me.btnCarreeZwilling = New System.Windows.Forms.Button
        Me.btnNurInEinerZeileImCarree = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GroupBoxStreichen3 = New System.Windows.Forms.GroupBox
        Me.btnNurInEinerSpalteImCarree = New System.Windows.Forms.Button
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.GroupBoxStreichen4 = New System.Windows.Forms.GroupBox
        Me.btnAusschliessendeGruppeSpalte = New System.Windows.Forms.Button
        Me.btnAusschliessendeGruppeZeile = New System.Windows.Forms.Button
        Me.GroupBoxGestrichenWeil = New System.Windows.Forms.GroupBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CheckBoxAutoStreichen = New System.Windows.Forms.CheckBox
        Me.CheckBoxZeileStreichen = New System.Windows.Forms.CheckBox
        Me.CheckBoxSpalteStreichen = New System.Windows.Forms.CheckBox
        Me.CheckBoxZwillingZeile = New System.Windows.Forms.CheckBox
        Me.CheckBoxCarreeStreichen = New System.Windows.Forms.CheckBox
        Me.CheckBoxNurInEinerSpalteImCarree = New System.Windows.Forms.CheckBox
        Me.CheckBoxNurInEinerZeileImCarree = New System.Windows.Forms.CheckBox
        Me.CheckBoxZwillingCarree = New System.Windows.Forms.CheckBox
        Me.CheckBoxZwillingSpalte = New System.Windows.Forms.CheckBox
        Me.CheckBoxVersteckterZwillingSpalte = New System.Windows.Forms.CheckBox
        Me.CheckBoxVersteckterZwillingZeile = New System.Windows.Forms.CheckBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBoxSingles.SuspendLayout()
        Me.GroupBoxDaten.SuspendLayout()
        Me.GroupBoxSudoku.SuspendLayout()
        Me.GroupBoxStreichen1.SuspendLayout()
        Me.GroupBoxStreichen2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBoxStreichen3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBoxStreichen4.SuspendLayout()
        Me.GroupBoxGestrichenWeil.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHinweis
        '
        Me.btnHinweis.Location = New System.Drawing.Point(87, 19)
        Me.btnHinweis.Name = "btnHinweis"
        Me.btnHinweis.Size = New System.Drawing.Size(67, 23)
        Me.btnHinweis.TabIndex = 0
        Me.btnHinweis.Text = "Hinweis"
        Me.btnHinweis.UseVisualStyleBackColor = True
        '
        'btnErzeugen
        '
        Me.btnErzeugen.Location = New System.Drawing.Point(10, 47)
        Me.btnErzeugen.Name = "btnErzeugen"
        Me.btnErzeugen.Size = New System.Drawing.Size(68, 23)
        Me.btnErzeugen.TabIndex = 2
        Me.btnErzeugen.Text = "Erzeugen"
        Me.btnErzeugen.UseVisualStyleBackColor = True
        '
        'btnFeldSingle
        '
        Me.btnFeldSingle.Location = New System.Drawing.Point(10, 19)
        Me.btnFeldSingle.Name = "btnFeldSingle"
        Me.btnFeldSingle.Size = New System.Drawing.Size(68, 23)
        Me.btnFeldSingle.TabIndex = 4
        Me.btnFeldSingle.Text = "Feld"
        Me.btnFeldSingle.UseVisualStyleBackColor = True
        '
        'btnZeilenSingle
        '
        Me.btnZeilenSingle.Location = New System.Drawing.Point(87, 19)
        Me.btnZeilenSingle.Name = "btnZeilenSingle"
        Me.btnZeilenSingle.Size = New System.Drawing.Size(67, 23)
        Me.btnZeilenSingle.TabIndex = 5
        Me.btnZeilenSingle.Text = "Zeile"
        Me.btnZeilenSingle.UseVisualStyleBackColor = True
        '
        'btnSpaltenSingle
        '
        Me.btnSpaltenSingle.Location = New System.Drawing.Point(87, 48)
        Me.btnSpaltenSingle.Name = "btnSpaltenSingle"
        Me.btnSpaltenSingle.Size = New System.Drawing.Size(67, 23)
        Me.btnSpaltenSingle.TabIndex = 6
        Me.btnSpaltenSingle.Text = "Spalte"
        Me.btnSpaltenSingle.UseVisualStyleBackColor = True
        '
        'btnCarreeSingle
        '
        Me.btnCarreeSingle.Location = New System.Drawing.Point(10, 47)
        Me.btnCarreeSingle.Name = "btnCarreeSingle"
        Me.btnCarreeSingle.Size = New System.Drawing.Size(68, 23)
        Me.btnCarreeSingle.TabIndex = 7
        Me.btnCarreeSingle.Text = "Quadrat"
        Me.btnCarreeSingle.UseVisualStyleBackColor = True
        '
        'PanelHauptZahlenFeld
        '
        Me.PanelHauptZahlenFeld.BackColor = System.Drawing.SystemColors.ControlText
        Me.PanelHauptZahlenFeld.Location = New System.Drawing.Point(11, 3)
        Me.PanelHauptZahlenFeld.Name = "PanelHauptZahlenFeld"
        Me.PanelHauptZahlenFeld.Size = New System.Drawing.Size(700, 700)
        Me.PanelHauptZahlenFeld.TabIndex = 8
        '
        'btnMerken
        '
        Me.btnMerken.AccessibleDescription = ""
        Me.btnMerken.Location = New System.Drawing.Point(10, 19)
        Me.btnMerken.Name = "btnMerken"
        Me.btnMerken.Size = New System.Drawing.Size(68, 23)
        Me.btnMerken.TabIndex = 9
        Me.btnMerken.Text = "Merken"
        Me.btnMerken.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMerken.UseVisualStyleBackColor = True
        '
        'btnHolen
        '
        Me.btnHolen.Enabled = False
        Me.btnHolen.Location = New System.Drawing.Point(87, 19)
        Me.btnHolen.Name = "btnHolen"
        Me.btnHolen.Size = New System.Drawing.Size(67, 23)
        Me.btnHolen.TabIndex = 10
        Me.btnHolen.Text = "Holen"
        Me.btnHolen.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "sku"
        Me.SaveFileDialog1.FileName = "Spiel1"
        Me.SaveFileDialog1.Filter = "Sudoku Dateien (*.sku)|*.sku"
        Me.SaveFileDialog1.RestoreDirectory = True
        Me.SaveFileDialog1.Title = "Spiel abspeichern"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "sku"
        Me.OpenFileDialog1.FileName = "Spiel1"
        Me.OpenFileDialog1.Filter = "Sudoku Dateien (*.sku)|*.sku"
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(10, 48)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(68, 23)
        Me.btnSpeichern.TabIndex = 11
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'btnLaden
        '
        Me.btnLaden.Location = New System.Drawing.Point(87, 48)
        Me.btnLaden.Name = "btnLaden"
        Me.btnLaden.Size = New System.Drawing.Size(67, 23)
        Me.btnLaden.TabIndex = 12
        Me.btnLaden.Text = "Laden"
        Me.btnLaden.UseVisualStyleBackColor = True
        '
        'btnLeeren
        '
        Me.btnLeeren.Location = New System.Drawing.Point(10, 19)
        Me.btnLeeren.Name = "btnLeeren"
        Me.btnLeeren.Size = New System.Drawing.Size(68, 23)
        Me.btnLeeren.TabIndex = 15
        Me.btnLeeren.Text = "Leeren"
        Me.btnLeeren.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        '
        'GroupBoxSingles
        '
        Me.GroupBoxSingles.Controls.Add(Me.btnCarreeSingle)
        Me.GroupBoxSingles.Controls.Add(Me.btnSpaltenSingle)
        Me.GroupBoxSingles.Controls.Add(Me.btnZeilenSingle)
        Me.GroupBoxSingles.Controls.Add(Me.btnFeldSingle)
        Me.GroupBoxSingles.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBoxSingles.Location = New System.Drawing.Point(719, 179)
        Me.GroupBoxSingles.Name = "GroupBoxSingles"
        Me.GroupBoxSingles.Size = New System.Drawing.Size(165, 81)
        Me.GroupBoxSingles.TabIndex = 16
        Me.GroupBoxSingles.TabStop = False
        Me.GroupBoxSingles.Text = "Singles finden in"
        Me.ToolTip1.SetToolTip(Me.GroupBoxSingles, "Zonen mit eindeutigen Setzmöglichkeiten finden")
        '
        'GroupBoxDaten
        '
        Me.GroupBoxDaten.Controls.Add(Me.btnLaden)
        Me.GroupBoxDaten.Controls.Add(Me.btnSpeichern)
        Me.GroupBoxDaten.Controls.Add(Me.btnMerken)
        Me.GroupBoxDaten.Controls.Add(Me.btnHolen)
        Me.GroupBoxDaten.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBoxDaten.Location = New System.Drawing.Point(719, 3)
        Me.GroupBoxDaten.Name = "GroupBoxDaten"
        Me.GroupBoxDaten.Size = New System.Drawing.Size(165, 81)
        Me.GroupBoxDaten.TabIndex = 17
        Me.GroupBoxDaten.TabStop = False
        Me.GroupBoxDaten.Text = "Daten"
        Me.ToolTip1.SetToolTip(Me.GroupBoxDaten, "Spielstände verwalten")
        '
        'GroupBoxSudoku
        '
        Me.GroupBoxSudoku.Controls.Add(Me.btnLösung)
        Me.GroupBoxSudoku.Controls.Add(Me.btnLeeren)
        Me.GroupBoxSudoku.Controls.Add(Me.btnHinweis)
        Me.GroupBoxSudoku.Controls.Add(Me.btnErzeugen)
        Me.GroupBoxSudoku.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBoxSudoku.Location = New System.Drawing.Point(719, 91)
        Me.GroupBoxSudoku.Name = "GroupBoxSudoku"
        Me.GroupBoxSudoku.Size = New System.Drawing.Size(165, 81)
        Me.GroupBoxSudoku.TabIndex = 18
        Me.GroupBoxSudoku.TabStop = False
        Me.GroupBoxSudoku.Text = "Sudoku"
        Me.ToolTip1.SetToolTip(Me.GroupBoxSudoku, "Funktionen zur Bearbeitung des gesamten Spielfeldes")
        '
        'btnLösung
        '
        Me.btnLösung.Location = New System.Drawing.Point(87, 47)
        Me.btnLösung.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLösung.Name = "btnLösung"
        Me.btnLösung.Size = New System.Drawing.Size(67, 23)
        Me.btnLösung.TabIndex = 16
        Me.btnLösung.Text = "Lösung"
        Me.btnLösung.UseVisualStyleBackColor = True
        '
        'btnZeileStreichen
        '
        Me.btnZeileStreichen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnZeileStreichen.Location = New System.Drawing.Point(5, 19)
        Me.btnZeileStreichen.Name = "btnZeileStreichen"
        Me.btnZeileStreichen.Size = New System.Drawing.Size(60, 23)
        Me.btnZeileStreichen.TabIndex = 16
        Me.btnZeileStreichen.Text = "Zeile"
        Me.btnZeileStreichen.UseVisualStyleBackColor = False
        '
        'GroupBoxStreichen1
        '
        Me.GroupBoxStreichen1.Controls.Add(Me.btnCarreeStreichen)
        Me.GroupBoxStreichen1.Controls.Add(Me.btnSpalteStreichen)
        Me.GroupBoxStreichen1.Controls.Add(Me.btnZeileStreichen)
        Me.GroupBoxStreichen1.Location = New System.Drawing.Point(4, 21)
        Me.GroupBoxStreichen1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxStreichen1.Name = "GroupBoxStreichen1"
        Me.GroupBoxStreichen1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxStreichen1.Size = New System.Drawing.Size(199, 47)
        Me.GroupBoxStreichen1.TabIndex = 19
        Me.GroupBoxStreichen1.TabStop = False
        Me.GroupBoxStreichen1.Text = "gesetzter Zahlen aus"
        '
        'btnCarreeStreichen
        '
        Me.btnCarreeStreichen.BackColor = System.Drawing.Color.Red
        Me.btnCarreeStreichen.Location = New System.Drawing.Point(134, 19)
        Me.btnCarreeStreichen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCarreeStreichen.Name = "btnCarreeStreichen"
        Me.btnCarreeStreichen.Size = New System.Drawing.Size(60, 23)
        Me.btnCarreeStreichen.TabIndex = 18
        Me.btnCarreeStreichen.Text = "Quadrat"
        Me.btnCarreeStreichen.UseVisualStyleBackColor = False
        '
        'btnSpalteStreichen
        '
        Me.btnSpalteStreichen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSpalteStreichen.Location = New System.Drawing.Point(69, 19)
        Me.btnSpalteStreichen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpalteStreichen.Name = "btnSpalteStreichen"
        Me.btnSpalteStreichen.Size = New System.Drawing.Size(60, 23)
        Me.btnSpalteStreichen.TabIndex = 17
        Me.btnSpalteStreichen.Text = "Spalte"
        Me.btnSpalteStreichen.UseVisualStyleBackColor = False
        '
        'AlleStrategieen
        '
        Me.AlleStrategieen.Location = New System.Drawing.Point(4, 17)
        Me.AlleStrategieen.Margin = New System.Windows.Forms.Padding(2)
        Me.AlleStrategieen.Name = "AlleStrategieen"
        Me.AlleStrategieen.Size = New System.Drawing.Size(126, 23)
        Me.AlleStrategieen.TabIndex = 19
        Me.AlleStrategieen.Text = "allen Strategieen"
        Me.AlleStrategieen.UseVisualStyleBackColor = True
        '
        'GroupBoxStreichen2
        '
        Me.GroupBoxStreichen2.Controls.Add(Me.btnZeilenZwilling)
        Me.GroupBoxStreichen2.Controls.Add(Me.btnSpaltenZwilling)
        Me.GroupBoxStreichen2.Controls.Add(Me.btnCarreeZwilling)
        Me.GroupBoxStreichen2.Location = New System.Drawing.Point(411, 21)
        Me.GroupBoxStreichen2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxStreichen2.Name = "GroupBoxStreichen2"
        Me.GroupBoxStreichen2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxStreichen2.Size = New System.Drawing.Size(200, 47)
        Me.GroupBoxStreichen2.TabIndex = 20
        Me.GroupBoxStreichen2.TabStop = False
        Me.GroupBoxStreichen2.Text = "Zwilling in"
        '
        'btnZeilenZwilling
        '
        Me.btnZeilenZwilling.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnZeilenZwilling.Location = New System.Drawing.Point(4, 19)
        Me.btnZeilenZwilling.Margin = New System.Windows.Forms.Padding(2)
        Me.btnZeilenZwilling.Name = "btnZeilenZwilling"
        Me.btnZeilenZwilling.Size = New System.Drawing.Size(60, 23)
        Me.btnZeilenZwilling.TabIndex = 3
        Me.btnZeilenZwilling.Text = "Zeile"
        Me.btnZeilenZwilling.UseVisualStyleBackColor = False
        '
        'btnSpaltenZwilling
        '
        Me.btnSpaltenZwilling.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSpaltenZwilling.Location = New System.Drawing.Point(69, 19)
        Me.btnSpaltenZwilling.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSpaltenZwilling.Name = "btnSpaltenZwilling"
        Me.btnSpaltenZwilling.Size = New System.Drawing.Size(60, 23)
        Me.btnSpaltenZwilling.TabIndex = 2
        Me.btnSpaltenZwilling.Text = "Spalte"
        Me.btnSpaltenZwilling.UseVisualStyleBackColor = False
        '
        'btnCarreeZwilling
        '
        Me.btnCarreeZwilling.BackColor = System.Drawing.Color.Yellow
        Me.btnCarreeZwilling.Location = New System.Drawing.Point(134, 19)
        Me.btnCarreeZwilling.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCarreeZwilling.Name = "btnCarreeZwilling"
        Me.btnCarreeZwilling.Size = New System.Drawing.Size(60, 23)
        Me.btnCarreeZwilling.TabIndex = 1
        Me.btnCarreeZwilling.Text = "Quadrat"
        Me.btnCarreeZwilling.UseVisualStyleBackColor = False
        '
        'btnNurInEinerZeileImCarree
        '
        Me.btnNurInEinerZeileImCarree.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNurInEinerZeileImCarree.Location = New System.Drawing.Point(28, 19)
        Me.btnNurInEinerZeileImCarree.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNurInEinerZeileImCarree.Name = "btnNurInEinerZeileImCarree"
        Me.btnNurInEinerZeileImCarree.Size = New System.Drawing.Size(60, 23)
        Me.btnNurInEinerZeileImCarree.TabIndex = 0
        Me.btnNurInEinerZeileImCarree.Text = "Zeile"
        Me.btnNurInEinerZeileImCarree.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.AlleStrategieen)
        Me.GroupBox6.Location = New System.Drawing.Point(719, 565)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Size = New System.Drawing.Size(165, 50)
        Me.GroupBox6.TabIndex = 21
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Streichen mit"
        '
        'GroupBoxStreichen3
        '
        Me.GroupBoxStreichen3.Controls.Add(Me.btnNurInEinerSpalteImCarree)
        Me.GroupBoxStreichen3.Controls.Add(Me.btnNurInEinerZeileImCarree)
        Me.GroupBoxStreichen3.Location = New System.Drawing.Point(207, 21)
        Me.GroupBoxStreichen3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxStreichen3.Name = "GroupBoxStreichen3"
        Me.GroupBoxStreichen3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxStreichen3.Size = New System.Drawing.Size(200, 47)
        Me.GroupBoxStreichen3.TabIndex = 22
        Me.GroupBoxStreichen3.TabStop = False
        Me.GroupBoxStreichen3.Text = "Ziffer im Quadrat nur in"
        '
        'btnNurInEinerSpalteImCarree
        '
        Me.btnNurInEinerSpalteImCarree.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNurInEinerSpalteImCarree.Location = New System.Drawing.Point(114, 19)
        Me.btnNurInEinerSpalteImCarree.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNurInEinerSpalteImCarree.Name = "btnNurInEinerSpalteImCarree"
        Me.btnNurInEinerSpalteImCarree.Size = New System.Drawing.Size(60, 23)
        Me.btnNurInEinerSpalteImCarree.TabIndex = 24
        Me.btnNurInEinerSpalteImCarree.Text = "Spalte"
        Me.btnNurInEinerSpalteImCarree.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.GroupBoxStreichen4)
        Me.GroupBox8.Controls.Add(Me.GroupBoxStreichen1)
        Me.GroupBox8.Controls.Add(Me.GroupBoxStreichen3)
        Me.GroupBox8.Controls.Add(Me.GroupBoxStreichen2)
        Me.GroupBox8.Location = New System.Drawing.Point(3, 708)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Size = New System.Drawing.Size(822, 76)
        Me.GroupBox8.TabIndex = 23
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Streichen wegen"
        '
        'GroupBoxStreichen4
        '
        Me.GroupBoxStreichen4.Controls.Add(Me.btnAusschliessendeGruppeSpalte)
        Me.GroupBoxStreichen4.Controls.Add(Me.btnAusschliessendeGruppeZeile)
        Me.GroupBoxStreichen4.Location = New System.Drawing.Point(615, 21)
        Me.GroupBoxStreichen4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxStreichen4.Name = "GroupBoxStreichen4"
        Me.GroupBoxStreichen4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxStreichen4.Size = New System.Drawing.Size(199, 47)
        Me.GroupBoxStreichen4.TabIndex = 23
        Me.GroupBoxStreichen4.TabStop = False
        Me.GroupBoxStreichen4.Text = "Ausschliessende Gruppe in"
        '
        'btnAusschliessendeGruppeSpalte
        '
        Me.btnAusschliessendeGruppeSpalte.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAusschliessendeGruppeSpalte.Location = New System.Drawing.Point(120, 18)
        Me.btnAusschliessendeGruppeSpalte.Name = "btnAusschliessendeGruppeSpalte"
        Me.btnAusschliessendeGruppeSpalte.Size = New System.Drawing.Size(59, 23)
        Me.btnAusschliessendeGruppeSpalte.TabIndex = 1
        Me.btnAusschliessendeGruppeSpalte.Text = "Spalte"
        Me.btnAusschliessendeGruppeSpalte.UseVisualStyleBackColor = False
        '
        'btnAusschliessendeGruppeZeile
        '
        Me.btnAusschliessendeGruppeZeile.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAusschliessendeGruppeZeile.Location = New System.Drawing.Point(25, 18)
        Me.btnAusschliessendeGruppeZeile.Name = "btnAusschliessendeGruppeZeile"
        Me.btnAusschliessendeGruppeZeile.Size = New System.Drawing.Size(59, 23)
        Me.btnAusschliessendeGruppeZeile.TabIndex = 0
        Me.btnAusschliessendeGruppeZeile.Text = "Zeile"
        Me.btnAusschliessendeGruppeZeile.UseVisualStyleBackColor = False
        '
        'GroupBoxGestrichenWeil
        '
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label21)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label20)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label18)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label17)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label16)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label15)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label14)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label13)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label12)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label11)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label10)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label9)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label8)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label7)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label6)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label5)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label4)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label3)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label2)
        Me.GroupBoxGestrichenWeil.Controls.Add(Me.Label1)
        Me.GroupBoxGestrichenWeil.Location = New System.Drawing.Point(749, 266)
        Me.GroupBoxGestrichenWeil.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxGestrichenWeil.Name = "GroupBoxGestrichenWeil"
        Me.GroupBoxGestrichenWeil.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxGestrichenWeil.Size = New System.Drawing.Size(135, 249)
        Me.GroupBoxGestrichenWeil.TabIndex = 24
        Me.GroupBoxGestrichenWeil.TabStop = False
        Me.GroupBoxGestrichenWeil.Text = "Gestrichen weil"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(23, 224)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(111, 13)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "Auschlies. Grp. Spalte"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(23, 201)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 13)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Auschlies. Grp. Zeile"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(6, 224)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 14)
        Me.Label18.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 178)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(101, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Alle Ziffern in Spalte"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(23, 155)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Alle Ziffern in Zeile"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(6, 201)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 14)
        Me.Label15.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(6, 178)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 14)
        Me.Label14.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 134)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Zwilling in Quadrat"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 112)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Zwilling in Spalte"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 89)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Zwilling in Zeile"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(6, 155)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 14)
        Me.Label10.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(6, 134)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 14)
        Me.Label9.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 67)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Zahl gesetzt in Quadrat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 45)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Zahl gesetzt in Spalte"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Zahl gesetzt in Zeile"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 112)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 14)
        Me.Label5.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 89)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 14)
        Me.Label4.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(6, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 14)
        Me.Label3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 14)
        Me.Label2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 14)
        Me.Label1.TabIndex = 0
        '
        'CheckBoxAutoStreichen
        '
        Me.CheckBoxAutoStreichen.AutoSize = True
        Me.CheckBoxAutoStreichen.Location = New System.Drawing.Point(729, 543)
        Me.CheckBoxAutoStreichen.Name = "CheckBoxAutoStreichen"
        Me.CheckBoxAutoStreichen.Size = New System.Drawing.Size(162, 17)
        Me.CheckBoxAutoStreichen.TabIndex = 25
        Me.CheckBoxAutoStreichen.Text = "Alle / keine Autom. streichen"
        Me.CheckBoxAutoStreichen.UseVisualStyleBackColor = True
        '
        'CheckBoxZeileStreichen
        '
        Me.CheckBoxZeileStreichen.AutoSize = True
        Me.CheckBoxZeileStreichen.Location = New System.Drawing.Point(729, 287)
        Me.CheckBoxZeileStreichen.Name = "CheckBoxZeileStreichen"
        Me.CheckBoxZeileStreichen.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxZeileStreichen.TabIndex = 26
        Me.CheckBoxZeileStreichen.UseVisualStyleBackColor = True
        '
        'CheckBoxSpalteStreichen
        '
        Me.CheckBoxSpalteStreichen.AutoSize = True
        Me.CheckBoxSpalteStreichen.Location = New System.Drawing.Point(729, 310)
        Me.CheckBoxSpalteStreichen.Name = "CheckBoxSpalteStreichen"
        Me.CheckBoxSpalteStreichen.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxSpalteStreichen.TabIndex = 27
        Me.CheckBoxSpalteStreichen.UseVisualStyleBackColor = True
        '
        'CheckBoxZwillingZeile
        '
        Me.CheckBoxZwillingZeile.AutoSize = True
        Me.CheckBoxZwillingZeile.Location = New System.Drawing.Point(729, 354)
        Me.CheckBoxZwillingZeile.Name = "CheckBoxZwillingZeile"
        Me.CheckBoxZwillingZeile.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxZwillingZeile.TabIndex = 29
        Me.CheckBoxZwillingZeile.UseVisualStyleBackColor = True
        '
        'CheckBoxCarreeStreichen
        '
        Me.CheckBoxCarreeStreichen.AutoSize = True
        Me.CheckBoxCarreeStreichen.Location = New System.Drawing.Point(729, 332)
        Me.CheckBoxCarreeStreichen.Name = "CheckBoxCarreeStreichen"
        Me.CheckBoxCarreeStreichen.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxCarreeStreichen.TabIndex = 28
        Me.CheckBoxCarreeStreichen.UseVisualStyleBackColor = True
        '
        'CheckBoxNurInEinerSpalteImCarree
        '
        Me.CheckBoxNurInEinerSpalteImCarree.AutoSize = True
        Me.CheckBoxNurInEinerSpalteImCarree.Location = New System.Drawing.Point(729, 444)
        Me.CheckBoxNurInEinerSpalteImCarree.Name = "CheckBoxNurInEinerSpalteImCarree"
        Me.CheckBoxNurInEinerSpalteImCarree.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxNurInEinerSpalteImCarree.TabIndex = 33
        Me.CheckBoxNurInEinerSpalteImCarree.UseVisualStyleBackColor = True
        '
        'CheckBoxNurInEinerZeileImCarree
        '
        Me.CheckBoxNurInEinerZeileImCarree.AutoSize = True
        Me.CheckBoxNurInEinerZeileImCarree.Location = New System.Drawing.Point(729, 421)
        Me.CheckBoxNurInEinerZeileImCarree.Name = "CheckBoxNurInEinerZeileImCarree"
        Me.CheckBoxNurInEinerZeileImCarree.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxNurInEinerZeileImCarree.TabIndex = 32
        Me.CheckBoxNurInEinerZeileImCarree.UseVisualStyleBackColor = True
        '
        'CheckBoxZwillingCarree
        '
        Me.CheckBoxZwillingCarree.AutoSize = True
        Me.CheckBoxZwillingCarree.Location = New System.Drawing.Point(729, 399)
        Me.CheckBoxZwillingCarree.Name = "CheckBoxZwillingCarree"
        Me.CheckBoxZwillingCarree.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxZwillingCarree.TabIndex = 31
        Me.CheckBoxZwillingCarree.UseVisualStyleBackColor = True
        '
        'CheckBoxZwillingSpalte
        '
        Me.CheckBoxZwillingSpalte.AutoSize = True
        Me.CheckBoxZwillingSpalte.Location = New System.Drawing.Point(729, 377)
        Me.CheckBoxZwillingSpalte.Name = "CheckBoxZwillingSpalte"
        Me.CheckBoxZwillingSpalte.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxZwillingSpalte.TabIndex = 30
        Me.CheckBoxZwillingSpalte.UseVisualStyleBackColor = True
        '
        'CheckBoxVersteckterZwillingSpalte
        '
        Me.CheckBoxVersteckterZwillingSpalte.AutoSize = True
        Me.CheckBoxVersteckterZwillingSpalte.Location = New System.Drawing.Point(729, 490)
        Me.CheckBoxVersteckterZwillingSpalte.Name = "CheckBoxVersteckterZwillingSpalte"
        Me.CheckBoxVersteckterZwillingSpalte.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxVersteckterZwillingSpalte.TabIndex = 35
        Me.CheckBoxVersteckterZwillingSpalte.UseVisualStyleBackColor = True
        '
        'CheckBoxVersteckterZwillingZeile
        '
        Me.CheckBoxVersteckterZwillingZeile.AutoSize = True
        Me.CheckBoxVersteckterZwillingZeile.Location = New System.Drawing.Point(729, 466)
        Me.CheckBoxVersteckterZwillingZeile.Name = "CheckBoxVersteckterZwillingZeile"
        Me.CheckBoxVersteckterZwillingZeile.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxVersteckterZwillingZeile.TabIndex = 34
        Me.CheckBoxVersteckterZwillingZeile.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(723, 271)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(29, 13)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "Auto"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 796)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.CheckBoxVersteckterZwillingSpalte)
        Me.Controls.Add(Me.CheckBoxVersteckterZwillingZeile)
        Me.Controls.Add(Me.CheckBoxNurInEinerSpalteImCarree)
        Me.Controls.Add(Me.CheckBoxNurInEinerZeileImCarree)
        Me.Controls.Add(Me.CheckBoxZwillingCarree)
        Me.Controls.Add(Me.CheckBoxZwillingSpalte)
        Me.Controls.Add(Me.CheckBoxZwillingZeile)
        Me.Controls.Add(Me.CheckBoxCarreeStreichen)
        Me.Controls.Add(Me.CheckBoxSpalteStreichen)
        Me.Controls.Add(Me.CheckBoxZeileStreichen)
        Me.Controls.Add(Me.CheckBoxAutoStreichen)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBoxGestrichenWeil)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBoxSudoku)
        Me.Controls.Add(Me.GroupBoxDaten)
        Me.Controls.Add(Me.GroupBoxSingles)
        Me.Controls.Add(Me.PanelHauptZahlenFeld)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Sudoku Pilot powered by SchwertAs"
        Me.GroupBoxSingles.ResumeLayout(False)
        Me.GroupBoxDaten.ResumeLayout(False)
        Me.GroupBoxSudoku.ResumeLayout(False)
        Me.GroupBoxStreichen1.ResumeLayout(False)
        Me.GroupBoxStreichen2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBoxStreichen3.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBoxStreichen4.ResumeLayout(False)
        Me.GroupBoxGestrichenWeil.ResumeLayout(False)
        Me.GroupBoxGestrichenWeil.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHinweis As System.Windows.Forms.Button
    Friend WithEvents btnErzeugen As System.Windows.Forms.Button
    Friend WithEvents btnFeldSingle As System.Windows.Forms.Button
    Friend WithEvents btnZeilenSingle As System.Windows.Forms.Button
    Friend WithEvents btnSpaltenSingle As System.Windows.Forms.Button
    Friend WithEvents btnCarreeSingle As System.Windows.Forms.Button
    Friend WithEvents PanelHauptZahlenFeld As System.Windows.Forms.Panel
    Friend WithEvents btnMerken As System.Windows.Forms.Button
    Friend WithEvents btnHolen As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnSpeichern As System.Windows.Forms.Button
    Friend WithEvents btnLaden As System.Windows.Forms.Button
    Friend WithEvents btnLeeren As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBoxSingles As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxDaten As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxSudoku As System.Windows.Forms.GroupBox
    Friend WithEvents btnZeileStreichen As System.Windows.Forms.Button
    Friend WithEvents btnLösung As System.Windows.Forms.Button
    Friend WithEvents GroupBoxStreichen1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSpalteStreichen As System.Windows.Forms.Button
    Friend WithEvents btnCarreeStreichen As System.Windows.Forms.Button
    Friend WithEvents AlleStrategieen As System.Windows.Forms.Button
    Friend WithEvents GroupBoxStreichen2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnZeilenZwilling As System.Windows.Forms.Button
    Friend WithEvents btnSpaltenZwilling As System.Windows.Forms.Button
    Friend WithEvents btnCarreeZwilling As System.Windows.Forms.Button
    Friend WithEvents btnNurInEinerZeileImCarree As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxStreichen3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxStreichen4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNurInEinerSpalteImCarree As System.Windows.Forms.Button
    Friend WithEvents GroupBoxGestrichenWeil As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxAutoStreichen As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxZeileStreichen As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxSpalteStreichen As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxZwillingZeile As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxCarreeStreichen As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxNurInEinerSpalteImCarree As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxNurInEinerZeileImCarree As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxZwillingCarree As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxZwillingSpalte As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxVersteckterZwillingSpalte As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxVersteckterZwillingZeile As System.Windows.Forms.CheckBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnAusschliessendeGruppeSpalte As System.Windows.Forms.Button
    Friend WithEvents btnAusschliessendeGruppeZeile As System.Windows.Forms.Button

End Class
