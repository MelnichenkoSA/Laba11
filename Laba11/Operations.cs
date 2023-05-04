using System;
using System.Collections.Generic;
using System.Text;

namespace Laba11
{
    class Operations
    {
        delegate double Message(double a);
        Message[] messages = { Plus, Minus, Umnozh, Podelit };
        static double Plus(double a)
        {
            return a + a;
        }
        static double Minus(double a)
        {
            return a - 2;
        }
        static double Umnozh(double a)
        {
            return a * a;
        }
        static double Podelit(double a)
        {
            return a / 2;
        }
        public void Print(double a)
        {
            foreach (var item in messages)
            {
                a = item(a);
                Console.WriteLine(a);
            }
        }
    }
}
