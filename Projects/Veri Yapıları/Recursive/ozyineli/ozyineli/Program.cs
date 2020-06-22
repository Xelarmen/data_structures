using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ozyineli
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int fact(int n)
        {
            int x, y;
            if (n == 0) return 1;
            x = n - 1;
            y = fact(x);
            return n * y;

        }
       
        public static int fibo(int n)
        {
            int x, y;
            if (n <= 1) return n;
            x = fibo(n - 1);
            y = fibo(n - 2);
            return (x + y);
        }
        }
    }

