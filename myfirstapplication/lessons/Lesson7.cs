namespace Myfirstapplication;
/*
 a struct is a value type, while a class is a reference type. you should use a struct for small objects that need to be memory dependant.
 */
internal struct Location
{
    private double _longitude, _latitude;

    public double Latitude
    {
        get { return _latitude; }
        set { _latitude = value; }
    }

    public double Longitude
    {
        get { return _longitude; }
        set { _longitude = value; }
    }
    public Location(double longitude, double latitude)
    {
        _longitude = longitude;
        _latitude = latitude;
    }

    // tostring override
    public override string ToString()
    {
        return $"{_longitude} long {_latitude} lat";
    }

} // end struct


// readonly struct
public readonly struct Student
{
    private readonly int _id;
    private readonly string _name;

    public int Studentid
    {
        get { return _id; }
        //set { _id = value; }
    }

    public string StudentName
    {
        get { return _name; }
        // set { _name = value; }
    }

    public Student(int strudentid, string StudentName)
    {
        _id = strudentid;
        _name = StudentName;
    }

} // end struct
