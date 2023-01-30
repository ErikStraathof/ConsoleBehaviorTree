using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBehaviorTree.Nodes
{
    public abstract class DecoratorNode : Node
    {
        public Node child;

        public DecoratorNode()
        {
            child = null;
        }
    }
}
