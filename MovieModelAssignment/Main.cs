using System;
using System.Collections.Generic;

namespace MovieModelAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
                        
            Movie movie1 = new Movie("Inception", 266000000);
            movie1.Reviews.Add(158857, new Review("Best movie ever!", 9));
            movie1.Reviews.Add(148896, new Review("Top notch!", 8));
            movie1.Reviews.Add(134436, new Review("Great scenario!", 10));
            movie1.Actors = new List<string> { "Brad Pitt", "Johnny Depp", "Kevin Spacey" };
            movie1.Actors.Add("Kevin Heart");
            movie1.CalculateRating();
            
            movies.Add(movie1);
                        
            Movie movie2 = new Movie("Dark Traits", 289000000.5);
            movie2.Reviews.Add(158857, new Review("Great performance", 10));
            movie2.Reviews.Add(148896, new Review("Fantastic music accompaniment", 8));
            movie2.Reviews.Add(134436, new Review("Loved it since minute 1!", 10));
            movie2.Actors = new List<string> { "Nicolas Cage", "Anthony Hopkins", "Scarlett Johansson" };
            movie2.CalculateRating();

            movies.Add(movie2);

            Movie movie3 = new Movie("The Godfather", 300000000);
            movie3.Reviews.Add(158857, new Review("Great cast", 10));
            movie3.Reviews.Add(148896, new Review("Fantastic music", 8));
            movie3.Reviews.Add(134436, new Review("Loved it", 7));
            movie3.Reviews.Add(155857, new Review("Great cast", 5));
            movie3.Reviews.Add(159857, new Review("hytkyukyku", 3));
            movie3.Actors = new List<string> { "Nicolas Cage", "Adam Sandler", "XYZ" };
            movie3.CalculateRating();

            movies.Add(movie3);

            Movie movie4 = new Movie("The Plan", 400000000);
            movie4.Reviews.Add(158857, new Review("Great cast", 10));
            movie4.Reviews.Add(148896, new Review("Fantastic music", 10));
            movie4.Reviews.Add(159857, new Review("hytkyukyku", 10));
            movie4.Actors = new List<string> { "ZXY", "Adam V", "XYZ" };
            movie4.CalculateRating();

            movies.Add(movie4);

            Movie movie5 = new Movie("Mastapiece", 150000000);
            movie5.Reviews.Add(158857, new Review("Great", 8));
            movie5.Reviews.Add(148896, new Review("Fantastic", 9));
            movie5.Reviews.Add(159857, new Review("fgdfgr", 3));
            movie5.Actors = new List<string> { "VBN", "G.", "STW" };
            movie5.CalculateRating();

            movies.Add(movie5);

            Movie movie6 = new Movie("Justice League", 180000000);
            movie6.Reviews.Add(158857, new Review("Original", 7));
            movie6.Reviews.Add(148896, new Review("Amazing", 9));
            movie6.Reviews.Add(159857, new Review("htghtyj", 3));
            movie6.Actors = new List<string> { "GHJ", "G.", "VBS", "Orion" };
            movie6.CalculateRating();

            movies.Add(movie6);

            Movie movie7 = new Movie("Deadpool", 385000000);
            movie7.Reviews.Add(158857, new Review("Boring", 4));
            movie7.Reviews.Add(148896, new Review("Didn't like the protagonist/antagonist", 5));
            movie7.Reviews.Add(159857, new Review("erteryryutyjnvb", 8));
            movie7.Actors = new List<string> { "Ryan Reynolds", "Z.", "BSM", "Ice Cube" };
            movie7.CalculateRating();

            movies.Add(movie7);

            Movie movie8 = new Movie("In Time", 266000000);
            movie8.Reviews.Add(158857, new Review("Great concept", 9));
            movie8.Reviews.Add(148896, new Review("Fantastic script!", 8));
            movie8.Reviews.Add(159857, new Review("ioyukjon", 7));
            movie8.Actors = new List<string> { "Justin Timberlake", "F.", "VST" };
            movie8.CalculateRating();

            movies.Add(movie8);

            Movie movie9 = new Movie("Shawshank Redemption", 277000000);
            movie9.Reviews.Add(158857, new Review("Amazing plot twist!", 10));
            movie9.Reviews.Add(148896, new Review("Fantastic scenario", 9));
            movie9.Reviews.Add(127852, new Review("Great acting!", 10));
            movie9.Actors = new List<string> { "Tim Robbins", "Morgan Freeman", "Bob Gunton" };
            movie9.CalculateRating();

            movies.Add(movie9);

            Movie movie10 = new Movie("Now You See Me", 295000000);
            movie10.Reviews.Add(158857, new Review("Amazing plot twist!", 9));
            movie10.Reviews.Add(148896, new Review("Great magic tricks", 8));
            movie10.Reviews.Add(127852, new Review("Top actors", 9));
            movie10.Actors = new List<string> { "Jesse Eisenberg", "Morgan Freeman", "Mark Ruffalo", "Common" };
            movie10.CalculateRating();

            movies.Add(movie10);

            Movie movie11 = new Movie("The Expendables", 103068524);
            movie11.Reviews.Add(158857, new Review("Lots of action, liked it!", 7));
            movie11.Reviews.Add(148896, new Review("So many well-known actors in one film!", 7));
            movie11.Reviews.Add(127852, new Review("Too much CGI...", 3));
            movie11.Actors = new List<string> { "Sylvester Stalone", "Jason Statham", "Jet Li", "Dolph Lundgren" };
            movie11.CalculateRating();

            movies.Add(movie11);


            movies.Sort();  //sorts based on average rating
            Console.WriteLine("Top 10 Rated Movies:\n\n");

            var counter = 1;
            foreach (Movie movie in movies)
            {
                if (counter > 10) break;
                Console.WriteLine(counter + ". " + movie.ToString());
                counter++;
            }
        }//end of main()
    }//end of class
}
