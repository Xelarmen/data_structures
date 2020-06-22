using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace kuyruk_veri_yapısı
{
    class Program
    {
        static void DegerleriYaz(Queue sira)
        {
            Object obj = new object();
            Queue yenisira = (Queue)sira.Clone();
            if(yenisira.Count != 0)
            {
                while (yenisira.Count > 0)
                {
                    obj = yenisira.Dequeue();
                    Console.WriteLine("\t {0}", obj.ToString());

                }
            }
            else Console.WriteLine("Yığın boş...");

        }
        static void Main(string[] args)
        {
            Queue kuyrukozel = new Queue();
            kuyrukozel.Enqueue("Oğuz");
            kuyrukozel.Enqueue("Ali");
            kuyrukozel.Enqueue("İlyas");
            kuyrukozel.Enqueue("Aytekin");
            kuyrukozel.Enqueue("Hakan");
            Console.WriteLine("\nEleman Sayisi : {0}", kuyrukozel.Count);
            Console.WriteLine("\nKuyruktaki elemanları ekrana yazdırıyoruz...");
            DegerleriYaz(kuyrukozel);
            string eleman = (string)kuyrukozel.Peek();
            Console.WriteLine("\nEleman Sayisi : {0}", eleman.ToString());
             eleman = (string)kuyrukozel.Dequeue();
            Console.WriteLine("\nEleman Sayisi : {0}", eleman.ToString());
            Console.WriteLine(kuyrukozel.Equals("Ali"));



            Console.ReadKey();
        }



    }
}
