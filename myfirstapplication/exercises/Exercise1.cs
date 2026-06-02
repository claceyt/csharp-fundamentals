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
    public void Convert(double firstNum, float secondNum, long thirdNum)
    {
        long doubleToLong = (long)firstNum;
        Console.WriteLine(doubleToLong);
            int floatToInt = (int)secondNum;
        Console.WriteLine((int)floatToInt);
        short longToShort = (short)thirdNum;
        Console.WriteLine(longToShort);
    }

    public void Task4()
    {
        string ValueA = "-9516248";
        double ValueB = 123_456.987;
        int ValueC = 3_500;
        long valueD = 988_562_486;
        decimal ValueE = -19_733.148_95m;
    }
}