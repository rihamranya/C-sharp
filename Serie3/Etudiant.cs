namespace Serie3;

public class Etudiant : Personne
    {
        private String niveau;
        private double moyenne;

        public Etudiant(string code, string nom, string prenom, String niveau, double moyenne) : base(code, nom, prenom)
        {
            this.niveau = niveau;
            this.moyenne = moyenne;
        }

        public String Niveau
        {
            get { return niveau;}
            set { niveau = value; }
        }
        public double Moyenne
        {
            get { return moyenne; }
            set { moyenne = value; }
        }
        
    }
