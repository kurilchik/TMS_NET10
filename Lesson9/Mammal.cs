using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    public abstract class Mammal : Entity
    {
        public virtual int LungsSize { get; set; }

        //protected Mammal() : this(1)
        //{
        //}

        protected Mammal(int age) : base(age)
        {
        }

        protected override void Breathe()
        {
            base.Breathe();
            // using lungs
        }
        public virtual bool Beat(Entity entity)
        {
            Console.WriteLine("Млекапитающие не кусаются");
            return false;
        }
    }
}
