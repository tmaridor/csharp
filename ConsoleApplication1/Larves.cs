using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//maridor thibault
//class larves
namespace ConsoleApplication1
{
    class Larves
    {
        public string _identifiant;
        public int _age;
        public int _tempdevie;
       
        public Larves()
        {

            Fourmi nouvelle = new Fourmi();
            _identifiant = nouvelle.Id;
            _age = 0;
            _tempdevie = 10;
        }

        public string GetIdentite()
        {
            return _identifiant + " a " + _age + " jour";
        }

        public void SetAge(int newAge)
        {
            
            _age = newAge;
        }
    }
}

