namespace TP5;

public class run
{
    static void Main(string[] args)
    {
        Banque banque = new Banque();
        
        while (true)
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("1) Ajouter un nouveau compte");
            Console.WriteLine("2) Rechercher un compte");
            Console.WriteLine("3) Supprimer un compte");
            Console.WriteLine("4) Opération sur un compte");
            Console.WriteLine("5) Afficher tous les comptes");
            Console.WriteLine("6) Quitter le programme");
            Console.Write("Donnez votre choix: ");
            
            int choix;
            if (!int.TryParse(Console.ReadLine(), out choix))
            {
                Console.WriteLine("Veuillez entrer un nombre valide !");
                continue;
            }

            switch (choix)
            {
                case 1:
                    banque.AjouterCompte();
                    break;

                case 2:
                    Console.Write("Entrez le numéro du compte: ");
                    int numero = int.Parse(Console.ReadLine());
                    var compte = banque.RechercherCompte(numero);
                    if (compte != null)
                    {
                        Console.WriteLine(compte.num_bancaire +" - "+compte.Nom_client +" "+compte.Prenom_client+" - "+ compte.solde );
                    }
                    break;

                case 3:
                    banque.SupprimerCompte();
                    break;

                case 4:
                    banque.OperationsCompte();
                    break;

                case 5:
                    banque.AfficherComptes();
                    break;

                case 6:
                    Console.WriteLine("Programme terminé ");
                    return;

                default:
                    Console.WriteLine("Choix invalide, veuillez réessayer.");
                    break;
            }
        }
    }
}