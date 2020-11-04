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
            // Als Benutzer möchte ich zwei Gleitkommazahlen eingeben, um deren Summe berechnen zu lassen
            // Floatzahlen sind Zahlen mit Komma...sie sind abe nur bis auf 10 Stellen genau

            Console.Write("Bitte gib den ersten Summanden ein: ");
            string ersterSummand = Console.ReadLine();
            Console.Write("Bitte gib den zweiten Summanden ein: ");
            string zweiterSummand = Console.ReadLine();

            //Wandel Text in Gleitkommazahlen
            float ersterSummandalsZahl = Convert.ToSingle(ersterSummand);
            float zweiterSummandalsZahl = Convert.ToSingle(zweiterSummand);

            //Berechnung ausführen
            float summe = ersterSummandalsZahl + zweiterSummandalsZahl;

            Console.WriteLine($"Die Summe beider Summanden ist: {summe}");
            Console.ReadLine();

        }
    }
}
