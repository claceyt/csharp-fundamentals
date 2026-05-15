

namespace myfirstapplication;

/*
 This class goes over strings
 */
internal class lesson2
{
    string myString = "Hello world";

        // string method - trim
        public void MyTrimExample()
    {
        string str = " Word ";
        // before trim
        Console.WriteLine(str);
        // trim
        string myTrim = str.Trim();
        // after trim
        Console.WriteLine(myTrim);
    }

    // string method - equals
    public void MyEqualsExample(string beta)
    {
        Console.WriteLine(beta.Equals("world"));
    }

    // string methods toupper tolower
    public void MyUpperLowerExample()
    {
        Console.WriteLine(myString.ToUpper());
        Console.WriteLine(myString.ToLower());
    }

    // string method - lenth
    public int myStringLength()
    {
        return myString.Length;
    }

    // char - uses single quotes
    public void MyExampleChar()
    {
        char myChar = 't';
        char copyright = '\u00A9';
        char something = '\x00A9';
        Console.WriteLine(myChar);
        Console.WriteLine(copyright);
        Console.WriteLine(something);
    }

    // Escape Sequence
    public string MyEscapeExample()
    {
        return "That\'s a cool car. \tCan I \ndrive it sometime?";
    }

    // Concatenation - with 2 string parameters
    public void MyJoinedStrings(string value1, string value2)
    {
        Console.WriteLine(value1 + " " + value2);
    }

    // String Interpolation
public string MyInterpolationExample(string food, int amount)
    {
        return $"My favorite food is {food} and I ate {amount} servings of it";
    }

    public void MyOtherInterpolation()
    {
        Console.WriteLine($"{"Number", -10} {"Order", 15}");
    }


} // end class
