using System;
using System.Collections.Generic;
using System.Text;

namespace ThePetStore.Pets
{
    public class Turtle
    {
        //Properties - Externally consumable

        //read-only property -> can only be set once and in the constructor/instantiation process
        public string Name { get; }
        //public property with a private setter
        public int Age { get; private set; }
        //read-only property, but can only be calculated
        public string Description => $"{Age} year old {Size}, {Color} turtle.";
        //auto-property
        public string Size { get; set; }
        public string Color { get; set; }
        //field backed property
        string _shellPattern = "squares";
        public string ShellPattern
        {
            get { return _shellPattern; }
            set { _shellPattern = value; }
        }


        //Fields - internal & private things
        private bool _isHungry = true;

        //public Turtle(string name) : this(name, 0);
        
        //Constructor
        public Turtle(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"This turtle name is {Name} and it's age is {Age}");
        }


        //Method overloading - call the LEAST specific method first
        public void Eat()
        {
            Eat("Pellets");
        }

        //Method
        //method signature return type, name, parameters
        public void Eat(string foodType)
        {
            if (_isHungry)
            {
                Console.WriteLine($"The turtle stretches it's neck out and munches on {foodType}");
                _isHungry = false;
            }
            else
            {
                Console.WriteLine($"Not hungry");
            }

        }
        public void ShowTime(string occasion)
        {
            if (occasion != null)
            {
                Console.WriteLine($"It is a {occasion}");
            }
            if (occasion == "birthday")
            {
                Console.WriteLine($"{Name} is now {++Age} years old");
            }
            else
            {
                Console.WriteLine($"No occasion...");
            }
            DressUp("tie");
        }
        
        private void DressUp(string clothing)
        {
            Console.WriteLine($"The turtle is wearing a {clothing}");
        }
    }
}
