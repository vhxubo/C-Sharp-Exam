using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q391
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int num = 1; num <= 100; num++)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
