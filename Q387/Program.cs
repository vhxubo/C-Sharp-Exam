using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q387
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            switch (day){
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("工作日");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("休息日");
                    break;
                default:
                    Console.WriteLine("请输入1-7的数字");
                    break;
            }
            Console.ReadKey();
        }
    }
}
