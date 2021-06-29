using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }
    }
}
