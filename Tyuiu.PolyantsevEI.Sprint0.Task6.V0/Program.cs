using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PolyantsevEI.Sprint0.Task6.V0.Lib;

namespace Tyuiu.PolyantsevEI.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NumsArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива = "+ DataService.AdditionArray(NumsArray));
            Console.WriteLine("Разность элементов массива = " + DataService.SubstructionArray(NumsArray));
            Console.WriteLine("Поизведение элементов массива = " + DataService.MultiplicationArray(NumsArray));
            Console.ReadKey();
        }
    }
}
