using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//0 uscita dal menu ok.
//1 Aggiunta nome animale ok.
//2 Cancella primo nome trovato animale ok.
//3 Ordinamento in ordine alfabetico (bubbleSort)
//4 Ricerca sequenziale animali ok.
//5 Visualizza animali ripetuti (anche quante volte sono ripetuti)
//6 Modifica nome
//7 Visualizzazione tutti gli animali ok.
//8 Ricerca nomi più lunghi e più corti + visualizzazione
//9 Cancellazione di tutti i nomi ripetuti ok.


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

        static void BubbleSort(string[] nomi, ref int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght-i-1; j++)
                {
                    if (nomi[j][0] > nomi[j+1][0])
                    {
                        (nomi[j], nomi[j+1]) = (nomi[j+1], nomi[j]);
                    }
                }
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

        static bool Cancella(string[] nomi, ref int lenght, string ricerca)
        {
            int pos;
            pos = Ricerca(nomi, ref lenght, ricerca);
            if (pos == -1)
            {
                return false;  
            }
            else
            {
                for (int i = pos; i < lenght; i++)
                {
                    nomi[i] = nomi[i + 1];
                }
                lenght--;
                return true;
            }
        }

        static bool CancellaAll(string[] nomi, ref int lenght, string ricerca)
        {
            int pos=0;
            pos = Ricerca(nomi, ref lenght, ricerca);
            if (pos == -1)
            {
                return false;
            }
            else
            {
                while (pos != -1)
                {
                    pos = Ricerca(nomi, ref lenght, ricerca);
                    if (pos == -1)
                    {
                        return true;
                    }
                    else
                    {
                        for (int i = pos; i < lenght; i++)
                        {
                            nomi[i] = nomi[i + 1];
                        }
                        lenght--;
                    }
                }
            }
            return true;

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
                        Console.WriteLine("Inserire elemento da cancellare");
                        ricerca = Console.ReadLine();
                        if(Cancella(nomi, ref lenght, ricerca))
                        {
                            Console.WriteLine("L'elemento è stato cancellato");
                        }
                        else
                        {
                            Console.WriteLine("Non è stato trovato un elemento con tale nome");
                        }
                        break;

                    case 3:
                        BubbleSort(nomi, ref lenght);
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
                        Console.WriteLine("Inserire elemento da cancellare");
                        ricerca = Console.ReadLine();
                        if (CancellaAll(nomi, ref lenght, ricerca))
                        {
                            Console.WriteLine("Tutti gli elementi sono stati cancellati");
                        }
                        else
                        {
                            Console.WriteLine("Non è stato trovato un elemento con tale nome");
                        }
                        break;

                    default:
                        break;

                }
            }
            
        }
    }
}
