namespace Myfirstapplication;
// acess modifiers
internal class Lesson9
{
    private int _value = 10;


    /*
     private acess modifier can only be seen within the class, struct or nested type
     */

    private void SamplePrivate()
    {
        Console.WriteLine("This method is private");
    }

    /*
     protect acess modifier can only be seen whithin the type or a child(derived class  */
    protected void SampleProtected()
    {
        Console.WriteLine("This method is protected.");
    }
    // internal acess modifier can be seen within the assembly, but not other assemblies.
    internal void SampleInternal()
    {
        Console.WriteLine("This method is internal.");
    }

    /*
     protected internal can be seen whithin the assembly or child(derived) class from another assembly  */
    protected internal void SampleProtectedInternal()
    {
        Console.WriteLine("This method is protected internal");
    }
    /*
     private protected can be seen only whithin the class and child(derived) class from whithin the assembly */
    private protected void SamplePrivateProtected()
    {
        Console.WriteLine("This method is private protected");
    }

    public class Nested
    {
        public Nested(Lesson9 parent)
        {
            Console.Write($"The value is {parent._value}");
        }
    }// end nested class


} // end class
