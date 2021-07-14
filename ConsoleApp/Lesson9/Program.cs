using System;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human(31);
            human.Move();
            human.Beat(new Dog());
            Console.WriteLine($"{nameof(human)} {nameof(human.Age)}: {human.Age}");
            Console.WriteLine(string.Empty);

            Dog dog = new Dog();
            dog.Move();
            dog.Beat(human);
            Console.WriteLine($"{nameof(dog)} {nameof(dog.Age)}: {dog.Age}");
            Console.WriteLine(string.Empty);

            Mammal mammal = dog;
            mammal.Move();
            mammal.Beat(human);
            Console.WriteLine($"{nameof(mammal)} {nameof(mammal.Age)}: {mammal.Age}");
            Console.WriteLine(string.Empty);

            Spider spider = new Spider(12);
            spider.Move();
            spider.Live();
            Console.WriteLine($"Пауки опасны для человека: {spider.ToxicToHumans}");
            Console.WriteLine($"{nameof(spider)} {nameof(spider.Age)}: {spider.Age}");
            Console.WriteLine($"{nameof(spider.PairsLimbs)}: {spider.PairsLimbs}");            
            Console.WriteLine();

            Scorpion scorpion = new Scorpion();
            scorpion.Move();
            scorpion.Live();
            Console.WriteLine($"Скорпионы опасны для человека: {scorpion.ToxicToHumans}");
            Console.WriteLine($"{nameof(scorpion)} {nameof(scorpion.Age)}: {scorpion.Age}");
            Console.WriteLine($"{nameof(scorpion.PairsLimbs)}: {scorpion.PairsLimbs}");
            Console.WriteLine();

            Arthropod arthropod = scorpion;
            arthropod.Move();
            arthropod.Live();
            Console.WriteLine($"{nameof(arthropod)} {nameof(arthropod.Age)} {arthropod.Age}");
            Console.WriteLine($"{nameof(arthropod.PairsLimbs)}: {arthropod.PairsLimbs}");
            Console.WriteLine($"{nameof(arthropod.ToxicToHumans)}: {arthropod.ToxicToHumans}");

            Console.ReadKey();
        }
    }
}
