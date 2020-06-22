using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nodetüründebağlilisteler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kelimeler = new string[] {"Veri","Yapıları","ve","Algoritmaları"};
            LinkedList<string> bagliliste_ornek = new LinkedList<string>(kelimeler);
            display(bagliliste_ornek, "Bağlı Listenin İlk Değerleri");
            Console.ReadKey();
            Console.WriteLine("Bağlı liste ve kelimesini içeriyor mu? {0}", bagliliste_ornek.Contains("ve"));
            Console.ReadKey();
            bagliliste_ornek.AddFirst("BTS205");
            display(bagliliste_ornek, "Bağlı Listenin Başına Eklendi");
            Console.ReadKey();
            /*İlk Nodu Son Node olarak değiştirin*/
            LinkedListNode<string> gecici = bagliliste_ornek.First;
            bagliliste_ornek.RemoveFirst();
            bagliliste_ornek.AddLast(gecici);
            display(bagliliste_ornek, "İlk Nodu Son Node olarak değiştirin");
            Console.ReadKey();
            /*son nodu yok et değerini UYGULAMALARI kelimesini ekle*/
            bagliliste_ornek.RemoveLast();
            bagliliste_ornek.AddLast("Uygulamaları");
            display(bagliliste_ornek, "Uygulamaları kelimesi eklendi");
            Console.ReadKey();
            /*Listedeki ve kelimesini bulun ve önüne arkasına kelimeler yerleştirin*/
            LinkedListNode<string> aktif = bagliliste_ornek.FindLast("ve");
            bagliliste_ornek.AddAfter(aktif, "türdeki");
            bagliliste_ornek.AddBefore(aktif, "farklı");
            display(bagliliste_ornek, "Listedeki ve kelimesinin önüne ve arkasına eklenen kelimeler");
            Console.ReadKey();
            bagliliste_ornek.AddAfter(aktif, "türdeki");
            /*Ve kelimesini içeren nodu kaldırın*/
            /*İlk nodu son nod olacak şekilde değiştirin*/
            /* algoritmalarını find metoduyla bulun. önüne ve sonuna kelime ekleyin*/
            /*Bağlı listeyi diziye kopyalayın*/
            /*Dizideki bağlı listeyi aynı sırada saklayan veriyapısına kopyalayın ve yazdırın*/


            Console.ReadKey();


        }
        public static void display(LinkedList<string>kelimeler,string test)
        {
            Console.WriteLine(test);
            foreach(string kelime in kelimeler)
            {
                Console.Write(kelime + " "); 
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        

    }
}
