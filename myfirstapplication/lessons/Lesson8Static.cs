namespace Myfirstapplication;
/*
 static class must have static methods as you can not use instance mthods.
 */
internal static class Lesson8Static
{
    public static double CelciusToFahrenheight(double celcius)
    {
        return (celcius * 9 / 5) + 32;
    }

    public static double FahrenheightToCelcius(double Fahrenheight)
    {
        return (Fahrenheight - 32) * 5 / 9;
    }

}// end class
