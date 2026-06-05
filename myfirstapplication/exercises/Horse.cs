using System;

namespace Myfirstapplication;

public class Horse
{
    
    public string TailType { get; init; }
    public string Horseshape { get; set; }
    public int Horsecolor { get; set; }
    public double Horserunning { get; set; }

    
    public Horse(string tailtype, string horseshape, string horsecolor, string horserunning)
    {
        TailType = tailtype;
        HorseShape = horseshape;
        HorseColor = horsecolor;
        HorseRunning = horserunning;
    }

    
    public Horse(string tailtype, string horseshape)
        : this(tailtype, horseshape, horsecolor: "black", horserunning: "20.5")
    {
    }

    
    public Horse()
        : this(tailtype: "soft", horseshape: "long")
    {
    }

    
    public void Running()
    {
        Console.WriteLine(
            $"The {HorseColor} horse with a {TailType} tail is running at {HorseRunning} miles per hour."
        );
    }
}









