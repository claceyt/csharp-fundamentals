using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstapplication;

internal class Exercise8
{
    const int Foot = 12;
    static void Main(string[] cs)
    {
        ConvertFeetToInches(3);
    }
        static void ConvertFeetToInches(int feet)
        {
            int inches = feet * Foot;
            Console.WriteLine(inches);
        }

        class Program
    {
        public static void CalculateArea(int length, int width)
        {
            int area = length * width;
            Console.WriteLine (area);
        }
        static void Main()
        {
            CalculateArea(5, 10);
            CalculateArea(7, 7);
        }
    }
    }


