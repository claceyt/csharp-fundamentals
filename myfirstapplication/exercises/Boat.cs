using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstapplication.exercises
{
    internal class Boat
    {
        public Boat(string boatSize, string boatMaterial, string boatColor)
        {
          boatSize = boatSize ;
           boatMaterial = boatMaterial;
            boatColor = boatColor;
        }

        public Boat(string boatSize, string boatColor)
            : this("Across", boatSize, boatColor)
        { }


        public Boat()
                : this("Water", "wood")
        { }
    }
}
