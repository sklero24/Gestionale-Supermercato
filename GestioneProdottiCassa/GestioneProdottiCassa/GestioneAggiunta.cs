using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneProdottiCassa
{
    internal class GestioneAggiunta
    {
        static void modificaProdotto(List<Prodotto> lista)
        {

            Console.WriteLine("tipo di oggetto da cercare?? Premi il tasto corrispondente:");
            Console.WriteLine("N - nome, C - categoria, \nB - codice a barre, P - prezzo");

            char input = Console.ReadKey().KeyChar;

            switch (input)
            {

                case 'n':
                    Console.WriteLine("inserisci il nome da cercare:");
                    string nome;
                    try
                    {
                        nome = Console.ReadLine();
                    }
                    catch (Exception)
                    {
                        nome = "default";
                    }
                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (nome == lista[i].getNome()) lista[i].setAll();
                    }
                    break;

                case 'c':
                    Console.WriteLine("inserisci la categoria da cercare:");
                    string categoria;
                    try
                    {
                        categoria = Console.ReadLine();
                    }
                    catch (Exception)
                    {
                        categoria = "default";
                    }
                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (categoria == lista[i].getCategoria()) lista[i].setAll();
                    }
                    break;

                case 'b':
                    Console.WriteLine("inserisci il codice a barre da cercare:");
                    string codiceABarre;
                    try
                    {
                        codiceABarre = Console.ReadLine();
                    }
                    catch (Exception)
                    {
                        codiceABarre = "default";
                    }
                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (codiceABarre == lista[i].getCodiceABarre()) lista[i].setAll();
                    }
                    break;

                case 'p':
                    Console.WriteLine("inserisci il prezzo da cercare:");
                    double prezzo;
                    try
                    {
                        prezzo = double.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        prezzo = 0.0;
                    }
                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (prezzo == lista[i].getPrezzo()) lista[i].setAll();
                    }
                    break;

                default:
                    break;
            }

            Console.WriteLine("hai modificato l' oggetto! Premi un tasto per andare avanti");
            Console.ReadKey();


        }

        static void eliminaProdotto(List<Prodotto> lista)
        {

            Console.WriteLine("in che modo vuoi eliminare l'oggetto?? Premi il tasto corrispondente:");
            Console.WriteLine("N - nome, C - categoria, \nB - codice a barre, P - prezzo");

            char input = Console.ReadKey().KeyChar;

            switch (input)
            {

                case 'n':
                    Console.WriteLine("inserisci il nome da cercare:");
                    string nome;
                        try
                        {
                            nome = Console.ReadLine();
                        }
                        catch (Exception) 
                        {
                            nome = "default";
                        }
                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (nome == lista[i].getNome()) lista.RemoveAt(i);
                    }
                    break;

                case 'c':
                    Console.WriteLine("inserisci la categoria da cercare:");
                    string categoria;
                    try
                    {
                        categoria = Console.ReadLine();
                    }
                    catch (Exception)
                    {
                        categoria = "default";
                    }
                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (categoria == lista[i].getCategoria()) lista.RemoveAt(i);
                    }
                    break;

                case 'b':
                    Console.WriteLine("inserisci il codice a barre da cercare:");
                    string codiceABarre;
                    try
                    {
                        codiceABarre = Console.ReadLine();
                    }
                    catch (Exception)
                    {
                        codiceABarre = "default";
                    }
                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (codiceABarre == lista[i].getCodiceABarre()) lista.RemoveAt(i);
                    }
                    break;

                case 'p':
                    Console.WriteLine("inserisci il prezzo da cercare:");
                    double prezzo;
                    try
                    {
                        prezzo = double.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        prezzo = 0.0;
                    }
                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (prezzo == lista[i].getPrezzo()) lista.RemoveAt(i);
                    }
                    break;

                default:
                    break;
            }

            Console.WriteLine("hai cancellato l' oggetto! Premi un tasto per andare avanti");
            Console.ReadKey();

        }

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

                        case 1: //aggiunta vari prodotti
                            aggiuntaProdotto(listaProdotti);
                            break;

                        case 2: //eliminazione prodotti
                            eliminaProdotto(listaProdotti);
                            break;

                        case 3:
                            modificaProdotto(listaProdotti);
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
