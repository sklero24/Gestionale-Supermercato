using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestioneProdottiCassa
{
    internal class Prodotto
    {

        private string nome;
        private string categoria;
        private string descrizione;
        private string codiceABarre;
        private double prezzo;
        private DateTime dataAggiunta;

        public Prodotto(string nome, string categoria, string descrizione, double prezzo, string codiceABarre)
        {

            this.nome = nome;
            this.categoria = categoria;
            this.descrizione = descrizione;
            this.codiceABarre = codiceABarre;
            this.prezzo = prezzo;
            this.dataAggiunta = DateTime.Now;

        }

        public string getNome()
        {
            return this.nome;
        }

        public string getCategoria()
        {
            return this.categoria;
        }

        public string getDescrizione()
        {
            return this.descrizione;
        }

        public DateTime getDataAggiunta()
        {
            return this.dataAggiunta;
        }
        public string getCodiceABarre()
        {
            return this.codiceABarre;
        }

        public void setAll()
        {
            try
            {
                Console.WriteLine("\n inserisci il nuovo nome:");
                this.nome = Console.ReadLine();
                Console.WriteLine("\n inserisci categoria:");
                this.categoria = Console.ReadLine();
                Console.WriteLine("\n inserisci descrizione:");
                this.descrizione = Console.ReadLine();
                Console.WriteLine("\n scannerizza codice a barre:");
                this.codiceABarre = Console.ReadLine();
                this.dataAggiunta = DateTime.Now;

            }
            catch (Exception)
            {
                this.nome = "default";
                this.categoria = "default";
                this.descrizione = "default";
                this.codiceABarre = "default";
                this.dataAggiunta = DateTime.Now;
            }
        }

        public string toString()
        {
            return "Nome: " + this.nome + "\n" + "Categoria: " + this.categoria + "\n" + "Descrizione: " + this.descrizione + "\n" + "Codice a Barre prodotto: " + this.codiceABarre + "\n" + "Prezzo prodotto: " + this.prezzo + " EURO\n" + "Data e ora aggiunta: " + this.dataAggiunta;
        }

    }
}
