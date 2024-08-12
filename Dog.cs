using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Assignment___leah_barzel
{
    public class Dog : Animal , ILand
    {
        private int numberOfLegs = 4;
        public Dog() { }
        public Dog(bool mamals, bool carnivorous, int mood) : base(mamals, carnivorous, mood)
        {
            this.mamals = true;
            this.carnivorous = true;
            this.mood = mood;
        }
        public override void SayHello()
        {
            Console.WriteLine("wagging the tail");
        }
        public override void SayHello(int mood)
        {
            if (mood == MOOD_HAPPY)
                Console.WriteLine("bark loudly");
            else if (mood == MOOD_SCARE)
                Console.WriteLine("whooping sound");
        }
        
        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }
    }
}
