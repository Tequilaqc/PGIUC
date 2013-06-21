Public Class GestionCategories

    Private Sub GestionCategories_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'PGUICDataSet.Categorie'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.CategorieTableAdapter.Fill(Me.PGUICDataSet.Categorie)


    End Sub

    Private Sub NouvelGCatBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouvelGCatBouton.Click
        IOModule.AddGDVCateorie(DGVCategorie, "Categorie")
    End Sub


    Private Sub FermerGCatBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FermerGCatBouton.Click

        Me.Hide()
    End Sub

    Private Sub ModifierGCatBouton_Click(sender As Object, e As EventArgs) Handles ModifierGCatBouton.Click
        IOModule.UpdateGDVCateorie(DGVCategorie, "Categorie")
    End Sub

    Private Sub supprimerGCatBouton_Click(sender As Object, e As EventArgs) Handles supprimerGCatBouton.Click
        IOModule.DeleteDGVCategorie(DGVCategorie, "CATEGORIE")
    End Sub

    Private Sub GestionCategories_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel() = True
        Me.FermerGCatBouton.PerformClick()
    End Sub

    Private Sub DGVCategorie_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVCategorie.CellDoubleClick
        IOModule.UpdateGDVCateorie(DGVCategorie, "Categorie")
    End Sub

    Private Sub ExportExcelCategorie_Click(sender As Object, e As EventArgs) Handles ExportExcelCategorie.Click
        SaveToExcelDGV(DGVCategorie, "Categorie")
    End Sub
End Class