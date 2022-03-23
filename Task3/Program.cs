using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create community collection...");
            var community = new Community()
            {
                new Student(18, "CT098234"),
                new Retiree(71, "GT223500"),
                new Student(20, "CT200400"),
                new Worker(30, "DE560244"),
                new Retiree(65, "FR430115"),
            };

            Console.WriteLine("\nCreated collection: ");
            foreach (object element in community)
                Console.WriteLine(element);

            Console.WriteLine("\n" + new string('-', 50));

            try
            {
                Console.WriteLine("Add new retiree in collection: ");
                Console.WriteLine("Added at index " + community.Add(new Retiree(68, "RE400600")));
                
                Console.WriteLine("Add available citizen in collection: ");
                Console.WriteLine("Added at index " + community.Add(new Student(18, "CT098234")));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            
            Console.WriteLine("\nReceived collection: ");
            foreach (object element in community)
                Console.WriteLine(element);

            Console.WriteLine("\n" + new string('-', 50));

            Console.WriteLine("Deleting citizen at passport 'CT098234': ");
            community.Remove(new Student(18, "CT098234"));
            Console.WriteLine("Deleting citizen at index 0: ");
            community.RemoveAt(0);

            Console.WriteLine("\nReceived collection: ");
            foreach (object element in community)
                Console.WriteLine(element);

            Console.WriteLine("\n" + new string('-', 50));

            Console.WriteLine("Contains citizen at passport 'FR430115'? ");
            Console.WriteLine("Its " + community.Contains(new Retiree(65, "FR430115")));
            Console.WriteLine("Index citizen at passport 'FR430115'? ");
            int index;
            community.Contains(new Retiree(65, "FR430115"), out index);
            Console.WriteLine("Index equal " + index);

            Console.WriteLine("\n" + new string('-', 50));

            Console.WriteLine("Return last citizen in collection: ");
            Console.WriteLine(community.ReturnLast(out index) + ", index equal " + index);

            Console.WriteLine("Clear collection...");
            community.Clear();
        }
    }
}
