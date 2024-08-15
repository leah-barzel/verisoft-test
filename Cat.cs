using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leah_barzel
{
    public class Cat : Animal, ILand
    {
        private int numberOfLegs = 4;
        public Cat() { }
        public Cat(bool mamals, bool carnivorous, int mood) : base(mamals, carnivorous, mood) { }

        public override void SayHello()
        {
            Console.WriteLine("moew");
        }
        public override void SayHello(int mood)
        {
            if (mood == MOOD_HAPPY)
                Console.WriteLine("purr , purr");
            else if (mood == MOOD_SCARE)
                Console.WriteLine("hiss");
        }
        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }


    }
}
