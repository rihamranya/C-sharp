namespace TP5;

public class Banque
{
    public List<Compte> comptes { get; set; }= new List<Compte>();

    public void AjouterCompte()
    {
        Console.Write("Entrez le numéro du compte bancaire: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Entrez le nom du client: ");
        string nom = Console.ReadLine();
        Console.Write("Entrez son prénom: ");
        string prenom = Console.ReadLine();
        

        if (RechercherCompte(numero) == null)
        {
            comptes.Add(new Compte(numero, nom, prenom));
            Console.WriteLine("Création du compte effectuée !");
        }
        else
        {
            Console.WriteLine("Ce compte existe déjà !");
        }
    }

    public Compte RechercherCompte(int numero)
    {
        for (int i = 0; i < comptes.Count; i++)
        {
            if (comptes[i].num_bancaire == numero)
            {
                return comptes[i];
            }
        }
        return null;
    }

    public void SupprimerCompte()
    {
        Console.WriteLine("Entrez le numéro du compte : ");
        int numero = int.Parse(Console.ReadLine());
        Compte compte = RechercherCompte(numero);

        if (compte != null)
        {
            comptes.Remove(compte);
            Console.WriteLine("Compte supprime......");
        }
    }

    public void AfficherComptes()
    {
        for (int i = 0; i < comptes.Count; i++)
        {
            Console.WriteLine(comptes[i].num_bancaire + " - " +comptes[i].Nom_client + " "+ comptes[i].Prenom_client +" - "+ comptes[i].solde+" dhs");
        }
    }

    public void OperationsCompte()
    {
        Console.Write("Entrez le numéro du compte: ");
        int numero = int.Parse(Console.ReadLine());
        Compte compte = RechercherCompte(numero);

        if (compte == null)
        {
            Console.WriteLine($"Le compte {numero} n'existe pas !!!");
            return;
        }

        while (true)
        {
            Console.WriteLine($"\n========== OPERATION SUR LE COMPTE {compte.num_bancaire} ==========");
            Console.WriteLine("1) Créditer");
            Console.WriteLine("2) Débiter");
            Console.WriteLine("3) Historique");
            Console.WriteLine("4) Retour au menu principal");
            Console.Write("Choisissez une option: ");
            int choix = int.Parse(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    Console.Write("Montant à créditer: ");
                    double credit = double.Parse(Console.ReadLine());
                    compte.Crediter(credit);
                    break;

                case 2:
                    Console.Write("Montant à débiter: ");
                    double debit = double.Parse(Console.ReadLine());
                    compte.Debiter(debit);
                    break;

                case 3:
                    compte.AfficherHistorique();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Option invalide, veuillez réessayer.");
                    break;
            }
        }
    }
}