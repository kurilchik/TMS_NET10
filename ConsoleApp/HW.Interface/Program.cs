using HW.Interface.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HW.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<Person> men = Enumerable.Range(1, 20).Select(x => new Person(Gender.Man, random.Next())).ToList();
            List<Person> women = Enumerable.Range(1, 20).Select(x => new Person(Gender.Woman, random.Next())).ToList();

            List<Person> children = new List<Person>();
            for (int i = 0; i < men.Count; i++)
            {
                children.Add(new Person(men[i].Reproduction(men[i].BabyGender, women[i].BabyGender), random.Next()));
            }

            foreach (var item in children)
            {
                Console.WriteLine(item.Sex);
            }
        }
    }
}
