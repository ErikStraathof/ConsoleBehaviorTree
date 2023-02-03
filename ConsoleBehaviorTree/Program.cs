using ConsoleBehaviorTree.Nodes;

namespace ConsoleBehaviorTree
{
	class Program
	{
        public static void Main(String[] args)
        {
            BehaviorTree behaviorTree = new BehaviorTree();
            
            Node root = new SequenceNode();
            behaviorTree.rootNode = root;
            behaviorTree.AddNode(root, null);

            Node firstMessage = new DebugNode("Debug 1", "Hi this is debug node 1");
            ((SequenceNode)root).AddChild(firstMessage);

            Node cooldown = new CooldownNode("Cooldown 1", 1f);
            ((SequenceNode)root).AddChild(cooldown);

            Node secondMessage = new DebugNode("Debug 2", "Hi this is debug node 2");
            ((SequenceNode)root).AddChild(secondMessage);

            while (behaviorTree.state == State.Running)
            {
                behaviorTree.state = behaviorTree.Update();
            }
        }
    }
}