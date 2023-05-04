using System;

namespace Laba11
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations op = new Operations();
            Console.WriteLine("Введите число");
            double a = double.Parse(Console.ReadLine());
            op.Print(a);
        }
    }
}
