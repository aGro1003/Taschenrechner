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

            string ersteZahlalsString = HoleBenutzereingabe("Gib die erste Zahl ein: ");
            string zweiteZahlalsString = HoleBenutzereingabe("Gib die zweite Zahl ein: ");

            string operation = HoleBenutzereingabe("Gib die auszuführende Operation an: (+ oder -)");

            // Wandel Text in Gleitkommazahlen
            // TODO: Auslagern in Methode, wenn Quellcode umfangreicher ist
            double ersteZahl = Convert.ToDouble(ersteZahlalsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlalsString);

            //Berechnung ausführen
            double summe = Addiere(ersteZahl, zweiteZahl);

            Console.WriteLine($"Die Summe beider Summanden ist: {summe}");
            HoleBenutzereingabe("Zum Beenden bitte Return drücken!");
        }

        // Methode Addieren
        static double Addiere(double ersterSummand, double zweiterSummand)
            {
            double summe = ersterSummand + zweiterSummand;

            return summe;
            }

        //Methode Subtrahieren
        static double Subtrahiere(double minuend, double subtrahent)
        {
            double differenz = minuend - subtrahent;

            return differenz;
        }

        // Methode Textausgabe  
        static string HoleBenutzereingabe(string ausgabeTxt)
        {
            Console.Write(ausgabeTxt);
            string summand = Console.ReadLine();

            return summand;
        }
        
    }
}
