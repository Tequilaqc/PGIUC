Public Class Article

    Private NoArt As String 'Numéro de l'article, peut contenir des chiffres ou des lettres
    Private Descript As String 'Description de l'article, son nom 
    Private Qt As Int16 'Quantité disponible si plusieurs
    Private Price As Double ' Prix de l'article avec les sous
    Private State As String ' Condition de l'article, préderterminé lors de la création de l'article dans le menu
    Private Cate As String ' Catégorie de l'article
    Private Serial As String ' Numéro de série si l'article en contient un
    Private Disp As Boolean ' Vrai si disponible Faux si non-disponible
    'Private Contenu As New DataGridView ' Contenu de l'objet dans un tableau dynamique de type DatagridView
    Private QuantiteRes As Int16
    Private Dat As Date




    'Initialise l'objet Article avec des valeur par défaut
    Public Sub New()
        NoArt = ""
        Descript = ""
        Qt = 0
        Price = 0
        State = ""
        Cate = ""
        Serial = ""
        Disp = True
        Dat = Today
    End Sub

    'Entrée direct des valeurs par défaut lors de la création de l'objet
    Public Sub New(ByVal NoArticle As String, ByVal Description As String, ByVal Quantite As Int16, ByVal Prix As Double, ByVal Etat As String, ByVal Categorie As String, ByVal NoSerie As String) ' ByVal Tab As DataGridView)
        NoArt = NoArticle
        Descript = Description
        Qt = Quantite
        Price = Prix
        State = Etat
        Cate = Categorie
        Serial = NoSerie
    End Sub

    '*****************************************************************************************
    'Méthode de Get et Set pour toute les variables de la classe Article

    Public Property NumeroArticle() As String
        Get
            Return NoArt
        End Get

        Set(ByVal NumeroArticle As String)
            NoArt = NumeroArticle
        End Set
    End Property

    Public Property Description() As String
        Get
            Return Descript
        End Get

        Set(ByVal DescriptionArticle As String)
            Descript = DescriptionArticle
        End Set
    End Property

    Public Property Quantite() As Int16
        Get
            Return Qt
        End Get

        Set(ByVal Qte As Int16)
            Qt = Qte
        End Set
    End Property

    Public Property PrixArticle() As Double
        Get
            Return Price
        End Get

        Set(ByVal PrixArt As Double)
            Price = PrixArt
        End Set
    End Property

    Public Property EtatArticle() As String
        Get
            Return State
        End Get

        Set(ByVal EtatArticle As String)
            State = EtatArticle
        End Set
    End Property

    Public Property CategorieArticle() As String
        Get
            Return Cate
        End Get

        Set(ByVal Categori As String)
            Cate = Categori
        End Set
    End Property

    Public Property NumeroSerie() As String
        Get
            Return Serial
        End Get

        Set(ByVal NoSeri As String)
            Serial = NoSeri
        End Set
    End Property

    Public Property Disponible() As Boolean
        Get
            Return Disp
        End Get
        Set(ByVal value As Boolean)
            Disp = value
        End Set
    End Property

    Public Property QuantiteRestante() As Int16
        Get
            Return QuantiteRes
        End Get
        Set(ByVal value As Int16)
            QuantiteRes = value
        End Set
    End Property

    Public Property DateAjout() As Date
        Get
            Return Dat
        End Get
        Set(ByVal value As Date)
            Dat = value
        End Set
    End Property

End Class