using System;

namespace First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            double numCheck = 4.2; //this is the variable that can be changed to check

            if(numCheck % 2 == 0)
            {
                Console.WriteLine("The integer is even");
            }
            else
            {
                Console.WriteLine("The integer is odd");
            }
        }
        //changing the numCheck to a double does allow it to work, but the issue arises in decimals, as the given mod check does not support the possiblilty of a decimal place. 
    }
}
