namespace Myfirstapplication;

internal class Condo : House
{
    private string _balcony;

    public string Balcony
    {
        get { return _balcony; }
        set { _balcony = value; }
    }

    public Condo()
        :this("second floor")
             { }
    
    public Condo(string balcony)
        :this("concrete", "steel", "Blue", 35, balcony)
    { }

    public Condo(string foundation, string roofType, string doorcolor, int windowSize, string balcony)
        :base(foundation, roofType, doorcolor, windowSize)
    {
        _balcony = balcony;
    }

    public override void DoorOpenClose()
    {
        Console.WriteLine($"The {DoorColor} door is creaking");
    }
    public void Maintenance()
    {
        Console.WriteLine($"Fixing the {_balcony} on appartment 2.");
    }

}
