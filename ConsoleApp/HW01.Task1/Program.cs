using System;

namespace HW01.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                number = UserInput();
                switch (number)
                {
                    case 0:
                        Console.WriteLine(1);
                        break;
                    case 1:
                        Console.WriteLine('A');
                        break;
                    case 2:
                        Console.WriteLine('I');
                        break;
                    default:
                        Console.WriteLine("See you soon!");
                        break;
                }
            } while (number != 3);
        }

        static int UserInput()
        {
            Console.WriteLine("Please enter a number between 0 and 3:");
            return int.TryParse(Console.ReadLine(), out int number) && number >= 0 && number < 4 ? number : UserInput();
        }
    }
}
