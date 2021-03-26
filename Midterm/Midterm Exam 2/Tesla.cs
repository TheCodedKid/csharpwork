using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm_Exam_2
{
    class Tesla
    {
        public static double TeslaPrice()
        {
            Random rnd = new Random();
            return rnd.Next(630, 651);
        }
    }
}
