namespace TP2;

public class Programmeur
{
    public int ID { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public float Bureau { get; set; }

    public Programmeur(int id, string nom, string prenom, float bureau)
    {
        ID = id;
        Nom = nom;
        Prenom = prenom;
        Bureau = bureau;
    }
    
}