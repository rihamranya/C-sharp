namespace serie1;

public class fichier
{
    public string Nom { get; set; }
    public string Extension { get; set; }
    public float Taille { get; set; }

    public fichier(string extension, float taille, string nom)
    {
        Extension = extension;
        Taille = taille;
        Nom = nom;
    }
    
}