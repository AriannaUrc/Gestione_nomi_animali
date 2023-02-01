using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//0 uscita dal menu ok.
//1 Aggiunta nome animale ok.
//2 Cancella primo nome trovato animale
//3 Ordinamento in ordine alfabetico (bubbleSort)
//4 Ricerca sequenziale animali
//5 Visualizza animali ripetuti (anche quante volte sono ripetuti)
//6 Modifica nome
//7 Visualizzazione tutti gli animali ok.
//8 Ricerca nomi più lunghi e più corti + visualizzazione
//9 Cancellazione di tutti i nomi ripetuti


namespace Gestione_funzione
{
    internal class Program
    {
        static void Aggiunta(string[] nomi, ref int lenght)
        {
            nomi[lenght]=Console.ReadLine();
            lenght++;
        }


        static void Visualizza(string[] nomi, ref int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine(nomi[i]);
            }
        }

        static int Ricerca(string[] nomi, ref int lenght, string ricerca)
        {
            int pos=-1;
            for (int i = 0; i < lenght; i++)
            {
                if (nomi[i] == ricerca)
                {
                    pos = i;
                    break;
                }
            }

            return pos;
        }

        static void Main(string[] args)
        {
            string[] nomi = new string[100];
            string ricerca;
            int scelta, lenght=0, pos;
            bool continua=true;
            

            while (continua)
            {
                scelta = int.Parse(Console.ReadLine());

                switch (scelta)
                {
                    case 0:
                        continua=false;
                        break;

                    case 1:
                        Console.WriteLine("Inserisci il nome dell'animale");
                        Aggiunta(nomi, ref lenght);
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        Console.WriteLine("Inserire elemento da ricercare");
                        ricerca = Console.ReadLine();
                        pos=Ricerca(nomi, ref lenght, ricerca);
                        if (pos == -1)
                        {
                            Console.WriteLine("Elemento non trovato");
                        }
                        else
                        {
                            Console.WriteLine("L'indice dell'elemento è: "+pos);
                        }
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        Visualizza(nomi, ref lenght);
                        break;

                    case 8:
                        break;

                    case 9:
                        break;

                }
            }
            
        }
    }
}
