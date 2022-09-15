using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testconsoleapp
{
    internal class Program
    {
        static void Main()
        {
            int[] tablica = new int[51];
            Wpisywanie(ref tablica);
            for (int i = 0; i < tablica.Length; i++)
            {
               Console.WriteLine(i+" "+tablica[i]);
            }
            Szukanie(tablica);

            Console.ReadKey();
        }
        static void Wpisywanie(ref int[] tablica)
        {
            Random random = new Random();
            for (int i = 0; i < tablica.Length-1; i++)
            {
                tablica[i] = random.Next(1,100);
            }
            tablica[50] = 102;
        }
        static void Szukanie(int[] tablica)
        {
            Console.Write("Jakiej liczby poszukujesz?: ");
            int szukana = int.Parse(Console.ReadLine());
            int i = 0;
            while (tablica[i] != szukana && tablica[i] != 102) ++i;
            if (tablica[i] == 102)
                Console.WriteLine("Szukany element nie występuje w tablicy");
            else
                Console.WriteLine("Liczba "+ szukana +" znajduje się na pozycji "+(i + 1)+" w tablicy, a jej indeks to [" +i+"]");

        }
    }
}
