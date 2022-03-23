using System;
using System.Collections;

namespace aditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(0, 9);

            Console.WriteLine("Random array of int numbers: ");
            foreach (int el in array)
                Console.Write(el + " ");

            IEnumerable newArray = CreateCollectionOfPowOddNumber(array);
            Console.WriteLine("\nArray of pow odd numbers: ");
            foreach (int el in newArray)
                Console.Write(el + " ");
        }

        static IEnumerable CreateCollectionOfPowOddNumber(int[] array)
        {
            int position = -1;
            while (true)
            {
                if (position < array.Length - 1)
                {
                    position++;
                    if ((array[position] % 2) == 1)
                        yield return (int)Math.Pow(array[position], 2);
                }
                else
                    yield break;
            }
        }
    }
}
