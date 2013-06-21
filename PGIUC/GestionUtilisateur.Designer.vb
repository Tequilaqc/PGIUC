<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionUtilisateur
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ImprimerGUtilBouton = New System.Windows.Forms.Button()
        Me.supprimerGUtilBouton = New System.Windows.Forms.Button()
        Me.NouvelGUtilBouton = New System.Windows.Forms.Button()
        Me.ModifierGUtilBouton = New System.Windows.Forms.Button()
        Me.FermerGUtilBouton = New System.Windows.Forms.Button()
        Me.DGVUtilisateur = New System.Windows.Forms.DataGridView()
        Me.IDUSERCADETDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomMembreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomMembreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeMembreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeBarreMembreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UtilisateurcadetBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PGUICDataSet = New PGIUC.PGUICDataSet()
        Me.UtilisateurcadetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UtilisateurcadetTableAdapter = New PGIUC.PGUICDataSetTableAdapters.UtilisateurcadetTableAdapter()
        Me.UtilisateurcadetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportExcelUser = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVUtilisateur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilisateurcadetBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PGUICDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilisateurcadetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilisateurcadetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ExportExcelUser)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(206, 496)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ImprimerGUtilBouton)
        Me.Panel2.Controls.Add(Me.supprimerGUtilBouton)
        Me.Panel2.Controls.Add(Me.NouvelGUtilBouton)
        Me.Panel2.Controls.Add(Me.ModifierGUtilBouton)
        Me.Panel2.Controls.Add(Me.FermerGUtilBouton)
        Me.Panel2.Location = New System.Drawing.Point(24, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(161, 206)
        Me.Panel2.TabIndex = 18
        '
        'ImprimerGUtilBouton
        '
        Me.ImprimerGUtilBouton.Location = New System.Drawing.Point(3, 125)
        Me.ImprimerGUtilBouton.Name = "ImprimerGUtilBouton"
        Me.ImprimerGUtilBouton.Size = New System.Drawing.Size(153, 35)
        Me.ImprimerGUtilBouton.TabIndex = 17
        Me.ImprimerGUtilBouton.Text = "Imprimer"
        Me.ImprimerGUtilBouton.UseVisualStyleBackColor = True
        '
        'supprimerGUtilBouton
        '
        Me.supprimerGUtilBouton.Location = New System.Drawing.Point(3, 84)
        Me.supprimerGUtilBouton.Name = "supprimerGUtilBouton"
        Me.supprimerGUtilBouton.Size = New System.Drawing.Size(153, 35)
        Me.supprimerGUtilBouton.TabIndex = 16
        Me.supprimerGUtilBouton.Text = "Supprimer"
        Me.supprimerGUtilBouton.UseVisualStyleBackColor = True
        '
        'NouvelGUtilBouton
        '
        Me.NouvelGUtilBouton.Location = New System.Drawing.Point(3, 2)
        Me.NouvelGUtilBouton.Name = "NouvelGUtilBouton"
        Me.NouvelGUtilBouton.Size = New System.Drawing.Size(153, 35)
        Me.NouvelGUtilBouton.TabIndex = 0
        Me.NouvelGUtilBouton.Text = "Nouveau Membre"
        Me.NouvelGUtilBouton.UseVisualStyleBackColor = True
        '
        'ModifierGUtilBouton
        '
        Me.ModifierGUtilBouton.Location = New System.Drawing.Point(3, 43)
        Me.ModifierGUtilBouton.Name = "ModifierGUtilBouton"
        Me.ModifierGUtilBouton.Size = New System.Drawing.Size(153, 35)
        Me.ModifierGUtilBouton.TabIndex = 15
        Me.ModifierGUtilBouton.Text = "Modifier"
        Me.ModifierGUtilBouton.UseVisualStyleBackColor = True
        '
        'FermerGUtilBouton
        '
        Me.FermerGUtilBouton.Location = New System.Drawing.Point(3, 166)
        Me.FermerGUtilBouton.Name = "FermerGUtilBouton"
        Me.FermerGUtilBouton.Size = New System.Drawing.Size(153, 35)
        Me.FermerGUtilBouton.TabIndex = 14
        Me.FermerGUtilBouton.Text = "Fermer"
        Me.FermerGUtilBouton.UseVisualStyleBackColor = True
        '
        'DGVUtilisateur
        '
        Me.DGVUtilisateur.AllowUserToAddRows = False
        Me.DGVUtilisateur.AllowUserToDeleteRows = False
        Me.DGVUtilisateur.AutoGenerateColumns = False
        Me.DGVUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUtilisateur.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDUSERCADETDataGridViewTextBoxColumn, Me.GradeDataGridViewTextBoxColumn, Me.NomMembreDataGridViewTextBoxColumn, Me.PrenomMembreDataGridViewTextBoxColumn, Me.TypeMembreDataGridViewTextBoxColumn, Me.CodeBarreMembreDataGridViewTextBoxColumn})
        Me.DGVUtilisateur.DataSource = Me.UtilisateurcadetBindingSource2
        Me.DGVUtilisateur.Location = New System.Drawing.Point(211, 3)
        Me.DGVUtilisateur.Name = "DGVUtilisateur"
        Me.DGVUtilisateur.Size = New System.Drawing.Size(643, 496)
        Me.DGVUtilisateur.TabIndex = 6
        '
        'IDUSERCADETDataGridViewTextBoxColumn
        '
        Me.IDUSERCADETDataGridViewTextBoxColumn.DataPropertyName = "ID_USERCADET"
        Me.IDUSERCADETDataGridViewTextBoxColumn.HeaderText = "ID_USERCADET"
        Me.IDUSERCADETDataGridViewTextBoxColumn.Name = "IDUSERCADETDataGridViewTextBoxColumn"
        Me.IDUSERCADETDataGridViewTextBoxColumn.Visible = False
        '
        'GradeDataGridViewTextBoxColumn
        '
        Me.GradeDataGridViewTextBoxColumn.DataPropertyName = "Grade"
        Me.GradeDataGridViewTextBoxColumn.HeaderText = "Grade"
        Me.GradeDataGridViewTextBoxColumn.Name = "GradeDataGridViewTextBoxColumn"
        '
        'NomMembreDataGridViewTextBoxColumn
        '
        Me.NomMembreDataGridViewTextBoxColumn.DataPropertyName = "NomMembre"
        Me.NomMembreDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomMembreDataGridViewTextBoxColumn.Name = "NomMembreDataGridViewTextBoxColumn"
        Me.NomMembreDataGridViewTextBoxColumn.Width = 150
        '
        'PrenomMembreDataGridViewTextBoxColumn
        '
        Me.PrenomMembreDataGridViewTextBoxColumn.DataPropertyName = "PrenomMembre"
        Me.PrenomMembreDataGridViewTextBoxColumn.HeaderText = "Prenom"
        Me.PrenomMembreDataGridViewTextBoxColumn.Name = "PrenomMembreDataGridViewTextBoxColumn"
        Me.PrenomMembreDataGridViewTextBoxColumn.Width = 150
        '
        'TypeMembreDataGridViewTextBoxColumn
        '
        Me.TypeMembreDataGridViewTextBoxColumn.DataPropertyName = "TypeMembre"
        Me.TypeMembreDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeMembreDataGridViewTextBoxColumn.Name = "TypeMembreDataGridViewTextBoxColumn"
        '
        'CodeBarreMembreDataGridViewTextBoxColumn
        '
        Me.CodeBarreMembreDataGridViewTextBoxColumn.DataPropertyName = "CodeBarreMembre"
        Me.CodeBarreMembreDataGridViewTextBoxColumn.HeaderText = "No. de Membre"
        Me.CodeBarreMembreDataGridViewTextBoxColumn.Name = "CodeBarreMembreDataGridViewTextBoxColumn"
        '
        'UtilisateurcadetBindingSource2
        '
        Me.UtilisateurcadetBindingSource2.DataMember = "Utilisateurcadet"
        Me.UtilisateurcadetBindingSource2.DataSource = Me.PGUICDataSet
        '
        'PGUICDataSet
        '
        Me.PGUICDataSet.DataSetName = "PGUICDataSet"
        Me.PGUICDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UtilisateurcadetBindingSource
        '
        Me.UtilisateurcadetBindingSource.DataMember = "Utilisateurcadet"
        Me.UtilisateurcadetBindingSource.DataSource = Me.PGUICDataSet
        '
        'UtilisateurcadetTableAdapter
        '
        Me.UtilisateurcadetTableAdapter.ClearBeforeFill = True
        '
        'UtilisateurcadetBindingSource1
        '
        Me.UtilisateurcadetBindingSource1.DataMember = "Utilisateurcadet"
        Me.UtilisateurcadetBindingSource1.DataSource = Me.PGUICDataSet
        '
        'ExportExcelUser
        '
        Me.ExportExcelUser.Location = New System.Drawing.Point(28, 422)
        Me.ExportExcelUser.Name = "ExportExcelUser"
        Me.ExportExcelUser.Size = New System.Drawing.Size(153, 35)
        Me.ExportExcelUser.TabIndex = 19
        Me.ExportExcelUser.Text = "Exporter vers Excel"
        Me.ExportExcelUser.UseVisualStyleBackColor = True
        '
        'GestionUtilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 502)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGVUtilisateur)
        Me.Name = "GestionUtilisateur"
        Me.Text = "Gestion des membres"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVUtilisateur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilisateurcadetBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PGUICDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilisateurcadetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilisateurcadetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ImprimerGUtilBouton As System.Windows.Forms.Button
    Friend WithEvents supprimerGUtilBouton As System.Windows.Forms.Button
    Friend WithEvents NouvelGUtilBouton As System.Windows.Forms.Button
    Friend WithEvents ModifierGUtilBouton As System.Windows.Forms.Button
    Friend WithEvents FermerGUtilBouton As System.Windows.Forms.Button
    Friend WithEvents DGVUtilisateur As System.Windows.Forms.DataGridView
    Friend WithEvents PGUICDataSet As PGIUC.PGUICDataSet
    Friend WithEvents UtilisateurcadetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UtilisateurcadetTableAdapter As PGIUC.PGUICDataSetTableAdapters.UtilisateurcadetTableAdapter
    Friend WithEvents UtilisateurcadetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IDUSERCADETDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GradeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomMembreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrenomMembreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeMembreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeBarreMembreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UtilisateurcadetBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ExportExcelUser As System.Windows.Forms.Button
End Class
