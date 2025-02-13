namespace TP2;

public class Projet
{
    public int Code { get; set; }
    public string Sujet { get; set; }
    public int Duree { get; set; }
    public List<Programmeur> Programmeurs { get; set; } =new List<Programmeur>();
    public List<Consos_Cafe> Consommations { get; set; } = new List<Consos_Cafe>(); 

    public Projet(int code, string sujet, int duree)
    {
        Code = code;
        Sujet = sujet;
        Duree = duree;
    }

    public void AjouterProgram(Programmeur programmeur)
    {
        Programmeurs.Add(programmeur);
    }

    public Programmeur RechercherProgram(int id)
    {
        for (int i = 0; i < Programmeurs.Count; i++)
        {
            if (Programmeurs[i].ID == id)
            {
                return Programmeurs[i];
            }
        }

        return null;
    }

    public void AfficherProgram(int id)
    {
        Programmeur programmeur = RechercherProgram(id);
        Console.WriteLine($"Id:{programmeur.ID},Nom:{programmeur.Nom}," +
                          $"Prenom:{programmeur.Prenom},Bureau:{programmeur.Bureau}");
    }

    public void Afficher()
    {
        for (int i = 0; i < Programmeurs.Count; i++)
        {
            Console.WriteLine($"Id:{Programmeurs[i].ID},Nom:{Programmeurs[i].Nom}," +
                              $"Prenom:{Programmeurs[i].Prenom},Bureau:{Programmeurs[i].Bureau}/n");
        }
    }

    public void Supprimer(int id)
    {
        Programmeur programmeur = RechercherProgram(id);
        Programmeurs.Remove(programmeur);
    }

    public void AjouterConsom(int No_Semaine,int IdProgrammeur,int Nb_Tasses)
    {
        Consommations.Add(new Consos_Cafe(No_Semaine,IdProgrammeur,Nb_Tasses));
    }

    public void ChangerBureau(int id, float nvBureau)
    {
        Programmeur programmeur = RechercherProgram(id);
        programmeur.Bureau = nvBureau;
    }

    public int getTasses(int No_Semaine)
    {
        int total=0;
        for (int i = 0; i < Consommations.Count; i++)
        {
            if (Consommations[i].No_Semaine == No_Semaine)
            {
                total += Consommations[i].Nb_Tasses;
            }
        }

        return total;
    }

}