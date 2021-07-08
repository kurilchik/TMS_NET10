using System;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            Three three = new Three();

            Node rootNode = three.CreateNode(Guid.NewGuid());
            three.AddNodes(rootNode);            

            while (three.NodesQueue.Count > 0)
            {
                Node tempNode = three.NodesQueue.Dequeue();
                three.AddNodes(tempNode);
            }
        }
    }
}
