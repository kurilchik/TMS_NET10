using System;
using System.Collections.Generic;

namespace Lesson11
{
    public class Tree
    {
        private Queue<Node> _nodesQueue = new Queue<Node>();

        public void CreateTree(Node node)
        {
            _nodesQueue.Enqueue(node);

            while (_nodesQueue.Count > 0)
            {
                Node tempNode = _nodesQueue.Dequeue();

                SetNodes(tempNode);
                PrintNode(tempNode);
                QueueNode(tempNode);
            }
        }

        private void SetNodes(Node node)
        {
            Console.WriteLine($"Enter the required number of nodes for {node.Id}:");
            int amountNodes = int.Parse(Console.ReadLine());

            for (int i = 0; i < amountNodes; i++)
            {
                Node newNode = new Node(Guid.NewGuid());
                node.Nodes.Add(newNode);
            }
        }

        private void PrintNode(Node node)
        {
            Console.WriteLine($"{node.Id}:");
            foreach (var item in node.Nodes)
            {
                Console.WriteLine($"- {item.Id}");
            }
            Console.WriteLine(string.Empty);
        }

        private void QueueNode(Node node)
        {
            foreach (var item in node.Nodes)
            {
                _nodesQueue.Enqueue(item);
            }
        }
    }
}
