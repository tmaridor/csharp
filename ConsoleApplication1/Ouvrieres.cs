﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//maridor thibault 
//class ouvriere
namespace ConsoleApplication1
{
    class Ouvrieres
    {
        public string _identifiant;
        public int _age;
        public int _tempdevie;
        
        public Ouvrieres()
        {
            Fourmi nouvelle = new Fourmi();
            _identifiant = nouvelle.Id;
            _age = 0;
            _tempdevie = 40;
        }
        public Ouvrieres(String identifiant, int age)
        {


            this._identifiant = identifiant;
            this._age = age;
            _tempdevie = 40;
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

