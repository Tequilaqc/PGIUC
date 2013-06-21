<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NouvelArticle
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DescriptionArticleBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.QuantiteArticleBox = New System.Windows.Forms.TextBox()
        Me.PrixArticleBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CategorieArticleBox = New System.Windows.Forms.ComboBox()
        Me.EtatArticleBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NoArticleBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PhotoArticleBox = New System.Windows.Forms.PictureBox()
        Me.NoSerieArticleBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGVArticleContenu = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contenuelabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ValideBouton = New System.Windows.Forms.Button()
        Me.ImprimerNArtBouton = New System.Windows.Forms.Button()
        Me.ApercuNArtBouton = New System.Windows.Forms.Button()
        Me.AjouterNArtBouton = New System.Windows.Forms.Button()
        Me.AnnulerNArtBouton = New System.Windows.Forms.Button()
        Me.FermerNArtBouton = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PhotoArticleBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVArticleContenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No. d'article"
        '
        'DescriptionArticleBox
        '
        Me.DescriptionArticleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescriptionArticleBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionArticleBox.Location = New System.Drawing.Point(95, 42)
        Me.DescriptionArticleBox.Name = "DescriptionArticleBox"
        Me.DescriptionArticleBox.Size = New System.Drawing.Size(266, 22)
        Me.DescriptionArticleBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Description"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quantité"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(222, 84)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Prix"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 120)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Catégorie"
        '
        'QuantiteArticleBox
        '
        Me.QuantiteArticleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QuantiteArticleBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantiteArticleBox.Location = New System.Drawing.Point(95, 78)
        Me.QuantiteArticleBox.Name = "QuantiteArticleBox"
        Me.QuantiteArticleBox.Size = New System.Drawing.Size(95, 22)
        Me.QuantiteArticleBox.TabIndex = 8
        '
        'PrixArticleBox
        '
        Me.PrixArticleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PrixArticleBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrixArticleBox.Location = New System.Drawing.Point(266, 78)
        Me.PrixArticleBox.Name = "PrixArticleBox"
        Me.PrixArticleBox.Size = New System.Drawing.Size(95, 22)
        Me.PrixArticleBox.TabIndex = 9
        Me.PrixArticleBox.Text = "0"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 156)
        Me.Label7.Margin = New System.Windows.Forms.Padding(10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "État"
        '
        'CategorieArticleBox
        '
        Me.CategorieArticleBox.FormattingEnabled = True
        Me.CategorieArticleBox.Location = New System.Drawing.Point(95, 115)
        Me.CategorieArticleBox.Name = "CategorieArticleBox"
        Me.CategorieArticleBox.Size = New System.Drawing.Size(265, 21)
        Me.CategorieArticleBox.TabIndex = 11
        '
        'EtatArticleBox
        '
        Me.EtatArticleBox.FormattingEnabled = True
        Me.EtatArticleBox.Items.AddRange(New Object() {"Neuf", "Bon", "Moyen", "Mauvais", "Inutilisable"})
        Me.EtatArticleBox.Location = New System.Drawing.Point(95, 151)
        Me.EtatArticleBox.Name = "EtatArticleBox"
        Me.EtatArticleBox.Size = New System.Drawing.Size(265, 21)
        Me.EtatArticleBox.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(193, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "12 chiffres sans espaces"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.NoArticleBox)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.PhotoArticleBox)
        Me.Panel1.Controls.Add(Me.NoSerieArticleBox)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.EtatArticleBox)
        Me.Panel1.Controls.Add(Me.CategorieArticleBox)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PrixArticleBox)
        Me.Panel1.Controls.Add(Me.QuantiteArticleBox)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DescriptionArticleBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(215, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(737, 228)
        Me.Panel1.TabIndex = 14
        '
        'NoArticleBox
        '
        Me.NoArticleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NoArticleBox.Location = New System.Drawing.Point(95, 10)
        Me.NoArticleBox.Mask = "000000000000"
        Me.NoArticleBox.Name = "NoArticleBox"
        Me.NoArticleBox.Size = New System.Drawing.Size(78, 20)
        Me.NoArticleBox.TabIndex = 18
        Me.NoArticleBox.Text = "000000000001"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(396, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Photo"
        '
        'PhotoArticleBox
        '
        Me.PhotoArticleBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PhotoArticleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PhotoArticleBox.Location = New System.Drawing.Point(396, 25)
        Me.PhotoArticleBox.Name = "PhotoArticleBox"
        Me.PhotoArticleBox.Size = New System.Drawing.Size(317, 183)
        Me.PhotoArticleBox.TabIndex = 16
        Me.PhotoArticleBox.TabStop = False
        '
        'NoSerieArticleBox
        '
        Me.NoSerieArticleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NoSerieArticleBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoSerieArticleBox.Location = New System.Drawing.Point(95, 186)
        Me.NoSerieArticleBox.Name = "NoSerieArticleBox"
        Me.NoSerieArticleBox.Size = New System.Drawing.Size(266, 22)
        Me.NoSerieArticleBox.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 192)
        Me.Label8.Margin = New System.Windows.Forms.Padding(10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "No. Série"
        '
        'DGVArticleContenu
        '
        Me.DGVArticleContenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVArticleContenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Description, Me.Quantite})
        Me.DGVArticleContenu.Location = New System.Drawing.Point(215, 270)
        Me.DGVArticleContenu.Name = "DGVArticleContenu"
        Me.DGVArticleContenu.Size = New System.Drawing.Size(545, 178)
        Me.DGVArticleContenu.TabIndex = 15
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.Width = 300
        '
        'Quantite
        '
        Me.Quantite.HeaderText = "Quantité"
        Me.Quantite.Name = "Quantite"
        '
        'Contenuelabel
        '
        Me.Contenuelabel.AutoSize = True
        Me.Contenuelabel.Location = New System.Drawing.Point(212, 254)
        Me.Contenuelabel.Name = "Contenuelabel"
        Me.Contenuelabel.Size = New System.Drawing.Size(445, 13)
        Me.Contenuelabel.TabIndex = 16
        Me.Contenuelabel.Text = "Contenue * indiquer si l'article contient du matériel qui ne sera pas séparé lors" & _
    " de son emprunt"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(206, 445)
        Me.Panel2.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ValideBouton)
        Me.Panel3.Controls.Add(Me.ImprimerNArtBouton)
        Me.Panel3.Controls.Add(Me.ApercuNArtBouton)
        Me.Panel3.Controls.Add(Me.AjouterNArtBouton)
        Me.Panel3.Controls.Add(Me.AnnulerNArtBouton)
        Me.Panel3.Controls.Add(Me.FermerNArtBouton)
        Me.Panel3.Location = New System.Drawing.Point(24, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(161, 206)
        Me.Panel3.TabIndex = 18
        '
        'ValideBouton
        '
        Me.ValideBouton.Location = New System.Drawing.Point(3, 3)
        Me.ValideBouton.Name = "ValideBouton"
        Me.ValideBouton.Size = New System.Drawing.Size(153, 35)
        Me.ValideBouton.TabIndex = 19
        Me.ValideBouton.Text = "Valider Modification"
        Me.ValideBouton.UseVisualStyleBackColor = True
        '
        'ImprimerNArtBouton
        '
        Me.ImprimerNArtBouton.Location = New System.Drawing.Point(3, 125)
        Me.ImprimerNArtBouton.Name = "ImprimerNArtBouton"
        Me.ImprimerNArtBouton.Size = New System.Drawing.Size(153, 35)
        Me.ImprimerNArtBouton.TabIndex = 17
        Me.ImprimerNArtBouton.Text = "Imprimer"
        Me.ImprimerNArtBouton.UseVisualStyleBackColor = True
        '
        'ApercuNArtBouton
        '
        Me.ApercuNArtBouton.Location = New System.Drawing.Point(3, 84)
        Me.ApercuNArtBouton.Name = "ApercuNArtBouton"
        Me.ApercuNArtBouton.Size = New System.Drawing.Size(153, 35)
        Me.ApercuNArtBouton.TabIndex = 16
        Me.ApercuNArtBouton.Text = "Aperçu"
        Me.ApercuNArtBouton.UseVisualStyleBackColor = True
        '
        'AjouterNArtBouton
        '
        Me.AjouterNArtBouton.Location = New System.Drawing.Point(3, 3)
        Me.AjouterNArtBouton.Name = "AjouterNArtBouton"
        Me.AjouterNArtBouton.Size = New System.Drawing.Size(153, 35)
        Me.AjouterNArtBouton.TabIndex = 0
        Me.AjouterNArtBouton.Text = "Ajouter"
        Me.AjouterNArtBouton.UseVisualStyleBackColor = True
        '
        'AnnulerNArtBouton
        '
        Me.AnnulerNArtBouton.Location = New System.Drawing.Point(3, 43)
        Me.AnnulerNArtBouton.Name = "AnnulerNArtBouton"
        Me.AnnulerNArtBouton.Size = New System.Drawing.Size(153, 35)
        Me.AnnulerNArtBouton.TabIndex = 15
        Me.AnnulerNArtBouton.Text = "Annuler"
        Me.AnnulerNArtBouton.UseVisualStyleBackColor = True
        '
        'FermerNArtBouton
        '
        Me.FermerNArtBouton.Location = New System.Drawing.Point(3, 166)
        Me.FermerNArtBouton.Name = "FermerNArtBouton"
        Me.FermerNArtBouton.Size = New System.Drawing.Size(153, 35)
        Me.FermerNArtBouton.TabIndex = 14
        Me.FermerNArtBouton.Text = "Fermer"
        Me.FermerNArtBouton.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(772, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Aperçu code barre"
        '
        'NouvelArticle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 450)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Contenuelabel)
        Me.Controls.Add(Me.DGVArticleContenu)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NouvelArticle"
        Me.Text = "Nouvel article"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PhotoArticleBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVArticleContenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DescriptionArticleBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents QuantiteArticleBox As System.Windows.Forms.TextBox
    Friend WithEvents PrixArticleBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CategorieArticleBox As System.Windows.Forms.ComboBox
    Friend WithEvents EtatArticleBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PhotoArticleBox As System.Windows.Forms.PictureBox
    Friend WithEvents NoSerieArticleBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DGVArticleContenu As System.Windows.Forms.DataGridView
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contenuelabel As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ImprimerNArtBouton As System.Windows.Forms.Button
    Friend WithEvents ApercuNArtBouton As System.Windows.Forms.Button
    Friend WithEvents AjouterNArtBouton As System.Windows.Forms.Button
    Friend WithEvents AnnulerNArtBouton As System.Windows.Forms.Button
    Friend WithEvents FermerNArtBouton As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ValideBouton As System.Windows.Forms.Button
    Friend WithEvents NoArticleBox As System.Windows.Forms.MaskedTextBox
End Class
