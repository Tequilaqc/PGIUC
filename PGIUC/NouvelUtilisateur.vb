Public Class NouvelUtilisateur

    Public TypeMembre As String = "Cadet"

    'Adapter à chaque élément via menu Unité
    Dim GradeCadet() As String = {"Cadet", "Soldat", "Caporal", "Caporal-Chef", "Sergent", "Adjudant", "Adjudant-Maître", "Adjudant-Chef"}
    Dim GradeOfficier() As String = {"Élève-Officier", "Second-Lieutenant", "Lieutenant", "Capitaine", "Major"}
    Dim GradeComite() As String = {"Président", "Vice-Président", "Trésorier", "Secrétaire", "administrateur"}
    Dim GradeParent() As String = {"Monsieur", "Madame"}

    Private Sub NouvelUtilisateur_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        AjouterUserBouton.PerformClick()
    End Sub


    Private Sub ValideBoutonUser_Click(sender As Object, e As EventArgs) Handles ValideBoutonUser.Click
        UpdateGDVUser(GestionUtilisateur.DGVUtilisateur, "Utilisateurcadet")
        ResetTextBoxUser()
        Me.Hide()
    End Sub

    Private Sub AjouterUserBouton_Click(sender As Object, e As EventArgs) Handles AjouterUserBouton.Click
        AddGDVUser(GestionUtilisateur.DGVUtilisateur, "Utilisateurcadet")
        ResetTextBoxUser()
        Me.Hide()
    End Sub

    Private Sub FermerUserBouton_Click(sender As Object, e As EventArgs) Handles FermerUserBouton.Click
        ResetTextBoxUser()
        Me.Hide()
    End Sub

    Private Sub OfficierRadio_CheckedChanged(sender As Object, e As EventArgs) Handles OfficierRadio.CheckedChanged
        TypeMembre = "Officier"
        ChoisirGrade(GradeOfficier)
    End Sub

    Private Sub CadetCadreRadio_CheckedChanged(sender As Object, e As EventArgs) Handles CadetCadreRadio.CheckedChanged
        TypeMembre = "Cadet-Cadre"
        ChoisirGrade(GradeCadet)
    End Sub

    Private Sub CadetRadio_CheckedChanged(sender As Object, e As EventArgs) Handles CadetRadio.CheckedChanged
        TypeMembre = "Cadet"
        ChoisirGrade(GradeCadet)
    End Sub

    Private Sub ComiteRadio_CheckedChanged(sender As Object, e As EventArgs) Handles ComiteRadio.CheckedChanged
        TypeMembre = "Membre du comité"
        ChoisirGrade(GradeComite)
    End Sub

    Private Sub ParentRadio_CheckedChanged(sender As Object, e As EventArgs) Handles ParentRadio.CheckedChanged
        TypeMembre = "Parent"
        ChoisirGrade(GradeParent)
    End Sub

    Public Sub ChoisirGrade(ByRef Tab() As String)
        GradeBox.Items.Clear()
        For c = 0 To Tab.GetUpperBound(0)
            GradeBox.Items.Add(Tab(c))
        Next

    End Sub

    Public Sub ResetTextBoxUser()
        NomBox.Text = ""
        NoMembreBox.Text = ""
        PrenomBox.Text = ""
        GradeBox.Text = ""
        OfficierRadio.Checked = True
    End Sub

    Public Sub ChargeTextBoxUser()
        GradeBox.Text = GestionUtilisateur.DGVUtilisateur.Item(1, GestionUtilisateur.DGVUtilisateur.CurrentCell.RowIndex).Value
        NomBox.Text = GestionUtilisateur.DGVUtilisateur.Item(2, GestionUtilisateur.DGVUtilisateur.CurrentCell.RowIndex).Value
        PrenomBox.Text = GestionUtilisateur.DGVUtilisateur.Item(3, GestionUtilisateur.DGVUtilisateur.CurrentCell.RowIndex).Value
        Select Case GestionUtilisateur.DGVUtilisateur.Item(4, GestionUtilisateur.DGVUtilisateur.CurrentCell.RowIndex).Value
            Case "Officier"
                OfficierRadio.Checked = True
            Case "Cadet"
                CadetRadio.Checked = True
            Case "Cadet-Cadre"
                CadetCadreRadio.Checked = True
            Case "Membre du comité"
                ComiteRadio.Checked = True
            Case "Parent"
                ParentRadio.Checked = True
        End Select
        NoMembreBox.Text = GestionUtilisateur.DGVUtilisateur.Item(5, GestionUtilisateur.DGVUtilisateur.CurrentCell.RowIndex).Value

    End Sub

End Class