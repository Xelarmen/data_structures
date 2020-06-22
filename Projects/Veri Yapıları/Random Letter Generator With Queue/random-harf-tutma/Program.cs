using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace random_harf_tutma
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue kuyruk = new Queue();
            Random rastgele = new Random();
            string sb = "";
            for (int j = 0 ; j< 15 ; j++)
            {
                for(int i = 0; i<4; i++)
                {
                    int ascii = rastgele.Next(65, 91);
                    char karakter = Convert.ToChar(ascii);
                    sb = sb + karakter;
                }
                kuyruk.Enqueue(sb);
                sb = "";
                        /*
                        string ali = Convert.ToChar((rastgele.Next(65, 91)) + Convert.ToChar((rastgele.Next(65, 91)) + Convert.ToChar((rastgele.Next(65, 91)) + Convert.ToChar((rastgele.Next(65, 91));
                        Console.WriteLine(ali + "\n");
                        */  
            }
            yazdir(kuyruk);
            String[] diziörnek = new string[kuyruk.Count];
            kuyruk.CopyTo(diziörnek, 0);

            Console.WriteLine("Dizideki Örnekler Yazdırılıyor \n");
            for(int x =0; x< diziörnek.Length; x++)
            {
                Console.WriteLine(diziörnek[x]);
            }
            Console.ReadKey();

        }
        public static void yazdir(Queue yiginim)
        {
            Object obj = new Object();
            Queue yeniyigin = (Queue)yiginim.Clone();
            if (yiginim.Count != 0)
            {
                while (yeniyigin.Count > 0)
                {
                    obj = yeniyigin.Dequeue();
                    Console.WriteLine("\t {0}", obj.ToString());
                }
            }
            else Console.WriteLine("Yığın boş...");
        }
    }
}
