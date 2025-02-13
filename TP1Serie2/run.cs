namespace TP1;

public class run
{
    static void Main(string[] args)
    {
        GestionEmployes gestion = new GestionEmployes();

        gestion.AjouterEmploye(new Employe("KONTAR", "Riham", 4000, "Développeuse", new DateOnly(2020, 5, 1), 101));
        gestion.AjouterEmploye(new Employe("KONTAR", "Ranya", 5000, "Chef de projet", new DateOnly(2018, 3, 15), 102));
        gestion.AjouterEmploye(new Employe("OUGUAS", "Ayah", 3000, "Technicien", new DateOnly(2022, 7, 10), 103));

        Directeur directeur = Directeur.Instance;
        directeur.SetGestionEmployes(gestion);

        Console.WriteLine("Liste des employés :");
        directeur.AfficherEmployes();

        Console.WriteLine($"\nSalaire total de l'entreprise : {directeur.GetSalaireTotal():C}");
        Console.WriteLine($"Salaire moyen des employés : {directeur.GetSalaireMoyen():C}");
    }
}