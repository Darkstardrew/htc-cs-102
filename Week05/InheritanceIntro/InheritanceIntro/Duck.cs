using ClassesIntro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InhereitenceIntro
{
    public class Duck : Animal
    {

        public void Quack()
        {
            MessageBox.Show("Meow...yeahhhh thats right, I'm a cat B****!");
        }

        public void SayName()
        {
            MessageBox.Show("My name is" + Name);
        }

        public Duck()
        {

        }
        
        public Duck(int height, string name)
        {
            Height = height;
            Name = name;
        }
    }
}
