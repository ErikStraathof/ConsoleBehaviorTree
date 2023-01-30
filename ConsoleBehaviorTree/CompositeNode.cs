using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBehaviorTree
{
    public abstract class CompositeNode : Node
    {
        public List<Node> children;

        public CompositeNode()
        {
            children = new List<Node>();
        }
    }
}
