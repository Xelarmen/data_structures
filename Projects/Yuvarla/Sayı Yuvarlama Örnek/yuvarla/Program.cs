using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yuvarla
{
    class Program
    {
        public static string Yuvarla(double sayi)
        {
            string s = sayi.ToString("#.#########", System.Globalization.CultureInfo.InvariantCulture);
            int x = Int32.Parse(s.Substring(s.IndexOf(".") + 1));
            if (x < 5)
            {
                return "aşağı";
            }
        }

        static void Main(string[] args)
        {
            double a = Console.Read();

            Yuvarla(a);
        }





    }
}
