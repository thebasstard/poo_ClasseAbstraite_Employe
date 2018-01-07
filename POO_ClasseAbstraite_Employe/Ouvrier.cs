using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ClasseAbstraite_Employe
{
    class Ouvrier : Employe
    {
        private DateTime dateentree;
        private static double sMIG = 2500;

        public static double SMIG
        {
            get { return sMIG; }

        }

        public DateTime Dateentree
        {
            get { return dateentree; }
            set { dateentree = value; }
        }

        public Ouvrier(int m, string n, string p, DateTime dn, DateTime de)
            : base(m, n, p, dn)
        {
            dateentree = de;
        }

        public override string ToString()
        {
            return "Employé:" + " " + base.ToString() + " Date d'entrée: " + dateentree.ToShortDateString();
        }

        public override double GetSalaire()
        {
            double salaire;
            int Anciennete = DateTime.Now.Year - dateentree.Year;
            if (dateentree.AddYears(Anciennete) > DateTime.Now.Date)
                Anciennete--;
            if (sMIG + Anciennete * 100 <= 2 * sMIG)
                salaire = sMIG + Anciennete * 100;
            else
                salaire = sMIG * 2;

            return salaire;
            
        }
    }
}
