<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionUnite
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CodePostaleUniteBox = New System.Windows.Forms.MaskedTextBox()
        Me.TelephoneUniteBox = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VilleUniteBox = New System.Windows.Forms.TextBox()
        Me.AdresseUniteBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NomUniteBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unité de cadets"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CodePostaleUniteBox)
        Me.Panel1.Controls.Add(Me.TelephoneUniteBox)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.VilleUniteBox)
        Me.Panel1.Controls.Add(Me.AdresseUniteBox)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.NomUniteBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 294)
        Me.Panel1.TabIndex = 1
        '
        'CodePostaleUniteBox
        '
        Me.CodePostaleUniteBox.Location = New System.Drawing.Point(128, 97)
        Me.CodePostaleUniteBox.Mask = "L0L 0L0"
        Me.CodePostaleUniteBox.Name = "CodePostaleUniteBox"
        Me.CodePostaleUniteBox.Size = New System.Drawing.Size(56, 20)
        Me.CodePostaleUniteBox.TabIndex = 13
        '
        'TelephoneUniteBox
        '
        Me.TelephoneUniteBox.Location = New System.Drawing.Point(263, 97)
        Me.TelephoneUniteBox.Mask = "(000)000-0000"
        Me.TelephoneUniteBox.Name = "TelephoneUniteBox"
        Me.TelephoneUniteBox.Size = New System.Drawing.Size(164, 20)
        Me.TelephoneUniteBox.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 153)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Heure d'ouverture du quartier-maître"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(9, 95)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(141, 22)
        Me.TextBox7.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Heure"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(9, 51)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(141, 22)
        Me.TextBox6.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Jours"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(190, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Téléphone"
        '
        'VilleUniteBox
        '
        Me.VilleUniteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VilleUniteBox.Location = New System.Drawing.Point(128, 71)
        Me.VilleUniteBox.Name = "VilleUniteBox"
        Me.VilleUniteBox.Size = New System.Drawing.Size(299, 20)
        Me.VilleUniteBox.TabIndex = 6
        '
        'AdresseUniteBox
        '
        Me.AdresseUniteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AdresseUniteBox.Location = New System.Drawing.Point(128, 45)
        Me.AdresseUniteBox.Name = "AdresseUniteBox"
        Me.AdresseUniteBox.Size = New System.Drawing.Size(299, 20)
        Me.AdresseUniteBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Code Postale"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ville"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Adresse"
        '
        'NomUniteBox
        '
        Me.NomUniteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NomUniteBox.Location = New System.Drawing.Point(128, 19)
        Me.NomUniteBox.Name = "NomUniteBox"
        Me.NomUniteBox.Size = New System.Drawing.Size(299, 20)
        Me.NomUniteBox.TabIndex = 1
        '
        'GestionUnite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 318)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "GestionUnite"
        Me.Text = "Gestion de l'unité"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CodePostaleUniteBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TelephoneUniteBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents VilleUniteBox As System.Windows.Forms.TextBox
    Friend WithEvents AdresseUniteBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NomUniteBox As System.Windows.Forms.TextBox
End Class
