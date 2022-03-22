using System;
using System.Collections;

namespace aditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var userCollection = new UserCollection();

            Console.WriteLine("Random array of int numbers: ");
            for (int i = 0; i < userCollection.Count; i++)
                Console.Write(userCollection[i] + " ");

            Console.WriteLine("Random array of int numbers: ");
            foreach (int el in UserCollection)
                Console.Write(el + " ");
        }

        
    }
}
