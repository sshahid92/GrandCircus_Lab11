using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab11
{
    class Program
    {

        static void Main(string[] args)
        {
            bool loop = true;
            List<Movie> movieList = new List<Movie>();
            // movieArray = (new Movie("Big Hero 6", "Animated"));
            // movieArray = (new Movie("Star Wars: A New Hope", "Sci-Fi"));
            // movieArray = (new Movie("Chuckie", "Horror"));
            // movieArray = (new Movie("Lion King", "Animated"));
            // movieArray = (new Movie("Straight Outta Compton", "Drama"));
            // movieArray = (new Movie("Back To The Future", "Sci-Fi"));
            // movieArray = (new Movie("Titanic", "Drama"));
            // movieArray = (new Movie("The Last Airbender", "Horror"));
            // movieArray = (new Movie("Dragonball Evolution", "Horror"));
            // movieArray = (new Movie("Aladdin", "Animated"));


             movieList.Add(new Movie(title : "Big Hero 6", category: "Animated"));
             movieList.Add(new Movie(title : "Star Wars: A New Hope", category: "Sci-Fi"));
             movieList.Add(new Movie(title : "Chuckie", category: "Horror"));
             movieList.Add(new Movie(title : "Lion King", category: "Animated"));
             movieList.Add(new Movie(title : "Straight Outta Compton", category: "Drama"));
             movieList.Add(new Movie(title : "Back To The Future", category: "Sci-Fi"));
             movieList.Add(new Movie(title : "Titanic", category: "Drama"));
             movieList.Add(new Movie(title : "The Last Airbender", category: "Horror"));
             movieList.Add(new Movie(title : "Dragonball Evolution", category: "Horror"));
             movieList.Add(new Movie(title : "Aladdin", category: "Animated"));

            while (loop)
            {
                Console.WriteLine($"Welcome to the Movie List Application!\nThere are {movieList.Count} movies in this list.");

                Console.WriteLine("What Category are you interested?\n1) Animated\n2) Drama\n3) Horror\n4) Sci-Fi");
                int selection;
                bool isNum;
                bool isValid = true;
                do
                {
                    isNum = int.TryParse(Console.ReadLine(), out selection);
                    if (selection < 1 || selection > 4)
                    {
                        Console.WriteLine("Try entering a number between 1-4.");

                    }
                } while (isNum == false && isValid == true);

                PrintList(movieList, selection);

                string answer;
                do
                {
                    Console.WriteLine("Continue? (y/n)");
                    answer = Console.ReadLine();
                } while (answer != "yes" && answer != "y" && answer != "no" && answer != "n");
                if(answer == "no" || answer == "n")
                {
                    loop = false;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
            
        }

        static void PrintList(List<Movie> movieList, int selection)
        {
            switch (selection)
            {
                case 1:
                    var animatedCategory = movieList.Where(a => a.Category.ToLower().Contains("animated")).ToList();
                    foreach (Movie movies in animatedCategory)
                    {
                        Console.WriteLine($"\tTitle: {movies.Title.PadRight(25)} Genre:{movies.Category}");
                    }
                    break;

                case 2:
                    var dramaCategory = movieList.Where(a => a.Category.ToLower().Contains("drama")).ToList();
                    foreach (Movie movies in dramaCategory)
                    {
                        Console.WriteLine($"\tTitle: {movies.Title.PadRight(25)} Genre:{movies.Category}");
                    }
                    break;

                case 3:
                    var horrorCategory = movieList.Where(a => a.Category.ToLower().Contains("horror")).ToList();
                    foreach (Movie movies in horrorCategory)
                    {
                        Console.WriteLine($"\tTitle: {movies.Title.PadRight(25)} Genre:{movies.Category}");
                    }
                    break;

                case 4:
                    var sciFiCategory = movieList.Where(a => a.Category.ToLower().Contains("sci-fi")).ToList();
                    foreach (Movie movies in sciFiCategory)
                    {
                        Console.WriteLine($"\tTitle: {movies.Title.PadRight(25)} Genre:{movies.Category}");
                    }
                    break;
                default:
                    Console.WriteLine("Ahh! I broke, this hurts!");
                    break;
            }
        }

    }
}
