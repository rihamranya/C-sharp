namespace TP2;

public class run
{
    static void Main(string[] args)
    {
        Projet projet = new Projet(2, "Suivi Café", 12);
        projet.AjouterProgram(new Programmeur(1, "KONTAR", "Riham", 205));
        projet.AjouterConsom(1, 1, 4);

        projet.AfficherProgram(1);
        Console.WriteLine("Total tasses semaine 1: " + projet.getTasses(1));
    }
}