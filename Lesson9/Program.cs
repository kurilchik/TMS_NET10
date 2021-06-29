using System;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human(31);
            Dog dog = new Dog();

            human.Move();

            Mammal mammal = dog;
            mammal.Move();
            mammal.Beat(human);
            Console.WriteLine(human.Age);
            Console.WriteLine(mammal.Age);

            Console.ReadKey();
        }
    }
}
