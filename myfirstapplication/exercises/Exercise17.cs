using System.Drawing;

namespace Myfirstapplication;

internal class Exercise17
{
    class ThisClass
    {
        static void Main()
        {
            Console.WriteLine("Testing valid numbers (10 and 2):");
            SafeDivide(10, 2);

            Console.WriteLine("testing with zero as divisor (10 and 0):");
            SafeDivide(10, 0);
            Console.WriteLine("Testing valid numbers (15 and 3):");
            SafeDivide(15, 3);

        }

        static void SafeDivide(int numerator, int denominator)
        {
            try
            {
                int result = numerator / denominator;
                Console.WriteLine($"The result of the division is: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"An error occured: {ex.Message}");
            }
        }

    }
}

 





public class Project
{
    // Auto-implemented property with a default value
    public string Color { get; set; } = "Silver";
}

public class HorseManager
{
    public void CheckHorse(Horse horse)
    {
        if (horse == null)
        {
            throw new ArgumentNullException(nameof(horse), "Horse cannot be null.");
        }

        // Output horse details
        Console.WriteLine($"Horse color: {horse.HorseColor}");
    }
}

public class Manager
{
    public static void Main()
    {
        HorseManager manager = new HorseManager();

        try
        {
            // This will throw an exception
            manager.CheckHorse(null);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        // This will work fine
        Horse myHorse = new Horse();
        manager.CheckHorse(myHorse);
    }
}
