using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesSettersGetters
{
    class Program
    {

        class Movie
        {
            string titel;
            string director;
            string ratings; //G, PG, PG-13, R, undefind
            int userRatings; //hinne mitte kõrgem kui 10 ja mitte vähem kui 0

            public Movie(string _titel, string _director, string _ratings, int _userRatings)
            {
                titel = _titel;
                director = _director;
                Ratings = _ratings;
                UserRatings = _userRatings;
            }

            public string Ratings
            {
                get { return ratings; }
                set
                {
                    if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                    {
                        ratings = value;
                    }
                    else
                    {
                        ratings = "undefine";
                    }
                }
            }
                                             
            
            public int UserRatings
            {
                get { return userRatings; }
                set
                {
                    if(value<= 10 && value >= 0)
                    {
                        userRatings = value;
                    }
                    else
                    {
                        userRatings = 0;
                    }
                }
            }
            public string Titel
            {
                get { return titel; }
            }
            public string Director
            {
                get { return director; }
            }
        }
        static void Main(string[] args)
        {
           
            string filePath = @"C:\DEMO\mingiTekst.txt";
            List<string> listFromFile = File.ReadAllLines(filePath).ToList();

            List<Movie> listOfMovies = new List<Movie>();

            foreach (string line in listFromFile)
            {
                string[] tempArray = line.Split('/');
            }


            /*foreach(string line in listFromFile)
            {
                string[] tempArray = line.Split('/'); //tempArray luuakse ainult ajutiselt selle tsükli jaoks
                for (int i = 0; i<tempArray.Length; i++)
                    Console.WriteLine($"Item {i} in the temporary array {tempArray[i]}");
                Console.WriteLine();
            } //selle kustutad muidu ära, kuna rojhkem ei vaka. oli ainult kontrolliks*/


            foreach(string line in listFromFile)
            {
                string[] tempArray = line.Split('/'); 
                string tempTitle = tempArray[0];
                string tempDir = tempArray[1];
                string tempRating = tempArray[2];
                int tempUserRating = int.Parse(tempArray[3]);

                Movie tempMovieObject = new Movie(tempTitle, tempDir, tempRating, tempUserRating);

                //Salvestan objektid list Movies sisse 
                listOfMovies.Add(tempMovieObject);
            }

            //Kuva objektid, mis listi sees-foreachiga
            int i = 1;
            foreach(Movie movieObject in listOfMovies)
            {
                Console.WriteLine($"Movie {i}: {movieObject.Titel} directed by {movieObject.Director}");
                i++;
            }

            //UUs muutuja, et leida sõna abil mingit asja

            Console.WriteLine("Enter a key word: ");
            string userSearch = Console.ReadLine().ToLower();

            //Tee uus list, et kuvada otsitud sõnud?
            List<Movie> searchResult = new List<Movie>();

            //Otsingu tulemused
            //int searchResult = 0;
            foreach(Movie movieObject in listOfMovies)
            {
                if (movieObject.Titel.ToLower().Contains(userSearch))
                {
                    searchResult.Add(movieObject);
                    //Console.WriteLine($"{movieObject.Titel} directed by {movieObject.Director}");
                    //searchResult++;
                }

            }

            Console.WriteLine($"{searchResult.Count} movies found");

            foreach( Movie movieObject in searchResult)
            {
                Console.WriteLine($"{movieObject.Titel} directed by {movieObject.Director}");
            }

            Console.ReadLine();
        }
    }
}
