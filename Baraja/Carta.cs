using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Carta
    {
        int number { get; set; }
        string palo { get; set; }

        public Carta(int number, string palo)
        {
            this.number = number;
            this.palo = palo;
        }

        override
        public string ToString()
        {
            return "\t{\n\t\t\"number\": " + number + ",\n\t\t\"palo\": \"" + palo + "\"\n\t}";
        }
}
