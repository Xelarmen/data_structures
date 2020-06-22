using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merge_sort
{
    class Program
    {
        static void Main(string[] args)
        {/*********ÇALIŞMIYOR İNTERNETTEN YENİ ÖRNEK BUL!**********/
            int[] dizi = { 6, 3, 5, 1, 8, 2, 4, 7 };
            mergesort(dizi,0, 7);
            for(int i =0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.ReadKey();
        }
        public static void mergesort(int[] arr , int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                mergesort(arr, start, end);
                mergesort(arr, mid + 1, end);
                mergesArray(arr, start, mid, end);
            }

        }
        public static void mergesArray(int[] arr, int start, int mid, int end)
        {
            int[] temp = new int[end - start + 1];
            int i = start, j = mid + 1, k = 0;
            while (i <= mid && j <= end)
            {
                if (arr[i] < arr[j])
                {
                    temp[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    k++;
                    j++;
                }
            }
            while (i <= mid)
            {
                temp[k] = arr[i];
                k++;
                i++;
            } 
            
            while (j <= end)
            {
                temp[k] = arr[j];
                k++;
                j++;
            }
            k = 0;
            i = start;
            while(k < temp.Length && i <= end)
            {
                arr[i] = temp[k];
                k++;
                i++;
            }
        }
    }
}
