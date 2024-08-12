using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Assignment___leah_barzel
{
    public class Frog : Animal, ILand, IWater
    {
        private int numberOfLegs = 4;
        public Frog() { }
        public Frog(bool mamals, bool carnivorous, int mood) : base(mamals, carnivorous, mood)
        {
            this.mamals = false;
            this.carnivorous = false;
            this.mood = mood;
        }
        public override void SayHello(int mood)
        {
            if (mood == MOOD_HAPPY)
                Console.WriteLine("quack quack quack");
            else if (mood == MOOD_SCARE)
                Console.WriteLine("plop into the water");
        }
        
        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }
        public bool HasGills()
        {
            return true;
        }
        public bool HasLaysEggs()
        {
            return true;
        }

       
    }
}
