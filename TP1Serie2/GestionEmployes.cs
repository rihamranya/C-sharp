namespace TP1;

public class GestionEmployes
{
    public List<Employe> employes =new List<Employe>();
    
    public List<Employe> Employes
    {
        get { return employes; }
        set { employes = value; }
    }

    public void AjouterEmploye(Employe employe)
    {
        employes.Add(employe);
    }

    public Employe RechercherEmpByCode(int code)
    {
        for (int i = 0; i < employes.Count; i++)
        {
            if (employes[i].Code == code)
            {
                return employes[i];
            }
        }
        return null;
    }

    public void SupprimerEmploye(int code)
    {
        Employe employe = RechercherEmpByCode(code);
        if (employe != null)
        {
            employes.Remove(employe);
        }
    }

    public float CalculSalaireTotal()
    {
        float salaire = 0;
        for (int i = 0; i < employes.Count; i++)
        {
            salaire += employes[i].Salaire;
        }
        return salaire;
    }

    public float SalaireMoyen()
    {
        float salaireMoyen = CalculSalaireTotal();
        salaireMoyen = salaireMoyen/employes.Count;
        return salaireMoyen;
    }

    public void AfficherEmployes()
    {
        for (int i = 0; i < employes.Count; i++)
        {
            Console.WriteLine("Nom:"+employes[i].Nom+" Prenom "+employes[i].Prenom);
        }
    }
    
}