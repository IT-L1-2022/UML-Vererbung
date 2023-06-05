using System;

namespace UML_Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Kunde einKunde = new Kunde();
            Kunde einKunde2 = new Kunde();

            einKunde2.SetID(6666);
            einKunde2.SetName("Hans");

            Console.WriteLine("Hallo");

            einKunde.Ausgabe();
            einKunde2.Ausgabe();
        }
    }
}
