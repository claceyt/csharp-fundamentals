
namespace Myfirstapplication;
/*
 constructors, methods, & more
 */
internal class Lesson6
{
    // delegates
    public delegate void TryOn(string type);
    public delegate void TryOnAnotherHat(string type);

    // private class varibles
    private string _hatType;
    private int _hatSize;

    // properties
    public string HatType
    {
        get { return _hatType; }
        set { _hatType = value; }
    }

    public int HatSize
    {
        get { return _hatSize; }
        set { _hatSize = value; }
    }



    /* default constructor */
    public Lesson6()
    {
        //  Console.WriteLine("Hello Lesson 6");
        TryOnAnotherHat tryHat = TryOnHat;
        TryALargeHat("Fadora", 7, tryHat);
    }

    /* constructor with 1 parameter */
    public Lesson6(int value)
    {
        Console.WriteLine($"Constructor = {value}");
    }

    /* constructor with 2 parameters */
    public Lesson6(string type, int size)
    {
        _hatType = type;
        _hatSize = size;
    }

    /*
     the in parameter modifier is passed by reference. the argument cannot be modified as it is readonly
     */
    public void InExample(in int value)
    {
        // value = 23; // cannot change the value
        int total = value + 5;
        Console.WriteLine($"in value + 5 = {total}");
    }

    /*
     the ref parameter modifier is passed by reference. the value changed in the method affects the called variable
     */

    public void RefExample(ref int value)
    {
        value += 5;
        Console.WriteLine($"RefExample = {value}");
    }

    /*
     the out parameter modifier is passed by reference. the out variable passed in does not have to be initialized.
     */

    public void OutExample(out int value)
    {
        value = 42;
    }

    // methods for delegates
    public void TryOnHat(string message)
    {
        Console.WriteLine($"TryOnHat = {message}");

    }
    public void TryALargeHat(string type, int oldSize, TryOnAnotherHat anotherHat)
    {
        anotherHat($"I tried on a {type} hat at size {++oldSize}");
    }

    public void HangUpHat(string message)
    {
        Console.WriteLine($"HangUpHat = {message}");
    }











} // end class
