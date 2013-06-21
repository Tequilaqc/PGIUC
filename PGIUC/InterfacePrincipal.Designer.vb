<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfacePrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NomUniteLabel = New System.Windows.Forms.Label()
        Me.AdminTabControl = New System.Windows.Forms.TabControl()
        Me.Administration = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CatalogueBouton = New System.Windows.Forms.Button()
        Me.EtiquetteBouton = New System.Windows.Forms.Button()
        Me.GenererPerteBouton = New System.Windows.Forms.Button()
        Me.ModuleUniformeBouton = New System.Windows.Forms.Button()
        Me.MenuLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GestionUniteBouton = New System.Windows.Forms.Button()
        Me.GestionUtilisateursBouton = New System.Windows.Forms.Button()
        Me.GestionCategoriesBouton = New System.Windows.Forms.Button()
        Me.GestionArticlesBouton = New System.Windows.Forms.Button()
        Me.PerteLabel = New System.Windows.Forms.Label()
        Me.SGVSommairePerte = New System.Windows.Forms.DataGridView()
        Me.UniformeLabel = New System.Windows.Forms.Label()
        Me.EmpruntLabel = New System.Windows.Forms.Label()
        Me.DGVUniforme = New System.Windows.Forms.DataGridView()
        Me.DGVSommaireEmprunt = New System.Windows.Forms.DataGridView()
        Me.Prets = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.ImprimerPret = New System.Windows.Forms.Button()
        Me.AnnulerPret = New System.Windows.Forms.Button()
        Me.ValiderPret = New System.Windows.Forms.Button()
        Me.NouveauPret = New System.Windows.Forms.Button()
        Me.DGVPret = New System.Windows.Forms.DataGridView()
        Me.NoArticlePret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionPret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypePret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantitePret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtatPret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PretUtilisateurNomBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateEmpruntPicker = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateRetourPrevuPicker = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NoUtilisateurBox = New System.Windows.Forms.TextBox()
        Me.Retour = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.ImprimerRetour = New System.Windows.Forms.Button()
        Me.AnnulerRetour = New System.Windows.Forms.Button()
        Me.ValiderRetour = New System.Windows.Forms.Button()
        Me.NouveauRetour = New System.Windows.Forms.Button()
        Me.DGVRetour = New System.Windows.Forms.DataGridView()
        Me.NoArticleRetour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionRetour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeRetour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantiteRetour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtatRetour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateRetourPicker = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ListePrets = New System.Windows.Forms.TabPage()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DGVListPret = New System.Windows.Forms.DataGridView()
        Me.NoEmpruntListPret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomEmpruntListPret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoArticleListPret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionListPret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantiteListPret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtatListPret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HistoriquePrets = New System.Windows.Forms.TabPage()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.DGVHistPret = New System.Windows.Forms.DataGridView()
        Me.NoMembreHistPret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomEmpruntHistPret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoArticleHistPret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionHistPret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantiteHistPret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtatHistPret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HistoriqueRetour = New System.Windows.Forms.TabPage()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.DGVHistRetour = New System.Windows.Forms.DataGridView()
        Me.NoMembreHistRetour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomEmpruntHistRetour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoArticleHistRetour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionHistRetour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantiteHistRetour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtatHistRetour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListeMateriel = New System.Windows.Forms.TabPage()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGVListMateriel = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminTabControl.SuspendLayout()
        Me.Administration.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SGVSommairePerte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVUniforme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVSommaireEmprunt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Prets.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.DGVPret, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Retour.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.DGVRetour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.ListePrets.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.DGVListPret, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HistoriquePrets.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.DGVHistPret, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HistoriqueRetour.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        CType(Me.DGVHistRetour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListeMateriel.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        CType(Me.DGVListMateriel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomUniteLabel
        '
        Me.NomUniteLabel.AutoSize = True
        Me.NomUniteLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomUniteLabel.Location = New System.Drawing.Point(252, 9)
        Me.NomUniteLabel.Name = "NomUniteLabel"
        Me.NomUniteLabel.Size = New System.Drawing.Size(206, 32)
        Me.NomUniteLabel.TabIndex = 0
        Me.NomUniteLabel.Text = "Nom de l'unité"
        '
        'AdminTabControl
        '
        Me.AdminTabControl.Controls.Add(Me.Administration)
        Me.AdminTabControl.Controls.Add(Me.Prets)
        Me.AdminTabControl.Controls.Add(Me.Retour)
        Me.AdminTabControl.Controls.Add(Me.ListePrets)
        Me.AdminTabControl.Controls.Add(Me.HistoriquePrets)
        Me.AdminTabControl.Controls.Add(Me.HistoriqueRetour)
        Me.AdminTabControl.Controls.Add(Me.ListeMateriel)
        Me.AdminTabControl.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminTabControl.Location = New System.Drawing.Point(11, 52)
        Me.AdminTabControl.Multiline = True
        Me.AdminTabControl.Name = "AdminTabControl"
        Me.AdminTabControl.SelectedIndex = 0
        Me.AdminTabControl.Size = New System.Drawing.Size(1029, 526)
        Me.AdminTabControl.TabIndex = 1
        '
        'Administration
        '
        Me.Administration.AutoScroll = True
        Me.Administration.Controls.Add(Me.Panel5)
        Me.Administration.Controls.Add(Me.PerteLabel)
        Me.Administration.Controls.Add(Me.SGVSommairePerte)
        Me.Administration.Controls.Add(Me.UniformeLabel)
        Me.Administration.Controls.Add(Me.EmpruntLabel)
        Me.Administration.Controls.Add(Me.DGVUniforme)
        Me.Administration.Controls.Add(Me.DGVSommaireEmprunt)
        Me.Administration.Location = New System.Drawing.Point(4, 25)
        Me.Administration.Name = "Administration"
        Me.Administration.Size = New System.Drawing.Size(1021, 497)
        Me.Administration.TabIndex = 4
        Me.Administration.Text = "Administration"
        Me.Administration.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Blue
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Controls.Add(Me.ModuleUniformeBouton)
        Me.Panel5.Controls.Add(Me.MenuLabel)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Location = New System.Drawing.Point(-4, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(206, 496)
        Me.Panel5.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Requête"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CatalogueBouton)
        Me.Panel2.Controls.Add(Me.EtiquetteBouton)
        Me.Panel2.Controls.Add(Me.GenererPerteBouton)
        Me.Panel2.Location = New System.Drawing.Point(24, 233)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(161, 126)
        Me.Panel2.TabIndex = 12
        '
        'CatalogueBouton
        '
        Me.CatalogueBouton.Location = New System.Drawing.Point(3, 87)
        Me.CatalogueBouton.Name = "CatalogueBouton"
        Me.CatalogueBouton.Size = New System.Drawing.Size(153, 35)
        Me.CatalogueBouton.TabIndex = 14
        Me.CatalogueBouton.Text = "Catalogue"
        Me.CatalogueBouton.UseVisualStyleBackColor = True
        '
        'EtiquetteBouton
        '
        Me.EtiquetteBouton.Location = New System.Drawing.Point(3, 5)
        Me.EtiquetteBouton.Name = "EtiquetteBouton"
        Me.EtiquetteBouton.Size = New System.Drawing.Size(153, 35)
        Me.EtiquetteBouton.TabIndex = 4
        Me.EtiquetteBouton.Text = "Générer des étiquettes"
        Me.EtiquetteBouton.UseVisualStyleBackColor = True
        '
        'GenererPerteBouton
        '
        Me.GenererPerteBouton.Location = New System.Drawing.Point(3, 46)
        Me.GenererPerteBouton.Name = "GenererPerteBouton"
        Me.GenererPerteBouton.Size = New System.Drawing.Size(153, 35)
        Me.GenererPerteBouton.TabIndex = 5
        Me.GenererPerteBouton.Text = "Rapport de perte"
        Me.GenererPerteBouton.UseVisualStyleBackColor = True
        '
        'ModuleUniformeBouton
        '
        Me.ModuleUniformeBouton.Location = New System.Drawing.Point(28, 386)
        Me.ModuleUniformeBouton.Name = "ModuleUniformeBouton"
        Me.ModuleUniformeBouton.Size = New System.Drawing.Size(153, 35)
        Me.ModuleUniformeBouton.TabIndex = 6
        Me.ModuleUniformeBouton.Text = "Module des uniformes"
        Me.ModuleUniformeBouton.UseVisualStyleBackColor = True
        '
        'MenuLabel
        '
        Me.MenuLabel.AutoSize = True
        Me.MenuLabel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuLabel.ForeColor = System.Drawing.Color.White
        Me.MenuLabel.Location = New System.Drawing.Point(21, 13)
        Me.MenuLabel.Name = "MenuLabel"
        Me.MenuLabel.Size = New System.Drawing.Size(166, 18)
        Me.MenuLabel.TabIndex = 7
        Me.MenuLabel.Text = "Commande de gestion"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GestionUniteBouton)
        Me.Panel1.Controls.Add(Me.GestionUtilisateursBouton)
        Me.Panel1.Controls.Add(Me.GestionCategoriesBouton)
        Me.Panel1.Controls.Add(Me.GestionArticlesBouton)
        Me.Panel1.Location = New System.Drawing.Point(24, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(161, 167)
        Me.Panel1.TabIndex = 4
        '
        'GestionUniteBouton
        '
        Me.GestionUniteBouton.Location = New System.Drawing.Point(3, 126)
        Me.GestionUniteBouton.Name = "GestionUniteBouton"
        Me.GestionUniteBouton.Size = New System.Drawing.Size(153, 35)
        Me.GestionUniteBouton.TabIndex = 3
        Me.GestionUniteBouton.Text = "Gestion de l'unité"
        Me.GestionUniteBouton.UseVisualStyleBackColor = True
        '
        'GestionUtilisateursBouton
        '
        Me.GestionUtilisateursBouton.Location = New System.Drawing.Point(3, 85)
        Me.GestionUtilisateursBouton.Name = "GestionUtilisateursBouton"
        Me.GestionUtilisateursBouton.Size = New System.Drawing.Size(153, 35)
        Me.GestionUtilisateursBouton.TabIndex = 2
        Me.GestionUtilisateursBouton.Text = "Gestion des membres"
        Me.GestionUtilisateursBouton.UseVisualStyleBackColor = True
        '
        'GestionCategoriesBouton
        '
        Me.GestionCategoriesBouton.Location = New System.Drawing.Point(3, 44)
        Me.GestionCategoriesBouton.Name = "GestionCategoriesBouton"
        Me.GestionCategoriesBouton.Size = New System.Drawing.Size(153, 35)
        Me.GestionCategoriesBouton.TabIndex = 1
        Me.GestionCategoriesBouton.Text = "Gestion des catégories"
        Me.GestionCategoriesBouton.UseVisualStyleBackColor = True
        '
        'GestionArticlesBouton
        '
        Me.GestionArticlesBouton.Location = New System.Drawing.Point(3, 3)
        Me.GestionArticlesBouton.Name = "GestionArticlesBouton"
        Me.GestionArticlesBouton.Size = New System.Drawing.Size(153, 35)
        Me.GestionArticlesBouton.TabIndex = 0
        Me.GestionArticlesBouton.Text = "Gestion des articles"
        Me.GestionArticlesBouton.UseVisualStyleBackColor = True
        '
        'PerteLabel
        '
        Me.PerteLabel.AutoSize = True
        Me.PerteLabel.Location = New System.Drawing.Point(580, 13)
        Me.PerteLabel.Name = "PerteLabel"
        Me.PerteLabel.Size = New System.Drawing.Size(132, 16)
        Me.PerteLabel.TabIndex = 11
        Me.PerteLabel.Text = "Sommaire des pertes"
        '
        'SGVSommairePerte
        '
        Me.SGVSommairePerte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SGVSommairePerte.Location = New System.Drawing.Point(583, 32)
        Me.SGVSommairePerte.Name = "SGVSommairePerte"
        Me.SGVSommairePerte.Size = New System.Drawing.Size(148, 437)
        Me.SGVSommairePerte.TabIndex = 10
        '
        'UniformeLabel
        '
        Me.UniformeLabel.AutoSize = True
        Me.UniformeLabel.Location = New System.Drawing.Point(410, 13)
        Me.UniformeLabel.Name = "UniformeLabel"
        Me.UniformeLabel.Size = New System.Drawing.Size(141, 16)
        Me.UniformeLabel.TabIndex = 9
        Me.UniformeLabel.Text = "Cadets sans uniformes"
        '
        'EmpruntLabel
        '
        Me.EmpruntLabel.AutoSize = True
        Me.EmpruntLabel.Location = New System.Drawing.Point(241, 13)
        Me.EmpruntLabel.Name = "EmpruntLabel"
        Me.EmpruntLabel.Size = New System.Drawing.Size(150, 16)
        Me.EmpruntLabel.TabIndex = 8
        Me.EmpruntLabel.Text = "Sommaire des emprunts"
        '
        'DGVUniforme
        '
        Me.DGVUniforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUniforme.Location = New System.Drawing.Point(413, 32)
        Me.DGVUniforme.Name = "DGVUniforme"
        Me.DGVUniforme.Size = New System.Drawing.Size(148, 437)
        Me.DGVUniforme.TabIndex = 6
        '
        'DGVSommaireEmprunt
        '
        Me.DGVSommaireEmprunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSommaireEmprunt.Location = New System.Drawing.Point(243, 32)
        Me.DGVSommaireEmprunt.Name = "DGVSommaireEmprunt"
        Me.DGVSommaireEmprunt.Size = New System.Drawing.Size(148, 437)
        Me.DGVSommaireEmprunt.TabIndex = 5
        '
        'Prets
        '
        Me.Prets.Controls.Add(Me.Panel6)
        Me.Prets.Controls.Add(Me.DGVPret)
        Me.Prets.Controls.Add(Me.PretUtilisateurNomBox)
        Me.Prets.Controls.Add(Me.Label4)
        Me.Prets.Controls.Add(Me.Panel3)
        Me.Prets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Prets.Location = New System.Drawing.Point(4, 25)
        Me.Prets.Name = "Prets"
        Me.Prets.Padding = New System.Windows.Forms.Padding(3)
        Me.Prets.Size = New System.Drawing.Size(1021, 497)
        Me.Prets.TabIndex = 0
        Me.Prets.Text = "Prêts"
        Me.Prets.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Blue
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Location = New System.Drawing.Point(-4, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(206, 496)
        Me.Panel6.TabIndex = 8
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.ImprimerPret)
        Me.Panel8.Controls.Add(Me.AnnulerPret)
        Me.Panel8.Controls.Add(Me.ValiderPret)
        Me.Panel8.Controls.Add(Me.NouveauPret)
        Me.Panel8.Location = New System.Drawing.Point(24, 32)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(161, 166)
        Me.Panel8.TabIndex = 8
        '
        'ImprimerPret
        '
        Me.ImprimerPret.Location = New System.Drawing.Point(3, 126)
        Me.ImprimerPret.Name = "ImprimerPret"
        Me.ImprimerPret.Size = New System.Drawing.Size(153, 35)
        Me.ImprimerPret.TabIndex = 3
        Me.ImprimerPret.Text = "Imprimer"
        Me.ImprimerPret.UseVisualStyleBackColor = True
        '
        'AnnulerPret
        '
        Me.AnnulerPret.Location = New System.Drawing.Point(3, 85)
        Me.AnnulerPret.Name = "AnnulerPret"
        Me.AnnulerPret.Size = New System.Drawing.Size(153, 35)
        Me.AnnulerPret.TabIndex = 2
        Me.AnnulerPret.Text = "Annuler"
        Me.AnnulerPret.UseVisualStyleBackColor = True
        '
        'ValiderPret
        '
        Me.ValiderPret.Location = New System.Drawing.Point(3, 44)
        Me.ValiderPret.Name = "ValiderPret"
        Me.ValiderPret.Size = New System.Drawing.Size(153, 35)
        Me.ValiderPret.TabIndex = 1
        Me.ValiderPret.Text = "Valider"
        Me.ValiderPret.UseVisualStyleBackColor = True
        '
        'NouveauPret
        '
        Me.NouveauPret.Location = New System.Drawing.Point(3, 3)
        Me.NouveauPret.Name = "NouveauPret"
        Me.NouveauPret.Size = New System.Drawing.Size(153, 35)
        Me.NouveauPret.TabIndex = 0
        Me.NouveauPret.Text = "Nouveau"
        Me.NouveauPret.UseVisualStyleBackColor = True
        '
        'DGVPret
        '
        Me.DGVPret.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPret.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoArticlePret, Me.DescriptionPret, Me.TypePret, Me.QuantitePret, Me.EtatPret})
        Me.DGVPret.Location = New System.Drawing.Point(215, 181)
        Me.DGVPret.Name = "DGVPret"
        Me.DGVPret.Size = New System.Drawing.Size(735, 305)
        Me.DGVPret.TabIndex = 7
        '
        'NoArticlePret
        '
        Me.NoArticlePret.HeaderText = "No. d'article"
        Me.NoArticlePret.Name = "NoArticlePret"
        Me.NoArticlePret.Width = 80
        '
        'DescriptionPret
        '
        Me.DescriptionPret.HeaderText = "Description"
        Me.DescriptionPret.Name = "DescriptionPret"
        Me.DescriptionPret.Width = 300
        '
        'TypePret
        '
        Me.TypePret.HeaderText = "Type"
        Me.TypePret.Name = "TypePret"
        Me.TypePret.Width = 150
        '
        'QuantitePret
        '
        Me.QuantitePret.HeaderText = "Quantité"
        Me.QuantitePret.Name = "QuantitePret"
        Me.QuantitePret.Width = 80
        '
        'EtatPret
        '
        Me.EtatPret.HeaderText = "Etat"
        Me.EtatPret.Name = "EtatPret"
        Me.EtatPret.Width = 80
        '
        'PretUtilisateurNomBox
        '
        Me.PretUtilisateurNomBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PretUtilisateurNomBox.Location = New System.Drawing.Point(560, 25)
        Me.PretUtilisateurNomBox.Name = "PretUtilisateurNomBox"
        Me.PretUtilisateurNomBox.ReadOnly = True
        Me.PretUtilisateurNomBox.Size = New System.Drawing.Size(318, 22)
        Me.PretUtilisateurNomBox.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(488, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Utilisateur"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.DateEmpruntPicker)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.DateRetourPrevuPicker)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.NoUtilisateurBox)
        Me.Panel3.Location = New System.Drawing.Point(215, 13)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(260, 155)
        Me.Panel3.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Date d'emprunt"
        '
        'DateEmpruntPicker
        '
        Me.DateEmpruntPicker.Location = New System.Drawing.Point(6, 65)
        Me.DateEmpruntPicker.Name = "DateEmpruntPicker"
        Me.DateEmpruntPicker.Size = New System.Drawing.Size(155, 22)
        Me.DateEmpruntPicker.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Utilisateur"
        '
        'DateRetourPrevuPicker
        '
        Me.DateRetourPrevuPicker.Location = New System.Drawing.Point(6, 118)
        Me.DateRetourPrevuPicker.Name = "DateRetourPrevuPicker"
        Me.DateRetourPrevuPicker.Size = New System.Drawing.Size(155, 22)
        Me.DateRetourPrevuPicker.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Date de retour prévue"
        '
        'NoUtilisateurBox
        '
        Me.NoUtilisateurBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NoUtilisateurBox.Location = New System.Drawing.Point(99, 11)
        Me.NoUtilisateurBox.Name = "NoUtilisateurBox"
        Me.NoUtilisateurBox.Size = New System.Drawing.Size(125, 22)
        Me.NoUtilisateurBox.TabIndex = 0
        Me.NoUtilisateurBox.Text = "No. Utilisateur"
        '
        'Retour
        '
        Me.Retour.Controls.Add(Me.Panel7)
        Me.Retour.Controls.Add(Me.DGVRetour)
        Me.Retour.Controls.Add(Me.TextBox1)
        Me.Retour.Controls.Add(Me.Label3)
        Me.Retour.Controls.Add(Me.Panel4)
        Me.Retour.Location = New System.Drawing.Point(4, 25)
        Me.Retour.Name = "Retour"
        Me.Retour.Padding = New System.Windows.Forms.Padding(3)
        Me.Retour.Size = New System.Drawing.Size(1021, 497)
        Me.Retour.TabIndex = 1
        Me.Retour.Text = "Retours"
        Me.Retour.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Blue
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Location = New System.Drawing.Point(-4, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(206, 496)
        Me.Panel7.TabIndex = 12
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.ImprimerRetour)
        Me.Panel9.Controls.Add(Me.AnnulerRetour)
        Me.Panel9.Controls.Add(Me.ValiderRetour)
        Me.Panel9.Controls.Add(Me.NouveauRetour)
        Me.Panel9.Location = New System.Drawing.Point(24, 32)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(161, 166)
        Me.Panel9.TabIndex = 8
        '
        'ImprimerRetour
        '
        Me.ImprimerRetour.Location = New System.Drawing.Point(3, 126)
        Me.ImprimerRetour.Name = "ImprimerRetour"
        Me.ImprimerRetour.Size = New System.Drawing.Size(153, 35)
        Me.ImprimerRetour.TabIndex = 13
        Me.ImprimerRetour.Text = "Imprimer"
        Me.ImprimerRetour.UseVisualStyleBackColor = True
        '
        'AnnulerRetour
        '
        Me.AnnulerRetour.Location = New System.Drawing.Point(3, 85)
        Me.AnnulerRetour.Name = "AnnulerRetour"
        Me.AnnulerRetour.Size = New System.Drawing.Size(153, 35)
        Me.AnnulerRetour.TabIndex = 12
        Me.AnnulerRetour.Text = "Annuler"
        Me.AnnulerRetour.UseVisualStyleBackColor = True
        '
        'ValiderRetour
        '
        Me.ValiderRetour.Location = New System.Drawing.Point(3, 44)
        Me.ValiderRetour.Name = "ValiderRetour"
        Me.ValiderRetour.Size = New System.Drawing.Size(153, 35)
        Me.ValiderRetour.TabIndex = 11
        Me.ValiderRetour.Text = "Valider"
        Me.ValiderRetour.UseVisualStyleBackColor = True
        '
        'NouveauRetour
        '
        Me.NouveauRetour.Location = New System.Drawing.Point(3, 3)
        Me.NouveauRetour.Name = "NouveauRetour"
        Me.NouveauRetour.Size = New System.Drawing.Size(153, 35)
        Me.NouveauRetour.TabIndex = 10
        Me.NouveauRetour.Text = "Nouveau"
        Me.NouveauRetour.UseVisualStyleBackColor = True
        '
        'DGVRetour
        '
        Me.DGVRetour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRetour.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoArticleRetour, Me.DescriptionRetour, Me.TypeRetour, Me.QuantiteRetour, Me.EtatRetour})
        Me.DGVRetour.Location = New System.Drawing.Point(215, 181)
        Me.DGVRetour.Name = "DGVRetour"
        Me.DGVRetour.Size = New System.Drawing.Size(735, 305)
        Me.DGVRetour.TabIndex = 11
        '
        'NoArticleRetour
        '
        Me.NoArticleRetour.HeaderText = "No. d'article"
        Me.NoArticleRetour.Name = "NoArticleRetour"
        Me.NoArticleRetour.Width = 80
        '
        'DescriptionRetour
        '
        Me.DescriptionRetour.HeaderText = "Description"
        Me.DescriptionRetour.Name = "DescriptionRetour"
        Me.DescriptionRetour.Width = 300
        '
        'TypeRetour
        '
        Me.TypeRetour.HeaderText = "Type"
        Me.TypeRetour.Name = "TypeRetour"
        Me.TypeRetour.Width = 150
        '
        'QuantiteRetour
        '
        Me.QuantiteRetour.HeaderText = "Quantité"
        Me.QuantiteRetour.Name = "QuantiteRetour"
        Me.QuantiteRetour.Width = 80
        '
        'EtatRetour
        '
        Me.EtatRetour.HeaderText = "Etat"
        Me.EtatRetour.Name = "EtatRetour"
        Me.EtatRetour.Width = 80
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(560, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(318, 22)
        Me.TextBox1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(488, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Utilisateur"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.DateRetourPicker)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.Location = New System.Drawing.Point(215, 13)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(260, 155)
        Me.Panel4.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "No. Utilisateur"
        '
        'DateRetourPicker
        '
        Me.DateRetourPicker.Location = New System.Drawing.Point(6, 118)
        Me.DateRetourPicker.Name = "DateRetourPicker"
        Me.DateRetourPicker.Size = New System.Drawing.Size(155, 22)
        Me.DateRetourPicker.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Date de retour"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(99, 11)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 22)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "No. Utilisateur"
        '
        'ListePrets
        '
        Me.ListePrets.Controls.Add(Me.Panel10)
        Me.ListePrets.Controls.Add(Me.DGVListPret)
        Me.ListePrets.Location = New System.Drawing.Point(4, 25)
        Me.ListePrets.Name = "ListePrets"
        Me.ListePrets.Size = New System.Drawing.Size(1021, 497)
        Me.ListePrets.TabIndex = 2
        Me.ListePrets.Text = "Liste des prêts"
        Me.ListePrets.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Blue
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Location = New System.Drawing.Point(-4, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(206, 496)
        Me.Panel10.TabIndex = 13
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.Button7)
        Me.Panel11.Location = New System.Drawing.Point(24, 32)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(161, 43)
        Me.Panel11.TabIndex = 8
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(3, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(153, 35)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "Imprimer"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'DGVListPret
        '
        Me.DGVListPret.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListPret.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoEmpruntListPret, Me.NomEmpruntListPret, Me.NoArticleListPret, Me.DescriptionListPret, Me.QuantiteListPret, Me.EtatListPret})
        Me.DGVListPret.Location = New System.Drawing.Point(208, 3)
        Me.DGVListPret.Name = "DGVListPret"
        Me.DGVListPret.Size = New System.Drawing.Size(815, 489)
        Me.DGVListPret.TabIndex = 0
        '
        'NoEmpruntListPret
        '
        Me.NoEmpruntListPret.HeaderText = "No. de membre"
        Me.NoEmpruntListPret.Name = "NoEmpruntListPret"
        Me.NoEmpruntListPret.Width = 80
        '
        'NomEmpruntListPret
        '
        Me.NomEmpruntListPret.HeaderText = "Nom de l'emprunteur"
        Me.NomEmpruntListPret.Name = "NomEmpruntListPret"
        Me.NomEmpruntListPret.Width = 150
        '
        'NoArticleListPret
        '
        Me.NoArticleListPret.HeaderText = "No. d'Article"
        Me.NoArticleListPret.Name = "NoArticleListPret"
        Me.NoArticleListPret.Width = 80
        '
        'DescriptionListPret
        '
        Me.DescriptionListPret.HeaderText = "Description"
        Me.DescriptionListPret.Name = "DescriptionListPret"
        Me.DescriptionListPret.Width = 300
        '
        'QuantiteListPret
        '
        Me.QuantiteListPret.HeaderText = "Quantité"
        Me.QuantiteListPret.Name = "QuantiteListPret"
        Me.QuantiteListPret.Width = 80
        '
        'EtatListPret
        '
        Me.EtatListPret.HeaderText = "Etat"
        Me.EtatListPret.Name = "EtatListPret"
        Me.EtatListPret.Width = 80
        '
        'HistoriquePrets
        '
        Me.HistoriquePrets.Controls.Add(Me.Panel12)
        Me.HistoriquePrets.Controls.Add(Me.DGVHistPret)
        Me.HistoriquePrets.Location = New System.Drawing.Point(4, 25)
        Me.HistoriquePrets.Name = "HistoriquePrets"
        Me.HistoriquePrets.Size = New System.Drawing.Size(1021, 497)
        Me.HistoriquePrets.TabIndex = 5
        Me.HistoriquePrets.Text = "Historique des prêts"
        Me.HistoriquePrets.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Blue
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Location = New System.Drawing.Point(-4, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(206, 496)
        Me.Panel12.TabIndex = 14
        '
        'Panel13
        '
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.Button9)
        Me.Panel13.Location = New System.Drawing.Point(24, 32)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(161, 43)
        Me.Panel13.TabIndex = 8
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(3, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(153, 35)
        Me.Button9.TabIndex = 13
        Me.Button9.Text = "Imprimer"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'DGVHistPret
        '
        Me.DGVHistPret.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHistPret.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoMembreHistPret, Me.NomEmpruntHistPret, Me.NoArticleHistPret, Me.DescriptionHistPret, Me.QuantiteHistPret, Me.EtatHistPret})
        Me.DGVHistPret.Location = New System.Drawing.Point(208, 3)
        Me.DGVHistPret.Name = "DGVHistPret"
        Me.DGVHistPret.Size = New System.Drawing.Size(815, 489)
        Me.DGVHistPret.TabIndex = 1
        '
        'NoMembreHistPret
        '
        Me.NoMembreHistPret.HeaderText = "No. de membre"
        Me.NoMembreHistPret.Name = "NoMembreHistPret"
        Me.NoMembreHistPret.Width = 80
        '
        'NomEmpruntHistPret
        '
        Me.NomEmpruntHistPret.HeaderText = "Nom de l'emprunteur"
        Me.NomEmpruntHistPret.Name = "NomEmpruntHistPret"
        Me.NomEmpruntHistPret.Width = 150
        '
        'NoArticleHistPret
        '
        Me.NoArticleHistPret.HeaderText = "No. d'Article"
        Me.NoArticleHistPret.Name = "NoArticleHistPret"
        Me.NoArticleHistPret.Width = 80
        '
        'DescriptionHistPret
        '
        Me.DescriptionHistPret.HeaderText = "Description"
        Me.DescriptionHistPret.Name = "DescriptionHistPret"
        Me.DescriptionHistPret.Width = 300
        '
        'QuantiteHistPret
        '
        Me.QuantiteHistPret.HeaderText = "Quantité"
        Me.QuantiteHistPret.Name = "QuantiteHistPret"
        Me.QuantiteHistPret.Width = 80
        '
        'EtatHistPret
        '
        Me.EtatHistPret.HeaderText = "Etat"
        Me.EtatHistPret.Name = "EtatHistPret"
        Me.EtatHistPret.Width = 80
        '
        'HistoriqueRetour
        '
        Me.HistoriqueRetour.Controls.Add(Me.Panel14)
        Me.HistoriqueRetour.Controls.Add(Me.DGVHistRetour)
        Me.HistoriqueRetour.Location = New System.Drawing.Point(4, 25)
        Me.HistoriqueRetour.Name = "HistoriqueRetour"
        Me.HistoriqueRetour.Size = New System.Drawing.Size(1021, 497)
        Me.HistoriqueRetour.TabIndex = 6
        Me.HistoriqueRetour.Text = "Historique des retours"
        Me.HistoriqueRetour.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Blue
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Location = New System.Drawing.Point(-4, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(206, 496)
        Me.Panel14.TabIndex = 15
        '
        'Panel15
        '
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel15.Controls.Add(Me.Button11)
        Me.Panel15.Location = New System.Drawing.Point(24, 32)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(161, 43)
        Me.Panel15.TabIndex = 8
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(3, 3)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(153, 35)
        Me.Button11.TabIndex = 13
        Me.Button11.Text = "Imprimer"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'DGVHistRetour
        '
        Me.DGVHistRetour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHistRetour.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoMembreHistRetour, Me.NomEmpruntHistRetour, Me.NoArticleHistRetour, Me.DescriptionHistRetour, Me.QuantiteHistRetour, Me.EtatHistRetour})
        Me.DGVHistRetour.Location = New System.Drawing.Point(208, 3)
        Me.DGVHistRetour.Name = "DGVHistRetour"
        Me.DGVHistRetour.Size = New System.Drawing.Size(815, 489)
        Me.DGVHistRetour.TabIndex = 2
        '
        'NoMembreHistRetour
        '
        Me.NoMembreHistRetour.HeaderText = "No. de membre"
        Me.NoMembreHistRetour.Name = "NoMembreHistRetour"
        Me.NoMembreHistRetour.Width = 80
        '
        'NomEmpruntHistRetour
        '
        Me.NomEmpruntHistRetour.HeaderText = "Nom de l'emprunteur"
        Me.NomEmpruntHistRetour.Name = "NomEmpruntHistRetour"
        Me.NomEmpruntHistRetour.Width = 150
        '
        'NoArticleHistRetour
        '
        Me.NoArticleHistRetour.HeaderText = "No. d'Article"
        Me.NoArticleHistRetour.Name = "NoArticleHistRetour"
        Me.NoArticleHistRetour.Width = 80
        '
        'DescriptionHistRetour
        '
        Me.DescriptionHistRetour.HeaderText = "Description"
        Me.DescriptionHistRetour.Name = "DescriptionHistRetour"
        Me.DescriptionHistRetour.Width = 300
        '
        'QuantiteHistRetour
        '
        Me.QuantiteHistRetour.HeaderText = "Quantité"
        Me.QuantiteHistRetour.Name = "QuantiteHistRetour"
        Me.QuantiteHistRetour.Width = 80
        '
        'EtatHistRetour
        '
        Me.EtatHistRetour.HeaderText = "Etat"
        Me.EtatHistRetour.Name = "EtatHistRetour"
        Me.EtatHistRetour.Width = 80
        '
        'ListeMateriel
        '
        Me.ListeMateriel.Controls.Add(Me.Panel16)
        Me.ListeMateriel.Controls.Add(Me.DGVListMateriel)
        Me.ListeMateriel.Location = New System.Drawing.Point(4, 25)
        Me.ListeMateriel.Name = "ListeMateriel"
        Me.ListeMateriel.Padding = New System.Windows.Forms.Padding(3)
        Me.ListeMateriel.Size = New System.Drawing.Size(1021, 497)
        Me.ListeMateriel.TabIndex = 7
        Me.ListeMateriel.Text = "Liste du matériel"
        Me.ListeMateriel.UseVisualStyleBackColor = True
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.Blue
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Location = New System.Drawing.Point(-4, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(206, 496)
        Me.Panel16.TabIndex = 16
        '
        'Panel17
        '
        Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel17.Controls.Add(Me.Button1)
        Me.Panel17.Location = New System.Drawing.Point(24, 32)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(161, 43)
        Me.Panel17.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 35)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Imprimer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DGVListMateriel
        '
        Me.DGVListMateriel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListMateriel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Disponible, Me.DataGridViewTextBoxColumn5, Me.Prix, Me.NoSerie})
        Me.DGVListMateriel.Location = New System.Drawing.Point(208, 3)
        Me.DGVListMateriel.Name = "DGVListMateriel"
        Me.DGVListMateriel.Size = New System.Drawing.Size(815, 489)
        Me.DGVListMateriel.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "No. d'article"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantité"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'Disponible
        '
        Me.Disponible.HeaderText = "Disponible"
        Me.Disponible.Name = "Disponible"
        Me.Disponible.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Etat"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'Prix
        '
        Me.Prix.HeaderText = "Prix"
        Me.Prix.Name = "Prix"
        Me.Prix.Width = 80
        '
        'NoSerie
        '
        Me.NoSerie.HeaderText = "No. Série"
        Me.NoSerie.Name = "NoSerie"
        Me.NoSerie.Width = 150
        '
        'InterfacePrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 590)
        Me.Controls.Add(Me.AdminTabControl)
        Me.Controls.Add(Me.NomUniteLabel)
        Me.Name = "InterfacePrincipal"
        Me.Text = "Programme de Gestion d'Inventaire des Unités de Cadets"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.AdminTabControl.ResumeLayout(False)
        Me.Administration.ResumeLayout(False)
        Me.Administration.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.SGVSommairePerte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVUniforme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVSommaireEmprunt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Prets.ResumeLayout(False)
        Me.Prets.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.DGVPret, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Retour.ResumeLayout(False)
        Me.Retour.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.DGVRetour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ListePrets.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.DGVListPret, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HistoriquePrets.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        CType(Me.DGVHistPret, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HistoriqueRetour.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        CType(Me.DGVHistRetour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListeMateriel.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        CType(Me.DGVListMateriel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NomUniteLabel As System.Windows.Forms.Label
    Friend WithEvents AdminTabControl As System.Windows.Forms.TabControl
    Friend WithEvents Prets As System.Windows.Forms.TabPage
    Friend WithEvents Retour As System.Windows.Forms.TabPage
    Friend WithEvents Administration As System.Windows.Forms.TabPage
    Friend WithEvents ListePrets As System.Windows.Forms.TabPage
    Friend WithEvents HistoriquePrets As System.Windows.Forms.TabPage
    Friend WithEvents HistoriqueRetour As System.Windows.Forms.TabPage
    Friend WithEvents DGVUniforme As System.Windows.Forms.DataGridView
    Friend WithEvents DGVSommaireEmprunt As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GenererPerteBouton As System.Windows.Forms.Button
    Friend WithEvents EtiquetteBouton As System.Windows.Forms.Button
    Friend WithEvents GestionUniteBouton As System.Windows.Forms.Button
    Friend WithEvents GestionUtilisateursBouton As System.Windows.Forms.Button
    Friend WithEvents GestionCategoriesBouton As System.Windows.Forms.Button
    Friend WithEvents GestionArticlesBouton As System.Windows.Forms.Button
    Friend WithEvents PerteLabel As System.Windows.Forms.Label
    Friend WithEvents SGVSommairePerte As System.Windows.Forms.DataGridView
    Friend WithEvents UniformeLabel As System.Windows.Forms.Label
    Friend WithEvents EmpruntLabel As System.Windows.Forms.Label
    Friend WithEvents MenuLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CatalogueBouton As System.Windows.Forms.Button
    Friend WithEvents ModuleUniformeBouton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateRetourPrevuPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PretUtilisateurNomBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NoUtilisateurBox As System.Windows.Forms.TextBox
    Friend WithEvents DGVPret As System.Windows.Forms.DataGridView
    Friend WithEvents DGVRetour As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateRetourPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateEmpruntPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListeMateriel As System.Windows.Forms.TabPage
    Friend WithEvents NoArticlePret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionPret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypePret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantitePret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EtatPret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoArticleRetour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionRetour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeRetour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantiteRetour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EtatRetour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGVListPret As System.Windows.Forms.DataGridView
    Friend WithEvents DGVHistPret As System.Windows.Forms.DataGridView
    Friend WithEvents DGVHistRetour As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents ImprimerPret As System.Windows.Forms.Button
    Friend WithEvents AnnulerPret As System.Windows.Forms.Button
    Friend WithEvents ValiderPret As System.Windows.Forms.Button
    Friend WithEvents NouveauPret As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents ImprimerRetour As System.Windows.Forms.Button
    Friend WithEvents AnnulerRetour As System.Windows.Forms.Button
    Friend WithEvents ValiderRetour As System.Windows.Forms.Button
    Friend WithEvents NouveauRetour As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents NoEmpruntListPret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomEmpruntListPret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoArticleListPret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionListPret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantiteListPret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EtatListPret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoMembreHistPret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomEmpruntHistPret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoArticleHistPret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionHistPret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantiteHistPret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EtatHistPret As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoMembreHistRetour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomEmpruntHistRetour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoArticleHistRetour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionHistRetour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantiteHistRetour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EtatHistRetour As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DGVListMateriel As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Disponible As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prix As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoSerie As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
