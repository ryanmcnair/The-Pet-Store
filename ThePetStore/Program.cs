using System;
using ThePetStore.Pets;

namespace ThePetStore
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //console.writeline("hello world!");
            var babyTurtle = new Turtle("Ted",0);
            Turtle turtle1 = new Turtle("mertle", 72);
            Console.WriteLine(turtle1.Description);
            turtle1.Eat("pizza");
            turtle1.Eat("pizza");
            babyTurtle.ShowTime("birthday");
            
            turtle1.ShowTime("bar-mitzvah");
            turtle1.ShowTime("birthday");

            Scorpion scorpion = new Scorpion("Steven");
            scorpion.Attack();
            //Console.WriteLine($"{turtle1.Name} is {turtle1.Age} years old.");

            var puppy = new Dog();
            Console.WriteLine(puppy);
        }
    }
}
