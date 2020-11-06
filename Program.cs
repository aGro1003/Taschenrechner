using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Als Benutzer möchte ich zwei Gleitkommazahlen eingeben, um deren Summe berechnen zu lassen
            // Floatzahlen sind Zahlen mit Komma...sie sind abe nur bis auf 10 Stellen genau

            string ersterSummand = HoleSummanden("Gib den ersten Summanden ein: ");
            string zweiterSummand = HoleSummanden("Gib den zweiten Summanden ein: ");

            //Wandel Text in Gleitkommazahlen
            double ersterSummandalsZahl = Convert.ToDouble(ersterSummand);
            double zweiterSummandalsZahl = Convert.ToDouble(zweiterSummand);

            //Berechnung ausführen
            double summe = Addiere(ersterSummandalsZahl, zweiterSummandalsZahl);

            Console.WriteLine($"Die Summe beider Summanden ist: {summe}");
            WarteaufBenutzereingabe();
        }
        // Methode Addieren
        static double Addiere(double ersterSummand, double zweiterSummand)
            {
            double summe = ersterSummand + zweiterSummand;

            return summe;
            }
        // Methode Textausgabe  
        static string HoleSummanden(string ausgabeTxt)
        {
            Console.Write(ausgabeTxt);
            string summand = Console.ReadLine();

            return summand;
        }
        // Methode Texteingabe    
        static void WarteaufBenutzereingabe()
        {
            Console.Write("Zum Beenden bitte Return drücken!");
            Console.ReadLine();
        }
    }
}
