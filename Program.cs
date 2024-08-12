namespace Object_Oriented_Assignment___leah_barzel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal dog = new Dog(true, true ,Animal.MOOD_HAPPY);
            Animal cat = new Cat(true, true,Animal.MOOD_SCARE);
            Animal frog = new Frog(false, false ,Animal.MOOD_HAPPY);

            Animal[] animals = { dog, cat, frog };

            foreach (Animal animal in animals)
            {
                Console.WriteLine("Animal Type: " + animal.GetType().Name);
                Console.WriteLine("Is mammal: " + animal.IsMamals());
                Console.WriteLine("Is carnivorous: " + animal.IsCarnivorous());
                Console.WriteLine("Number of legs: " + ((ILand)animal).GetNumberOfLegs());
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
            static ConsoleColor GetRandomConsoleColor()
            {
                var consoleColors = Enum.GetValues(typeof(ConsoleColor));
                return (ConsoleColor)consoleColors.GetValue(new Random().Next(consoleColors.Length));
            }
            
        }
    }
}