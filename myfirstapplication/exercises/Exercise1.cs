using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace myfirstapplication.exercises
{
    internal class Exercise1
    {
        public void Integral()
        {
            // value of 35
            int value1 = 35; // decimal
            int value2 = 0x23; // hexadecimal
            int value3 = 100011; // binary
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
        }

        public void ConvertbyteToInt()
        {
            int converted = (int)myByte; // byte
            Console.WriteLine(converted);
        }
{

        public void ConvertshortTolong()
        {
            int converted = (int)myshort; // short
            Console.WriteLine(converted);
        }

        public void ConvertintTofloat()
        {
            int converted = (int)myInt; // int
            Console.WriteLine(converted);
        }

        public void ConvertdoubleTolong()
        {
            int converted = (int)myDouble; // double
            Console.WriteLine(converted);
        }

        public void ConvertfloatToInt()
        {
            int converted = (int)myFloat; // float
            Console.WriteLine(converted);
        }

        public void ConvertlongToshort()
        {
            int converted = (int)mylong; // long
            Console.WriteLine(converted);
        }

        //int range -2,147,483,648 to 2,147,483,647
        int myInt = 3500;

        public void IntMinMax()
        {
            Console.WriteLine(Int32.MinValue);
            Console.WriteLine(Int32.MaxValue);
        }
    }
