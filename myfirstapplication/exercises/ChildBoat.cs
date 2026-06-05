namespace myfirstapplication;
public class Boat
{
    public string water { get; set; }
    public string Size { get; set; }
    public string Color { get; set; }
    public string Material { get; set; }

    public Boat() { }

    public Boat(string water, string size, string color, string material)
    {
        water = water;
        Size = size;
        Color = color;
        Material = material;
    }

    public virtual void DescribeColor()
    {
        Console.WriteLine($"My boat is {Color}.");
    }
}

public class SailBoat : Boat
{
    public string Row { get; set; }

    public SailBoat(string accrosswater, string boatSize, string boatColor, string boatMaterial, string row)
        : base(accrosswater, boatSize, boatColor, boatMaterial)
    {
        Row = row;
    }

    public SailBoat(string accrosswater, string boatSize, string row)
        : this(accrosswater, boatSize, "Big", "Black", row)
    {
    }

    public override void DescribeColor()
    {
        Console.WriteLine("My sailboat is green.");
    }
}




