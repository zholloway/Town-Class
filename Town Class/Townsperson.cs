using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town_Class
{
    class Townsperson
    {
        public string Name { get; set; }

        public string HairColor { get; set; }

        public string EyeColor { get; set; }

        public Townsperson(string name, string hairColor, string eyeColor)
        {
            this.Name = name;
            this.HairColor = hairColor;
            this.EyeColor = eyeColor;
        }
    }
}
