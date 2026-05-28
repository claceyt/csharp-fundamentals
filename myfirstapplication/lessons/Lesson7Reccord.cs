namespace Myfirstapplication;

/*
 a record is a reference type that provides built-in functionality for encapulating data
 */
internal record Person(string FirstName, string LastName);


/*
 a record struct is a value type with simular functionality as a record class
 */
public record struct Resolution(int width, int height)
{
    public void CalculateRes()
    {
        Console.WriteLine(width * height);
    }
} // end record