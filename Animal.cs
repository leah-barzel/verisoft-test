using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leah_barzel
{
    public abstract class Animal
    {
        protected bool mamals;

        protected bool carnivorous;

        protected int mood;

        public const int MOOD_HAPPY = 1;

        public const int MOOD_SCARE = 2;


        public Animal()
        {

        }
        public Animal(bool mamals, bool carnivorous, int mood)
        {
            this.mamals = mamals;
            this.carnivorous = carnivorous;

            if (mood == MOOD_HAPPY || mood == MOOD_SCARE)
            {
                this.mood = mood;
            }
        }
        public int GetMood()
        {
            return this.mood;
        }

        public virtual void SayHello() { }
        public abstract void SayHello(int mood);
        public bool IsMamals()
        {
            return mamals;
        }
        public bool IsCarnivorous()
        {
            return carnivorous;
        }

        /*public void SetMamals(bool mamals)
        {
            this.mamals = mamals;
        }
        */
        /*public void SetCarnivorous(bool carnivorous)
        {
            this.carnivorous = carnivorous;
        }
        */







    }
}
