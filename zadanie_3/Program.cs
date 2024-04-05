using System;
using zadanie_3;
class Program
{
    static void Main(string[] args)
    {
        Tree root = new Tree(1);
        Tree child1 = new Tree(2);
        Tree child2 = new Tree(3);
        Tree grandchild1 = new Tree(4);
        Tree grandchild2 = new Tree(5);

        root.AddChild(child1);
        root.AddChild(child2);
        child1.AddChild(grandchild1);
        child1.AddChild(grandchild2);

        root.PrintChildrenQuantity();

    }
}
