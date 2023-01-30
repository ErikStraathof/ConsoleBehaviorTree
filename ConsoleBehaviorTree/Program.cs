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



            while (behaviorTree.state == State.Running)
            {
                behaviorTree.state = behaviorTree.Update();
            }
        }
    }
}