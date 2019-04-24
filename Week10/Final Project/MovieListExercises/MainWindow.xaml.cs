using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;
using System.Collections.Generic;

namespace SongList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Song> SongList;

        public MainWindow()
        {
            InitializeComponent();

            comboBox.Items.Add("Title");
            comboBox.Items.Add("Artist");
            comboBox.Items.Add("Date");

            SongList = new List<Song>()
            {
                new Song
                {
                    Title = "Kahoot Theme Song",
                    ReleaseYear = 2003,
                    Artist = "Alf Inge Wang",
                    FilePathToPlay = @"C:\Users\User1\Music\Kahoot Lobby Music (HD).mp4"
                },
                new Song
                {
                    Title = "Ninja Tuna",
                    ReleaseYear = 2008,
                    Artist = "Mr. Scruff",
                    FilePathToPlay = @"C:\Users\User1\Music\ninjatuna.mp4",
                },
                new Song
                {
                    Title = "Despacito",
                    ReleaseYear = 2018,
                    Artist = "Luis Fonsi (ft. Daddy Yankee)",
                    FilePathToPlay = @"C:\Users\User1\Music\Despacito.mp4",
                },
                new Song
                {
                    Title = "Crab Rave",
                    ReleaseYear = 2018,
                    Artist = "Noisestorm",
                    FilePathToPlay = @"C:\Users\User1\Music\Crab Rave.mp4",
                },
                new SongList.Song
                {
                    Title = "Never Gonna Give You Up",
                    ReleaseYear = 1987,
                    Artist = "Rick Astley",
                    FilePathToPlay = @"C:\Users\User1\Music\Rick Astley - Never Gonna Give You Up (Video).mp4",
                },
                new SongList.Song
                {
                    Title = "Fresh Prince Of Bel Air Theme Song",
                    ReleaseYear = 1990,
                    Artist = "DJ Jazzy Jeff & The Fresh Prince",
                    FilePathToPlay = @"C:\Users\User1\Music\The Fresh Prince Of Bel Air Theme Song (Full).mp4",
                },
                new Song
                {
                    Title = "Nutshack Opening Theme",
                    ReleaseYear = 2007,
                    Artist = "Steven King",
                    FilePathToPlay = @"C:\Users\User1\Music\The Nutshack Opening 2007 HD.mp4",
                },
                new SongList.Song
                {
                    Title = "Get'cha Head In The Game",
                    ReleaseYear = 2006,
                    Artist = "Drew Seeley",
                    FilePathToPlay = @"C:\Users\User1\Music\High School Musical - Get'cha Head In The Game.mp4",
                },
                new SongList.Song
                {
                    Title = "Party In The U.S.A.",
                    ReleaseYear = 2009,
                    Artist = "Miley Cyrus",
                    FilePathToPlay = @"C:\Users\User1\Music\Miley Cyrus - Party In The U.S.A. (Official Music Video).mp4",
                },
                new SongList.Song
                {
                    Title = "Africa",
                    ReleaseYear = 1982,
                    Artist = "Toto",
                    FilePathToPlay = @"C:\Users\User1\Music\Toto - Africa (Official Music Video).mp4",
                },
                new SongList.Song
                {
                    Title = "It's Everyday Bro",
                    ReleaseYear = 2017,
                    Artist = "Jake Paul",
                    FilePathToPlay = @"C:\Users\User1\Music\Jake Paul - It's Everyday Bro (Song) feat. Team 10 (Official Music Video).mp4",
                },
                new Song
                {
                    Title = "Kazoo Kid - Trap Remix",
                    ReleaseYear = 2016,
                    Artist = "Mike Diva & Sick System",
                    FilePathToPlay = @"C:\Users\User1\Music\Kazoo Kid - Trap Remix.mp4",
                },
                new SongList.Song
                {
                    Title = "Hannah Montana Theme Song",
                    ReleaseYear = 2006,
                    Artist = "Miley Cyrus",
                    FilePathToPlay = @"C:\Users\User1\Music\Hannah Montana Theme Song.mp4",
                },
                new SongList.Song
                {
                    Title = "Let it grow but roasting everyone",
                    ReleaseYear = 2017,
                    Artist = "TheMinecraftGuy105",
                    FilePathToPlay = @"C:\Users\User1\Music\Let it grow but roasting everyone.mp4",
                },

            };

           // SongList = SongList.OrderBy(x => x.Title).ToList();

            lvSong.ItemsSource = SongList;
        }

        private void lvSong_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            Song song = lvSong.SelectedItem as Song;
            song.Play();
        }

        public void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string comboBoxValue = comboBox.SelectedValue.ToString();
            bool a = true;
            while (a == true)
            {

                if (comboBoxValue == "Date")
                {
                    SongList = SongList.OrderByDescending(x => x.ReleaseYear).ToList();
                    a = false;
                    lvSong.ItemsSource = SongList;

                    //lvSong.Items.Clear();
                    //lvSong.Items.Add(SongList);
                }
                else if (comboBoxValue == "Title")
                {
                    SongList = SongList.OrderBy(x => x.Title).ToList();
                    a = false;
                    lvSong.ItemsSource = SongList;
                }
                else if (comboBoxValue == "Artist")
                {
                    SongList = SongList.OrderBy(x => x.Artist).ToList();
                    a = false;
                    lvSong.ItemsSource = SongList;
                }
            }
        }

        private void lvSong_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
