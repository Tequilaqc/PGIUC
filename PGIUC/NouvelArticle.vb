Public Class NouvelArticle

    Public article As New Article()
    Dim ChampObligatoire As Boolean = False

    Private Sub AjouterNArtBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterNArtBouton.Click
        AddGDVArticle(GestionArticles.DGVArticle, "Article")
        Me.Hide()
    End Sub


    Private Sub ValideBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValideBouton.Click
        UpdateGDVArticle(GestionArticles.DGVArticle, "Article")
        Me.Hide()
    End Sub


    Private Sub AnnulerNArtBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnnulerNArtBouton.Click
        If MsgBox("Etes-vous certain de voulloir effacer les prises/modifications de données ?", MsgBoxStyle.YesNo) = 6 Then
            NoArticleBox.Text = article.NumeroArticle
            DescriptionArticleBox.Text = article.Description
            CategorieArticleBox.Text = article.CategorieArticle
            EtatArticleBox.Text = article.EtatArticle
            QuantiteArticleBox.Text = article.Quantite
            PrixArticleBox.Text = article.PrixArticle
            NoSerieArticleBox.Text = article.NumeroSerie
        End If
    End Sub

    Private Sub FermerNArtBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FermerNArtBouton.Click
        Me.Hide()
    End Sub

    Public Sub DonneesAmodifier()
        Me.NoArticleBox.Text = GestionArticles.DGVArticle.Item(0, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value
        Me.DescriptionArticleBox.Text = GestionArticles.DGVArticle.Item(1, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value
        Me.CategorieArticleBox.Text = GestionArticles.DGVArticle.Item(2, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value
        Me.EtatArticleBox.Text = GestionArticles.DGVArticle.Item(3, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value
        Me.QuantiteArticleBox.Text = GestionArticles.DGVArticle.Item(4, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value
        Me.PrixArticleBox.Text = GestionArticles.DGVArticle.Item(5, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value
        Me.NoSerieArticleBox.Text = GestionArticles.DGVArticle.Item(6, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value

        article.NumeroArticle = NoArticleBox.Text
        article.Description = DescriptionArticleBox.Text
        article.CategorieArticle = CategorieArticleBox.Text
        article.EtatArticle = EtatArticleBox.Text
        article.Quantite = QuantiteArticleBox.Text
        article.PrixArticle = PrixArticleBox.Text
        article.NumeroSerie = NoSerieArticleBox.Text
    End Sub


    Private Function ValidationTextbox()

        If NoArticleBox.Text = "" Then
            NoArticleBox.BackColor = Color.Red
            ChampObligatoire = True
        End If

        If NoArticleBox.Text.ToString.Length <> 12 Then
            NoArticleBox.BackColor = Color.Red
            ChampObligatoire = True
            MsgBox("Le numéro d'article doit contenir 12 chiffres sans espaces")
        End If

        If DescriptionArticleBox.Text = "" Then
            DescriptionArticleBox.BackColor = Color.Red
            ChampObligatoire = True
        End If

        If QuantiteArticleBox.Text = "" Then
            QuantiteArticleBox.BackColor = Color.Red
            ChampObligatoire = True
        End If

        If ChampObligatoire Then
            MsgBox("Veuillez remplir les champs obligatoires")
        Else
            For c = 0 To GestionArticles.DGVArticle.RowCount - 1
                If NoArticleBox.Text = GestionArticles.DGVArticle.Item(0, c).Value Then
                    MsgBox("Le numéro d'item choisi existe déjâ, veuiller choisir un autre numéro d'item!")
                    NoArticleBox.BackColor = Color.Red
                    ChampObligatoire = True
                    Exit For
                End If
            Next
        End If

        Return ChampObligatoire
    End Function

    Private Sub NouvelArticle_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub
    
    Private Sub NouvelArticle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class