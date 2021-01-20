using System;

namespace ThePetStore
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Pets.Turtle turtle1 = new Pets.Turtle("Mertle", 72);
            //turtle1.Eat("pizza");
            //turtle1.Eat("pizza");
            //turtle1.ShowTime("Bar-Mitzvah");

            Pets.Scorpion scorpion = new Pets.Scorpion("Steven");
            scorpion.Attack();
            //Console.WriteLine($"{turtle1.Name} is {turtle1.Age} years old.");
        }
    }
}
