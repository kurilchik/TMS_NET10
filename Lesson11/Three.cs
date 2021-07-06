using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public class Three
    {
        public Node CreateNode(int id)
        {
            return new Node(id);
        }

        public void SetNodes(Node node, int range)
        {
            Random random = new Random();

            for (int i = 0; i < range; i++)
            {
                var newNode = CreateNode(random.Next());
                node.Nodes.Add(newNode);
            }
        }

        public void SetLevel(Node node, int level)
        {
            Random random = new Random();

            for (int i = 0; i < level; i++)
            {
                var newNode = CreateNode(random.Next());
                node.Nodes.Add(newNode);
            }
        }
    }
}
