using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            BMI Bob_BMI = new BMI();
            Bob_BMI.set_values(45, 5.2);
            BMI Alice_BMI = new BMI(35, 6.2);
            Bob_BMI.print_values();
            Alice_BMI.print_values();
        }
    }

}