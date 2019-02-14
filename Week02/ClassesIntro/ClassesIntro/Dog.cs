using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassesIntro
{
    public class Dog
    {
        public string Breed;
        public int Height;
        public int Age;
        public string Name;

        public void Bark()
        {
            MessageBox.Show("Bark");
        }

        public void SayName()
        {
            MessageBox.Show("yo yo diggity dawg was poppin g, yee can call me " + Name);
        }
    }
}