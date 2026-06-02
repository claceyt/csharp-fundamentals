

namespace myfirstapplication;



// Base class
public class Boat
{
    public string Accrosswater { get; set; }
    public string BoatSize { get; set; }
    public string BoatColor { get; set; }
    public string BoatMaterial { get; set; }

    public Boat() { }

    public Boat(string accrosswater, string boatSize, string boatColor, string boatMaterial)
    {
        Accrosswater = accrosswater;
        BoatSize = boatSize;
        BoatColor = boatColor;
        BoatMaterial = boatMaterial;
    }

    // Virtual method so it can be overridden
    public virtual void DescribeColor()
    {
        Console.WriteLine($"My boat is {BoatColor}.");
    }
}

// Derived class
public class SailBoat : Boat
{
    public string Row { get; set; }

    public SailBoat(string accrosswater, string boatSize, string boatColor, string boatMaterial, string row)
        : base(accrosswater, boatSize, boatColor, boatMaterial)
    {
        Row = row;
    }

    public SailBoat(string accrosswater, string boatSize, string row)
        : this(accrosswater, boatSize, "Stocky", "Black", row)
    {
    }

    // Override DescribeColor
    public override void DescribeColor()
    {
        Console.WriteLine("My sailboat is green.");
    }
}

// Another derived class
public class FishingBoat : Boat
{
    public override void DescribeColor()
    {
        base.DescribeColor();
        Console.WriteLine("I use this boat for fishing.");
    }
}


