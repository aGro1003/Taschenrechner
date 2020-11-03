using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Iteration_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen
            Console.Write("Bitte gib den ersten Summanden ein: ");
            string ersterSummand = Console.ReadLine();
            Console.Write("Bitte gib den zweiten Summanden ein: ");
            string zweiterSummand = Console.ReadLine();

            //Wandel Text in Ganzzahlen
            int ersterSummandalsZahl = Convert.ToInt32(ersterSummand);
            int zweiterSummandalsZahl = Convert.ToInt32(zweiterSummand);

            //Berechnung ausführen
            int summe = ersterSummandalsZahl + zweiterSummandalsZahl;

            Console.WriteLine($"Die Summe beider Summanden ist: {summe}");
            Console.ReadLine();

        }
    }
}
