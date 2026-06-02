using System.Security.Cryptography;

namespace Myfirstapplication;

internal struct Employee
{
    public int _id;
    public string _name;

    public Employee(int id, string name)
    {
        _id = id;
        _name = name;
    }
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string Name
    {
        get { return _name;  } 
        set { _name = value; }
    }
}

public record Boat(double LengthInMeters, string color, string Material)
{
    public void MoveAcrossWater(double speed)
    {
        Console.WriteLine($"The {color} {Material} boat, which is {LengthInMeters} meters long, is moving across the water at {speed} knots");
    }
}
