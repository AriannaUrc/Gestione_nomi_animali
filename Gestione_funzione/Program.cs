using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1 Aggiunta nome animale
//2 Cancella primo nome trovato animale
//3 Ordinamento in ordine alfabetico (bubbleSort)
//4 Ricerca sequenziale animali
//5 Visualizza animali ripetuti (anche quante volte sono ripetuti)
//6 Modifica nome
//7 Visualizzazione tutti gli animali
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

        static void Main(string[] args)
        {
        }
    }
}
