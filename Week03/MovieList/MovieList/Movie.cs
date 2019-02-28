using System;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        public string MovieName;
        public int ReleaseYear;

        public Movie (string name, int releaseYear)
        {
            this.MovieName = name;
            this.ReleaseYear = releaseYear;
        }

    public void ShowMovie()
        {
            MessageBox.Show(MovieName + Environment.NewLine + ReleaseYear);
        }
    }
}
