using System;

namespace Lesson9
{
    public class Dog : Mammal
    {
        public override int Weight { get; set; }


        public Dog() : base(1)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Собаки перемещаются на 4-х ногах.");
        }
        public override bool Beat(Entity entity)
        {
            base.Beat(entity);
            Console.WriteLine("Собаки кусаются");
            return true;
        }
    }
}
