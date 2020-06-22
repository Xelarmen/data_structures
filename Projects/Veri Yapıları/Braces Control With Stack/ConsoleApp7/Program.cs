using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack yigin = new Stack();
            char harf = ' '; char cikan = ' ';
            while(harf !='ç')
            {
                harf = Convert.ToChar(Console.ReadLine());
                if(harf =='(' || harf == '[' || harf == '{')
                {
                    yigin.Push(harf);
                }
                else if(harf == ')' || harf == '}' || harf == ']'){
                    if (yigin.Count > 0)
                    {
                        cikan = (char)yigin.Pop();
                        Console.WriteLine("\n Yığındaki eleman Sayısı {0}", yigin.Count);
                    }
                    else
                        Console.WriteLine("Yığında Eleman Yok");

                }
                if(harf ==')' && cikan != '(')
                {
                    Console.WriteLine("Yanlış parantez");
                }
                else if (harf == ']' && cikan != '[')
                {
                    Console.WriteLine("Yanlış parantez");
                }
                else if (harf == '}' && cikan != '{')
                {
                    Console.WriteLine("Yanlış parantez");
                }

            }


        }
    }
}
