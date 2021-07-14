using System;

namespace Lesson9
{
    public abstract class Mammal : Entity
    {
        public virtual int LungsSize { get; set; }

        protected Mammal(int age) : base(age)
        {
        }

        protected override void Breathe()
        {
            base.Breathe();
            Console.WriteLine("Млекопитающие используют легкие.");
        }
        public virtual bool Beat(Entity entity)
        {
            Console.WriteLine("Млекапитающие не кусаются");
            return false;
        }
    }
}
