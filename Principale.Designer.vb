<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetectionVisage
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetectionVisage))
        Me.OpenFileImage = New System.Windows.Forms.OpenFileDialog()
        Me.MenuPrinc = New System.Windows.Forms.MenuStrip()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChargerUneImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.PicExemple = New System.Windows.Forms.PictureBox()
        Me.PicChoixImage = New System.Windows.Forms.PictureBox()
        Me.picSelection = New System.Windows.Forms.PictureBox()
        Me.lblCheveux = New System.Windows.Forms.Label()
        Me.lblYeux = New System.Windows.Forms.Label()
        Me.lblPeau = New System.Windows.Forms.Label()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.cbCheveux = New System.Windows.Forms.ComboBox()
        Me.cbYeux = New System.Windows.Forms.ComboBox()
        Me.cbPeau = New System.Windows.Forms.ComboBox()
        Me.PicSimilaire = New System.Windows.Forms.PictureBox()
        Me.PicOriginale = New System.Windows.Forms.PictureBox()
        Me.lblOriginale = New System.Windows.Forms.Label()
        Me.lblSimilaire = New System.Windows.Forms.Label()
        Me.btnTerminer = New System.Windows.Forms.Button()
        Me.sfdSauvegarde = New System.Windows.Forms.SaveFileDialog()
        Me.MenuPrinc.SuspendLayout()
        CType(Me.PicExemple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicChoixImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSimilaire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicOriginale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileImage
        '
        Me.OpenFileImage.FileName = "OpenFileImage"
        Me.OpenFileImage.InitialDirectory = "CurDir() & ""Photos"""
        '
        'MenuPrinc
        '
        Me.MenuPrinc.AccessibleName = "MenuPrinc"
        Me.MenuPrinc.BackColor = System.Drawing.SystemColors.Menu
        Me.MenuPrinc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileOpen})
        Me.MenuPrinc.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrinc.Name = "MenuPrinc"
        Me.MenuPrinc.Size = New System.Drawing.Size(898, 24)
        Me.MenuPrinc.TabIndex = 1
        Me.MenuPrinc.Text = "MenuStrip1"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.AccessibleName = "mnuFileOpen"
        Me.mnuFileOpen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChargerUneImageToolStripMenuItem})
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.Size = New System.Drawing.Size(54, 20)
        Me.mnuFileOpen.Text = "Fichier"
        '
        'ChargerUneImageToolStripMenuItem
        '
        Me.ChargerUneImageToolStripMenuItem.Name = "ChargerUneImageToolStripMenuItem"
        Me.ChargerUneImageToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ChargerUneImageToolStripMenuItem.Text = "Charger une image"
        '
        'lblSelection
        '
        Me.lblSelection.AccessibleName = "lblSelection"
        Me.lblSelection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblSelection.Location = New System.Drawing.Point(520, 78)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(277, 30)
        Me.lblSelection.TabIndex = 3
        Me.lblSelection.Text = "Sélectionnez: Nez"
        Me.lblSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSelection.Visible = False
        '
        'PicExemple
        '
        Me.PicExemple.AccessibleName = "PicExemple"
        Me.PicExemple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicExemple.Image = Global.Projet_Visage.My.Resources.Resources.Schema
        Me.PicExemple.InitialImage = Global.Projet_Visage.My.Resources.Resources.Schema
        Me.PicExemple.Location = New System.Drawing.Point(520, 129)
        Me.PicExemple.Name = "PicExemple"
        Me.PicExemple.Size = New System.Drawing.Size(277, 325)
        Me.PicExemple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicExemple.TabIndex = 3
        Me.PicExemple.TabStop = False
        Me.PicExemple.Visible = False
        '
        'PicChoixImage
        '
        Me.PicChoixImage.AccessibleName = "PicImageChoisie"
        Me.PicChoixImage.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PicChoixImage.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PicChoixImage.Image = Global.Projet_Visage.My.Resources.Resources.Charger_img
        Me.PicChoixImage.InitialImage = Global.Projet_Visage.My.Resources.Resources.Charger_img
        Me.PicChoixImage.Location = New System.Drawing.Point(34, 51)
        Me.PicChoixImage.Name = "PicChoixImage"
        Me.PicChoixImage.Size = New System.Drawing.Size(424, 417)
        Me.PicChoixImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicChoixImage.TabIndex = 2
        Me.PicChoixImage.TabStop = False
        '
        'picSelection
        '
        Me.picSelection.AccessibleName = "picSelectionImage"
        Me.picSelection.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.picSelection.BackgroundImage = Global.Projet_Visage.My.Resources.Resources.Charger_img2
        Me.picSelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picSelection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSelection.InitialImage = Global.Projet_Visage.My.Resources.Resources.Charger_img2
        Me.picSelection.Location = New System.Drawing.Point(34, 51)
        Me.picSelection.Name = "picSelection"
        Me.picSelection.Size = New System.Drawing.Size(822, 417)
        Me.picSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSelection.TabIndex = 0
        Me.picSelection.TabStop = False
        Me.picSelection.Visible = False
        '
        'lblCheveux
        '
        Me.lblCheveux.AccessibleName = "lblCheveux"
        Me.lblCheveux.AutoSize = True
        Me.lblCheveux.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCheveux.Location = New System.Drawing.Point(530, 151)
        Me.lblCheveux.Name = "lblCheveux"
        Me.lblCheveux.Size = New System.Drawing.Size(164, 20)
        Me.lblCheveux.TabIndex = 4
        Me.lblCheveux.Text = "Couleur des cheveux :"
        '
        'lblYeux
        '
        Me.lblYeux.AccessibleName = "lblYeux"
        Me.lblYeux.AutoSize = True
        Me.lblYeux.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblYeux.Location = New System.Drawing.Point(530, 249)
        Me.lblYeux.Name = "lblYeux"
        Me.lblYeux.Size = New System.Drawing.Size(138, 20)
        Me.lblYeux.TabIndex = 5
        Me.lblYeux.Text = "Couleur des yeux :"
        '
        'lblPeau
        '
        Me.lblPeau.AccessibleName = "lblPeau"
        Me.lblPeau.AutoSize = True
        Me.lblPeau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblPeau.Location = New System.Drawing.Point(530, 357)
        Me.lblPeau.Name = "lblPeau"
        Me.lblPeau.Size = New System.Drawing.Size(150, 20)
        Me.lblPeau.TabIndex = 6
        Me.lblPeau.Text = "Couleur de la peau :"
        '
        'btnValider
        '
        Me.btnValider.AccessibleName = "btnValider"
        Me.btnValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnValider.Location = New System.Drawing.Point(641, 414)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(75, 26)
        Me.btnValider.TabIndex = 7
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'cbCheveux
        '
        Me.cbCheveux.AccessibleName = "cbCheveux"
        Me.cbCheveux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCheveux.FormattingEnabled = True
        Me.cbCheveux.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbCheveux.Items.AddRange(New Object() {"Noir", "Brun", "Châtain", "Roux", "Blond", "Gris", "Blanc"})
        Me.cbCheveux.Location = New System.Drawing.Point(700, 150)
        Me.cbCheveux.Name = "cbCheveux"
        Me.cbCheveux.Size = New System.Drawing.Size(121, 21)
        Me.cbCheveux.TabIndex = 8
        '
        'cbYeux
        '
        Me.cbYeux.AccessibleName = "cbYeux"
        Me.cbYeux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYeux.FormattingEnabled = True
        Me.cbYeux.Items.AddRange(New Object() {"Bleus", "Marrons", "Verts"})
        Me.cbYeux.Location = New System.Drawing.Point(700, 248)
        Me.cbYeux.Name = "cbYeux"
        Me.cbYeux.Size = New System.Drawing.Size(121, 21)
        Me.cbYeux.TabIndex = 9
        '
        'cbPeau
        '
        Me.cbPeau.AccessibleDescription = ""
        Me.cbPeau.AccessibleName = "cbYeux"
        Me.cbPeau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPeau.FormattingEnabled = True
        Me.cbPeau.Items.AddRange(New Object() {"Beige", "Blanc", "Marron ", "Noir"})
        Me.cbPeau.Location = New System.Drawing.Point(700, 359)
        Me.cbPeau.Name = "cbPeau"
        Me.cbPeau.Size = New System.Drawing.Size(121, 21)
        Me.cbPeau.TabIndex = 10
        '
        'PicSimilaire
        '
        Me.PicSimilaire.AccessibleName = "PicImageChoisie"
        Me.PicSimilaire.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PicSimilaire.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PicSimilaire.InitialImage = Global.Projet_Visage.My.Resources.Resources.Charger_img
        Me.PicSimilaire.Location = New System.Drawing.Point(481, 83)
        Me.PicSimilaire.Name = "PicSimilaire"
        Me.PicSimilaire.Size = New System.Drawing.Size(352, 371)
        Me.PicSimilaire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSimilaire.TabIndex = 11
        Me.PicSimilaire.TabStop = False
        '
        'PicOriginale
        '
        Me.PicOriginale.AccessibleName = "PicOriginale"
        Me.PicOriginale.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PicOriginale.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PicOriginale.InitialImage = Global.Projet_Visage.My.Resources.Resources.Charger_img
        Me.PicOriginale.Location = New System.Drawing.Point(60, 83)
        Me.PicOriginale.Name = "PicOriginale"
        Me.PicOriginale.Size = New System.Drawing.Size(352, 371)
        Me.PicOriginale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicOriginale.TabIndex = 12
        Me.PicOriginale.TabStop = False
        '
        'lblOriginale
        '
        Me.lblOriginale.AccessibleName = "lblOriginale"
        Me.lblOriginale.AutoSize = True
        Me.lblOriginale.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblOriginale.Location = New System.Drawing.Point(163, 41)
        Me.lblOriginale.Name = "lblOriginale"
        Me.lblOriginale.Size = New System.Drawing.Size(143, 24)
        Me.lblOriginale.TabIndex = 13
        Me.lblOriginale.Text = "Image Originale"
        '
        'lblSimilaire
        '
        Me.lblSimilaire.AccessibleName = "lblSimilaire"
        Me.lblSimilaire.AutoSize = True
        Me.lblSimilaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblSimilaire.Location = New System.Drawing.Point(590, 41)
        Me.lblSimilaire.Name = "lblSimilaire"
        Me.lblSimilaire.Size = New System.Drawing.Size(138, 24)
        Me.lblSimilaire.TabIndex = 14
        Me.lblSimilaire.Text = "Image Similaire"
        '
        'btnTerminer
        '
        Me.btnTerminer.AccessibleName = "btnTerminer"
        Me.btnTerminer.Location = New System.Drawing.Point(811, 460)
        Me.btnTerminer.Name = "btnTerminer"
        Me.btnTerminer.Size = New System.Drawing.Size(75, 23)
        Me.btnTerminer.TabIndex = 15
        Me.btnTerminer.Text = "Terminer"
        Me.btnTerminer.UseVisualStyleBackColor = True
        '
        'sfdSauvegarde
        '
        Me.sfdSauvegarde.InitialDirectory = "..\.."
        Me.sfdSauvegarde.RestoreDirectory = True
        Me.sfdSauvegarde.Title = "sfdSauvegarde"
        '
        'DetectionVisage
        '
        Me.AccessibleName = "DetectionVisage"
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(898, 493)
        Me.Controls.Add(Me.btnTerminer)
        Me.Controls.Add(Me.lblSimilaire)
        Me.Controls.Add(Me.lblOriginale)
        Me.Controls.Add(Me.PicOriginale)
        Me.Controls.Add(Me.PicSimilaire)
        Me.Controls.Add(Me.cbPeau)
        Me.Controls.Add(Me.cbYeux)
        Me.Controls.Add(Me.cbCheveux)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.lblPeau)
        Me.Controls.Add(Me.lblYeux)
        Me.Controls.Add(Me.lblCheveux)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.PicExemple)
        Me.Controls.Add(Me.PicChoixImage)
        Me.Controls.Add(Me.picSelection)
        Me.Controls.Add(Me.MenuPrinc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuPrinc
        Me.MaximizeBox = False
        Me.Name = "DetectionVisage"
        Me.Text = "Détection Visage"
        Me.MenuPrinc.ResumeLayout(False)
        Me.MenuPrinc.PerformLayout()
        CType(Me.PicExemple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicChoixImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSelection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSimilaire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicOriginale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSelection As PictureBox
    Friend WithEvents OpenFileImage As OpenFileDialog
    Friend WithEvents MenuPrinc As MenuStrip
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents ChargerUneImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PicChoixImage As PictureBox
    Friend WithEvents PicExemple As PictureBox
    Friend WithEvents lblSelection As Label
    Friend WithEvents lblCheveux As Label
    Friend WithEvents lblYeux As Label
    Friend WithEvents lblPeau As Label
    Friend WithEvents btnValider As Button
    Friend WithEvents cbCheveux As ComboBox
    Friend WithEvents cbYeux As ComboBox
    Friend WithEvents cbPeau As ComboBox
    Friend WithEvents PicSimilaire As PictureBox
    Friend WithEvents PicOriginale As PictureBox
    Friend WithEvents lblOriginale As Label
    Friend WithEvents lblSimilaire As Label
    Friend WithEvents btnTerminer As Button
    Friend WithEvents sfdSauvegarde As SaveFileDialog
End Class
