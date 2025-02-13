namespace TP5;

public class Compte
{
    public int num_bancaire { get; set; }
    public string Nom_client { get; set; }
    public string Prenom_client { get; set; }
    
    public double solde { get; set; }
    public List<string> Historique { get; private set; }

    public Compte(int numBancaire, string nomClient, string prenomClient)
    {
        num_bancaire = numBancaire;
        Nom_client = nomClient;
        Prenom_client = prenomClient;
        solde = 0;
        Historique = new List<string>();
    }
    
    
    
    public void Crediter(double montant)
    {
        if (montant > 0)
        {
            solde += montant;
            Historique.Add($"+{montant} EUR | Nouveau solde: {solde}");
            Console.WriteLine($"Compte {num_bancaire} crédité de {montant} EUR.");
        }
        else
        {
            Console.WriteLine("Montant invalide.");
        }
    }

    public void Debiter(double montant)
    {
        if (montant > 0 && montant <= solde)
        {
            solde -= montant;
            Historique.Add($"-{montant} EUR | Nouveau solde: {solde}");
            Console.WriteLine($"Compte {num_bancaire} débité de {montant} EUR.");
        }
        else
        {
            Console.WriteLine("Fonds insuffisants ou montant invalide.");
        }
    }

    public void AfficherHistorique()
    {
        Console.WriteLine($"Historique du compte {num_bancaire} :");
        foreach (var operation in Historique)
        {
            Console.WriteLine(operation);
        }
    }
}