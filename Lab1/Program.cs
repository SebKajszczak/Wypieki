using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilosc Kremowek: ");
            int intTemp = Convert.ToInt32(Console.ReadLine());
            List<Ciastka> lista_ciastek = new List<Ciastka>();
            lista_ciastek.Add(new Kremowka(intTemp));
            Console.WriteLine("Podaj ilosc Piegusek: ");
            intTemp = Convert.ToInt32(Console.ReadLine());
            lista_ciastek.Add(new Pieguski(intTemp));

            foreach (Ciastka ciacho in lista_ciastek)
            {
                ciacho.skladniki();
                ciacho.przygotowanie();
                ciacho.jedz();
            }

            //Kremowka jakkolwiek = new Kremowka(7);
            //jakkolwiek.skladniki();
            //jakkolwiek.przygotowanie();
            //jakkolwiek.jedz(); 
            Console.ReadKey();
        }
        
    }
}
