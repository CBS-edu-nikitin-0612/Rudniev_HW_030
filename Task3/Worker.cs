using System;

namespace Task3
{
    class Worker : Citizen
    {
        public override void Greeting()
        {
            Console.WriteLine("Hello boss!");
        }

        public Worker(int age, string seriesAndNumberOfPassport) : base(age, seriesAndNumberOfPassport) { }
    }
}
