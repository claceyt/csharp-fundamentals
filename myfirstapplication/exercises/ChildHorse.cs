

using Myfirstapplication;
using System.Drawing;
using System.Reflection.Metadata;

namespace Myfirstapplication;

using System;

public class Horse
{
    public string HorseRunning { get; set; }
    public string TypeOfTail { get; set; }
    public string HorseShape { get; set; }
    public string HorseColor { get; set; }

    public Horse() { }

    public Horse(string horseRunning, string tailType, string horseShape, string horseColor)
    {
        HorseRunning = horseRunning;
        TypeOfTail = tailType;
        HorseShape = horseShape;
        HorseColor = horseColor;
    }

    public virtual void DescribeColor()
    {
        Console.WriteLine($"My horse is {HorseColor}.");
    }
}

public class Stallion : Horse
{
    public string Clydesdale { get; set; }

    public Stallion(string horseRunning, string typeOfTail, string horseShape, string horseColor, string clydesdale)
        : base(horseRunning, typeOfTail, horseShape, horseColor)
    {
        Clydesdale = clydesdale;
    }

    public Stallion(string horseRunning, string typeOfTail, string clydesdale)
        : this(horseRunning, typeOfTail, "Stocky", "Black", clydesdale)
    {
    }

    public override void DescribeColor()
    {
        Console.WriteLine("My horse is green.");
    }

    public void DescribeEating(int quantity)
    {
        Console.WriteLine($"I eat {quantity} horses every day.");
    }
}

public class Horses : Horse
{
    public override void DescribeColor()
    {
        base.DescribeColor();
        Console.WriteLine("I eat apples.");
    }
}







