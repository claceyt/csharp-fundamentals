using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstapplication;

public class Boat2
{

    public string Water { get; init; }
    public string Size { get; set; }
    public string Color { get; set; }
    public string Material { get; set; }


    public Boat2(string water, string size, string color, string material)
    {
        Water = Water;
        Size = Size;
        Color = color;
        Material = material;
    }


    public Boat2(string water, string size)
        : this(water, size, color: "black", material: "Wood")
    {
    }


    public Boat2()
        : this(water: "Hard", size: "Huge")
    {}

    public string Description => $"{Water} is Hard {Size} is huge {Color} is black {Material} is wood ";
}
    
 


    