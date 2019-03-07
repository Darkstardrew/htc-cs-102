using InhereitenceIntro;
using System;
using System.Collections.Generic;
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

namespace InheritanceIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Bark();
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            // Define a new List of dogs
            List<Dog> dogs = new List<Dog>();
            
            // Instantiate some dog objects
            Dog dog1 = new Dog("Pug Mix", 20, "Sid");
            Dog dog2 = new Dog("Pug", 18, "Yoda");

            // Add the dogs to the list
            dogs.Add(dog1);
            dogs.Add(dog2);

            // Loop through the list and call a method on the objects
            foreach (Dog d in dogs)
            {
                d.SayName();
            }

            Duck duck1 = new InhereitenceIntro.Duck(25, " Harry!");
            Duck duck2 = new InhereitenceIntro.Duck(45, " Henrietta!");

            List<Duck> ducks = new List<Duck>();
            ducks.Add(duck1);
            ducks.Add(duck2);
            
            foreach (Duck duck in ducks)
            {
                duck.SayName();
            }
        }

        private void Quack_Button_Click(object sender, RoutedEventArgs e)
        {
            Duck duck = new Duck();
            duck.Quack();
        }

        private void ImageButton_Click(object sender, RoutedEventArgs e)
        {
            Process photoViewer = new Process();
            //photoViewer.StartInfo.FileName = @"C:\Program Files\Windows Photo Viewer\ImagingDevices.exe";
            photoViewer.StartInfo.FileName = @"\Microsoft.Windows.Photos_2019.18114.17710.0_x64__8wekyb3d8bbwe";
            photoViewer.StartInfo.Arguments = @"C:\Users\User1\Pictures\FrogCostume.jpg";
            photoViewer.Start();
        }
    }
}
