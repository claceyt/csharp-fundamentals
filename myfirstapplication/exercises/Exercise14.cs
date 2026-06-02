using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstapplication;

internal class Exercise14
{
    static void Main()
    {
        DisplayIceCreamFlavors();
    }
    static void DisplayIceCreamFlavors()
    {
        string[] flavors = { "vanilla", "chocolate", "strawberry", "mint chocolate chip", "coockie dough" };
        foreach (string flavor in flavors)
        {
        Console.WriteLine(flavor);
        }
    }

    public void PrintChiefsScores()
    {
        
        int[,] chiefsScores =
        {
            { 17, 22, 24, 38, 34, 20, 10, 26, 31, 33, 35, 31, 27, 24, 16, 22, 33, 27, 21 },
            { 9, 31, 20, 34, 23, 20, 40, 32, 26, 17, 43, 16, 9, 35, 32, 29, 14, 17, 38 }
        };

        Console.WriteLine("Chiefs Scores:");

      
        foreach (int score in chiefsScores)
        {
            Console.Write(score + " ");
        }

        Console.WriteLine(); 
    }

     void PrintScores()
    {
        PrintScores();
    }

}
