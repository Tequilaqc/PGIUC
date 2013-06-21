<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NouvelUtilisateur
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NoMembreBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ValideBoutonUser = New System.Windows.Forms.Button()
        Me.AjouterUserBouton = New System.Windows.Forms.Button()
        Me.AnnulerUserBouton = New System.Windows.Forms.Button()
        Me.FermerUserBouton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NomBox = New System.Windows.Forms.TextBox()
        Me.ParentRadio = New System.Windows.Forms.RadioButton()
        Me.ComiteRadio = New System.Windows.Forms.RadioButton()
        Me.CadetRadio = New System.Windows.Forms.RadioButton()
        Me.CadetCadreRadio = New System.Windows.Forms.RadioButton()
        Me.OfficierRadio = New System.Windows.Forms.RadioButton()
        Me.GradeBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrenomBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NoMembreBox
        '
        Me.NoMembreBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NoMembreBox.Location = New System.Drawing.Point(335, 61)
        Me.NoMembreBox.Name = "NoMembreBox"
        Me.NoMembreBox.Size = New System.Drawing.Size(169, 20)
        Me.NoMembreBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numéro de membre"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ValideBoutonUser)
        Me.Panel3.Controls.Add(Me.AjouterUserBouton)
        Me.Panel3.Controls.Add(Me.AnnulerUserBouton)
        Me.Panel3.Controls.Add(Me.FermerUserBouton)
        Me.Panel3.Location = New System.Drawing.Point(23, 18)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(161, 125)
        Me.Panel3.TabIndex = 18
        '
        'ValideBoutonUser
        '
        Me.ValideBoutonUser.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ValideBoutonUser.Location = New System.Drawing.Point(3, 4)
        Me.ValideBoutonUser.Name = "ValideBoutonUser"
        Me.ValideBoutonUser.Size = New System.Drawing.Size(153, 35)
        Me.ValideBoutonUser.TabIndex = 19
        Me.ValideBoutonUser.Text = "Valider Modification"
        Me.ValideBoutonUser.UseVisualStyleBackColor = True
        '
        'AjouterUserBouton
        '
        Me.AjouterUserBouton.Location = New System.Drawing.Point(3, 3)
        Me.AjouterUserBouton.Name = "AjouterUserBouton"
        Me.AjouterUserBouton.Size = New System.Drawing.Size(153, 35)
        Me.AjouterUserBouton.TabIndex = 0
        Me.AjouterUserBouton.Text = "Ajouter"
        Me.AjouterUserBouton.UseVisualStyleBackColor = True
        '
        'AnnulerUserBouton
        '
        Me.AnnulerUserBouton.Location = New System.Drawing.Point(3, 43)
        Me.AnnulerUserBouton.Name = "AnnulerUserBouton"
        Me.AnnulerUserBouton.Size = New System.Drawing.Size(153, 35)
        Me.AnnulerUserBouton.TabIndex = 15
        Me.AnnulerUserBouton.Text = "Annuler"
        Me.AnnulerUserBouton.UseVisualStyleBackColor = True
        '
        'FermerUserBouton
        '
        Me.FermerUserBouton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.FermerUserBouton.Location = New System.Drawing.Point(3, 84)
        Me.FermerUserBouton.Name = "FermerUserBouton"
        Me.FermerUserBouton.Size = New System.Drawing.Size(153, 35)
        Me.FermerUserBouton.TabIndex = 14
        Me.FermerUserBouton.Text = "Fermer"
        Me.FermerUserBouton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(206, 198)
        Me.Panel2.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(293, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Grade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Nom"
        '
        'NomBox
        '
        Me.NomBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NomBox.Location = New System.Drawing.Point(335, 115)
        Me.NomBox.Name = "NomBox"
        Me.NomBox.Size = New System.Drawing.Size(169, 20)
        Me.NomBox.TabIndex = 26
        '
        'ParentRadio
        '
        Me.ParentRadio.AutoSize = True
        Me.ParentRadio.Location = New System.Drawing.Point(307, 19)
        Me.ParentRadio.Name = "ParentRadio"
        Me.ParentRadio.Size = New System.Drawing.Size(56, 17)
        Me.ParentRadio.TabIndex = 4
        Me.ParentRadio.TabStop = True
        Me.ParentRadio.Text = "Parent"
        Me.ParentRadio.UseVisualStyleBackColor = True
        '
        'ComiteRadio
        '
        Me.ComiteRadio.AutoSize = True
        Me.ComiteRadio.Location = New System.Drawing.Point(222, 19)
        Me.ComiteRadio.Name = "ComiteRadio"
        Me.ComiteRadio.Size = New System.Drawing.Size(79, 17)
        Me.ComiteRadio.TabIndex = 3
        Me.ComiteRadio.TabStop = True
        Me.ComiteRadio.Text = "Comité Civil"
        Me.ComiteRadio.UseVisualStyleBackColor = True
        '
        'CadetRadio
        '
        Me.CadetRadio.AutoSize = True
        Me.CadetRadio.Location = New System.Drawing.Point(163, 19)
        Me.CadetRadio.Name = "CadetRadio"
        Me.CadetRadio.Size = New System.Drawing.Size(53, 17)
        Me.CadetRadio.TabIndex = 2
        Me.CadetRadio.TabStop = True
        Me.CadetRadio.Text = "Cadet"
        Me.CadetRadio.UseVisualStyleBackColor = True
        '
        'CadetCadreRadio
        '
        Me.CadetCadreRadio.AutoSize = True
        Me.CadetCadreRadio.Location = New System.Drawing.Point(73, 19)
        Me.CadetCadreRadio.Name = "CadetCadreRadio"
        Me.CadetCadreRadio.Size = New System.Drawing.Size(84, 17)
        Me.CadetCadreRadio.TabIndex = 1
        Me.CadetCadreRadio.TabStop = True
        Me.CadetCadreRadio.Text = "Cadet-Cadre"
        Me.CadetCadreRadio.UseVisualStyleBackColor = True
        '
        'OfficierRadio
        '
        Me.OfficierRadio.AutoSize = True
        Me.OfficierRadio.Location = New System.Drawing.Point(9, 19)
        Me.OfficierRadio.Name = "OfficierRadio"
        Me.OfficierRadio.Size = New System.Drawing.Size(58, 17)
        Me.OfficierRadio.TabIndex = 0
        Me.OfficierRadio.TabStop = True
        Me.OfficierRadio.Text = "Officier"
        Me.OfficierRadio.UseVisualStyleBackColor = True
        '
        'GradeBox
        '
        Me.GradeBox.FormattingEnabled = True
        Me.GradeBox.Location = New System.Drawing.Point(335, 87)
        Me.GradeBox.Name = "GradeBox"
        Me.GradeBox.Size = New System.Drawing.Size(168, 21)
        Me.GradeBox.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Prénom"
        '
        'PrenomBox
        '
        Me.PrenomBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PrenomBox.Location = New System.Drawing.Point(335, 142)
        Me.PrenomBox.Name = "PrenomBox"
        Me.PrenomBox.Size = New System.Drawing.Size(169, 20)
        Me.PrenomBox.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.CadetCadreRadio)
        Me.GroupBox1.Controls.Add(Me.ParentRadio)
        Me.GroupBox1.Controls.Add(Me.OfficierRadio)
        Me.GroupBox1.Controls.Add(Me.ComiteRadio)
        Me.GroupBox1.Controls.Add(Me.CadetRadio)
        Me.GroupBox1.Location = New System.Drawing.Point(224, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 45)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type de membre"
        '
        'NouvelUtilisateur
        '
        Me.AcceptButton = Me.AjouterUserBouton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.FermerUserBouton
        Me.ClientSize = New System.Drawing.Size(618, 198)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PrenomBox)
        Me.Controls.Add(Me.GradeBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NomBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NoMembreBox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NouvelUtilisateur"
        Me.Text = "Nouvelle fiche utilisateur"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NoMembreBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ValideBoutonUser As System.Windows.Forms.Button
    Friend WithEvents AjouterUserBouton As System.Windows.Forms.Button
    Friend WithEvents AnnulerUserBouton As System.Windows.Forms.Button
    Friend WithEvents FermerUserBouton As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NomBox As System.Windows.Forms.TextBox
    Friend WithEvents ParentRadio As System.Windows.Forms.RadioButton
    Friend WithEvents ComiteRadio As System.Windows.Forms.RadioButton
    Friend WithEvents CadetRadio As System.Windows.Forms.RadioButton
    Friend WithEvents CadetCadreRadio As System.Windows.Forms.RadioButton
    Friend WithEvents OfficierRadio As System.Windows.Forms.RadioButton
    Friend WithEvents GradeBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PrenomBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
