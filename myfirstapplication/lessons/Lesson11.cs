namespace Myfirstapplication;

public class Polygon
{
    // properties
    protected int NumberOfSides { get; set; }

    // base constructor. if a derived class has not implement a base class constructor explicitly, the base constructor is called implicity
    public Polygon()
    {
        NumberOfSides = 1;
    }

    // this constructor will be accessed from the child class using the base in its constructor 
    public Polygon(int sides)
    {
        NumberOfSides = sides;
    }

    internal double CalculateInteriorAngle()
    {
        return (NumberOfSides - 2) * 180 / NumberOfSides;
    }

} // end class


// square is the derived class of polygon
public class Square : Polygon
{
    public Square()
        :base(4)
    {
       // NumberOfSides = 4;
    }
}// end class

// triangle is the derived class of polygon
public class Triangle : Polygon
{
    public Triangle()
        :base(3)
    {
       // NumberOfSides = 3;
    }
}