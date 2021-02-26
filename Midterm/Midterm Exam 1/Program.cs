using System;

namespace Midterm_Exam_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(testLoop(10));
            Console.WriteLine(testRecursive(10, 0, 10));
        }
        static double testLoop(int n)
        {
            var rand = new Random();
            int randomnum = 0;
            double sum = 0;
            for(int i = 0; i < n; i++)
            {
                randomnum = rand.Next(1000, 5001);
                Console.WriteLine(randomnum);
                sum = sum + randomnum;
            }
            Console.Write("The sum is: ");
            Console.WriteLine(sum);
            Console.Write("The mean is: ");
            return (sum/n);
        }
            static double testRecursive(int n, double sum, int count)
            {
                Random Rand = new Random();
                double num = Rand.Next(100, 1001);
                sum = sum + num;
                Console.WriteLine("num = {0}", num);
            if (n == 0)
            {
                Console.WriteLine("The mean is:");
                return (sum/count);
            }
            else
                return testRecursive(n - 1, sum, count);
            }
        }
    }
