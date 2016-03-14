using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//maridor thibault
//class fourmiliere
namespace ConsoleApplication1
{
    class Fourmiliere
    {
        

        public Fourmiliere()
        {
            int larves = 0;
            int males = 0;
            int reines = 0;
            int ouvrieres = 0;

        }
        public Fourmiliere(int larves, int males,int ouvrieres, int reines)
        {
            this.larves = larves;
            this.males = males;
            this.reines = reines;
            this.ouvrieres = ouvrieres;
            int l = 0, m = 0, r = 0, o = 0;
            do
            {
                creeLarve();
                l++;
            } while (l < larves);

            do
            {
                creeMale();
                m++;
            } while (m < males) ;

            do
            {
                creeOuvriere();
                o++;
            } while (o < ouvrieres);

            do
            {
                creeReine();
                r++;
            } while (r < reines);
        }

        public int larves { get; private set; }
        public int males { get; private set; }
        public int ouvrieres { get; private set; }
        public int reines { get; private set; }
        List<Males> unMale = new List<Males>();
        List<Reines> uneReine = new List<Reines>();
        List<Larves> uneLarve = new List<Larves>();
        List<Ouvrieres> uneOuvriere = new List<Ouvrieres>();
        private Larves s;
        private Ouvrieres ouv;
        private Males mal;
        private Reines rei;

        public void creeMale()
        {
         
            unMale.Add(new Males());
        }
        public void creeReine()
        {
           
            uneReine.Add(new Reines());
        }
        public void creeLarve()
        {
            
            uneLarve.Add(new Larves());
            
            
        }
        public void creeOuvriere()
        {
            
            uneOuvriere.Add(new Ouvrieres());
        }
        public void avanceFourmiliere(int jour)
        {

        }
        public void demographie()
        {
            Console.WriteLine("les larves au nombre de" + uneLarve.Count);
            Console.WriteLine("les ouvrieres au nombre de" + uneOuvriere.Count);
            Console.WriteLine("les males au nombre de" + unMale.Count);
            Console.WriteLine("les reines au nombre de" + uneReine.Count);
        }
        //sert a afficher toutes les fourmis id et age et type
        public void listerFourmiliere()
        {
            Console.WriteLine("les larves");
            foreach (Larves alarve in uneLarve)
            {
                
                Console.WriteLine("age" + alarve._age + " id: " + alarve._identifiant);
            }
           
            Console.WriteLine("les ouvrieres");
            foreach (Ouvrieres aouvriere in uneOuvriere)
            {
                Console.WriteLine("age" + aouvriere._age + " id: " + aouvriere._identifiant);
            }
           
            Console.WriteLine("les males");
            foreach (Males amale in unMale)
            {
                Console.WriteLine("age" + amale._age + " id: " + amale._identifiant);
            }
           
            Console.WriteLine("les reines");
            foreach (Reines areine in uneReine)
            {
                Console.WriteLine("age" + areine._age + " id: " + areine._identifiant);
            }
           

         
        }
        //fonctionnement fourmiliere
        public void traitement(int jour=0)
        {
            int j = 0,k=0,p=0,q=0;
            do
            {
                List<Larves> removedItems = new List<Larves>();
                foreach (Larves alarve in uneLarve)
                {
                    alarve._age++;
                    if (alarve._age == 10)
                    {
                        removedItems.Add(s);
                    }
                }
                foreach (Larves s in uneLarve)
                {
                    if (s._age == 10)
                    {
                        removedItems.Add(s);
                        Random rnd = new Random();
                        int min = 0;
                        int max = 100;
                        int nb=rnd.Next(min, max);
                        //pourcentage de chance de se transformer
                        if (nb < 5)
                        {
                            uneReine.Add(new Reines(s._identifiant, 0));
                        }
                        else if(nb>5 && nb<15)
                        {
                            unMale.Add(new Males(s._identifiant, 0));
                        }
                        else {
                            uneOuvriere.Add(new Ouvrieres(s._identifiant, 0));
                        }

                    }
                }
                foreach (Larves s in removedItems)
                {
                    uneLarve.Remove(s);
                }
                j++;
            } while (j < jour);

            //ouvriere
            do
            {
                List<Ouvrieres> removedouv = new List<Ouvrieres>();
                foreach (Ouvrieres aouvriere in uneOuvriere)
                {
                    aouvriere._age++;
                    if (aouvriere._age == 40)
                    {
                        removedouv.Add(ouv);
                    }
                }
                foreach (Ouvrieres ouv in uneOuvriere)
                {
                    if (ouv._age == 40)
                    {
                        removedouv.Add(ouv);
                    }
                }
                foreach (Ouvrieres ouv in removedouv)
                {
                    uneOuvriere.Remove(ouv);
                }
                k++;
            } while (k < jour);
            //male
            do
            {
                List<Males> removedmal = new List<Males>();
                foreach (Males amale in unMale)
                {
                    amale._age++;
                    if (amale._age == 15)
                    {
                        removedmal.Add(mal);
                    }
                }
                foreach (Males mal in unMale)
                {
                    if (mal._age == 15)
                    {
                        removedmal.Add(mal);
                    }
                }
                foreach (Males mal in removedmal)
                {
                    unMale.Remove(mal);
                }
                p++;
            } while (p < jour);
            //reines
            do
            {
                List<Reines> removedrei = new List<Reines>();
                foreach (Reines areine in uneReine)
                {
                    areine._age++;
                    if (areine._age == 40)
                    {
                        removedrei.Add(rei);
                    }
                }
                foreach (Reines rei in uneReine)
                {
                    if (rei._age == 40)
                    {
                        removedrei.Add(rei);
                    }
                }
                foreach (Reines rei in removedrei)
                {
                    uneReine.Remove(rei);
                }
                q++;
                int oeuf = 0;
                if(unMale.Count>=1&&uneReine.Count>=1)
                { do { creeLarve();oeuf++; } while (oeuf != 10); }
            } while (q < jour);
            



        }


    }
}
