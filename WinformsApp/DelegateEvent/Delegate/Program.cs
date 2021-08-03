using System;

namespace Delegate
{
    class Program
    {
        delegate void Message();

        static void Main(string[] args)
        {
            Message message = Hello;
            message -= Hello;
            message += Hello;            
            message += HowAreYou;
            message += Goodbye;
            message?.Invoke();
            Console.Read();
        }

        private static void Hello()
        {
            Console.WriteLine("Hello");
        }
        private static void HowAreYou()
        {
            Console.WriteLine("How are you?");
        }
        private static void Goodbye()
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
