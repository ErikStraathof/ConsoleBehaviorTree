using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBehaviorTree.Nodes
{
    public abstract class CompositeNode : Node
    {
        public List<Node> children { get; private set; }

        public CompositeNode()
        {
            children = new List<Node>();
        }

        public void AddChild(Node node)
        {
            children.Add(node);
        }
    }
}
