using HW.Interface.Enums;

namespace HW.Interface.Interfaces
{
    public interface IHuman
    {
        public Gender Sex { get; }

        public int BabyGender { get; }

        public Person Reproduction(Person man, Person woman);
    }
}
