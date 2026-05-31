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

    public static void PrintChiefsScores()
    {
        
        int[,] chiefsScores =
        {
            { 23, 34, 43 },
            { 34, 35, 22 }
        };

        Console.WriteLine("Chiefs Scores:");

      
        foreach (int score in chiefsScores)
        {
            Console.Write(score + " ");
        }

        Console.WriteLine(); 
    }

    static void Scores()
    {
        PrintChiefsScores();
    }

}
