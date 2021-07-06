using System;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Three three = new Three();

            Node node = three.CreateNode(random.Next());

        }
    }
}
