using System;

namespace First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var numCheck = 4; //this is the variable that can be changed to check

            if (numCheck % 2 == 0)
            {
                Console.WriteLine("The integer is even");
            }
            else
            {
                Console.WriteLine("The integer is odd");
            }
        }
        //by using var as the type of the variable, the system implicitly assumes the type of numCheck based on what the initial cast determined by what is inputted, in this case being an integer
    }
}
