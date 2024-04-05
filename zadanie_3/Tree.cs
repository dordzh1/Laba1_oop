
namespace zadanie_3
{
    internal class Tree
    {
        public int Quantity { get; }
        public List<Tree> Children { get;}
        public Tree(int quantity)
        {
            Quantity = quantity;
            Children = new List<Tree>();
        }
        public void AddChild(Tree child)
        {
            Children.Add(child);
        }
        public void PrintChildrenQuantity()
        {
            Console.WriteLine($"Children of node {Quantity}");
            foreach (var child in Children)
            {
                Console.Write($"{child.Quantity} ");
            }
            Console.WriteLine();

            foreach (var child in Children)
            {
                child.PrintChildrenQuantity();
            }
        }
    }
}
