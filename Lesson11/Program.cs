using System;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            Node node = new Node(Guid.NewGuid());
            tree.CreateTree(node);            
        }
    }
}
