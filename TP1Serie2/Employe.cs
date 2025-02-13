namespace TP1;

public class Employe
{
    private int code;
    private String nom;
    private String prenom;
    private float salaire;
    private String poste;
    private DateOnly date_embauche;
    public int Code
    {
        get { return code; }
        set { code = value; }
    }
    public String Nom
    {
        get { return nom; }
        set { nom = value; }
    }
    public String Prenom
    {
        get { return prenom; }
        set { prenom = value; }
    }
    
    public float Salaire
    {
        get { return salaire; }
        set { salaire = value; }
    }
    
    public String Poste
    {
        get { return poste; }
        set { poste = value; }
    }
    
    public DateOnly Date_Embauche
    {
        get { return date_embauche; }
        set { date_embauche = value; }
    }

    public Employe(string nom, string prenom, float salaire, string poste, DateOnly dateEmbauche, int code)
    {
        this.code = code;
        this.nom = nom;
        this.prenom = prenom;
        this.salaire = salaire;
        this.poste = poste;
        date_embauche = dateEmbauche;
    }
}