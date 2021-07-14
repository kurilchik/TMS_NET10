using System;

namespace Lesson9
{
    public class Human : Mammal
    {
        public Human(int age) : base(age)
        {
        }

        public override int Weight { get ; set ; }

        public override void Move()
        {
            Console.WriteLine("Люди перемещаются на двух ногах.");
        }
    }
}
