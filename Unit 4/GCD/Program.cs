using System;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
