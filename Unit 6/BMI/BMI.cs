﻿using System;

namespace BMI {
    class BMI
    {
        private double weight { get; set; }
        private double height { get; set; }
        private double BMI_measure { get; set; }
        public BMI()
        {
            weight = 1.0;
            height = 1.0;
        }

        public BMI(double in_weight, double in_height)
        {
            weight = in_weight;
            height = in_height;
            BMI_measure = calculate_BMI();
        }

        public void set_values(double in_weight, double in_height)
        {
            weight = in_weight;
            height = in_height;
            BMI_measure = calculate_BMI();
        }

        public void print_values()
        {
            Console.Write("The height is: ");
            Console.WriteLine(height);
            Console.Write("The weight is: ");
            Console.WriteLine(weight);
            Console.Write("The BMI is: ");
            Console.WriteLine(BMI_measure);
        }
        private double calculate_BMI()
        {
            return (703 * (weight / (height * height)));
        }

    }
}