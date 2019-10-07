Public Class Frm_Princ
    Dim Ensemble As New Collection
    Dim ht As New Hashtable
    Private Sub Btn_Start_Click(sender As Object, e As EventArgs)
        'Affectation des réponses avec input box avec les questions contenues dans les labels
        For index = 1 To 5
            Ensemble.Item(index * 2).Text = InputBox(Ensemble.Item(index * 2 - 1).text)
        Next
    End Sub

    Private Sub Frm_Princ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ht As New Hashtable
        'Création de la table de hachage avec les questions
        ht.Add(1, "Question 1")
        ht.Add(2, "Question 2")
        ht.Add(3, "Question 3")
        ht.Add(4, "Question 4")
        ht.Add(5, "Question 5")
        'Création du panel
        Dim Pan_1 As New Panel
        Pan_1.Top = 25
        Pan_1.Left = 29
        Pan_1.Size = New Size(512, 318)
        'Ajout du panel à la fenêtre
        Me.Controls.Add(Pan_1)
        'On créé les controles dans la collection Ensemble
        For index = 1 To 5
            Dim MonLabel As New Label
            Dim MaTextBox As New TextBox
            Ensemble.Add(MonLabel)
            Ensemble.Add(MaTextBox)
            With Ensemble.Item(index * 2 - 1)
                .Top = 50 + index * 30
                .Left = 60
                .Text = ht.Item(index)
            End With
            With Ensemble.Item(index * 2)
                .Top = 50 + index * 30
                .Left = 200
                .enabled = False
            End With
        Next
        'Ajout des controles dans le panel
        For index = 1 To 10
            Pan_1.Controls.Add(Ensemble.Item(index))
        Next
        'Ajout du bouton Start dynamiquement
        Dim Btn_Depart As New Button
        Btn_Depart.Size = New Size(250, 40)
        Btn_Depart.Top = 350
        Btn_Depart.Left = 150
        Btn_Depart.Text = "Top Départ"
        'Affectation de la procédure au bouton Start
        AddHandler Btn_Depart.Click, AddressOf Btn_Start_Click
        Me.Controls.Add(Btn_Depart)

    End Sub
End Class
