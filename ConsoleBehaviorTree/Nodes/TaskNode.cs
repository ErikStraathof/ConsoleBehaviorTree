using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBehaviorTree.Nodes
{
    public abstract class TaskNode : Node
    {
        protected string nodeName;

        public TaskNode(string name)
        {
            nodeName = name;
        }
    }
}
