using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }
    }
}
