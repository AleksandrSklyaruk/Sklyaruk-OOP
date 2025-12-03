using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLabGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b:");
            double b = Convert.ToDouble(Console.ReadLine());
            double sum = a + b;
            Console.WriteLine($"Сумма чисел: {sum}");
            Console.ReadLine();
        }
    }
}
