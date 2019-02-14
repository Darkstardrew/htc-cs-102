using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassesIntro
{
    public class Restaraunt
    {
        public string Name;
        public int AvgReview;
        public string Price;
        public string Location;

        public void Restaraunt2()
        {
            MessageBox.Show("Bark");
        }

        public void SayName()
        {
            MessageBox.Show("yo yo diggity dawg was poppin g, yee can call me " + Name);
        }
    }
}