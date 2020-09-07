using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q402
{
    class Program
    {
        static void Main(string[] args)
        {
            string food = Console.ReadLine();
            switch (food)
            {
                case "黄瓜":
                    Console.Write("5元");
                    break;
                case "香蕉":
                    Console.Write("8元");
                    break;
                case "苦瓜":
                    Console.Write("10元");
                    break;
                case "苹果":
                    Console.Write("12元");
                    break;
                default:
                    Console.Write("商店中不存在此商品!");
                    break;

            }
            Console.ReadKey();
        }
    }
}
