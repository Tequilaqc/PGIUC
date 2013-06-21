
Imports Microsoft.Office.Interop
Imports System.Data.OleDb

Module IOModule
    ' String de connexion à la base de donnée ACCES
    Dim PGUICConnectionString As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\PGUIC.mdb")


    ' Variable Excel pour l'exportation de donnée
    Public FichierExcel As Excel.Application
    Public ClasseurExcel As Excel.Workbook
    Public FeuilleExcel As Excel.Worksheet


    Sub RefreshDGV(ByRef DGV As DataGridView, ByVal NomTable As String)
        Dim sql As String
        sql = "SELECT * FROM " + NomTable
        Dim adapter As New OleDbDataAdapter(sql, PGUICConnectionString)
        Dim dt As New DataTable(NomTable)
        adapter.Fill(dt)
        DGV.DataSource = dt
    End Sub


    Public Sub DeleteDGV(ByRef DGV As DataGridView, ByVal Nomtable As String)
        Dim sqldelete As String
        sqldelete = "DELETE * FROM " + Nomtable + " WHERE ID_" + Nomtable.ToUpper + "=" + DGV.Item(0, DGV.CurrentCell.RowIndex).Value.ToString
        Dim adapter As New OleDbDataAdapter(sqldelete, PGUICConnectionString)
        Dim dt As New DataTable(Nomtable)
        adapter.Fill(dt)
        DGV.DataSource = dt
        RefreshDGV(DGV, Nomtable)
    End Sub

    Public Sub DeleteDGVUser(ByRef DGV As DataGridView, ByVal Nomtable As String)
        Dim sqldelete As String
        sqldelete = "DELETE * FROM " + Nomtable + " WHERE ID_USERCADET=" + DGV.Item(0, DGV.CurrentCell.RowIndex).Value.ToString
        Dim adapter As New OleDbDataAdapter(sqldelete, PGUICConnectionString)
        Dim dt As New DataTable(Nomtable)
        adapter.Fill(dt)
        DGV.DataSource = dt
        RefreshDGV(DGV, Nomtable)
    End Sub

    Public Sub DeleteDGVCategorie(ByRef DGV As DataGridView, ByVal Nomtable As String)

        Dim sqldelete As String
        sqldelete = "DELETE * FROM " + Nomtable + " WHERE NO_" + Nomtable.ToUpper + "=" + DGV.Item(0, DGV.CurrentCell.RowIndex).Value.ToString
        Dim adapter As New OleDbDataAdapter(sqldelete, PGUICConnectionString)
        Dim dt As New DataTable(Nomtable)
        adapter.Fill(dt)
        DGV.DataSource = dt
        RefreshDGV(DGV, Nomtable)
    End Sub

    Public Sub cmdParamAddArticle(ByVal sql As String)
        Dim cmd As New OleDbCommand(sql, PGUICConnectionString)
        cmd.Parameters.Add(New OleDbParameter("@NO_ARTICLE", NouvelArticle.NoArticleBox.Text))
        cmd.Parameters.Add(New OleDbParameter("@Description", NouvelArticle.DescriptionArticleBox.Text))
        cmd.Parameters.Add(New OleDbParameter("@no_categorie", NouvelArticle.CategorieArticleBox.Text))
        cmd.Parameters.Add(New OleDbParameter("@etat", NouvelArticle.EtatArticleBox.Text))
        cmd.Parameters.Add(New OleDbParameter("@qte_totale", NouvelArticle.QuantiteArticleBox.Text))
        cmd.Parameters.Add(New OleDbParameter("@qte_restante", NouvelArticle.QuantiteArticleBox.Text))
        cmd.Parameters.Add(New OleDbParameter("@prix", NouvelArticle.PrixArticleBox.Text))
        cmd.Parameters.Add(New OleDbParameter("@no_serie", NouvelArticle.NoSerieArticleBox.Text))
        cmd.Parameters.Add(New OleDbParameter("@disponible", True))
        cmd.Parameters.Add(New OleDbParameter("@date_ajout", NouvelArticle.article.DateAjout))
        PGUICConnectionString.Open()
        cmd.ExecuteNonQuery()
        PGUICConnectionString.Close()
    End Sub



    Public Sub cmdParamAddUser(ByVal sql As String)
        Dim cmd As New OleDbCommand(sql, PGUICConnectionString)
        cmd.Parameters.Add(New OleDbParameter("@Grade", NouvelUtilisateur.GradeBox.Text))
        cmd.Parameters.Add(New OleDbParameter("@NomMembre", NouvelUtilisateur.NomBox.Text))
        cmd.Parameters.Add(New OleDbParameter("@PrenomMembre", NouvelUtilisateur.PrenomBox.Text))
        cmd.Parameters.Add(New OleDbParameter("@TypeMembre", NouvelUtilisateur.TypeMembre))
        cmd.Parameters.Add(New OleDbParameter("@CodeBarreMembre", NouvelUtilisateur.NoMembreBox.Text))
        PGUICConnectionString.Open()
        cmd.ExecuteNonQuery()
        PGUICConnectionString.Close()
    End Sub


    Public Sub cmdParamAddCategorie(ByVal sql As String)

        Dim cmd As New OleDbCommand(sql, PGUICConnectionString)
        cmd.Parameters.Add(New OleDbParameter("@nom_categorie", InputBox("Entrer un nom de catégorie")))
        PGUICConnectionString.Open()
        cmd.ExecuteNonQuery()
        PGUICConnectionString.Close()

    End Sub

    Public Sub AddGDVArticle(ByRef DGV As DataGridView, ByVal Nomtable As String)
        Dim sqlinsert As String
        sqlinsert = "INSERT INTO " + Nomtable + "(NO_ARTICLE, Description, no_categorie, etat, qte_totale, qte_restante, prix, no_serie, disponible, date_ajout)" & _
        "VALUES(@NO_ARTICLE, @Description, @no_categorie, @etat, @qte_totale, @qte_restante, @prix, @no_serie, @disponible, @date_ajout)"
        cmdParamAddArticle(sqlinsert)
        RefreshDGV(DGV, Nomtable)
    End Sub

    Public Sub UpdateGDVArticle(ByRef DGV As DataGridView, ByVal nomTable As String)
        Dim sqlupdate As String
        sqlupdate = "UPDATE " + nomTable + " SET NO_ARTICLE=@NO_ARTICLE, Description=@Description, no_categorie=@no_categorie, etat=@etat, qte_totale=@qte_totale, qte_restante=@qte_restante, prix=@prix, no_serie=@no_serie, disponible=@disponible, date_ajout=@date_ajout WHERE ID_ARTICLE=" + DGV.Item(0, DGV.CurrentCell.RowIndex).Value.ToString
        Dim cmd As New OleDbCommand(sqlupdate, PGUICConnectionString)
        cmdParamAddArticle(sqlupdate)
        RefreshDGV(DGV, nomTable)
    End Sub

    Public Sub AddGDVCateorie(ByRef DGV As DataGridView, ByVal Nomtable As String)
        Dim sqlinsert As String
        sqlinsert = "INSERT INTO " + Nomtable + "(nom_categorie)" & _
        "VALUES(@nom_categorie)"
        cmdParamAddCategorie(sqlinsert)
        RefreshDGV(DGV, Nomtable)
    End Sub

    Public Sub UpdateGDVCateorie(ByRef DGV As DataGridView, ByVal nomTable As String)
        Dim sqlupdate As String
        sqlupdate = "UPDATE " + nomTable + " SET nom_categorie=@nom_categorie WHERE NO_CATEGORIE=" + DGV.Item(0, DGV.CurrentCell.RowIndex).Value.ToString
        Dim cmd As New OleDbCommand(sqlupdate, PGUICConnectionString)
        cmdParamAddCategorie(sqlupdate)
        RefreshDGV(DGV, nomTable)
    End Sub

    Public Sub AddGDVUser(ByRef DGV As DataGridView, ByVal Nomtable As String)
        Dim sqlinsert As String
        sqlinsert = "INSERT INTO " + Nomtable + "(Grade, NomMembre, PrenomMembre, TypeMembre, CodeBarreMembre)" & _
        "VALUES(@Grade, @NomMembre, @PrenomMembre, @TypeMembre, @CodeBarreMembre)"
        cmdParamAddUser(sqlinsert)
        RefreshDGV(DGV, Nomtable)
    End Sub

    Public Sub UpdateGDVUser(ByRef DGV As DataGridView, ByVal nomTable As String)
        Dim sqlupdate As String
        sqlupdate = "UPDATE " + nomTable + " SET Grade=@Grade, NomMembre=@NomMembre, PrenomMembre=@PrenomMembre, TypeMembre=@TypeMembre, CodeBarreMembre=@CodeBarreMembre WHERE ID_USERCADET=" + DGV.Item(0, DGV.CurrentCell.RowIndex).Value.ToString
        Dim cmd As New OleDbCommand(sqlupdate, PGUICConnectionString)
        cmdParamAddUser(sqlupdate)
        RefreshDGV(DGV, nomTable)
    End Sub


    'Enregistrer vers excel les données d'un DataGridView
    Public Sub SaveToExcelDGV(ByRef DGV As DataGridView, ByVal NomFichier As String)
        FichierExcel = New Excel.Application
        FichierExcel.Workbooks.Add()
        ClasseurExcel = FichierExcel.ActiveWorkbook
        ClasseurExcel.SaveCopyAs(NomFichier)
        FeuilleExcel = FichierExcel.ActiveSheet
        FichierExcel.Visible = True
        FeuilleExcel.Name = NomFichier
        For Column = 0 To DGV.ColumnCount - 1
            FeuilleExcel.Cells(1, 1 + Column) = (DGV.Columns(Column).HeaderCell.Value())
            For Row = 0 To DGV.RowCount - 1
                FeuilleExcel.Cells(2 + Row, 1 + Column) = DGV.Item(Column, Row).Value
            Next
        Next
        'FichierExcel.DisplayAlerts = False
        'ClasseurExcel.SaveAs(My.Application.Info.DirectoryPath + "\" + NomFichier)
        'ClasseurExcel.Close()
        'FichierExcel.Quit()
        'KillExcel()
    End Sub

    Public Sub LoadFromExcelDGV(ByRef DGV As DataGridView, ByVal NomFichier As String)
        If System.IO.File.Exists(My.Application.Info.DirectoryPath + "\" + NomFichier) = False Then
        Else
            FichierExcel = New Excel.Application
            ClasseurExcel = FichierExcel.Workbooks.Open(My.Application.Info.DirectoryPath + "\" + NomFichier) 'ouvrir le fichier xls
            FeuilleExcel = FichierExcel.ActiveWorkbook.ActiveSheet
            FeuilleExcel = ClasseurExcel.Worksheets(1) 'se positionner sur la feuille cible

            For row = 1 To FeuilleExcel.Cells(1, 26).value
                DGV.Rows.Add()
            Next

            For Row As Integer = 0 To FeuilleExcel.Cells(1, 26).value - 1
                For Column As Integer = 0 To FeuilleExcel.Cells(1, 27).value - 1
                    DGV.Item(Column, Row).Value = FeuilleExcel.Cells(2 + Row, 1 + Column).value
                Next
            Next

            FichierExcel.DisplayAlerts = False
            ClasseurExcel.Close()
            FichierExcel.Quit()
            KillExcel()
        End If
    End Sub

    'CA sa marche pas criss
    Public Sub UpdateSaveToExcel(ByRef DGV As DataGridView, ByVal NomFichier As String)
        Dim currentRow As Integer = GestionArticles.DGVArticle.CurrentCell.RowIndex + 1
        MsgBox(currentRow)
        FichierExcel = New Excel.Application
        FichierExcel.Workbooks.Add()
        ClasseurExcel = FichierExcel.Workbooks.Open(My.Application.Info.DirectoryPath + "\" + NomFichier)
        FeuilleExcel = FichierExcel.ActiveSheet
        FichierExcel.Visible = False
        FeuilleExcel.Name = NomFichier


        For Column = 0 To DGV.ColumnCount - 1
            FeuilleExcel.Cells(currentRow + 1, 1 + Column) = DGV.Item(Column, currentRow - 1).Value
        Next

        FichierExcel.DisplayAlerts = False
        ClasseurExcel.SaveAs(My.Application.Info.DirectoryPath + "\" + NomFichier)

        ClasseurExcel.Close()
        FichierExcel.Quit()
        KillExcel()
    End Sub


    Public Sub KillExcel()
        Dim proc As System.Diagnostics.Process

        For Each proc In System.Diagnostics.Process.GetProcessesByName("EXCEL")
            proc.Kill()
        Next
    End Sub





    ' Ceci lie les enregistrement dans la base de donnée et le lie au DataGridView
    'Public Sub LiaisonAuTable(ByRef DGV As DataGridView, ByVal NomTable As String)
    '    ' Our SQL Statement
    '    Dim sql As String
    '    sql = "SELECT * FROM " + NomTable
    '    ' This is our DataAdapter. This executes our SQL Statement above against the Database
    '    ' we defined in the Connection String
    '    Dim adapter As New OleDbDataAdapter(sql, con1)
    '    ' Gets the records from the table and fills our adapter with those.
    '    Dim dt As New DataTable(NomTable)
    '    adapter.Fill(dt)
    '    ' Assigns our DataSource on the DataGridView
    '    DGV.DataSource = dt
    '    '
    '    Dim sql1 As String
    '    sql1 = "SELECT * FROM " + NomTable
    '    Dim adapter1 As New OleDbDataAdapter(sql1, con1)
    '    Dim cmd1 As New OleDbCommand(sql1, con1)
    '    'Dim dt1 As New DataTable("users")
    '    con1.Open()
    '    Dim myreader As OleDbDataReader = cmd1.ExecuteReader
    '    myreader.Read()

    '    con1.Close()

    '    'IOModule.RefreshDGV(DGV, NomTable)
    'End Sub




End Module