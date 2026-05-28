

namespace Myfirstapplication;

internal class Exercise6
{
    private int _showSize;
    private string _shoeType;
    public Exercise6(int showSize, string shoeType)
    {
        _showSize = showSize;
        _shoeType = shoeType;
    }

    public int ShowSize
    {
        get { return _showSize; }
        set { _showSize = value; }
    }

    public string ShoeType
    {
        get { return _shoeType; }
        set { _shoeType = value; }
    }



    public delegate void TryOn(string message);

    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }







}
