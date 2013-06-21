Public Class GestionUnite

    Private Sub GestionUnite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub NouvelArticle_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
        InterfacePrincipal.NomUniteLabel.Text = NomUniteBox.Text
    End Sub

End Class