using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace myfirstapplication.exercises
{
    internal class Exercise5
    {
    }


    public interface Voltage(int current, int resistance)
    {
        Func<int, int, int> calculate = (c, r) => c * r;
        Return calculate(Current, resistance);
    }

    public string Grades(char grade)
        {
            return grade switch
            {
                'E' or 'e' => "Excellent",
                'V' or 'v' => "very good",
                'g' or 'G' => "good",
                'a' or 'A' => "Average",
                'F' or 'f' => "Fail",
                _ => "Not a valid grade"
            };
        }

        public void PopcornSize(int size)
        {
            string PopcornSize = size switch
            {
                <= 3 => "Microwave bag",
                <= 16 => "movie snack",
                <= 32 => "Movie cup",
                <= 64 => " movie tub",
                _ => " we dont have that size"
            };
        }










}





