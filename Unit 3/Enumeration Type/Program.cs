using System;
namespace Date
{
    enum Months { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

    class Date
    {
        int year;
        int month;
        int day;
        public Date()
        {
            year = 2021;
            month = (int)Months.Sep;
            day = 1;
        }
        public Date(int y, int m, int d)
        {
            set_date(y, m, d);
        }
        public void set_date(int y, int m, int d)
        {
            year = y;
            month = m;
            day = d;
        }
        public Date get_date()
        {
            return this;
        }
        public void display_date()
        {
            Console.WriteLine("\n {0}, {1}, {2}\n", year, month, day);
        }
    }
}