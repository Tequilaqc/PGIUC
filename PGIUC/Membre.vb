Public Class Membre

    Private NoMem As String 'Numéro du membre, peut-être une combinaison de chiffres et de lettres
    Private Grd As String 'Grade du membre
    Private Name As String 'Nom de famille du membre
    Private FirstName As String 'Prénom du membre 
    Private Typ As String 'Type: Officier, Cadet, parent, membre comité...

    'Initialise l'objet Membre avec des valeur par défaut
    Public Sub New()
        NoMem = "XXXXXXX"
        Grd = "grade"
        Name = "Nom"
        FirstName = "Prenom"
        Typ = "Officier ou cadet"
    End Sub

    'Entrée direct des valeurs par défaut lors de la création de l'objet
    Public Sub New(ByVal NoMembre As String, ByVal Grade As String, ByVal Nom As String, ByVal Prenom As String, ByVal Type As String)
        NoMem = NoMembre
        Grd = Grade
        Name = Nom
        FirstName = Prenom
        Typ = Type
    End Sub

    '*****************************************************************************************
    'Méthode de Get et Set pour toute les variables de la classe membres
    Public Property NumeroMembre() As String
        Get
            Return NoMem
        End Get

        Set(ByVal NuMembre As String)
            NoMem = NuMembre
        End Set
    End Property

    Public Property GradeMembre() As String
        Get
            Return Grd
        End Get

        Set(ByVal GradeMem As String)
            Grd = GradeMem
        End Set
    End Property

    Public Property NomMembre() As String
        Get
            Return Name
        End Get

        Set(ByVal NMembre As String)
            Name = NMembre
        End Set
    End Property

    Public Property PrenomMembre() As String
        Get
            Return FirstName
        End Get

        Set(ByVal FName As String)
            FirstName = FName
        End Set
    End Property

    Public Property TypeMembre() As String
        Get
            Return Typ
        End Get

        Set(ByVal T As String)
            Typ = T
        End Set
    End Property

End Class
