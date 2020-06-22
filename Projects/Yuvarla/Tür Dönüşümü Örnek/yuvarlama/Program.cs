using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * Abdulkadir KAYA
 * 19-701-806   
 * akadirkaya34@gmail.com
 * www.abdulkadirkaya.com.tr
 * 
 */
namespace yuvarlama
{
    class Program
    {
        static Int32 yuvarla(double a)
        {
            return Convert.ToInt32(a); ;//tür dönüşümü en yakın değere yuvarlar
        }
        static void Main(string[] args)
        {
            double sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(yuvarla(sayi));
            
            Console.ReadKey();
        }
    }
}
