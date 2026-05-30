namespace Myfirstapplication;
// base class with a method declared virtual for overriding
public class Fruit
{
    public virtual void EatFruit()
    {
        Console.WriteLine("I eat fruit.");
    }

    public void EatFruit(int Quantity)
    {
        Console.WriteLine($"I eat {Quantity} portions of fruit everyday.");
    }

}// end class


// derived class overriding the base class method
public class Apple : Fruit
{
    public override void EatFruit()
    {
        base.EatFruit();
        {
            base.EatFruit();
            Console.WriteLine("I eat apples.");
        }
    }

}// end class