using System;

namespace Task3
{
    class Student : Citizen
    {
        public override void Greeting()
        {
            Console.WriteLine("Hello teacher!");
        }

        public Student(int age, string seriesAndNumberOfPassport) : base(age, seriesAndNumberOfPassport) { }
    }
}
