namespace TP2;

public class Consos_Cafe
{
    public int No_Semaine { get; set; }
    public int IdProgrammeur { get; set; }
    public int Nb_Tasses { get; set; }

    public Consos_Cafe(int noSemaine, int idProgrammeur, int nbTasses)
    {
        No_Semaine = noSemaine;
        IdProgrammeur = idProgrammeur;
        Nb_Tasses = nbTasses;
    }
    
    
}