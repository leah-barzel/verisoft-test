namespace Object_Oriented_Assignment___leah_barzel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal dog = new Dog(true, true, 1);
            Animal cat = new Cat(true, true,2);
            Animal frog = new Frog(false, false,2);

            Animal[] animals = { dog, cat, frog };

            foreach (Animal animal in animals)
            {
                Console.WriteLine("Animal Type: " + animal.GetType().Name);
                Console.WriteLine("Is mammal: " + animal.IsMamals());
                Console.WriteLine("Is carnivorous: " + animal.IsCarnivorous());
                Console.WriteLine("Number of legs: " + ((ILand)animal).GetNumberOfLegs());
                if (animal.GetType().Name != "Frog")
                {
                    Console.Write("greet people by: "); animal.SayHello();
                }
                Console.Write("Say hello becoause it mood: "); animal.SayHello(animal.mood);

                if (animal is IWater waterAnimal)
                {
                    Console.WriteLine("Has gills: " + waterAnimal.HasGills());
                    Console.WriteLine("Lays eggs: " + waterAnimal.HasLaysEggs());
                }

                //Console.WriteLine("Current Mood: " + animal.SayHello());
                if(animal.GetType().Name != "Frog")
                    Console.Write("greet people by: "); animal.SayHello();
                
                animal.SayHello(animal.mood);
                Console.WriteLine( dog.mood);
                Console.WriteLine();
            }
        }
    }
}