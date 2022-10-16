using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneProdottiCassa
{
    internal class Program
    {

        static void outputScelta(int scelta) {

            switch (scelta)
            {
                case 1: //output prima scelta, inserire un prodotto.
                    Console.WriteLine("" +
                    "Gestionale Scannerizzazione prodotti supermercato \n" +
                    "Inserisci prodotto \n" +
                    "------------------ \n" +
                    "visualizza tutti i prodotti \n" +
                    "\n" +
                    "Funzionalità \n" +
                    "\n" +
                   "Esci dal programma \n" +
                    "\n");

                    break;

                case 2: //output seconda scelta
                    Console.WriteLine("" +
                    "Gestionale Scannerizzazione prodotti supermercato \n" +
                    "Inserisci prodotto \n" +
                    "\n" +
                    "visualizza tutti i prodotti \n" +
                    "--------------------------- \n" +
                    "Funzionalità\n" +
                    "\n" +
                   "Esci dal programma \n" +
                    "\n");

                    break;

                case 3: //output seconda scelta
                    Console.WriteLine("" +
                    "Gestionale Scannerizzazione prodotti supermercato \n" +
                    "Inserisci prodotto \n" +
                    "\n" +
                    "visualizza tutti i prodotti \n" +
                    "\n" +
                    "Funzionalità\n" +
                    "---------------------\n" +
                   "Esci dal programma \n" +
                    "\n");

                    break;

                case 4: //output seconda scelta
                    Console.WriteLine("" +
                    "Gestionale Scannerizzazione prodotti supermercato \n" +
                    "Inserisci prodotto \n" +
                    "\n" +
                    "visualizza tutti i prodotti \n" +
                    "\n" +
                    "Funzionalità\n" +
                    "\n" +
                   "Esci dal programma \n" +
                   "------------------\n");

                    break;

            }

        }

        static int movimentoMenu()
        {
            char pulsante = 'a';
            try
            {
                pulsante = Console.ReadKey().KeyChar; //lettura singolo char per andare su e giù con le freccie
            }
            catch (Exception)
            {

                pulsante = 'a';

            }

            switch (pulsante)
            {

                case 'w': //sopra
                    return 1;
                case 's': //sotto
                    return 2;
                case 'e': //invio
                    return 3;
                default: //in caso che nessuno dei seguenti caratteri sia stato inserito, il metodo ritorna 0
                    break;

            }

            return 0; //return di default per no action, il programma non farà niente.
        }

        static void Menu()
        {

            List<Prodotto> prodotti = new List<Prodotto>();
            //ArrayList prodotti = new ArrayList();
            //prodotti test
            prodotti.Add(new Prodotto("Espressioni e sentimenti", "Libri", "libro sul disegno", 19.99 , "9788865050224"));
            prodotti.Add(new Prodotto("Equilibrio e dinamica dei corpi", "Libri", "libro sul disegno", 19.99 , "9788865050064"));
            prodotti.Add(new Prodotto("Character Design", "Libri", "libro sul disegno", 19.99, "9788865050101"));
            prodotti.Add(new Prodotto("Pennarelli - Felt Pens", "Cancelleria", "Pennarelli per disegnare", 2.99 , "8027217008379"));
            prodotti.Add(new Prodotto("Database SQL e PHP", "Libri", "Libro scolastico su mysql e php",29.99 , "9788820383398"));


            int exit = 0; //variabile per uscire all' infuori del programma e chiudere tutto
            int scelta = 1; //opzione per girare nel menu, variabile che serve
            int movimento = 0;

            while (exit != 1)
            {
                //loop default applicazione
                Console.Clear(); //svuotamento area lavoro
                outputScelta(scelta); //output menu
                movimento = movimentoMenu(); //registrazione input comando menu

                if (movimento == 1) //verso l' alto.
                {
                    if (scelta > 1)
                    {
                        --scelta;
                    }
                }

                if (movimento == 2) //movimento verso il basso
                {
                    if(scelta < 4)
                    {

                            ++scelta;

                    }
                }
                
                if (movimento == 3) //invio, ovvero ho premuto e
                {

                    switch (scelta) //entro nelle varie funzioni dell' app
                    {

                        case 1:
                            GestioneAggiunta gestione = new GestioneAggiunta(prodotti);
                            break;

                        case 2:
                            Console.Clear();

                            //ciclo for di arraylist
                            for(int i = 0; i<prodotti.Count; i++)
                            {
                                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");
                                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");
                                Console.WriteLine($"prodotto numero {i+1}");
                                Console.WriteLine("---------------------------------------------------");
                                Console.WriteLine(prodotti[i].toString());
                                Console.WriteLine("---------------------------------------------------");
                                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");
                                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");
                                Console.WriteLine("\n");
                            }

                            Console.WriteLine("Premi un tasto qualsiasi per tornare al menù.");
                            Console.ReadKey();

                            break;

                        case 3:
                            break;

                        case 4:
                            exit = 1;
                            break;


                    }

                }
            
            } //fine while
        } 

        static void Main(string[] args)
        {

            Menu();

            Console.Clear();
            Console.WriteLine("grazie per aver usato il gestionale \ncreato da Lorenzo Skliarov");
            Console.ReadKey();
        }
    }
}
