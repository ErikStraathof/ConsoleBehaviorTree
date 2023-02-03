using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBehaviorTree.Nodes
{
    public class CooldownNode : TaskNode
    {
        public float cooldown;
        private DateTime startTime;

        public CooldownNode(string name, float cooldown) : base(name)
        {
            this.cooldown = cooldown;
        }

        protected override void Enter()
        {
            startTime = DateTime.Now;
        }

        protected override State Execute()
        {
            float secondsLeft = DateTime.Now.Second - startTime.Second;
            if (secondsLeft > cooldown)
            {
                Console.WriteLine();
                state = State.Success;
            }
            return state;
        }

        protected override void Exit()
        {
            Console.WriteLine("Ended Cooldown");
        }
    }
}
