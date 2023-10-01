using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolstykhVS.Sprint0.Task5.Lib;

namespace Tyuiu.TolstykhVS.Sprint0.Task5.Vo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));

            Console.WriteLine("A - B = " + DataService.Substraction(15, 5));

            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));

            Console.WriteLine("A / B = " + DataService.Divison(5, 0));

            Console.ReadKey();
        }
    }
}