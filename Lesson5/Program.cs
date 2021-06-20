using System;
using System.Collections.Generic;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList();
            MyArray();
        }

        static void MyList()
        {
            List<User> users = new List<User>();

            for (int i = 0; i < 5; i++)
            {
                users.Add(new User($"user{i + 1}"));
            }

            foreach (var item in users)
            {
                Console.WriteLine(item.Name);
            }

            foreach (var item in users)
            {
                item.Name = "changed!";
            }

            foreach (var item in users)
            {
                Console.WriteLine(item.Name);
            }

            users.RemoveAll(x => x.Name != null);
        }

        static void MyArray()
        {
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 100;
            }

            foreach (var item in arr)
            {
                Console.WriteLine($"changed: {item}");
            }
        }
    }
}
