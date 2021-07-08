using System;
using System.Collections.Generic;

namespace Lesson11
{
    public class Three
    {
        public Queue<Node> NodesQueue { get; set; }

        public Three()
        {
            NodesQueue = new Queue<Node>();
        }

        public Node CreateNode(Guid id)
        {
            return new Node(id);
        }

        public void AddNodes(Node node)
        {
            SetNodes(node);
            PrintNode(node);
            QueueNode(node);
        }

        private void SetNodes(Node node)
        {
            Console.WriteLine($"Enter the required number of nodes for {node.Id}:");
            int amountNodes = int.Parse(Console.ReadLine());

            for (int i = 0; i < amountNodes; i++)
            {
                var newNode = CreateNode(Guid.NewGuid());
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
                NodesQueue.Enqueue(item);
            }
        }
    }
}
