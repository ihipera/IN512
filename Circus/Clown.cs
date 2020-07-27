using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Circus
{
    public class Clown
    {
        private string name;
        private int height;
        private int age;

        public Clown(string name, int height, int age)
        {
            this.name = name;
            this.height = height;
            this.age = age;
        }

        public string TalkAboutYourself()
        {
            return ("My name is " + name + ". I am " + age + " years old. And I am " + height + " centimeters tall.");

        }
    }
}
