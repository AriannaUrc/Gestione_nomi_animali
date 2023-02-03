using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//0 uscita dal menu ok.
//1 Aggiunta nome animale ok.
//2 Cancella primo nome trovato animale ok.
//3 Ordinamento in ordine alfabetico (bubbleSort) ok.
//4 Ricerca sequenziale animali ok.
//5 Visualizza animali ripetuti (anche quante volte sono ripetuti) ok.
//6 Modifica nome ok.
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

        static void Modifica(string[] nomi, int lenght, int pos, string nuovoNome)
        {
            nomi[pos]=nuovoNome;
        }


        static void Visualizza(string[] nomi, ref int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine(nomi[i]);
            }
        }

        static void VisualizzaRip(string[] nomi, int lenght)
        {
            int lenght2 = lenght, templenght2, rip;
            string[] nomi2 = new string[lenght2];
            for (int j = 0; j < lenght; j++)
            {
                nomi2[j] = nomi[j];
            }

            for (int i = 0; i < lenght; i++)
            {
                templenght2=lenght2;
                CancellaAll(ref nomi2, ref lenght2, nomi[i]);
                for (int j = 0; j < lenght2; j++)
                {
                    Console.WriteLine(nomi2[j]);
                }
                rip = templenght2 - lenght2;
                if (rip > 1)
                {
                    Console.WriteLine("la parola " + nomi[i] + " è stata ripetuta " + rip + " volte");
                }
            }

        }

        static void MaxMin(string[] nomi, int lenght)
        {
            int max=0, min=0, indexMax=0, indexMin=0;
            for (int i = 0; i < lenght; i++)
            {
                if (max < nomi[i].Length)
                {
                    max= nomi[i].Length;
                    indexMax= i;
                }

                if (min > nomi[i].Length)
                {
                    min = nomi[i].Length;
                    indexMin= i;
                }

            }
            Console.WriteLine("la parola più lunga è: " + nomi[indexMax]);
            Console.WriteLine("la parola più corta è: " + nomi[indexMin]);
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

        static bool CancellaAll(ref string[] animali, ref int lenght, string ricerca)
        {
            int pos=0;
            pos = Ricerca(animali, ref lenght, ricerca);
            if (pos == -1)
            {
                return false;
            }
            else
            {
                while (pos != -1)
                {
                    pos = Ricerca(animali, ref lenght, ricerca);
                    if (pos == -1)
                    {
                        return true;
                    }
                    else
                    {
                        for (int i = pos; i < lenght-1; i++)
                        {
                            animali[i] = animali[i + 1];
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
            string ricerca, nuovoNome;
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
                        VisualizzaRip(nomi, lenght);
                        break;

                    case 6:
                        Console.WriteLine("Inserire indice dell'elemento da modificare: ");
                        pos =int.Parse(Console.ReadLine());
                        Console.WriteLine("Inserire il nuovo elemento: ");
                        nuovoNome = Console.ReadLine();
                        Modifica(nomi, lenght, pos, nuovoNome);
                        break;

                    case 7:
                        Visualizza(nomi, ref lenght);
                        break;

                    case 8:
                        MaxMin(nomi, lenght);
                        break;

                    case 9:
                        Console.WriteLine("Inserire elemento da cancellare");
                        ricerca = Console.ReadLine();
                        if (CancellaAll(ref nomi, ref lenght, ricerca))
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
