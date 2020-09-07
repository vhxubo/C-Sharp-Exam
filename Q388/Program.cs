using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q388
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = 80;
            if (score > 90)
            {
                Console.WriteLine("变形金刚");
            }
            else if (score > 80)
            {
                Console.WriteLine("芭比娃娃");
            }
            else if (score > 70)
            {
                Console.WriteLine("肥皂");
            }
            Console.ReadKey();
        }
    }
}
