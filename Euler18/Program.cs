namespace Euler18;
public class Program {
    static string pyramide=@"75
95 64
17 47 82
18 35 87 10
20 04 82 47 65
19 01 23 75 03 34
88 02 77 73 07 63 67
99 65 04 28 06 16 70 92
41 41 26 56 83 40 80 70 33
41 48 72 33 47 32 37 16 94 29
53 71 44 65 25 43 91 52 97 51 14
70 11 33 28 77 73 17 78 39 68 17 57
91 71 52 38 17 14 91 43 58 50 27 29 48
63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";

    public static void Main(string[] args) {
        Node[] nodes = ParseNodes(pyramide);
        Node root = ParseBinaryTree(nodes);
        Console.WriteLine(MaxSum(root, new Dictionary<Node, int>()));
    }

    static Node[] ParseNodes(string pyramide) {
        List<Node> nodes = new List<Node>();
        string[] lines = pyramide.Split("\r");
        foreach(string s in lines) {
            string[] nums = s.Split(" ");
            foreach(string t in nums) {
                nodes.Add(new Node(Convert.ToInt32(t)));
            }
        }
        return nodes.ToArray();
    }

    static Node ParseBinaryTree(Node[] nodes) {
        int level = 0;
        int number = 0;
        int ret = 0;
        for(int i = 0; i < nodes.Length; i++) {
            if(2 * i + 1 - ret < nodes.Length)
                nodes[i].Left = nodes[2 * i + 1 - ret];

            if(2 * i + 2 - ret < nodes.Length)
                nodes[i].Right = nodes[2 * i + 2 - ret];

            if(number == level) {
                level++;
                number = 0;
            } else {
                number++;
                ret++;
            }
        }
        return nodes[0];
    }

    static int MaxSum(Node? node, Dictionary<Node, int> dict) {
        if(node == null)
            return 0;

        int sum;
        if(!dict.TryGetValue(node, out sum)) {
            sum = Math.Max(MaxSum(node.Left, dict), MaxSum(node.Right, dict)) + node.Value;
            dict.Add(node, sum);
        }

        return sum;
    }
}

public class Node {
    public int Value {get; set;}
    public (Node?, Node?) Parents {get; set;}
    public Node? Left {get; set;}
    public Node? Right {get; set;}

    public Node(int value) {
        Value = value;
    }
}
