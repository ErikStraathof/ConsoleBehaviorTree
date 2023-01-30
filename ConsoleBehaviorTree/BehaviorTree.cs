using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleBehaviorTree
{
    public class BehaviorTree
    {
        public Node rootNode;
        public State state;

        public BehaviorTree(Node root)
        {
            rootNode = root;
        }

        public State Update()
        {
            if (rootNode.state == State.Running)
            {
                state = rootNode.Update();
            }
            return state;
        }
    }
}
