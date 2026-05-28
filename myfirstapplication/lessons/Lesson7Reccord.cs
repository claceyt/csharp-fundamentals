namespace Myfirstapplication;

/*
 a record is a reference type that provides built-in functionality for encapulating data
 */
internal record Person(string FirstName, string LastName);


/*
 a record struct is a value type with simular functionality as a record class
 */
public record Boat(double LengthInMeters, string color, string Material)
{
    public void MoveAcrossWater(double speed)
    {
        Console.WriteLine($"The {color} {Material} boat, which is {LengthInMeters} meters long, is moving across the water at {speed} knots");
    }
} // end record