

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


public interface IMovement
{
    int Speed { get; }
}

// Abstract base class for water birds
public abstract class WaterBirds : IMovement
{
    public int Speed { get; } // Read-only property

    protected WaterBirds(int speed)
    {
        if (speed <= 0)
            throw new ArgumentException("Speed must be positive.", nameof(speed));

        Speed = speed;
    }

    public abstract void Swim();
    public abstract void Dive();
    public abstract void Fly();
}

// Concrete class for Mallard Duck
public class MallardDuck : WaterBirds
{
    public MallardDuck(int speed) : base(speed)
    {
        Console.WriteLine($"Constructor: passed speed={speed}, stored Speed={this.Speed}");
    }

    public override void Fly()
    {
        Console.WriteLine($"Mallard duck is flying at {Speed} km/h");
    }

    public override void Swim()
    {
        Console.WriteLine("The mallard duck is swimming faster");
    }

    public override void Dive()
    {
        Console.WriteLine("The mallard duck dives gracefully");
    }
}
