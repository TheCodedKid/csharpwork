using System;

namespace Midterm_Exam_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StockHolder Tim = new StockHolder(10, 2);
            Tim.FiveDayReturn("telsa");
            Tim.FiveDayReturn("apple");
            Tim.Report();
        }
    }
}
