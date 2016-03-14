using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  //maridor thibault
  //class fourmi
  //genere les id
    class Fourmi
    {
        public string _identifiant;
        
        private static int inc;

        public Fourmi()
        {
            
            inc++;
            _identifiant = "fourmie" + inc;

        }
        public string Id
        {
            get
            {
                return _identifiant;
            }
      set
        {
        }
    }
    }
}