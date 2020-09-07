using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q405
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int num = 1; num <= 5; num++)
            {
                sum += num;
            }
            Console.Write(sum);
            Console.ReadKey();
        }
    }
}
