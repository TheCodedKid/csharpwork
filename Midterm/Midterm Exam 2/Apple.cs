using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm_Exam_2
{
    class Apple
    {
        public static double ApplePrice()
        {
            Random rnd = new Random();
            return rnd.Next(110, 131);
        }
    }
}
