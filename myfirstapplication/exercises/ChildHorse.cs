namespace Myfirstapplication;


public class Horse1
{
    public string TailType { get; set; }
    public string HorseSize { get; set; }
    public string HorseColor { get; set; }
    public string HorseRunning { get; set; }

    public Horse1() { }

    public Horse1(string tailType, string horseSize, string horseColor, string horseRunning)
    {
        TailType = tailType;
        HorseSize = horseSize;
        HorseColor = horseColor;
        HorseRunning = horseRunning;
    }

    public virtual void DescribeColor()
    {
        Console.WriteLine($"My boat is {HorseColor}.");
    }
}

public class Stallion : Horse1
{
    public string Row { get; set; }

    public Stallion(string tailType, string horseSize, string horseColor, string horseRunning, string row)
        : base(tailType, horseSize, horseColor, horseRunning)
    {
        Row = row;
    }

    public Stallion(string tailType, string horseSize, string row)
        : this(tailType, horseSize, "Big", "Black", row)
    {
    }

    public override void DescribeColor()
    {
        Console.WriteLine("My Stallion is green.");
    }
}
