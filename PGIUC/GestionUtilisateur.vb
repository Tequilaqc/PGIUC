Public Class GestionUtilisateur

    Private Sub GestionUtilisateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'PGUICDataSet.Utilisateurcadet'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.UtilisateurcadetTableAdapter.Fill(Me.PGUICDataSet.Utilisateurcadet)

    End Sub

    Private Sub NouvelGUtilBouton_Click(sender As Object, e As EventArgs) Handles NouvelGUtilBouton.Click
        NouvelUtilisateur.ValideBoutonUser.Hide()
        NouvelUtilisateur.AjouterUserBouton.Show()
        NouvelUtilisateur.Show()
        NouvelUtilisateur.ResetTextBoxUser()
    End Sub

    Private Sub ModifierGUtilBouton_Click(sender As Object, e As EventArgs) Handles ModifierGUtilBouton.Click
        NouvelUtilisateur.ValideBoutonUser.Show()
        NouvelUtilisateur.AjouterUserBouton.Hide()
        NouvelUtilisateur.Show()
        NouvelUtilisateur.Text = "Modifier une fiche utilisateur"
        NouvelUtilisateur.ChargeTextBoxUser()
    End Sub

    Private Sub FermerGUtilBouton_Click(sender As Object, e As EventArgs) Handles FermerGUtilBouton.Click
        Me.Hide()
    End Sub

    Private Sub supprimerGUtilBouton_Click(sender As Object, e As EventArgs) Handles supprimerGUtilBouton.Click
        DeleteDGVUser(DGVUtilisateur, "Utilisateurcadet")
    End Sub

    Private Sub ExportExcelUser_Click(sender As Object, e As EventArgs) Handles ExportExcelUser.Click
        SaveToExcelDGV(DGVUtilisateur, "Utilisateur")
    End Sub
End Class