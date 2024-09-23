namespace leetcode_sharp;

// 919. Complete Binary Tree Inserter
// https://leetcode.com/problems/complete-binary-tree-inserter
public class S00919
{
    public class CBTInserter
    {
        private readonly List<TreeNode> _tree = [];

        public CBTInserter(TreeNode root)
        {
            _tree.Add(root);
            for (var i = 0; i < _tree.Count; ++i)
            {
                if (_tree[i].left != null)
                {
                    _tree.Add(_tree[i].left!);
                }

                if (_tree[i].right != null)
                {
                    _tree.Add(_tree[i].right!);
                }
            }
        }

        public int Insert(int val)
        {
            var count = _tree.Count;

            var node = new TreeNode(val);
            _tree.Add(node);

            if (count % 2 == 1)
            {
                _tree[(count - 1) / 2].left = node;
            }
            else
            {
                _tree[(count - 1) / 2].right = node;
            }

            return _tree[(count - 1) / 2].val;
        }

        public TreeNode Get_root()
        {
            return _tree.First();
        }
    }
}
