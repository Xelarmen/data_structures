using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 9, 4, 6, 7, 3, 8, 1 };
            QuickSort(dizi,0,6);
            for(int i = 0; i< dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.ReadLine();
        }
        public static void QuickSort(int[] dizi, int baslangic, int bitis)
        {
            int i;
            if(baslangic < bitis)
            {
                i = Parca(dizi, baslangic, bitis);
                QuickSort(dizi, baslangic, i - 1);
                QuickSort(dizi, i + 1, bitis);
            }
        }
        public static int Parca(int[] A, int baslangic, int bitis)
        {
            int gecici;
            int x = A[bitis];
            int i = baslangic - 1;
            for(int j = baslangic; j<= bitis-1;j++)
            {
                if(A[j] <= x)
                {
                    i++;
                    gecici = A[i];
                    A[i] = A[j];
                    A[j] = gecici;
                }
            }
            gecici = A[i + 1];
            A[i + 1] = A[bitis];
            A[bitis] = gecici;
            return i + 1;
        }
    
    
    
    }
}
