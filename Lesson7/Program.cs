using System;
using System.Text;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            MyChar();
            MyString();
        }

        static void MyChar()
        {
            char[] items = new char[] { 'A', 'a', (char)90, '\u005A', '1', '.', '\u2192' };

            foreach (var item in items)
            {
                Console.WriteLine($"{item} is number: {char.IsNumber(item)}");
                Console.WriteLine($"{item} is upper: {char.IsUpper(item)}");
                Console.WriteLine($"{item} to upper: {char.ToUpper(item)}");
                Console.WriteLine();
            }
        }

        static void MyString()
        {
            string str1 = "Ich will";

            Console.WriteLine(string.IsNullOrEmpty(str1));

            foreach (var item in str1)
            {
                Console.WriteLine(item);
            }

            StringBuilder sb = new StringBuilder(str1);
            sb.Append(" dass ihr mir vertraut\n");
            sb.Append("Ich will dass ihr mir glaubt\n");

            string str2 = sb.ToString();
            string str3 = str2.ToLower();

            Console.WriteLine($"str2 == str3: {str2 == str3}");
            Console.WriteLine($"str2 equals str3: {str2.Equals(str3, StringComparison.InvariantCultureIgnoreCase)}");
        }
    }
}
