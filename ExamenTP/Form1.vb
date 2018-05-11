Imports System.Data.OleDb

Public Class Form1

    'variable globale
    Dim connexion As OleDbConnection
    Dim titre As String
    Dim editeur As String
    Dim annee As Integer
    Dim nbExemp As Integer
    Dim domaine As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initialisation
        cmbDomaine.Items.Add("Software")
        cmbDomaine.Items.Add("Back-end")
        cmbDomaine.Items.Add("Front-end")

        'Etablir la connexion avec la base de donnée
        Dim ConnexionString As String
        ConnexionString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source= C:\Users\Emine 'HusSoka' Rass\Documents\Visual Studio 2017\Projects\ExamenTP\ExamenTP\livre.mdb"
        connexion = New OleDbConnection(ConnexionString)
        connexion.Open()

    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        'recuperer les donnees à partir du graphique
        titre = txtTitre.Text
        editeur = txtEditeur.Text
        annee = Val(txtAnnee.Text)
        nbExemp = Val(txtNbexemp.Text)
        domaine = cmbDomaine.Text

        'requete d'insertion
        Dim req As String
        req = "INSERT INTO livre(titre,editeur,annee,nbexemplaire,domaine) values('" & titre & "','" & editeur & "'," & annee & "," & annee & ",'" & domaine & "')"


        'Executer la requete
        Dim insertcmd As OleDbCommand
        insertcmd = New OleDbCommand(req, connexion)
        insertcmd.ExecuteNonQuery()

    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        'recuperer les donnees à partir du graphique
        titre = txtTitre.Text
        editeur = txtEditeur.Text
        annee = Val(txtAnnee.Text)
        nbExemp = Val(txtNbexemp.Text)
        domaine = cmbDomaine.Text

        'Requete de mise à jour
        Dim majreq As String
        majreq = "UPDATE livre SET nbexemplaire = " & nbExemp & ", editeur = '" & editeur & "', domaine = '" & domaine & "', annee =" & annee & " WHERE titre = '" & titre & "'"

        'Executer la requete
        Dim majcmd As OleDbCommand
        majcmd = New OleDbCommand(majreq, connexion)
        majcmd.ExecuteNonQuery()
    End Sub

    Private Sub btnSupp_Click(sender As Object, e As EventArgs) Handles btnSupp.Click
        titre = txtTitre.Text

        'requete de suppression
        Dim deleteStr As String
        deleteStr = "DELETE * FROM livre WHERE titre = '" & titre & "'"

        'Executer la requete
        Dim deleteCMD As OleDbCommand
        deleteCMD = New OleDbCommand(deleteStr, connexion)
        deleteCMD.ExecuteNonQuery()
    End Sub

    Private Sub cmbDomaine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDomaine.SelectedIndexChanged
        domaine = cmbDomaine.Text

        'requete de selection
        Dim req As String
        req = "SELECT * FROM livre WHERE domaine = '" & domaine & "'"

        'Executer la requete
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(req, connexion)

        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()

        While reader.Read()
            lbTitreDomaine.Items.Add(reader.Item(1))
        End While
    End Sub

    Private Sub rbInf10_CheckedChanged(sender As Object, e As EventArgs) Handles rbInf10.CheckedChanged
        'requete de selection
        Dim req As String
        req = "SELECT * FROM livre WHERE nbexemplaire < 10"

        'Executer la requete
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(req, connexion)

        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()

        While reader.Read()
            lbTitreExemp.Items.Add(reader.Item(1))
        End While
    End Sub

    Private Sub rbSup10_CheckedChanged(sender As Object, e As EventArgs) Handles rbSup10.CheckedChanged
        'requete de selection
        Dim req As String
        req = "SELECT * FROM livre WHERE nbexemplaire >= 10"

        'Executer la requete
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(req, connexion)

        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()

        While reader.Read()
            lbTitreExemp.Items.Add(reader.Item(1))
        End While
    End Sub

    Private Sub lbTitreExemp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbTitreExemp.SelectedIndexChanged

        'recuperer les donnees à partir du graphique
        titre = lbTitreExemp.GetItemText(lbTitreExemp.SelectedItem)

        'requete de selection
        Dim req As String
        req = "SELECT * FROM livre WHERE titre ='" & titre & "'"

        'Executer la requete
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(req, connexion)

        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()

        While reader.Read()
            txtTitre.Text = reader.Item(1)
            txtEditeur.Text = reader.Item(2)
            txtAnnee.Text = reader.Item(3)
            txtNbexemp.Text = reader.Item(4)
            cmbDomaine.Text = reader.Item(5)
        End While
    End Sub

    Private Sub lbTitreDomaine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbTitreDomaine.SelectedIndexChanged

        'recuperer les donnees à partir du graphique
        titre = lbTitreDomaine.GetItemText(lbTitreDomaine.SelectedItem)

        'requete de selection
        Dim req As String
        req = "SELECT * FROM livre WHERE titre ='" & titre & "'"

        'Executer la requete
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(req, connexion)

        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()

        While reader.Read()
            txtTitre.Text = reader.Item(1)
            txtEditeur.Text = reader.Item(2)
            txtAnnee.Text = reader.Item(3)
            txtNbexemp.Text = reader.Item(4)
            cmbDomaine.Text = reader.Item(5)
        End While
    End Sub
End Class
