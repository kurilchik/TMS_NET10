using System.Collections.Generic;

namespace Lesson11
{
    public class Node
    {
        public int Id { get; }
        public List<Node> Nodes { get; set; }

        public Node(int id)
        {
            Id = id;
        }
    }
}
