namespace Myfirstapplication;

internal class Exercise1
{
    public void Integral()
    {
        // value of 35
        int value1 = 35; // decimal
        int value2 = 0x23; // hexadecimal
        int value3 = 100011; // binary
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
    }

    public void Task2(byte num1, short num2, int num3)
    {
        int value = num1;
        int value2 = num2;
        int value3 = num3;
        Console.WriteLine(value);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
    }
    public void Task3(double num1, float num2, long num3)
    {
        int converted = (int)num1; // double
        Console.WriteLine(converted);
        int value2 = (int)num2; // float
        Console.WriteLine(value2);
        int value3 = (int)num3; // long
        Console.WriteLine(value3);
    }

    public void Task4()
    {
        float myFloat = 123_456.987F;
        Console.WriteLine(myFloat);
    }
}