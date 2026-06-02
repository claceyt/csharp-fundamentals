using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstapplication;

public enum FavoritesMovie
{
    YourForma,
    Arifureta,
    TheWorldsFinestAssassin,
    LordOfMysteries
}

public class Program
{
    public string GetMovieRecommendations(FavoritesMovie movie)
    {
        return movie switch
        {
            FavoritesMovie.YourForma => $"Android robot and a detective {movie} must watch",
            FavoritesMovie.Arifureta => $"Guy gets reincarnated and gets betrayed and gets very powerful {movie} must watch",
            FavoritesMovie.TheWorldsFinestAssassin => $"Assassin gets reincarnated and is insanely op {movie} must watch",
            FavoritesMovie.LordOfMysteries => $"Guy gets reincarted into the past, it is a magic-ish type of series{movie} this is a must watch",
            _ => $"Its a good choice, though {movie} is not my top choises"

        };
    }


    public void Main()
    {
        FavoritesMovie myFav = new FavoritesMovie();
        string message = GetMovieRecommendations(myFav);

        Console.WriteLine(message); }

       

        public  (int num, string movie) GetMovieData(FavoritesMovie movie)
        {
            int Value = (int) movie;
            string StringValue = movie.ToString();
            return (Value, StringValue);
        }






    }





