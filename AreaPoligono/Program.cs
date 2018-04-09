using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPoligono
{
    class Program
    {
        static void Main0(string[] args)
        {
            // allocazione dati di INPUT
            int lato;
            int apotema;
            int numLati;

            // allocazione dati di OUTPUT
            int area;

            // inizializzazione dati di INPUT
            lato = LeggiNumero("lato");
            apotema = LeggiNumeroB("apotema");
            numLati = LeggiNumeroB("numero lati");


            // calcolo...
            area = lato * numLati * apotema / 2;

            // OUTPUT risultato del calcolo
            Console.WriteLine("L'area del poligono di {0} lati, lato {1} ed apotema {2} è {3}", numLati, lato, apotema, area);            

        }
        static void Main(string[] args)
        {
            // allocazione dati di INPUT
            int lato;
            int apotema;
            int numLati;

            // allocazione dati di OUTPUT
            int area;

            bool finito = false;
            do
            {
                Console.WriteLine("\r\n\r\n=== Calcolo dell'area del poligono regolare ===" +
                    "\r\n   (per terminare inserisci il valore 0)\r\n"); //  valore "tappo"

                lato = LeggiNumeroB("lato");
                if ( lato > 0 )
                {
                    apotema = LeggiNumeroB("apotema");
                    numLati = LeggiNumeroB("numero lati");

                    // calcolo...
                    area = lato * numLati * apotema / 2;

                    // OUTPUT risultato del calcolo
                    Console.WriteLine("L'area del poligono di {0} lati, lato {1} ed apotema {2} è {3}", numLati, lato, apotema, area);
                }
                else
                {
                    finito = true;
                }

            } while (!finito);

        }

        static int LeggiNumero1Cifra(string nomeValore)
        {
            Console.WriteLine("Inserire il valore per {0}:", nomeValore);

            // alloca una variabile per contenere l'input
            int valoreLetto;

            // leggi il codice del carattere e trasformalo in numero
            valoreLetto =  Console.Read() - '0';
            // salta l'INVIO
            Console.Read();
            Console.Read();

            return valoreLetto;
        }

        static int LeggiNumero2Cifre(string nomeValore)
        {
            Console.WriteLine("Inserire il valore a due cifre per {0}:", nomeValore);

            // alloca una variabile per contenere l'input
            int valoreLetto;

            // leggi il codice del 1o carattere e trasformalo in numero
            valoreLetto = Console.Read() - '0';
            // leggi il codice del 2o carattere , moltiplica il precedente valore per 10 e 
            // sommalo al nuovo valore letto
            valoreLetto = valoreLetto * 10 + Console.Read() - '0';
            // salta l'INVIO
            Console.Read();
            Console.Read();

            return valoreLetto;
        }

        static int LeggiNumero(string nomeValore)
        {
            Console.WriteLine("Inserire il valore per {0}:", nomeValore);

            // alloca una variabile per contenere l'input
            int valoreLetto;
            int numero = 0;

            do
            {
                // leggi il codice del carattere inserito
                valoreLetto = Console.Read();

                if (!Char.IsDigit((char)valoreLetto))
                {
                    break;
                }
                // trasformalo in numero
                valoreLetto = valoreLetto - '0';
                // moltiplica il numero accumulato precedentemente per 10 e 
                // sommalo al nuovo valore letto
                numero = numero * 10 + valoreLetto;

            } while (true);

            // salta l'INVIO
            Console.Read();

            return numero;
        }

        static int LeggiNumeroB(string nomeValore)
        {
            Console.WriteLine("Inserire il valore per {0}:", nomeValore);

            // alloca una variabile per contenere l'input
            int valoreLetto;
            int numero = 0;

            while (Char.IsDigit((char)(valoreLetto = Console.Read())))
            {
                // moltiplica il numero accumulato precedentemente per 10 e 
                // sommalo al nuovo valore letto trasformato in numero
                numero = numero * 10 + valoreLetto - '0';
            };

            // salta l'INVIO
            Console.Read();

            return numero;
        }
    }
}
