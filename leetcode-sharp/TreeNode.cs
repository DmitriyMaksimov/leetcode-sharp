namespace leetcode_sharp;

public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    // Parse from string representation, for example "[1,2,3]"
    public static TreeNode? Parse(string str)
    {
        str = str.Trim();
        if (!str.StartsWith("[")) throw new ArgumentException("Should start with '['", nameof(str));
        if (!str.EndsWith("]")) throw new ArgumentException("Should end with ']'", nameof(str));

        str = str.Replace(" ", "");

        var enumerable = str[1..][..^1].Split(',').Select(x => int.TryParse(x, out var n) ? n : default(int?));

        return Parse(enumerable);
    }

    public static TreeNode? Parse(IEnumerable<int?> values)
    {
        TreeNode? root = null;
        var isRoot = true;
        var queue = new Queue<(TreeNode? node, bool leftChild)>();

        TreeNode? parentNode = null;
        var leftChild = false;

        foreach (var value in values)
        {
            if (queue.Any())
            {
                // If the queue is non-empty, parent nodes have been processed, so we're not currently processing the root
                (parentNode, leftChild) = queue.Dequeue();
                isRoot = false;
            }

            if (value == null) continue;

            var node = new TreeNode((int) value);
            queue.Enqueue((node, true));
            queue.Enqueue((node, false));

            if (isRoot)
            {
                root = node;
            }
            else
            {
                if (leftChild)
                {
                    parentNode.left = node;
                }
                else
                {
                    parentNode.right = node;
                }
            }
        }

        return root;
    }

    public static void Print(TreeNode? root)
    {
        var levels = listOfLevels(root).Reverse();
        var lines = new List<string>();
        var currentLevelPositions = new List<int>();
        TreeNode?[] previousLevel = null;
        int[]? previousLevelPositions = null;

        foreach (var level in levels)
        {
            var line = "";
            if (previousLevel == null)
            {
                // Deepest level of tree
                foreach (var node in level)
                {
                    var val = node != null ? node.val.ToString() : " ";

                    // midpoint of string representation of val
                    var valMidpoint = val.Length / 2;
                    if (line.Any())
                    {
                        line += "   ";
                    }
                    
                    // Absolute position of the node, with string centered
                    var nodePos = valMidpoint + line.Length;

                    line += val;

                    currentLevelPositions.Add(nodePos);
                }
            }
            else
            {
                // These nodes have children
                var i = 0;
                foreach (var node in level)
                {
                    var val = node != null ? node.val.ToString() : " ";

                    // midpoint of string representation of val
                    var valMidpoint = val.Length / 2;

                    var leftChild = previousLevel[i * 2];
                    var rightChild = previousLevel[i * 2 + 1];
                    var leftChildPos = previousLevelPositions[i * 2];
                    var rightChildPos = previousLevelPositions[i * 2 + 1];
                    
                    // Set position of parent as midpoint of the children's positions

                    var nodePos = (leftChildPos + rightChildPos) / 2;

                    while (line.Length <= leftChildPos)
                    {
                        line += " ";
                    }

                    while (line.Length < nodePos - valMidpoint)
                    {
                        line += leftChild == null ? " " : "_";
                    }

                    line += val;

                    while (line.Length < rightChildPos)
                    {
                        line += rightChild == null ? " " : "_";
                    }

                    currentLevelPositions.Add(nodePos);

                    ++i;
                }
            }
            
            lines.Add(line);
            previousLevel = level.ToArray();
            previousLevelPositions = currentLevelPositions.ToArray();
            currentLevelPositions = new List<int>();
        }

        lines.Reverse();
        
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
    }
    
    private static IEnumerable<IEnumerable<TreeNode?>> listOfLevels(TreeNode? root)
    {
        var currentLevel = new List<TreeNode?> {root};
        var nextLevel = new List<TreeNode?>();
        var levels = new List<List<TreeNode?>> {currentLevel};

        while (true)
        {
            foreach (var node in currentLevel)
            {
                if (node != null)
                {
                    nextLevel.Add(node.left);
                    nextLevel.Add(node.right);
                }
                else
                {
                    nextLevel.Add(null);
                    nextLevel.Add(null);
                }
            }

            if (nextLevel.Any(x => x != null))
            {
                levels.Add(nextLevel);
                currentLevel = nextLevel;
                nextLevel = new List<TreeNode?>();
            }
            else
            {
                break;
            }
        }

        return levels;
    }
}