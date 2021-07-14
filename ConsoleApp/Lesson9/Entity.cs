using System;

namespace Lesson9
{
    public abstract class Entity
    {
        public abstract int Weight { get;  set; }
        public int Age { get; }

        protected Entity(int age)
        {
            Age = age;
        }

        public abstract void Move();
        protected virtual void Breathe()
        {
            Console.WriteLine("Сущности дышат.");
        }
    }
}
