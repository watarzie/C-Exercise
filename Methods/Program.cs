using System;
using System.Collections.Generic;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;
            var result = Add(ref number1, number2);

            Console.WriteLine(result);
            Console.WriteLine(Add2(1, 2, 3, 4, 5, 6));
            Console.WriteLine(number1);
            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,7));
            Console.ReadLine();


        }
        static int Add(ref int number1, int number2)
        {
            number1 = 30;
            var result = number1 + number2;
            return result;
        }
        static int Add2(params int[] numbers)
        {
            return numbers.Sum();
        }
        static int Multiply(int a,int b)
        {
            return a * b;
        }
        static int Multiply(int a,int b,int c)
        {
            return a * b * c;
        }
    }
}
