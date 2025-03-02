namespace Serie3;

public class Directeur : Personnel
{
    private static Directeur instance;
    public Directeur(string code, string nom, string prenom, string bureau, double salaire, double prime) : base(code, nom, prenom, bureau, salaire, prime)
    {
    }
    public override double CalculerSalaire()
    {
        return Salaire+Prime;
    }
}