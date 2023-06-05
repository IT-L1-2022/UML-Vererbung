using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Vererbung
{
    class Person
    {
        private string name;

        public Person() { name = "NN"; }

        public void SetName(string n) { name = n; }

        public string GetName() { return name; }

    }
}
