namespace Myfirstapplication;
// this will be about abstract modifier and interfaces

public interface ILesson13Interface
{
    int Miles { get; }
    int ConvertMilesToYards();
}// end interface


internal abstract class Lesson13Base : ILesson13Interface
{
    protected int num;

    // abstact properties
    protected abstract int Inches {  get; }
    protected abstract int Feet { get; }

    // implemented from interface
    public abstract int Miles { get; }

    protected Lesson13Base(int num)
    {
        this.num = num;
    }

    // abstract methods
    public abstract int ConvertFeetToInches();
    public abstract int ConvertYardsToFeet();

    // implemeted from interface
    public abstract int ConvertMilesToYards();

}// end class

// our derived class will implement our abtract class members

internal class Lesson13Derived : Lesson13Base
{
    // inplementing abstract properties
    protected override int Inches { get; } = 12;
    protected override int Feet { get; } = 3;

    // implementing interface
    public override int Miles { get; } = 1760;

    public Lesson13Derived(int value)
        :base(value) { }

    // implementing abstract methods
    public override int ConvertFeetToInches()
    {
        return num * Inches;
    }

    public override int ConvertYardsToFeet()
    {
        return num * Feet;
    }

    // implement interface method
    public override int ConvertMilesToYards()
    {
        return num * Miles;
    }


}// end class