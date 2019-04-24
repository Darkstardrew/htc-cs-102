using System.Diagnostics;
using System.Windows;

namespace SongList
{
    public class Song
    {
        public string FilePathToPlay { get; set; }

        public string Title
        {
            get;
            set;
        }

        public int ReleaseYear
        {
            get;
            set;
        }
        public string Artist
        {
            get;
            set;
        }

        public Song() { }

        public Song(string myTitle, int myReleaseYear, string myArtist)
        {
            this.Title = myTitle;
            this.ReleaseYear = myReleaseYear;
            this.Artist = myArtist;
        }

        public Song(string myTitle, int myReleaseYear, string myArtist, string FilePathToPlay) : this(myTitle, myReleaseYear, myArtist)
        {
            this.FilePathToPlay = FilePathToPlay;
        }

        public void Play()
        {
            ProcessStartInfo fullscreen = new ProcessStartInfo();
            fullscreen.WindowStyle = ProcessWindowStyle.Maximized;
            fullscreen.FileName = FilePathToPlay;
            Process.Start(fullscreen);
        }

    }
}
