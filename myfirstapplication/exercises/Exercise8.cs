using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstapplication;

internal class Exercise8
{
    class Convert
    {
        const int Foot = 12;
        public void ConvertFeetToInches(int feet)
        {
            int inches = feet * Foot;
            Console.WriteLine(inches);
        }
    }
    public class Program
    {
        public static void Main()
        {
            CalculateArea(5, 10);
        }
        public static void CalculateArea(int length, int width)
        {
            int area = length * width;
            Console.WriteLine("The area is: " + area);
        }

    }
}
