using System;
using System.Collections.Generic;
using System.Text;

namespace MovieModelAssignment
{
    public class Movie : IComparable<Movie>
    {
        private string _title;
        private double _rating;
        private double _gross;
        public List<string> Actors { get; set; }
        public Dictionary<int, Review> Reviews { get; set; }

        public Movie(string title, double gross)
        {
            _title = title;
            _gross = gross;
            Actors = new List<string>();
            Reviews = new Dictionary<int, Review>();
            _rating = 0;

        }//end of main constructor

        public int CompareTo(Movie movie_2)
        {
            //return this._rating.CompareTo(movie_2._rating);   //ascending order
            return movie_2._rating.CompareTo(this._rating);     //descending order
        }

        public void CalculateRating()
        {
            foreach (KeyValuePair<int, Review> entry in Reviews)
            {
                _rating += entry.Value.Rating;
            }
            _rating = _rating / Reviews.Count;
        }

        public override string ToString()
        {
            string actors,result;
            actors = "";

            foreach (var actor_name in Actors) {
                actors += actor_name + " | ";
            }
            result = _title + " (" + _rating.ToString("#.#") + "/10" + ")" + "\n" + "Gross: $" + _gross.ToString("N2") + "\n" + "Actors: " + actors + "\n";
            return result;
        }

    }//end of class
}
