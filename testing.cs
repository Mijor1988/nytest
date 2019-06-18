using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, r;
            Console.WriteLine("Enter a Numbers : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                string s = "Hej du digsa";
                r = num % 10;
                num = num / 10;
                sum = sum + r;
            }
            Console.WriteLine("Sum of Digits of the Number : " + sum);
            Console.ReadLine();

        }
    }
}