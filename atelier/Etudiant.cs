namespace atelier;

public class Etudiant
{
    private int code;
    private string nom, prenom;

    public int Code
    {
        get { return code; }
        set { Code = value; }
    }

    public Etudiant(int code = 10, string nom = "", string prenom = "")
    {
        this.code = code;
        this.nom = nom;
        this.prenom = prenom;    
    }

    public void Afficher()
    {
        Console.WriteLine(
            $@"Code: {code}
            Nom: {nom}
            Prenom: {prenom}"
            );
    }

    static public void Main(string[] args)
    {
        Etudiant E = new Etudiant();
        E.nom = "KONTAR";
        E.prenom = "Riham";
        E.Afficher();
    }
    
}