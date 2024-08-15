namespace leah_barzel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog(true, true, 2);
            Animal cat = new Cat(true, true, 1);
            Animal frog = new Frog(false, false, 2);

            Animal[] animals = { dog, cat, frog };

            foreach (Animal animal in animals)
            {
                Console.WriteLine("Animal Type: " + animal.GetType().Name);
                Console.WriteLine("Is mammal: " + animal.IsMamals());
                Console.WriteLine("Is carnivorous: " + animal.IsCarnivorous());

                if (animal is ILand landAnimal)
                {
                    Console.WriteLine("Number of legs: " + landAnimal.GetNumberOfLegs());
                }

                animal.SayHello();

                Console.Write("Hello according to the mood: ");
                animal.SayHello(animal.GetMood());

                if (animal is IWater waterAnimal)
                {
                    Console.WriteLine("Has gills: " + waterAnimal.HasGills());
                    Console.WriteLine("Lays eggs: " + waterAnimal.HasLaysEggs());
                }

                Console.WriteLine();
            }
        }
    }
}