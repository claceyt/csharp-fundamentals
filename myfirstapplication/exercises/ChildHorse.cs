

using Myfirstapplication;

namespace Myfirstapplication;

public class Horse
{
    public string HorseRunning { get; set; }
    public string TypeOfTail { get; set; }
    public string HorseShape { get; set; }
    public string HorseColor { get; set; }


    public Horse() { }

    public Horse(string horseRunning, string tailType, string horseShape, string horseColor)
    {
        HorseRunning = horseRunning;
        TypeOfTail = tailType;
        HorseShape = horseShape;
        HorseColor = horseColor;
    }
}

public class Stallion : Horse
{
    public string Clydesdale { get; set; }


    public Stallion(string horseRunning, string typeOfTail, string horseShape, string horseColor, string clydesdale)
        : base(horseRunning, typeOfTail, "Unknown Color", clydesdale)

    {
        Clydesdale = clydesdale;
    }


    public Stallion(string horseRunning, string typeOfTail, string clydesdale)
         : this(horseRunning, typeOfTail, "Stocky", "Black", clydesdale)
    { }

}


