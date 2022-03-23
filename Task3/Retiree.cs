using System;

namespace Task3
{
    class Retiree : Citizen
    {
        public override void Greeting()
        {
            Console.WriteLine("Hello kailyard!");
        }

        public Retiree(int age, string seriesAndNumberOfPassport) : base(age, seriesAndNumberOfPassport) { }
    }
}
