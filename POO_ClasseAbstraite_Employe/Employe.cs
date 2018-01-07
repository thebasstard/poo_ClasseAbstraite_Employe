using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ClasseAbstraite_Employe
{
    abstract class Employe
    {
        private int matricule;
        private string nom;
        private string prenom;
        private DateTime datenaissance;
        

        
        public int Matricule
        {
            get { return matricule; }
            set { matricule = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public DateTime Datenaissance
        {
            get { return datenaissance; }
            set { datenaissance = value; }
        }


        public Employe() { }


        public Employe(int m, string n, string p, DateTime dn)
        {
            matricule = m;
            nom = n;
            prenom = p;
            datenaissance = dn;
        }


        public override string ToString()
        {
            return "Matricule: " + matricule + " Nom: " + nom + " Prénom: " + prenom + "Date de naissance: " + datenaissance.ToShortDateString();
        }

        public abstract double GetSalaire();
  
    }
}
