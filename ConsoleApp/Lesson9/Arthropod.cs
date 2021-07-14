namespace Lesson9
{
    public abstract class Arthropod : Entity
    {
        public abstract bool ToxicToHumans { get; set; }
        public int PairsLimbs { get; }

        protected Arthropod(int age, int pairsLimbs, bool toxicToHumans) : base(age)
        {
            PairsLimbs = pairsLimbs;
            ToxicToHumans = toxicToHumans;
        }

        public abstract void Live();
    }
}
