using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selectionsort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 9, 4, 6, 7, 3, 8, 1 };
            secmelisiralama(dizi);
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.ReadLine();
        }
        public static int[] secmelisiralama(int[] dizi)
        {
            int n = dizi.Length;
            int yedek;
            int minindex;
            for(int i = 0; i < n - 1; i++)
            {
                minindex = i;
                for(int j = i; j < n; j++)
                {
                    if (dizi[j] < dizi[minindex]) minindex = j;
                }
                yedek = dizi[i];
                dizi[i] = dizi[minindex];
                dizi[minindex] = yedek;

            }
            return dizi;
        }
    }
}
