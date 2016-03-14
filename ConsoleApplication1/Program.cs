
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Maridor thibault
//main et menu du programme
namespace ConsoleApplication1
{
    class Program
    {


        static void Main(string[] args)
        {
            //on demande les fourmis initial de chaque type
            Console.WriteLine("Combien de fourmis existe du type:");

            int iteration = 0;
            bool isinputvalid = false;
            int larves = 0, males = 0, ouvrieres = 0, reines = 0;

        
                while (iteration != 5)
                {
                    switch (iteration)
                    {
                        case 1:
                            Console.WriteLine("Les Larves ");
                            do {
                                if (Int32.TryParse(Console.ReadLine(), out larves))
                                { Console.WriteLine("larves ok: " + larves); isinputvalid = false; }
                                else { Console.WriteLine("problème non numérique");
                                Console.WriteLine("Les Larves ");
                                isinputvalid = true; }
                            } while (isinputvalid);
                            isinputvalid = false;
                        
                            break;
                        case 2:
                            Console.WriteLine("Les Mâles ");
                            do
                            {
                                if (Int32.TryParse(Console.ReadLine(), out males))
                                { Console.WriteLine("males ok: " + males); isinputvalid = false; }
                                else { Console.WriteLine("problème non numérique");
                                Console.WriteLine("Les Mâles ");
                                isinputvalid = true; }
                            } while (isinputvalid);
                            isinputvalid = false;
                            break;
                        case 3:
                            Console.WriteLine("Les Ouvrières ");
                            do
                            {
                                if (Int32.TryParse(Console.ReadLine(), out ouvrieres))
                                { Console.WriteLine("ouvireres ok: " + ouvrieres); isinputvalid = false; }
                                else { Console.WriteLine("problème non numérique");
                                Console.WriteLine("Les Ouvrières ");
                                isinputvalid = true; }
                            } while (isinputvalid);
                            isinputvalid = false;
                            break;
                        case 4:
                            Console.WriteLine("Les Reines ");
                            do
                            {
                                if (Int32.TryParse(Console.ReadLine(), out reines))
                                { Console.WriteLine("Reines ok: " + reines); isinputvalid = false; }
                                else { Console.WriteLine("problème non numérique");
                                Console.WriteLine("Les Reines ");
                                isinputvalid = true; }
                            } while (isinputvalid);
                            isinputvalid = false;
                            break;
                        case 5:
                            Console.WriteLine("continuer ");
                            break;

                        default:
                            break;
                    }
                    
                    iteration++;

                }
            Console.WriteLine("Les Larves " + larves + "\n Males :" + males + "\n ouvrieres:" + ouvrieres + "\n reines:" + reines);
            Fourmiliere maFourmiliere = new Fourmiliere(larves,males,ouvrieres,reines);
            String choix="e";
            int jour = 0;
            bool enter = true;
            do
            {
                Console.WriteLine("Pour quitter tapper q, pour avancer de quelque jour taper un nombre de jour ou entrer pour continuer le jour suivant");
                
                choix = Console.ReadLine();
                int saisie;

                    if (Int32.TryParse(choix, out saisie))
                    { Console.WriteLine("avance de: "+saisie+" jour");
                    jour = jour + saisie;
                    Console.WriteLine(jour + " jours");
                    maFourmiliere.traitement(saisie);//plusieurs jour
                    maFourmiliere.demographie();
                    enter = false;
                    }
                    if(enter==true)
                {
                    Console.WriteLine("plus 1 jour");
                    jour++;
                    saisie = 0;
                    maFourmiliere.traitement(1);//jour par jour
                    Console.WriteLine(jour + " jours");
                }
                
                enter = true;


             //   maFourmiliere.listerFourmiliere();//affichage des noms et age des fourmis

            } while (choix != "q");
            Console.ReadLine();

        }
    }
 
}
