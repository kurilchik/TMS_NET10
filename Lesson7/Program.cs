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
            char[] arr = new char[] { 'A', 'a', (char)90, '\u005A', '1', '.', '\u2192' };

            foreach (var item in arr)
            {
                Console.WriteLine($"{item} is number: {char.IsNumber(item)}");
                Console.WriteLine($"{item} is upper: {char.IsUpper(item)}");
                Console.WriteLine($"{item} to upper: {char.ToUpper(item)}");
                Console.WriteLine($"{item} to lower: {char.ToLower(item)}\n");
            }
        }

        static void MyString()
        {
            char[] arr = new char[] { 'I', 'c', 'h', ' ', 'w', 'i', 'l', 'l' };
            string str1 = new string(arr);

            Console.WriteLine("Substring str1: {0}", str1.Substring(str1.IndexOf(' ') + 1));

            Console.WriteLine($"\"{str1}\" is null or empty: {string.IsNullOrEmpty(str1)}");
            Console.WriteLine(@$"\{str1}\ index of \l\: {str1.IndexOf('l')}");
            Console.WriteLine($"\\{str1}\\ last index of \\l\\: {str1.LastIndexOf('l')}\n");

            foreach (var item in str1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            StringBuilder sb = new StringBuilder(str1);
            sb.Append(" dass ihr mir vertraut\n");
            sb.Append("Ich will dass ihr mir glaubt\n");

            string str2 = sb.ToString();
            string str3 = str2.ToLower();

            Console.WriteLine($"{str2} ==\n{str3}: {str2 == str3}\n");
            Console.WriteLine($"{str2} equals\n{str3}: {str2.Equals(str3, StringComparison.InvariantCultureIgnoreCase)}\n");
        }
    }
}
