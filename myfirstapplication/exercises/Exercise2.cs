namespace Myfirstapplication;

internal class Exercise2
{
    public void Task1(string word)
    {
        Console.WriteLine(word.Trim());
        Console.WriteLine(word.ToLower());
        Console.WriteLine(word.Contains("tow"));
        Console.WriteLine(word.Length);
        Console.WriteLine(word.IndexOf('c'));
    }

    public void Task2()
    {
        char pilcrow = '\u00B6';
        Console.WriteLine(pilcrow);
    }

    public void singnursuryrhyme()
    {
        string rhyme = "Jack and jill went up the hill\to fetch the pail of water.\njack fell down and broke his crown\nand jill came tumbling down after";
        Console.WriteLine(rhyme);
    }

    public string Task3()
    {
        string name = "Jacob";
        string favoritemovie = "Lord of Mysteries";
        string FavoriteSnack = "slim jim";
        string FavoriteDrink = "Dirty Mountain Dew";
        return $"{name}'s favorite movie is {favoritemovie}. jacob loves eating {FavoriteSnack} and drinking {FavoriteDrink} while watching the movie.";
    }


}