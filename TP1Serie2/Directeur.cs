namespace TP1;

public class Directeur
{
    private static Directeur _instance;
    private GestionEmployes gestionEmployes;

    
    private Directeur()
    {
        gestionEmployes = new GestionEmployes();
    }
    public static Directeur Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Directeur();
            return _instance;
        }
    }
    
    public double GetSalaireTotal()
    {
        return gestionEmployes.CalculSalaireTotal();
    }
    
    public double GetSalaireMoyen()
    {
        return gestionEmployes.SalaireMoyen();
    }
    
    public void SetGestionEmployes(GestionEmployes gestionEmployes)
    {
        this.gestionEmployes = gestionEmployes;
    }

    public void AfficherEmployes()
    {
        gestionEmployes.AfficherEmployes();
    }
    
}