using System;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            Three three = new Three();

            Node node = new Node(Guid.NewGuid());
            three.CreateTree(node);            
        }
    }
}
