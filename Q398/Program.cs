using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q398
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int i = 0;

            while (name != "q")
            {
                name = Console.ReadLine();
                i++;
                if (i == 5)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
