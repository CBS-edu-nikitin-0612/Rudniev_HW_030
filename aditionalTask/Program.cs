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
            foreach (var el in array)
                Console.Write(el + " ");

            IEnumerable newArray = CreateCollectionOfPowOddNumber(array);
            Console.WriteLine("\nArray of pow odd numbers: ");
            foreach (var el in newArray)
                Console.Write(el + " ");
        }

        //static IEnumerable CreateCollectionOfPowOddNumber(int[] array)
        //{
        //    int position = -1;
        //    while (true)
        //    {
        //        if (position < array.Length - 1)
        //        {
        //            position++;
        //            if ((array[position] % 2) == 1)
        //                yield return (int)Math.Pow(array[position], 2);
        //        }
        //        else
        //            yield break;
        //    }
        //}

        //static IEnumerable CreateCollectionOfPowOddNumber(int[] array)
        //{
        //    for(int i = 0; i < array.Length; i++)
        //    {
        //        if ((array[i] % 2) == 1)
        //            yield return (int)Math.Pow(array[i], 2);
        //    }
        //    yield break;
        //}

        static IEnumerable CreateCollectionOfPowOddNumber(int[] array)
        {
            foreach (var item in array)
                if (item % 2 == 1)
                    yield return Math.Pow(item, 2);
            //yield break;
        }
    }
}
