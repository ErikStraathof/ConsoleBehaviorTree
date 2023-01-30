﻿namespace ConsoleBehaviorTree
{
    public abstract class Node
    {
        protected bool started;
        public State state;
        public Node parent;

        public Node() 
        { 
            started = false;
            state = State.Running;
            parent = null;
        }

        public State Update()
        {
            if (!started)
            {
                Enter();
                started = true;
            }

            state = Execute();

            if (state == State.Success)
            {
                Exit();
            }
            return state;
        }

        protected abstract void Enter();
        protected abstract State Execute();
        protected abstract void Exit();
    }
}
