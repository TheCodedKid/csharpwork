using System;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int max;
            int min;

            Console.WriteLine("Enter the min and max value for the 3 different GCD methods.");
            Console.Write("Max Value: ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.Write("Min Value: ");
            min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Brute Force Method: ");
            Console.WriteLine(brute(max,min,min));

            Console.Write("Euclid Method: ");
            Console.WriteLine(euclid(max,min));

            Console.Write("Dijkstra's Method: ");
            Console.WriteLine(dijkstra(max,min));
        }
        static int brute(int m, int n, int g)
        {
            if (((m % g) == 0) && ((n % g) == 0))
                return g;
            else
                return brute(m, n, g - 1);
        }
        static int euclid(int m, int n)
        {
            if ((m % n) == 0)
                return n;
            else
                return euclid(n, m % n);
        }
        static int dijkstra(int m, int n)
        {
            if ((m % n) == 0)
                return n;

            else
                return dijkstra(n, m % n);
        }
    }
}
