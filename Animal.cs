using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Assignment___leah_barzel
{
    public abstract class Animal
    {
        protected bool mamals { get; set; }

        protected bool carnivorous { get; set; }
        
        public const int MOOD_HAPPY =  1 ;
        
        public const int MOOD_SCARE = 2 ;
        
        protected int mood;

        public int GetMood()
        {
            return mood;
        }

        public Animal()
        {

        }
        public Animal(bool mamals, bool carnivorous, int mood)
        {
            this.mamals = mamals;
            this.carnivorous = carnivorous;
            this.mood = mood;
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

        //public void SetMamals(bool mamals) { }
        
        //public  void SetCarnivorous(bool carnivorous) { }

        






    }
}
