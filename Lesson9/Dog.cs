using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    public class Dog : Mammal
    {
        public override int Weight { get; set; }


        protected Dog() : base(1)
        {
        }

        public override void Move()
        {
            // move like Jager
        }
        public override bool Beat(Entity entity)
        {
            base.Beat(entity);
            Console.WriteLine("Сабаки кусаются");
            return true;
        }
    }
}
