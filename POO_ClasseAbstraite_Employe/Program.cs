using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ClasseAbstraite_Employe
{
    class Program
    {
        static void Main(string[] args)
        {
            // un exemple de programme de test simple
            Ouvrier o = new Ouvrier(1, "Nom1", "Prenom1", new DateTime(1980, 2, 3), new DateTime(2000, 4, 5));
            Console.Out.WriteLine(o);
            Console.Out.WriteLine("Salaire de l'employé: " + o.GetSalaire());
            Console.Out.WriteLine("***********************************");
            Cadre c = new Cadre(2, "Nom2", "Prenom2", new DateTime(1986, 4, 3), 3);
            Console.Out.WriteLine(c);
            Console.Out.WriteLine("Le salaire du cadre est: " + c.GetSalaire());
            Console.Out.WriteLine("***********************************");
            Patron.CA = 17000000;
            Patron p = new Patron(3, "Nom3", "Prenom3", new DateTime(1970, 6, 6), 3);
            Console.Out.WriteLine(p);
            Console.Out.WriteLine("Le salaire du patron est: " + p.GetSalaire());
            Console.ReadKey();
           
        }
    }
}
