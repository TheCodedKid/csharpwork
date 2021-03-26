using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm_Exam_2
{
    class StockHolder
    {
        private int appleshares;
        private int teslashares;
        private double[] applefiveday = new double[5];
        private double[] teslafiveday = new double[5];
        public StockHolder()
        {
            appleshares = 0;
            teslashares = 0;
            for(int i = 0; i < 5; i++)
            {
                applefiveday[i] = Apple.ApplePrice();
                teslafiveday[i] = Tesla.TeslaPrice();
            }
        }
        public StockHolder(int x, int y)
        {
            appleshares = x;
            teslashares = y;
            for (int i = 0; i < 5; i++)
            {
                applefiveday[i] = Apple.ApplePrice();
                teslafiveday[i] = Tesla.TeslaPrice();
            }
        }
        public void FiveDayReturn(string type)
        {
            double temp = 0; ;
            if (type == "Tesla" | type == "telsa" | type == "t")
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write("March {0}, 2021 Current Tesla Stock: ", (i + 14));
                    temp = teslafiveday[i - 1];
                    Console.WriteLine(temp.ToString());
                }
            }
            else if (type == "Apple" | type == "apple" | type == "a")
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write("March {0}, 2021 Current Apple Stock: ", (i + 14));
                    temp = applefiveday[i - 1];
                    Console.WriteLine(temp.ToString());
                }
            }
        }

        public void AverageStock()
        {
            double applesum = 0;
            double teslasum = 0;
            for(int i = 0; i < 5; i++)
            {
                applesum += appleshares * applefiveday[i];
                teslasum += teslashares * teslafiveday[i];
            }
            Console.WriteLine("Average Apple Stock Earnings: {0}", (applesum / 5));
            Console.WriteLine("Average Tesla Stock Earnings: {0}", (teslasum / 5));
        }
        public void HighestStock()
        {
            double maxstock = 0;
            int maxindex = 0;
            for(int i = 0; i < 5; i++)
            {
                if(((appleshares * applefiveday[i]) + (teslashares * teslafiveday[i])) >= maxstock)
                {
                    maxstock = (appleshares * applefiveday[i]) + (teslashares * teslafiveday[i]);
                    maxindex = i;
                }
            }
            Console.WriteLine("The highest day of asset return is: March {0}, 2021 with a value of {1})", (maxindex + 14), maxstock);
        }
        public void LowestStock()
        {
            double minstock = Double.MaxValue;
            int minindex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (((appleshares * applefiveday[i]) + (teslashares * teslafiveday[i])) <= minstock)
                {
                    minstock = (appleshares * applefiveday[i]) + (teslashares * teslafiveday[i]);
                    minindex = i;
                }
            }
            Console.WriteLine("The lowest day of asset return is: March {0}, 2021 with a value of {1})", (minindex + 14), minstock);
        }
        public void Report()
        {
            AverageStock();
            HighestStock();
            LowestStock();
        }
    }
}
