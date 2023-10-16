Public Class DetectionVisage

    Private Const GRIS_FONCE As String = "#BCBCBC"
    Private Const GRIS_CLAIR As String = "#E1E1E1"

    Private nb_Etape As Integer = 0
    Private taillePoint As Integer = 10

    'Déclaration variables contenant les coordonnées de chaque point
    Private pt As Point
    Private ptMilieuOeilDroit As Point
    Private ptMilieuOeilGauche As Point
    Private ptBasDuMenton As Point
    Private ptExtGaucheVisage As Point
    Private ptBordGaucheLevres As Point
    Private ptExtDroiteVisage As Point
    Private ptBordDroitLevres As Point

    Private PtNezGauche As Point
    Private PtNezDroite As Point
    Private PtLevreHaut As Point
    Private PtLevreBas As Point
    Private PtMilieuYeux As Point
    Private ptBasNez As Point

    'Déclaration des ratios
    Private ratioLevre As Double
    Private ratioNez As Double
    Private ratioVisage As Double
    Private ratioYeux As Double
    'Voilà quoi
    Private largeurVis As Double

    Private MousePoint As Point

    ''Chargement du logiciel
    Private Sub DetectionVisage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picSelection.BorderStyle = BorderStyle.None
        Afficher_Accueil()
        picSelection.BackColor = ColorTranslator.FromHtml(GRIS_CLAIR)
    End Sub

    Private Sub PicBoxSelection_Click(sender As Object, e As EventArgs) Handles picSelection.Click ''Permet de sélectionner une image dans un fichier
        Charger_Image_Fichier()
    End Sub

    ''Procédures d'affichage des différentes pages
    Private Sub Afficher_Accueil()
        picSelection.Visible = True
        PicChoixImage.Visible = False
        lblSelection.Visible = False
        PicExemple.Visible = False
        lblCheveux.Visible = False
        lblPeau.Visible = False
        lblSelection.Visible = False
        lblYeux.Visible = False
        btnValider.Visible = False
        cbCheveux.Visible = False
        cbYeux.Visible = False
        cbPeau.Visible = False
        lblOriginale.Visible = False
        lblSimilaire.Visible = False
        PicOriginale.Visible = False
        PicSimilaire.Visible = False
        btnTerminer.Visible = False
        nb_Etape = 0
    End Sub

    Private Sub Afficher_Selection_Points()
        picSelection.Visible = False
        PicChoixImage.Visible = True
        lblSelection.Visible = True
        PicExemple.Visible = True
        lblCheveux.Visible = False
        lblPeau.Visible = False
        lblSelection.Visible = True
        lblYeux.Visible = False
        btnValider.Visible = False
        cbCheveux.Visible = False
        cbYeux.Visible = False
        cbPeau.Visible = False
        lblOriginale.Visible = False
        lblSimilaire.Visible = False
        PicOriginale.Visible = False
        PicSimilaire.Visible = False
        btnTerminer.Visible = False
    End Sub

    Private Sub Afficher_Selection_Couleurs()
        picSelection.Visible = False
        PicChoixImage.Visible = True
        lblSelection.Visible = True
        PicExemple.Visible = False
        lblCheveux.Visible = True
        lblPeau.Visible = True
        lblSelection.Visible = False
        lblYeux.Visible = True
        btnValider.Visible = True
        cbCheveux.Visible = True
        cbYeux.Visible = True
        cbPeau.Visible = True
        lblOriginale.Visible = False
        lblSimilaire.Visible = False
        PicOriginale.Visible = False
        PicSimilaire.Visible = False
        btnTerminer.Visible = False
    End Sub

    Private Sub Afficher_Comparaison()
        picSelection.Visible = False
        PicChoixImage.Visible = False
        lblSelection.Visible = False
        PicExemple.Visible = False
        lblCheveux.Visible = False
        lblPeau.Visible = False
        lblSelection.Visible = False
        lblYeux.Visible = False
        btnValider.Visible = False
        cbCheveux.Visible = False
        cbYeux.Visible = False
        cbPeau.Visible = False
        lblOriginale.Visible = True
        lblSimilaire.Visible = True
        PicOriginale.Visible = True
        PicSimilaire.Visible = True
        btnTerminer.Visible = True

    End Sub


    ''FeedBacks 
    Private Sub PicBoxSelection_Hover(sender As Object, e As EventArgs) Handles picSelection.MouseHover ''Permet de sélectionner une image dans un fichier
        picSelection.BorderStyle = BorderStyle.Fixed3D
        picSelection.BackColor = ColorTranslator.FromHtml(GRIS_FONCE)
    End Sub

    Private Sub PicBoxSelection_Leave(sender As Object, e As EventArgs) Handles picSelection.MouseLeave ''Permet de sélectionner une image dans un fichier
        picSelection.BorderStyle = BorderStyle.None
        picSelection.BackColor = ColorTranslator.FromHtml(GRIS_CLAIR)
    End Sub


    ''Procédures de chargement d'images
    Private Sub Charger_Image_Fichier() ''Choix du fichier en cliquant
        OpenFileImage.Title = "Ouvrir une image" ''Nom de la fenetre
        OpenFileImage.Filter = "PNG|*.png|JPG|*.jpg" ''Type de fichier sélectionnable
        If OpenFileImage.ShowDialog = DialogResult.OK Then
            Image_Chargee(OpenFileImage.FileName)
        End If
    End Sub


    ''Procédure Drag And Drop
    Private Sub DetectionVisage_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            Image_Chargee(path)
        Next
    End Sub

    Private Sub Form1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            picSelection.BackColor = ColorTranslator.FromHtml(GRIS_FONCE)
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub ChargerUneImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChargerUneImageToolStripMenuItem.Click
        Charger_Image_Fichier()
    End Sub

    Private Sub Image_Chargee(FileName As String)
        PicChoixImage.Image = Image.FromFile(FileName) ''Affiche l'image
        PicOriginale.Image = Image.FromFile(FileName)
        Enregistrer_Image()
        Afficher_Selection_Points()
        Choix_Etape()
    End Sub

    Private Sub Enregistrer_Image()
        If Not PicChoixImage.Image Is Nothing Then 'Vérifier si image existe dans Picturebox1
            Dim savefiledialog1 As New SaveFileDialog
            savefiledialog1.Title = "Image sauvegarder"
            savefiledialog1.InitialDirectory = CurDir() & "Photos" 'afficher le répertoire du bureau
            savefiledialog1.Filter = "PNG|*.png|JPG|*.jpg"
            If savefiledialog1.ShowDialog() = DialogResult.OK Then
                PicChoixImage.Image.Save(savefiledialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg) 'sauvegarder l'image depuis picturebox1
                Enregistrer_NomImage(System.IO.Path.GetFileName(savefiledialog1.FileName))
            Else
                MessageBox.Show("Veuillez séléctionner un repertoire pour sauvegarder l'image", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error) 'si vous annuler le répertoire de sauvegarder de l'image vous avez ce message erreur
            End If
        Else
            MessageBox.Show("Veuillez ajouter un image dans Picturebox1", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error) 'si picturebox1 est vide vous avez ce message erreur
        End If

    End Sub

    Sub Choix_Etape()
        Select Case nb_Etape
            Case 0
                Selection_Nez_Bas()
            Case 1
                Selection_Nez_Gauche()
            Case 2
                Selection_Nez_Droit()
            Case 3
                Selection_Menton()
            Case 4
                Selection_Visage_Gauche()
            Case 5
                Selection_Levre_gauche()
            Case 6
                Selection_Levre_Haut()
            Case 7
                Selection_Levre_Bas()
            Case 8
                Selection_Levre_Droite()
            Case 9
                Selection_Visage_Droite()
            Case 10
                Selection_Oeil_Droit()
            Case 11
                Selection_Oeil_Gauche()
            Case 12
                Afficher_Selection_Couleurs()

        End Select
    End Sub

    Private Sub PicImageChoisie_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PicChoixImage.MouseClick
        Choix_Etape()
        MousePoint = New Point(e.X, e.Y)
        If (nb_Etape < 12) Then
            createDot(e.X, e.Y)
        End If
    End Sub

    Private Sub Selection_Nez_Bas()
        lblSelection.Text = "Selectionner: le bas du nez"
        PicExemple.Image = Projet_Visage.My.Resources.BasNez

        PtNezGauche = MousePoint

        nb_Etape = nb_Etape + 1
    End Sub

    Private Sub Selection_Menton()
        lblSelection.Text = "Selectionner: Menton" 'Ecrit du texte dans le label
        PicExemple.Image = Projet_Visage.My.Resources.Menton 'Change l'image du schéma
        'Temporaire:
        ptBasDuMenton = MousePoint


        nb_Etape = nb_Etape + 1
    End Sub
    Private Sub Selection_Visage_Gauche()
        lblSelection.Text = "Selectionner: la gauche du visage"
        PicExemple.Image = Projet_Visage.My.Resources.Visage_Gauche

        ptExtGaucheVisage = MousePoint


        nb_Etape = nb_Etape + 1
    End Sub
    Private Sub Selection_Levre_gauche()
        lblSelection.Text = "Selectionner: Gauche de la lèvre"
        PicExemple.Image = Projet_Visage.My.Resources.Levre_Gauche

        ptBordGaucheLevres = MousePoint


        nb_Etape = nb_Etape + 1
    End Sub
    Private Sub Selection_Visage_Droite()
        lblSelection.Text = "Selectionner: la droite du visage"
        PicExemple.Image = Projet_Visage.My.Resources.Visage_Droite

        ptExtDroiteVisage = MousePoint


        nb_Etape = nb_Etape + 1
    End Sub
    Private Sub Selection_Levre_Droite()
        lblSelection.Text = "Selectionner: Droite de la lèvre"
        PicExemple.Image = Projet_Visage.My.Resources.Levre_Droite

        ptBordDroitLevres = MousePoint

        nb_Etape = nb_Etape + 1
    End Sub

    Private Sub Selection_Oeil_Droit()
        lblSelection.Text = "Selectionner: Oeil Droit"
        PicExemple.Image = Projet_Visage.My.Resources.Oeil_Droit

        ptMilieuOeilDroit = MousePoint

        nb_Etape = nb_Etape + 1
    End Sub

    Private Sub Selection_Oeil_Gauche()
        lblSelection.Text = "Selectionner: Oeil Gauche"
        PicExemple.Image = Projet_Visage.My.Resources.Oeil_Gauche

        ptMilieuOeilGauche = MousePoint

        nb_Etape = nb_Etape + 1
    End Sub

    Private Sub Selection_Nez_Gauche()
        lblSelection.Text = "Selectionner: la gauche du nez"
        PicExemple.Image = Projet_Visage.My.Resources.NezGauche

        PtNezGauche = MousePoint

        nb_Etape = nb_Etape + 1
    End Sub

    Private Sub Selection_Nez_Droit()
        lblSelection.Text = "Selectionner: la droite du nez"
        PicExemple.Image = Projet_Visage.My.Resources.NezDroite

        PtNezDroite = MousePoint

        nb_Etape = nb_Etape + 1
    End Sub

    Private Sub Selection_Levre_Haut()
        lblSelection.Text = "Selectionner: le haut de la lèvre"
        PicExemple.Image = Projet_Visage.My.Resources.Levre_Haut

        PtLevreHaut = MousePoint

        nb_Etape = nb_Etape + 1
    End Sub

    Private Sub Selection_Levre_Bas()
        lblSelection.Text = "Selectionner: le Bas de la lèvre"
        PicExemple.Image = Projet_Visage.My.Resources.Levre_Bas

        PtLevreBas = MousePoint

        nb_Etape = nb_Etape + 1
    End Sub

    Private Sub createDot(ByVal x As Integer, ByVal y As Integer)
        'MsgBox(x.ToString & " " & y.ToString)
        Dim PointRouge As Graphics = PicChoixImage.CreateGraphics

        Dim myPen As Pen
        Dim redBrush As New SolidBrush(Color.Red)

        myPen = New Pen(Drawing.Color.Red, 1)

        PointRouge.DrawEllipse(myPen, x - 5, y - 5, 1 * taillePoint, 1 * taillePoint)
        PointRouge.FillEllipse(redBrush, x - 5, y - 5, 1 * taillePoint, 1 * taillePoint)
    End Sub

    Private Function CalculRatioLevre() As Double
        Dim hauteurL As Double
        Dim largeurL As Double

        hauteurL = PtLevreBas.Y - PtLevreHaut.Y
        largeurL = ptBordDroitLevres.X - ptBordGaucheLevres.X

        Return ratioLevre = hauteurL / largeurL
    End Function

    Private Function CalculRatioNez() As Double
        Dim hauteurNez As Double
        Dim largeurNez As Double

        hauteurNez = ptBasNez.Y - ptMilieuOeilDroit.Y
        largeurNez = PtNezDroite.X - PtNezGauche.X
        Return ratioNez = hauteurNez / largeurNez
    End Function

    Private Function CalculRatioVisage() As Double
        Dim hauteurVis As Double

        hauteurVis = ptBasDuMenton.Y - ptMilieuOeilDroit.Y
        largeurVis = ptExtDroiteVisage.X - ptExtGaucheVisage.X
        Return ratioVisage = hauteurVis / largeurVis
    End Function

    Private Function CalculRatioYeux() As Double
        Dim largeurYeux As Double

        largeurYeux = ptMilieuOeilDroit.X - ptMilieuOeilGauche.X
        largeurVis = ptExtDroiteVisage.X - ptExtGaucheVisage.X
        Return ratioYeux = largeurVis / largeurYeux
    End Function

    Private Sub Enregistrer_NomImage(nomImage As String)
        ' écrire dans le fichier csv, chemin relatif
        My.Computer.FileSystem.WriteAllText("..\..\visages.csv", nomImage, True)
    End Sub

    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        Afficher_Comparaison()
    End Sub

    Private Sub btnTerminer_Click(sender As Object, e As EventArgs) Handles btnTerminer.Click
        Afficher_Accueil()
    End Sub

End Class
