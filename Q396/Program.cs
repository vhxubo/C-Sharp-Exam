using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q396
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (true)
            {
                x += 1;
                if (x == 3)
                {
                    break;
                }
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
