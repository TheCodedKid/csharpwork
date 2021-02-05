using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int answer = 1;
            int on = n;
            while(n >= 1)
            {
                answer = answer * n;
                n--;
            }
            Console.Write("\n The value of {0} factorial is {1}\n ", on, answer);
        }
    }
}