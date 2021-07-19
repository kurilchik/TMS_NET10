using System;

namespace HW14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(100);
            acc.Notify += DisplayMessage;
            acc.Put(20);
            acc.Take(70);
            acc.Take(150);
            Console.Read();
        }
        private static void DisplayMessage(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"Сумма транзакции: {e.Sum}");
            Console.WriteLine(e.Message);
        }
    }
}
