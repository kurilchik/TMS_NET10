using System;

namespace Lesson9
{
    public class Spider : Arthropod
    {
        public override int Weight { get; set; }
        public override bool ToxicToHumans { get; set; }

        public Spider(int age) : base(age, 6, true)
        {

        }        

        public override void Move()
        {
            Console.WriteLine("Пауки перемещаются на 8-ми ногах.");
            Breathe();
        }

        protected override void Breathe()
        {
            base.Breathe();
            Console.WriteLine("Пауки тоже.");
        }

        public override void Live()
        {
            Console.WriteLine("Пауки живут везде.");
        }
    }
}
