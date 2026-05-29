namespace Myfirstapplication;
// encapsulation is the process of wrapping data and the code into a single unit
internal class Lesson10
{
    private string _firstName;
    private string _address;
    protected int zipcode;
    public string _FirstName
    {
        get { return _firstName; }
        set {  _firstName = value; }
    }

    // auto implemented property with innit keyword
    public string LastName { get; init; }

    // auto implemented property with a default value
    public int Id { get; set; } = 1000;

    // property with set
    public long Phone { get; private set; }

    // expression bodied member property
    public string Address
    {
        get => _address;
        set => _address = value;  
    }

    public int Zipcode
    {
        get => zipcode;
        set => zipcode = value;
    }

    // default constructor
    public Lesson10() { }
    // constructor using this with variables
    public Lesson10(string firstName, string lastName, int zipcode)
    {
        _firstName = firstName;
        LastName = lastName;
        this.zipcode = zipcode;
    }

    /*
     this method shows how you can change a private set property, but not a property with init
     */
    private void ShowLastAndPhone()
    {
        // LastName = "jon"; 
        Phone = 12345678;
    }



}// end class
