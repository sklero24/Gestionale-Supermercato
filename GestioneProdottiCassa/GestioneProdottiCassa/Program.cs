using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GestioneProdottiCassa
{
    internal class Program
    {

        static void letturaDaFile(List<Prodotto> p)
        {

            StreamReader reader;
            reader = new StreamReader("listaProdotti.txt");
            string testoFile;
                try
                {
                    testoFile = reader.ReadToEnd();
                    try
                    {

                        string[] stringhe;
                        stringhe = testoFile.Split(';');
                      
                        foreach (string stringa in stringhe)
                        {
                            stringa.TrimStart('n');
                            string[] variabili = stringa.Split('|');
                            p.Add(new Prodotto(variabili[0], variabili[1], variabili[2], double.Parse(variabili[3]), variabili[4], DateTime.Parse(variabili[5])));
                        }

                    }
                    catch (Exception)
                    {
                        //non so cosa non vada, da sistemare
                        //Console.WriteLine("Non sono riuscito a leggere da file. Premi un qualsiasi tasto per continuare....");
                        //Console.ReadKey();

                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Errore nell' aprire il file! Premi un qualsiasi tasto per continuare....");
                    Console.ReadKey();
                }
                finally{

                    reader.Close();
                }

        }

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


            //lettura file inizio programma:
            letturaDaFile(prodotti);

            int exit = 0; //variabile per uscire all' infuori del programma e chiudere tutto
            int scelta = 1; //opzione per girare nel menu, variabile che serve per visualizzare la scelta
            int movimento = 0; //variabile per il movimento, 1 alto, 2 basso, 3 invio.

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
                            Console.Clear();
                            //funzionalità varie, da gestire con gli oggetti
                            Console.WriteLine("menu con varie funzioni da sviluppare." +
                                "le funzioni che abbiamo sono, print excel da fare" +
                                "funzione cassa con rilevamento prodotto e pagamento" +
                                "calcolo valore dei vari prodotti" +
                                "calcolo guadagni totali se venduti tutti i prodotti" +
                                "quindi bisogna dividere tutto per categorie ecc");

                            Console.ReadKey();
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
