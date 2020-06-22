using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Agac_ornek = new List<int>();
            Agac_ornek.Add(47);
            Agac_ornek.Add(25);
            Agac_ornek.Add(43);
            Agac_ornek.Add(77);
            Agac_ornek.Add(65);
            Agac_ornek.Add(68);
            Agac_ornek.Add(93);
            Agac_ornek.Add(11);
            Agac_ornek.Add(17);
            Agac_ornek.Add(44);
            Agac_ornek.Add(31);
            Agac_ornek.Add(7);

            /*******************************/
            foreach (int eleman in Agac_ornek){
                Console.WriteLine(eleman);
            }
            Console.ReadKey();
            /*******************************/
            Agac_ornek.Sort();
            foreach (int eleman in Agac_ornek)
            {
                Console.WriteLine(eleman);
            }
            Console.ReadKey();
            /********************************/
            Console.WriteLine("\nBinarySearch ve Eleman Ekleme:62yi Ekleyelim");
            int index = Agac_ornek.BinarySearch(62);
            if (index < 0)
            {
                Agac_ornek.Insert(~index, 62);
            }
            Console.WriteLine();
            foreach (int eleman in Agac_ornek)
            {
                Console.WriteLine(eleman);
            }
            /*********************************/



            Console.ReadKey();

        }
    }
}
