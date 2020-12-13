using System;
using System.Collections.Generic;
using System.Text;

namespace XMl_Lab2
{
   public class Movie
    {
        public string Genre;
        public string Name;
        public string Studio;
        public string Year;
        public string Time;
        public Movie()
        { }
        public Movie( string[] info)
        {
            Genre = info[0];
            Studio = info[1];
            Name = info[2];
            Year = info[3];
            Time = info[4];
        }
        public bool Equal(Movie movie)
        {
            if((this.Genre==movie.Genre)&&(this.Studio==movie.Studio)
                &&(this.Name==movie.Name)&&(this.Year==movie.Year)&&(this.Time==movie.Time))
            {
                return true;
            }
            return false;
        }
    }
}
