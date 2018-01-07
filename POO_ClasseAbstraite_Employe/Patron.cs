using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ClasseAbstraite_Employe
{
    class Patron:Employe
    {
        private static double ca;
        private double pourcentage;
        
        public double Pourcentage
        {
            get { return pourcentage; }
            set { pourcentage = value; }
        }

        public static double CA
        {
            get { return ca; }
            set { ca = value; }
        }

        public Patron(int matricule,string nom,string prenom,DateTime datenaissance,double p)
            : base(matricule, nom, prenom, datenaissance)
        {
            pourcentage = p;
        }

        public override string ToString()
        {
            return "Patron : " + base.ToString() + "pourcentage : " + pourcentage + " %";
        }

        public override double GetSalaire()
        {
            return Math.Round((ca * pourcentage / 100) / 12, 2);
        }
        
    }
}
