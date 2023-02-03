using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBehaviorTree.Nodes
{
    public class SequenceNode : CompositeNode
    {
        private int current;

        protected override void Enter()
        {
            current = 0;
        }

        protected override State Execute()
        {
            Node child = children[current];
            switch (child.Update())
            {
                case State.Running:
                    return State.Running;
                case State.Failed:
                    return State.Failed;
                case State.Success:
                    current++;
                    break;
            }

            if (current > children.Count - 1)
            {
                return State.Success;
            }
            return State.Running;
        }

        protected override void Exit()
        {
            Console.WriteLine("Exiting sequence Node");
        }
    }
}
