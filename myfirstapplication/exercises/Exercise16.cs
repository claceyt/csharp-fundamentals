using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstapplication;

internal class Exercise16
{

    public class Horse
    {
        
        public string Name { get; set; }
        public string Running { get; set; }
        public string Tail { get; set; }
        public string Shape { get; set; }
        public string Color { get; set; }

        
        public Horse() { }

        
        public Horse(string name)
        {
            Name = name;
        }

        
        public override string ToString()
        {
            return $"Name: {Name ?? "Unnamed"}, Running: {Running}, Tail: {Tail}, Shape: {Shape}, Color: {Color}";
        }

        
        public static void ProcessHorseCollection()
        {
            
            List<Horse> horseList = new List<Horse>();

           
            Horse horse1 = new Horse();
            horse1.Name = "Speedy";
            horse1.Running = "Fast";
            horse1.Tail = "White";
            horse1.Shape = "Skinny";
            horse1.Color = "Black";

            
            Horse horse2 = new Horse("Shiny");
            horse2.Color = "Gold";
            horse2.Shape = "Big";
            horse2.Running = "Medium";
            horse2.Tail = "Brown";

            
            horseList.Add(horse1);
            horseList.Add(horse2);

            
            foreach (Horse currentHorse in horseList)
            {
                Console.WriteLine(currentHorse.ToString());
            }
        }

       
        public static void Main()
        {
            ProcessHorseCollection();
        }
    }



    class MovieManager
    {
        public void DisplayFavoriteMovies()
        {
            Dictionary<int, string> favoriteMovies = new Dictionary<int, string>();

            favoriteMovies.Add(1, "Arifureta");
            favoriteMovies.Add(2, "TheWorldsFinestAssassin");
            favoriteMovies.Add(3, "LordOfMysteries");
            favoriteMovies.Add(4, "YourForma");


            foreach (KeyValuePair<int, string> movie in favoriteMovies)
            {
                Console.WriteLine($"Rank: {movie.Key} - movie: {movie.Value}");
            }
        }
    }





}

