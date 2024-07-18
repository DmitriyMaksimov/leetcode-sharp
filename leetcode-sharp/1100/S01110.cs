namespace leetcode_sharp;

// 1110. Delete Nodes And Return Forest
// https://leetcode.com/problems/delete-nodes-and-return-forest
public class S01110
{
    private HashSet<int> _toDeleteSet;
    private List<TreeNode> _result;

    public IList<TreeNode> DelNodes(TreeNode? root, int[] toDelete)
    {
        _toDeleteSet = toDelete.ToHashSet();
        _result = new List<TreeNode>();

        Helper(root, true);

        return _result;
    }

    private TreeNode? Helper(TreeNode? node, bool isRoot)
    {
        if (node == null)
        {
            return null;
        }

        var deleted = _toDeleteSet.Contains(node.val);
        
        if (isRoot && !deleted)
        {
            _result.Add(node);
        }

        node.left = Helper(node.left, deleted);
        node.right = Helper(node.right, deleted);
        
        return deleted ? null : node;
    }
}