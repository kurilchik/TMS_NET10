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

        public Gender Reproduction(int manBabyGender, int womanBabyGender)
        {
            return manBabyGender >= womanBabyGender ? Gender.Man : Gender.Woman;
        }
    }
}
