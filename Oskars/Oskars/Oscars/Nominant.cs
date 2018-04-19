using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Oskars
{
    class Nominant:ITrue
    {
        public string name { get; set; }
        public int nominations { get; set; }
        public int oscars { get; set; }

        public Nominant()
        {
            
        }

        public Nominant(string _name, int _nominations, int _oscars)
        {
            name = _name;
            nominations = _nominations;
            oscars = _oscars;
        }

        public bool IsTrue(int nominatios, int oscars)
        {
            if (nominatios >= oscars) return true;
            else return false;
        }
    }
}
