
Public Class InterfacePrincipal


    Private Sub GestionArticlesBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionArticlesBouton.Click
        GestionArticles.Show()
    End Sub

    Private Sub GestionCategoriesBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionCategoriesBouton.Click
        GestionCategories.Show()
    End Sub

    Private Sub GestionUtilisateursBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionUtilisateursBouton.Click
        GestionUtilisateur.Show()
    End Sub

    Private Sub GestionUniteBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionUniteBouton.Click
        GestionUnite.Show()
    End Sub

    Private Sub EtiquetteBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EtiquetteBouton.Click
        EtiquetteArticles.Show()
    End Sub

    Private Sub GenererPerteBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenererPerteBouton.Click

    End Sub

    Private Sub SaisiePrets_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prets.Enter

        'MsgBox("lalala")
        'NoUtilisateurBox.Text = InputBox("Veuiller entrer le numéro d'utilisateur à l'aide du lecteur de code barre")

    End Sub






End Class
