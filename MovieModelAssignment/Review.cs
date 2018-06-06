using System;
using System.Collections.Generic;
using System.Text;

namespace MovieModelAssignment
{
    public class Review
    {
        private string _text;
        //private int _rating;
        public int Rating { get; set; }

        public Review(string text, int rating)
        {
            _text = text;
            //_rating = rating;
            Rating = rating;
        }//end of main constructor
    }//end of class
}
