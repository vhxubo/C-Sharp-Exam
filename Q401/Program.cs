using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q401
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;
            do
            {
                sum += num;
                num++;
            } while (num <= 100);
            Console.Write(sum);
            Console.ReadKey();
        }
    }
}
