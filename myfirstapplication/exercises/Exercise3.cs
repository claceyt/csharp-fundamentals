namespace myfirstapplication;

internal class Exercise3
{
    public int CalculateModulus(int divisor)
    {
        int a = 15;
        int b = 456;
        int c = 23;
        int d = 89;
        int e = 245;
        Console.WriteLine(a % divisor);
        Console.WriteLine(b % divisor);
        Console.WriteLine(c % divisor);
        Console.WriteLine(d % divisor);
        return e % divisor;

    }

    public void SolveMathproblems()
    {
        // a output 138
        Console.WriteLine(10 + 32 * 12 / 3);
        // b output 168
        Console.WriteLine(10 + 32 * 5 - 2);
        // c output 131
        Console.WriteLine(10 + 121);
    }


    public void Calculate(short first, short second)
    {
        short result = first;
        result += second;
        Console.WriteLine($"= result: {result}");
        result = first;
        result /= second;
        Console.WriteLine($"/= result: {result}");
        result = first;
        result *= second;
        Console.WriteLine($"*= result: {result}");
        result = first;
        result %= second;
        Console.WriteLine($"%= result: {result}");
    }

    public void BooleanLogic(bool arg1, bool arg2)
    {
        Console.WriteLine(arg2 & arg1);
        Console.WriteLine(arg2 | arg1);
        Console.WriteLine(arg2 ^ arg1);
        Console.WriteLine(arg2 || arg1);
    }
}