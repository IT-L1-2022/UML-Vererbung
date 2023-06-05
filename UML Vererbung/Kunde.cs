using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Vererbung
{
    class Kunde : Person
    {
        private int id;

        public Kunde() : base() { id = 0; }

        public void SetID(int i)
        {
            if (i > 0 && i < 9999) id = i;
        }

        public int GetID() { return id; }

        public void Ausgabe()
        {
            Console.WriteLine("Kundenname: " + GetName());
            Console.WriteLine("Kunden-ID: " + id);
        }

    }
}
