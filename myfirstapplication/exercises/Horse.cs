using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace myfirstapplication.exercises
{
    internal class Horse
    {
        public Horse(string tailType, string horseShape, string horseColor)
        {
            tailType = tailType;
            horseShape = horseShape;
            horseColor = horseColor;
        }

        public Horse(string horseShape, string horseColor)
            : this("Flowing", horseShape, horseColor)
        { }


        public Horse()
                : this("Muscular", "Chestnut")
        { }
    
    public virtual void HorseColor()
        {
            Console.WriteLine($"My {HorseColor} horse is green.");
        }
    }
}
