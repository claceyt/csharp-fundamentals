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

public record struct (int width, int height)
{
    public void CalculateRes()
    {
        Console.WriteLine(width * height);
    }
