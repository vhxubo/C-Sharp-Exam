using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q408
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;
            while (num <= 100)
            {
                if (num % 7 == 0)
                {
                    num++;
                    continue;
                }
                sum += num;
                num++;
            }
            Console.Write(sum);
            Console.ReadKey();
        }
    }
}
