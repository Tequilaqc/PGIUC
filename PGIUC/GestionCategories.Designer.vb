<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionCategories
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
        Me.components = New System.ComponentModel.Container()
        Me.DGVCategorie = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categorie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategorieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PGUICDataSet = New PGIUC.PGUICDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ImprimerGCatBouton = New System.Windows.Forms.Button()
        Me.supprimerGCatBouton = New System.Windows.Forms.Button()
        Me.NouvelGCatBouton = New System.Windows.Forms.Button()
        Me.ModifierGCatBouton = New System.Windows.Forms.Button()
        Me.FermerGCatBouton = New System.Windows.Forms.Button()
        Me.CategorieTableAdapter = New PGIUC.PGUICDataSetTableAdapters.CategorieTableAdapter()
        Me.NOCATEGORIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomcategorieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExportExcelCategorie = New System.Windows.Forms.Button()
        CType(Me.DGVCategorie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategorieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PGUICDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVCategorie
        '
        Me.DGVCategorie.AllowUserToAddRows = False
        Me.DGVCategorie.AutoGenerateColumns = False
        Me.DGVCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCategorie.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Categorie, Me.NOCATEGORIEDataGridViewTextBoxColumn, Me.NomcategorieDataGridViewTextBoxColumn})
        Me.DGVCategorie.DataSource = Me.CategorieBindingSource
        Me.DGVCategorie.Location = New System.Drawing.Point(211, 3)
        Me.DGVCategorie.Name = "DGVCategorie"
        Me.DGVCategorie.Size = New System.Drawing.Size(345, 496)
        Me.DGVCategorie.TabIndex = 8
        '
        'No
        '
        Me.No.DataPropertyName = "NO_CATEGORIE"
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.Visible = False
        Me.No.Width = 50
        '
        'Categorie
        '
        Me.Categorie.DataPropertyName = "nom_categorie"
        Me.Categorie.HeaderText = "Catégorie"
        Me.Categorie.Name = "Categorie"
        Me.Categorie.Width = 300
        '
        'CategorieBindingSource
        '
        Me.CategorieBindingSource.DataMember = "Categorie"
        Me.CategorieBindingSource.DataSource = Me.PGUICDataSet
        '
        'PGUICDataSet
        '
        Me.PGUICDataSet.DataSetName = "PGUICDataSet"
        Me.PGUICDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ExportExcelCategorie)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(206, 496)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ImprimerGCatBouton)
        Me.Panel2.Controls.Add(Me.supprimerGCatBouton)
        Me.Panel2.Controls.Add(Me.NouvelGCatBouton)
        Me.Panel2.Controls.Add(Me.ModifierGCatBouton)
        Me.Panel2.Controls.Add(Me.FermerGCatBouton)
        Me.Panel2.Location = New System.Drawing.Point(24, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(161, 206)
        Me.Panel2.TabIndex = 18
        '
        'ImprimerGCatBouton
        '
        Me.ImprimerGCatBouton.Location = New System.Drawing.Point(3, 125)
        Me.ImprimerGCatBouton.Name = "ImprimerGCatBouton"
        Me.ImprimerGCatBouton.Size = New System.Drawing.Size(153, 35)
        Me.ImprimerGCatBouton.TabIndex = 17
        Me.ImprimerGCatBouton.Text = "Imprimer"
        Me.ImprimerGCatBouton.UseVisualStyleBackColor = True
        '
        'supprimerGCatBouton
        '
        Me.supprimerGCatBouton.Location = New System.Drawing.Point(3, 84)
        Me.supprimerGCatBouton.Name = "supprimerGCatBouton"
        Me.supprimerGCatBouton.Size = New System.Drawing.Size(153, 35)
        Me.supprimerGCatBouton.TabIndex = 16
        Me.supprimerGCatBouton.Text = "Supprimer"
        Me.supprimerGCatBouton.UseVisualStyleBackColor = True
        '
        'NouvelGCatBouton
        '
        Me.NouvelGCatBouton.Location = New System.Drawing.Point(3, 2)
        Me.NouvelGCatBouton.Name = "NouvelGCatBouton"
        Me.NouvelGCatBouton.Size = New System.Drawing.Size(153, 35)
        Me.NouvelGCatBouton.TabIndex = 0
        Me.NouvelGCatBouton.Text = "Nouvel Catégorie"
        Me.NouvelGCatBouton.UseVisualStyleBackColor = True
        '
        'ModifierGCatBouton
        '
        Me.ModifierGCatBouton.Location = New System.Drawing.Point(3, 43)
        Me.ModifierGCatBouton.Name = "ModifierGCatBouton"
        Me.ModifierGCatBouton.Size = New System.Drawing.Size(153, 35)
        Me.ModifierGCatBouton.TabIndex = 15
        Me.ModifierGCatBouton.Text = "Modifier"
        Me.ModifierGCatBouton.UseVisualStyleBackColor = True
        '
        'FermerGCatBouton
        '
        Me.FermerGCatBouton.Location = New System.Drawing.Point(3, 166)
        Me.FermerGCatBouton.Name = "FermerGCatBouton"
        Me.FermerGCatBouton.Size = New System.Drawing.Size(153, 35)
        Me.FermerGCatBouton.TabIndex = 14
        Me.FermerGCatBouton.Text = "Fermer"
        Me.FermerGCatBouton.UseVisualStyleBackColor = True
        '
        'CategorieTableAdapter
        '
        Me.CategorieTableAdapter.ClearBeforeFill = True
        '
        'NOCATEGORIEDataGridViewTextBoxColumn
        '
        Me.NOCATEGORIEDataGridViewTextBoxColumn.DataPropertyName = "NO_CATEGORIE"
        Me.NOCATEGORIEDataGridViewTextBoxColumn.HeaderText = "NO_CATEGORIE"
        Me.NOCATEGORIEDataGridViewTextBoxColumn.Name = "NOCATEGORIEDataGridViewTextBoxColumn"
        '
        'NomcategorieDataGridViewTextBoxColumn
        '
        Me.NomcategorieDataGridViewTextBoxColumn.DataPropertyName = "nom_categorie"
        Me.NomcategorieDataGridViewTextBoxColumn.HeaderText = "nom_categorie"
        Me.NomcategorieDataGridViewTextBoxColumn.Name = "NomcategorieDataGridViewTextBoxColumn"
        '
        'ExportExcelCategorie
        '
        Me.ExportExcelCategorie.Location = New System.Drawing.Point(28, 425)
        Me.ExportExcelCategorie.Name = "ExportExcelCategorie"
        Me.ExportExcelCategorie.Size = New System.Drawing.Size(153, 35)
        Me.ExportExcelCategorie.TabIndex = 19
        Me.ExportExcelCategorie.Text = "Exporter ver Excel"
        Me.ExportExcelCategorie.UseVisualStyleBackColor = True
        '
        'GestionCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 502)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGVCategorie)
        Me.Name = "GestionCategories"
        Me.Text = "Gestion des catégories"
        CType(Me.DGVCategorie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategorieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PGUICDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVCategorie As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ImprimerGCatBouton As System.Windows.Forms.Button
    Friend WithEvents supprimerGCatBouton As System.Windows.Forms.Button
    Friend WithEvents NouvelGCatBouton As System.Windows.Forms.Button
    Friend WithEvents ModifierGCatBouton As System.Windows.Forms.Button
    Friend WithEvents FermerGCatBouton As System.Windows.Forms.Button
    Friend WithEvents PGUICDataSet As PGIUC.PGUICDataSet
    Friend WithEvents CategorieBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategorieTableAdapter As PGIUC.PGUICDataSetTableAdapters.CategorieTableAdapter
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categorie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOCATEGORIEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomcategorieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExportExcelCategorie As System.Windows.Forms.Button
End Class
