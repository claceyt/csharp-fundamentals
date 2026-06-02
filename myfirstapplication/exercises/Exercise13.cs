namespace Myfirstapplication;

internal class Exercise13
{
    public interface IMovement
    {
        int Speed { get; }
    }

    // Abstract base class for water birds
    public abstract class WaterBirds : IMovement
    {
        public int Speed { get; } // Read-only property

        protected WaterBirds(int speed)
        {
            if (speed <= 0)
                throw new ArgumentException("Speed must be positive.", nameof(speed));

            Speed = speed;
        }

        public abstract void Swim();
        public abstract void Dive();
        public abstract void Fly();
    }

   
    public class MallardDuck : WaterBirds
    {
        public MallardDuck(int speed) : base(speed)
        {
            Console.WriteLine($"Constructor: passed speed={speed}, stored Speed={this.Speed}");
        }

        public override void Fly()
        {
            Console.WriteLine($"Mallard duck is flying at {Speed} km/h");
        }

        public override void Swim()
        {
            Console.WriteLine("The mallard duck is swimming faster");
        }

        public override void Dive()
        {
            Console.WriteLine("The mallard duck dives gracefully");
        }
    }

}
