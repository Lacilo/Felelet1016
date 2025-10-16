using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Felelet1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] tomb = new int[20];
            int ossz = 0;
            double atl = 0;
            bool oszthato = false;
            int index = 0;
            int elsKaSzam = 0;
            bool nTalalt = true;
            int kIndex = 0;
            int kSzam = 0;
            bool kTalalt = false;
            int szIndex = 0;
            int hEsNyolcvanK = 0;
            int absIndex = 0;
            List<int> pSzam = new List<int> { };
            int min = tomb[0];
            int max = tomb[0];
            int maxMinIndex = 0;
            bool talaltMax = false;

            for (int i = 0; i < 20; i++)
            {
                tomb[i] = rnd.Next(50, 100);
                ossz = ossz + tomb[i];
            }

            foreach (var szam in tomb)
            {
                Console.WriteLine(szam);
            }

            atl = ossz / 20.0;

            Console.WriteLine("A számok összege - " + ossz);
            Console.WriteLine("A számok átlaga - " + atl);

            while (index < tomb.Length && !oszthato)
            {
                if (tomb[index] % 11 == 0)
                {
                    oszthato = true;
                }               

                index++;
            }            

            while (kIndex < tomb.Length && nTalalt)
            {
                if (tomb[kIndex] < atl)
                {
                    elsKaSzam = kIndex;
                    nTalalt = false;
                }

                kIndex++;
            }

            Console.WriteLine(oszthato);
            Console.WriteLine("Az első szám indexe ami kisebb az átlagnál - " + elsKaSzam + "Ez a szám a " + tomb[elsKaSzam]);

            Console.Write("Adja meg a keresendő számot --> ");
            kSzam = int.Parse(Console.ReadLine());            

            while (szIndex < tomb.Length && !kTalalt)
            {
                if (tomb[szIndex] == kSzam)
                {
                    kTalalt = true;
                }

                szIndex++;
            }

            if (kTalalt)
            {
                Console.WriteLine("Van " + kSzam + " szám a listában");
            }
            else
            {
                Console.WriteLine("Nincs " + kSzam + " szám a listában");
            }            

            foreach (var szam in tomb)
            {
                if (szam < 80 && szam > 70)
                {
                    hEsNyolcvanK++;
                }
            }

            Console.WriteLine("70-80 között - " + hEsNyolcvanK);            

            foreach (var szam in tomb)
            {
                if (szam % 2 == 0)
                {
                    pSzam.Add(szam);
                }
            }

            foreach (var szam in pSzam)
            {
                Console.WriteLine(szam);
            }            

            while (absIndex < tomb.Length - 1)
            {
                Console.Write(Math.Abs(tomb[absIndex] - tomb[absIndex + 1]) + ", ");

                absIndex++;
            }            

            foreach (var szam in tomb)
            {
                if (szam < min)
                {
                    min = szam;
                }

                if (szam > max)
                {
                    max = szam;
                }
            }

            Console.WriteLine("\n" + "A lista terjedelme - " + (max - min));

            List<int> minIndexek = new List<int> { };
            List<int> maxIndexek = new List<int> { };

            while (maxMinIndex < tomb.Length)
            {
                if (tomb[maxMinIndex] == max)
                {
                    maxIndexek.Add(max);
                }
                if (tomb[maxMinIndex] == min)
                {
                    minIndexek.Add(min);
                }

                maxMinIndex++;
            }

            Console.Write("Minimumok indexei - ");

            foreach (var szam in minIndexek)
            {
                Console.Write(szam + ", ");
            }

            Console.Write("\n" + "Maximumok indexei - ");

            foreach (var szam in maxIndexek)
            {
                Console.Write(szam + ", ");
            }

            // ---------------------------------------------------

            string[] szoTomb = new string[20];



        }
    }
}
