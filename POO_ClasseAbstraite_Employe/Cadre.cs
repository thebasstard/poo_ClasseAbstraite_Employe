using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ClasseAbstraite_Employe
{
    class Cadre : Employe
    {
        private int indice;

        public int Indice
        {
            get { return indice; }
            set { indice = value; }
        }

        public Cadre(int matricule, string nom, string prenom, DateTime dn, int indice)
            : base(matricule, nom, prenom, dn)
        {
            this.indice = indice;
        }

        public override string ToString()
        {
            return "Cadre: " + " " + base.ToString() + " Indice: " + indice;
        }

        public override double GetSalaire()
        {
            if (indice == 1)
                return 13000;
            else if (indice == 2)
                return 15000;
            else if (indice == 3)
                return 17000;
            else if (indice == 4)
                return 20000;
            else
                return -1;

        }
    }
}