using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q389
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2));
            Console.ReadKey();
        }
        static int Sum(params int[] args)
        {
            int result = 0;
            foreach (int num in args)
            {
                result += num;
            }
            return result;
        }
    }
}
