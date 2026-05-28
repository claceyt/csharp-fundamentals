using System.Security.Cryptography;

namespace Myfirstapplication;

internal struct Employee
{
   public int Id { get; set; } 
    public string Name { get; set; }

    public Employee(int id, string name)
    {
        Id = id;
        Name = Name;
    }
}

public record Boat(double LengthInMeters, string color, string Material)
{
    public void MoveAcrossWater(double speed)
    {
        Console.WriteLine($"The {color} {Material} boat, which is {LengthInMeters} meters long, is moving across the water at {speed} knots");
    }
}
