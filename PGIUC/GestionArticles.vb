Public Class GestionArticles

    Private Sub NouvelArticleBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouvelGArtBouton.Click
        NouvelArticle.Show()
        NouvelArticle.Text = "Nouvel Article"
        NouvelArticle.ValideBouton.Hide()
    End Sub


    'Mise a jours des champs via le bouton modifier
    Private Sub ModifierGArtBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierGArtBouton.Click
        If DGVArticle.RowCount = 0 Then
            MsgBox("Il n'y a aucune article enregistré présentement")
        Else
            UpdateChampTextModifier()
            NouvelArticle.Show()
        End If
    End Sub


    'Mise a jours des champs via un double click dans le datagridview
    Private Sub DGVArticle_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVArticle.CellDoubleClick
        NouvelArticle.Show()
        UpdateChampTextModifier()
    End Sub


    'Remplie les champ à modifier 
    Private Sub UpdateChampTextModifier()
        NouvelArticle.AjouterNArtBouton.Hide()
        NouvelArticle.ValideBouton.Show()
        NouvelArticle.Text = "Modification d'un article existant"
        NouvelArticle.NoArticleBox.Text = DGVArticle.Item(1, DGVArticle.CurrentCell.RowIndex).Value
        NouvelArticle.DescriptionArticleBox.Text = DGVArticle.Item(2, DGVArticle.CurrentCell.RowIndex).Value
        NouvelArticle.CategorieArticleBox.Text = DGVArticle.Item(3, DGVArticle.CurrentCell.RowIndex).Value
        NouvelArticle.EtatArticleBox.Text = DGVArticle.Item(4, DGVArticle.CurrentCell.RowIndex).Value
        NouvelArticle.QuantiteArticleBox.Text = DGVArticle.Item(5, DGVArticle.CurrentCell.RowIndex).Value
        NouvelArticle.PrixArticleBox.Text = DGVArticle.Item(7, DGVArticle.CurrentCell.RowIndex).Value
        NouvelArticle.NoSerieArticleBox.Text = DGVArticle.Item(8, DGVArticle.CurrentCell.RowIndex).Value
    End Sub


    Private Sub supprimerGArtBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimerGArtBouton.Click
        If MsgBox("Etes-vous vraiment certain de voulloir supprimer cet article?", MsgBoxStyle.YesNo) = 6 Then
            IOModule.DeleteDGV(DGVArticle, "Article")
        End If
    End Sub

    Private Sub FermerGArtBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FermerGArtBouton.Click
        Me.Hide()
    End Sub

    Private Sub GestionArticles_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Me.FermerGArtBouton.PerformClick()
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub GestionArticles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'PGUICDataSet.Article'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ArticleTableAdapter.Fill(Me.PGUICDataSet.Article)

    End Sub


    Private Sub ExportItemExcel_Click(sender As Object, e As EventArgs) Handles ExportItemExcel.Click
        SaveToExcelDGV(DGVArticle, "Article")
    End Sub
End Class