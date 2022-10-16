using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneProdottiCassa
{
    internal class GestioneAggiunta
    {

        static void aggiuntaProdotto(List<Prodotto> lista)
        {



            string nomeTMP;
            string categoriaTMP;
            string descrizioneTMP;
            string codiceABarreTMP;
            double prezzoTMP;

            Console.Clear();

            //aggiunta nome dell' oggetto
            Console.WriteLine("Inserisci il nome dell' oggetto da aggiungere:");
            try
            {
                nomeTMP = Console.ReadLine();
            }
            catch (Exception)
            {
                nomeTMP = "default";
            }

            Console.Clear();

            //aggiunta categoria
            Console.WriteLine("categorie prodotti già esistenti:");
            for(int i = 0; i<lista.Count(); i++)
            {
                for (int j = 0; j<3; j++)
                {
                    Console.Write(lista[i].getCategoria() + "\t");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Inserisci la categoria:");
            try
            {
                categoriaTMP = Console.ReadLine();
            }
            catch (Exception)
            {
                categoriaTMP = "default";
            }

            Console.Clear();

            //aggiungi descrizione
            Console.WriteLine("Descrizione prodotto:");
            try
            {
                descrizioneTMP = Console.ReadLine();
            }
            catch (Exception)
            {
                descrizioneTMP = "default";
            }

            Console.Clear();

            //codice a barre
            Console.WriteLine("scannerizza/inserisci codice a barre:");
            try
            {
                codiceABarreTMP = Console.ReadLine();
            }
            catch (Exception)
            {
                codiceABarreTMP = "default";
            }

            Console.Clear();

            //inserimento 
            Console.WriteLine("Inserisci il prezzo dell'oggetto:");
            try
            {
                prezzoTMP = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                prezzoTMP = 0;
            }

            Console.Clear();
            
            lista.Add(new Prodotto(nomeTMP, categoriaTMP, descrizioneTMP, prezzoTMP, codiceABarreTMP));

            Console.WriteLine("Prodotto inserito. premi un qualsiasi tasto per tornare al menù.");
            Console.ReadKey();

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
        static void outputScelta(int scelta)
        {

            switch (scelta)
            {
                case 1: //output prima scelta, inserire un prodotto.
                    Console.WriteLine("" +
                    "Gestionale Inserimento prodotto \n" +
                    "Inserisci prodotto \n" +
                    "------------------ \n" +
                    "Elimina prodotto \n" +
                    "\n" +
                    "Modifica prodotto \n" +
                    "\n" +
                   "torna indietro \n" +
                    "\n");

                    break;

                case 2: //output prima scelta, inserire un prodotto.
                    Console.WriteLine("" +
                    "Gestionale Inserimento prodotto \n" +
                    "Inserisci prodotto \n" +
                    "\n" +
                    "Elimina prodotto \n" +
                    "------------------ \n" +
                    "Modifica prodotto \n" +
                    "\n" +
                   "torna indietro \n" +
                    "\n");

                    break;

                case 3: //output prima scelta, inserire un prodotto.
                    Console.WriteLine("" +
                    "Gestionale Inserimento prodotto \n" +
                    "Inserisci prodotto \n" +
                    "\n" +
                    "Elimina prodotto \n" +
                    "\n" +
                    "Modifica prodotto \n" +
                    "------------------ \n" +
                   "torna indietro \n" +
                    "\n");

                    break;

                case 4: //output prima scelta, inserire un prodotto.
                    Console.WriteLine("" +
                    "Gestionale Inserimento prodotto \n" +
                    "Inserisci prodotto \n" +
                    "\n" +
                    "Elimina prodotto \n" +
                    "\n" +
                    "Modifica prodotto \n" +
                    "\n" +
                   "torna indietro \n" +
                    "------------------ \n");

                    break;

            }

        }

        public GestioneAggiunta(List<Prodotto> listaProdotti)
        {

            int movimento = 0;
            int exit = 0;
            int scelta = 1; //deve sempre partire con l'essere 1

            while (exit != 1)
            {
                //loop default applicazione
                Console.Clear(); //svuotamento area lavoro

                /////////////////////////////
                //debug
                //Console.WriteLine(scelta);
                //Console.WriteLine(movimento);
                /////////////////////
                ///

                //funzioni in loop
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
                    if (scelta < 4)
                    {

                        ++scelta;

                    }
                }

                if (movimento == 3) //invio, ovvero ho premuto e
                {

                    switch (scelta)
                    {

                        case 1:
                            aggiuntaProdotto(listaProdotti);
                            break;

                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            exit = 1;
                            break;

                    }

                }

            }
        }

    }
}
