using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleBehaviorTree.Nodes;

namespace ConsoleBehaviorTree
{
    public class BehaviorTree
    {
        public Node rootNode;
        public State state;
        public List<Node> nodes;

        public BehaviorTree()
        {
            rootNode = null;
            state = State.Running;
            nodes = new List<Node>();
        }

        public State Update()
        {
            if (rootNode.state == State.Running)
            {
                state = rootNode.Update();
            }
            return state;
        }

        public void AddNode(Node node, Node parent)
        {
            if (parent == null)
            {
                node.isRoot = true;
                nodes.Add(node);
                return;
            }

            node.parent = parent;

            if (parent.GetType() == typeof(CompositeNode))
            {
                ((CompositeNode)parent).AddChild(node);
            }
            else if (parent.GetType() == typeof(DecoratorNode))
            {
                ((DecoratorNode)parent).child = node;
            }

            nodes.Add(node);
        }
    }
}
