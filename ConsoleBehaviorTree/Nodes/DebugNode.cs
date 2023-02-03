using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBehaviorTree.Nodes
{
    public class DebugNode : TaskNode
    {
        string message;

        public DebugNode(string name, string message) : base(name)
        {
            this.message = message;
        }

        protected override void Enter()
        {
            Console.WriteLine("Enter debug node: " + nodeName); 
        }

        protected override State Execute()
        {
            Console.WriteLine(message);
            return State.Success;
        }

        protected override void Exit()
        {
            Console.WriteLine("Exit debug node: " + nodeName);
        }
    }
}
