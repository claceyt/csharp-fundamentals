using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstapplication;
public class Boat
{
    public string Accrosswater { get; set; }
    public string BoatSize{ get; set; }
    public string BoatColor{ get; set; }
    public string BoatMaterial{ get; set; }


    public Boat() { }

    public Boat(string Accrosswater, string BoatSize, string BoatColor, string BoatMaterial)
    {
        Accrosswater = Accrosswater;
        BoatSize = BoatSize;
        BoatColor = BoatColor;
        BoatMaterial = BoatMaterial;
    }
}

public class SailBoat : Boat
{
    public string Row { get; set; }


    public SailBoat(string Accrosswater, string BoatSize, string BoatColor, string BoatMaterial, string Row)
        : base(Accrosswater, BoatSize, "Unknown Color", Row)

    {
        Row = Row;
    }
      


    public SailBoat(string Accrosswater, string BoatSize, string Row)
         : this(Accrosswater, BoatSize, "Stocky", "Black", Row)
    { }

}


