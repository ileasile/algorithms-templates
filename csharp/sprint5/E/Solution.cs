#if REMOTE_JUDGE
#else
public class Node
{
    public int Value;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}
#endif

public class Solution
{
    public static bool Solve(Node root)
    {
        // Your code
        // “ヽ(´▽｀)ノ”
    }

    private static void Test()
    {
        var node1 = new Node(1);
        var node2 = new Node(4);
        var node3 = new Node(3)
        {
            Left = node1,
            Right = node2
        };
        var node4 = new Node(8);
        var node5 = new Node(5)
        {
            Left = node3,
            Right = node4
        };
        Console.WriteLine(Solve(node5));
        node2.Value = 5;
        Console.WriteLine(Solve(node5));
    }
}
