namespace Serie3;

public class RessourcesHumaines : IRessourcesHumaines
{
    private List<Personnel> GRH = new List<Personnel>();

    public void AjouterPersonnel(Personnel p)
    {
        GRH.Add(p);
    }
    public void AfficherEnseignants()
    {
        for (int i = 0; i < GRH.Count; i++)
        {
                
        }
    }

    public int Rechercher_Ens(String Code)
    {
        for (int i = 0; i < GRH.Count; i++)
        {
            if (GRH[i] is Enseignant ens && ens.Code == Code)
                return i;
        }
        return 0;
    }

}