<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblEditeur = New System.Windows.Forms.Label()
        Me.lblNbexemp = New System.Windows.Forms.Label()
        Me.lblAnnee = New System.Windows.Forms.Label()
        Me.lblDomaine = New System.Windows.Forms.Label()
        Me.txtTitre = New System.Windows.Forms.TextBox()
        Me.txtEditeur = New System.Windows.Forms.TextBox()
        Me.txtAnnee = New System.Windows.Forms.TextBox()
        Me.txtNbexemp = New System.Windows.Forms.TextBox()
        Me.cmbDomaine = New System.Windows.Forms.ComboBox()
        Me.gbNbexemp = New System.Windows.Forms.GroupBox()
        Me.rbSup10 = New System.Windows.Forms.RadioButton()
        Me.rbInf10 = New System.Windows.Forms.RadioButton()
        Me.lbTitreExemp = New System.Windows.Forms.ListBox()
        Me.lbTitreDomaine = New System.Windows.Forms.ListBox()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnSupp = New System.Windows.Forms.Button()
        Me.lblTitreExemp = New System.Windows.Forms.Label()
        Me.lblTitreDomaine = New System.Windows.Forms.Label()
        Me.gbNbexemp.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Location = New System.Drawing.Point(25, 39)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(34, 13)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "&Titre :"
        '
        'lblEditeur
        '
        Me.lblEditeur.AutoSize = True
        Me.lblEditeur.Location = New System.Drawing.Point(25, 77)
        Me.lblEditeur.Name = "lblEditeur"
        Me.lblEditeur.Size = New System.Drawing.Size(46, 13)
        Me.lblEditeur.TabIndex = 1
        Me.lblEditeur.Text = "&Editeur :"
        '
        'lblNbexemp
        '
        Me.lblNbexemp.AutoSize = True
        Me.lblNbexemp.Location = New System.Drawing.Point(25, 152)
        Me.lblNbexemp.Name = "lblNbexemp"
        Me.lblNbexemp.Size = New System.Drawing.Size(104, 13)
        Me.lblNbexemp.TabIndex = 3
        Me.lblNbexemp.Text = "&Nombre Exemplaire :"
        '
        'lblAnnee
        '
        Me.lblAnnee.AutoSize = True
        Me.lblAnnee.Location = New System.Drawing.Point(25, 114)
        Me.lblAnnee.Name = "lblAnnee"
        Me.lblAnnee.Size = New System.Drawing.Size(44, 13)
        Me.lblAnnee.TabIndex = 2
        Me.lblAnnee.Text = "Année :"
        '
        'lblDomaine
        '
        Me.lblDomaine.AutoSize = True
        Me.lblDomaine.Location = New System.Drawing.Point(25, 187)
        Me.lblDomaine.Name = "lblDomaine"
        Me.lblDomaine.Size = New System.Drawing.Size(55, 13)
        Me.lblDomaine.TabIndex = 4
        Me.lblDomaine.Text = "&Domaine :"
        '
        'txtTitre
        '
        Me.txtTitre.Location = New System.Drawing.Point(171, 39)
        Me.txtTitre.Name = "txtTitre"
        Me.txtTitre.Size = New System.Drawing.Size(121, 20)
        Me.txtTitre.TabIndex = 5
        '
        'txtEditeur
        '
        Me.txtEditeur.Location = New System.Drawing.Point(171, 77)
        Me.txtEditeur.Name = "txtEditeur"
        Me.txtEditeur.Size = New System.Drawing.Size(121, 20)
        Me.txtEditeur.TabIndex = 6
        '
        'txtAnnee
        '
        Me.txtAnnee.Location = New System.Drawing.Point(171, 114)
        Me.txtAnnee.Name = "txtAnnee"
        Me.txtAnnee.Size = New System.Drawing.Size(121, 20)
        Me.txtAnnee.TabIndex = 7
        '
        'txtNbexemp
        '
        Me.txtNbexemp.Location = New System.Drawing.Point(171, 152)
        Me.txtNbexemp.Name = "txtNbexemp"
        Me.txtNbexemp.Size = New System.Drawing.Size(121, 20)
        Me.txtNbexemp.TabIndex = 8
        '
        'cmbDomaine
        '
        Me.cmbDomaine.FormattingEnabled = True
        Me.cmbDomaine.Location = New System.Drawing.Point(171, 184)
        Me.cmbDomaine.Name = "cmbDomaine"
        Me.cmbDomaine.Size = New System.Drawing.Size(121, 21)
        Me.cmbDomaine.TabIndex = 9
        '
        'gbNbexemp
        '
        Me.gbNbexemp.Controls.Add(Me.rbSup10)
        Me.gbNbexemp.Controls.Add(Me.rbInf10)
        Me.gbNbexemp.Location = New System.Drawing.Point(28, 260)
        Me.gbNbexemp.Name = "gbNbexemp"
        Me.gbNbexemp.Size = New System.Drawing.Size(104, 100)
        Me.gbNbexemp.TabIndex = 10
        Me.gbNbexemp.TabStop = False
        Me.gbNbexemp.Text = "&NbExemplaire"
        '
        'rbSup10
        '
        Me.rbSup10.AutoSize = True
        Me.rbSup10.Location = New System.Drawing.Point(6, 58)
        Me.rbSup10.Name = "rbSup10"
        Me.rbSup10.Size = New System.Drawing.Size(46, 17)
        Me.rbSup10.TabIndex = 1
        Me.rbSup10.TabStop = True
        Me.rbSup10.Text = "> 10"
        Me.rbSup10.UseVisualStyleBackColor = True
        '
        'rbInf10
        '
        Me.rbInf10.AutoSize = True
        Me.rbInf10.Location = New System.Drawing.Point(6, 28)
        Me.rbInf10.Name = "rbInf10"
        Me.rbInf10.Size = New System.Drawing.Size(46, 17)
        Me.rbInf10.TabIndex = 0
        Me.rbInf10.TabStop = True
        Me.rbInf10.Text = "< 10"
        Me.rbInf10.UseVisualStyleBackColor = True
        '
        'lbTitreExemp
        '
        Me.lbTitreExemp.FormattingEnabled = True
        Me.lbTitreExemp.Location = New System.Drawing.Point(171, 260)
        Me.lbTitreExemp.Name = "lbTitreExemp"
        Me.lbTitreExemp.Size = New System.Drawing.Size(120, 95)
        Me.lbTitreExemp.TabIndex = 11
        '
        'lbTitreDomaine
        '
        Me.lbTitreDomaine.FormattingEnabled = True
        Me.lbTitreDomaine.Location = New System.Drawing.Point(337, 260)
        Me.lbTitreDomaine.Name = "lbTitreDomaine"
        Me.lbTitreDomaine.Size = New System.Drawing.Size(120, 95)
        Me.lbTitreDomaine.TabIndex = 12
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(337, 67)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouter.TabIndex = 13
        Me.btnAjouter.Text = "&Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.Location = New System.Drawing.Point(337, 109)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(75, 23)
        Me.btnModifier.TabIndex = 14
        Me.btnModifier.Text = "&Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'btnSupp
        '
        Me.btnSupp.Location = New System.Drawing.Point(337, 152)
        Me.btnSupp.Name = "btnSupp"
        Me.btnSupp.Size = New System.Drawing.Size(75, 23)
        Me.btnSupp.TabIndex = 15
        Me.btnSupp.Text = "&Supprimer"
        Me.btnSupp.UseVisualStyleBackColor = True
        '
        'lblTitreExemp
        '
        Me.lblTitreExemp.AutoSize = True
        Me.lblTitreExemp.Location = New System.Drawing.Point(168, 244)
        Me.lblTitreExemp.Name = "lblTitreExemp"
        Me.lblTitreExemp.Size = New System.Drawing.Size(101, 13)
        Me.lblTitreExemp.TabIndex = 16
        Me.lblTitreExemp.Text = "Titre/NbExemplaire "
        '
        'lblTitreDomaine
        '
        Me.lblTitreDomaine.AutoSize = True
        Me.lblTitreDomaine.Location = New System.Drawing.Point(334, 244)
        Me.lblTitreDomaine.Name = "lblTitreDomaine"
        Me.lblTitreDomaine.Size = New System.Drawing.Size(75, 13)
        Me.lblTitreDomaine.TabIndex = 17
        Me.lblTitreDomaine.Text = "Titre/Domaine" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 380)
        Me.Controls.Add(Me.lblTitreDomaine)
        Me.Controls.Add(Me.lblTitreExemp)
        Me.Controls.Add(Me.btnSupp)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.lbTitreDomaine)
        Me.Controls.Add(Me.lbTitreExemp)
        Me.Controls.Add(Me.gbNbexemp)
        Me.Controls.Add(Me.cmbDomaine)
        Me.Controls.Add(Me.txtNbexemp)
        Me.Controls.Add(Me.txtAnnee)
        Me.Controls.Add(Me.txtEditeur)
        Me.Controls.Add(Me.txtTitre)
        Me.Controls.Add(Me.lblDomaine)
        Me.Controls.Add(Me.lblNbexemp)
        Me.Controls.Add(Me.lblAnnee)
        Me.Controls.Add(Me.lblEditeur)
        Me.Controls.Add(Me.lblTitre)
        Me.Name = "Form1"
        Me.Text = "Gestion_Livre"
        Me.gbNbexemp.ResumeLayout(False)
        Me.gbNbexemp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Label
    Friend WithEvents lblEditeur As Label
    Friend WithEvents lblNbexemp As Label
    Friend WithEvents lblAnnee As Label
    Friend WithEvents lblDomaine As Label
    Friend WithEvents txtTitre As TextBox
    Friend WithEvents txtEditeur As TextBox
    Friend WithEvents txtAnnee As TextBox
    Friend WithEvents txtNbexemp As TextBox
    Friend WithEvents cmbDomaine As ComboBox
    Friend WithEvents gbNbexemp As GroupBox
    Friend WithEvents rbSup10 As RadioButton
    Friend WithEvents rbInf10 As RadioButton
    Friend WithEvents lbTitreExemp As ListBox
    Friend WithEvents lbTitreDomaine As ListBox
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnSupp As Button
    Friend WithEvents lblTitreExemp As Label
    Friend WithEvents lblTitreDomaine As Label
End Class
