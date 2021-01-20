using System;
using System.Collections.Generic;
using System.Text;


namespace ThePetStore.Pets
{
    //A class is implicitly internal 
    class Scorpion
    {
        //Inside class things are implicitly private
        //Properties
        public int StingerWidth { get; set; }
        public string Origin { get; set; }
        public string Name { get; set; }
        public bool DoesGlow { get; set; }

        //Constructor
        public Scorpion(string name)
        {
            Name = name;
            DoesGlow = true;
        }

        //Methods
        public void Attack()
        {
            if(DoesGlow)
            {
                Console.WriteLine("Scorpion attacks! Get to the hospital");
            }
            else
            {
                Console.WriteLine("Scorpion kiss. You are fine");
            }
        }
    }
}
