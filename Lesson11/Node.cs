using System;
using System.Collections.Generic;

namespace Lesson11
{
    public class Node
    {
        public Guid Id { get; }
        public List<Node> Nodes { get; set; }

        public Node(Guid id)
        {
            Id = id;
            Nodes = new List<Node>();
        }
    }
}
