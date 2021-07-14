using System;

namespace Lesson9
{
    public class Scorpion : Arthropod
    {
        public override int Weight { get; set; }
        public override bool ToxicToHumans { get; set; }

        public Scorpion() : this(1, 5, false)
        {

        }

        public Scorpion(int age, int pairsLimbs, bool toxicToHumans) : base(age, pairsLimbs, toxicToHumans)
        {

        }

        public override void Move()
        {
           
        }

        public override void Live()
        {
            Console.WriteLine("Скоррионы живут на земле.");
        }
    }
}
