using HW.Interface.Enums;
using HW.Interface.Interfaces;

namespace HW.Interface
{
    public class Person : IHuman
    {
        public Gender Sex { get; }

        public int BabyGender { get; }

        public Person(Gender gender, int babyGender)
        {
            Sex = gender;
            BabyGender = babyGender;
        }

        public Person Reproduction(Person man, Person woman)
        {
            return man.BabyGender > woman.BabyGender ? new Person(man.Sex, woman.BabyGender) : new Person(woman.Sex, man.BabyGender);
        }
    }
}
