using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q385
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            if (age >= 18)
            {
                Console.WriteLine("成年");
            }
            else if(age < 18)
            {
                Console.WriteLine("未成年");
            }
            Console.ReadKey();
        }
    }
}
