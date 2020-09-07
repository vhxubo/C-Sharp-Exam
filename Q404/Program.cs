using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q404
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入您的年龄：");
            int age = int.Parse(Console.ReadLine());
            if (age > 23)
            {
                Console.Write("您到了结婚的年龄了~");
            }
            Console.ReadKey();
        }
    }
}
