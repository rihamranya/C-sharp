namespace serie1;

public class Repertoire
{
    public string Nom;
    public int Nbr_fichiers;
    private fichier[] Fichiers=new fichier[30];

    public Repertoire(string nom, int Nbre, fichier[] fichiers)
    {
        Nom = nom;
        Nbr_fichiers = Nbre;
        Fichiers = fichiers;
    }

    public void Afficher()
    {
        Console.WriteLine($"Repertoire : {Nom}");
        for (int i = 0; i < Nbr_fichiers; i++)
        {
            Console.WriteLine(Fichiers[i]);
        }
    }

    public int Rechercher(string nom)
    {
        for (int i = 0; i < Nbr_fichiers;i++)
        {
            if (this.Fichiers[i].Nom == nom)
            {
                return i;
            }
        }
        return -1;
    }

    public void Ajouter(fichier Fichier)
    {
        if (Nbr_fichiers < 30)
        {
            Fichiers[Nbr_fichiers++] = Fichier;
        }
        else
        {
            Console.WriteLine("plein");
        }
    }

    public void RechercherPdf()
    {
        for (int i = 0; i < Nbr_fichiers; i++)
        {
            if (Fichiers[i].Extension == "pdf")
            {
                Console.WriteLine(Fichiers[i]);
            }
        }
    }

    public void Supprimer(string nom )
    {
        int i=Rechercher(nom);
        if (i != -1)
        {
            for (int j = i; j < Nbr_fichiers; j++)
            {
                Fichiers[j] = Fichiers[j + 1];
            }
        }
    }

    public void Renommer(string newNom, string nom )
    {
        int i=Rechercher(nom);
        if (i != -1)
        {
            Fichiers[i].Nom = newNom;
        }
    }

    public void ModifierTaille(string nom, float taille)
    {
        int i=Rechercher(nom);
        if (i != -1)
        {
            Fichiers[i].Taille = taille;
        }
    }

    public float getTaille()
    {
        float Taille = 0;
        for (int i = 0; i < Nbr_fichiers; i++)
        {
            Taille += Fichiers[i].Taille;
        }
        return Taille/1024;
    }


}