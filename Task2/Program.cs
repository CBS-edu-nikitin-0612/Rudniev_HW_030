using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MonthCollection monthCollection = new MonthCollection();

            Console.WriteLine("Collection of month: ");
            for (int i = 0; i < monthCollection.Count; i++)
            {
                Console.WriteLine($"mounth {i}: {monthCollection[i].ToString()}");
            }

            Console.WriteLine(new string('-', 60));

            Console.WriteLine("Collection of month with amount of days equal 31: ");
            foreach (Month el in monthCollection.CreateCollectionMonthsWithSameAmountOfDays(31))
            {
                Console.WriteLine(el.ToString());
            }
        }
    }
}
