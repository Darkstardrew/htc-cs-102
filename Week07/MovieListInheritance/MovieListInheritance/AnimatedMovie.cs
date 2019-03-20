using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieList
{
    class AnimatedMovie : Movie
    {
        public string AnimationStudio;
        public string AnimationType;

        public AnimatedMovie(string Title, int? ReleaseYear, string AnimationStudio, string AnimationType)
        {
            this.Title = Title;
            this.ReleaseYear = ReleaseYear;
            this.AnimationStudio = AnimationStudio;
            this.AnimationType = AnimationType;
        }

        public override void ShowDetails()
        {
            string infoString = "Title: " + this.Title;
            infoString += "\nRelease Year: " + this.ReleaseYear;
            infoString += "\nAnimation Studio: " + this.AnimationStudio;
            infoString += "\nAnimation Type: " + this.AnimationType;
            MessageBox.Show(infoString);
        }
    }
}

