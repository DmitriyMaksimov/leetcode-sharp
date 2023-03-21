namespace leetcode_sharp;

// 109. Convert Sorted List to Binary Search Tree
// https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/
public class S00109
{
    public TreeNode? SortedListToBST(ListNode? head)
    {
        if (head == null)
        {
            return null;
        }

        var list = new List<int>();
        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }
        
        return arrayToBst(list, 0, list.Count - 1);
    }

    private static TreeNode? arrayToBst(IReadOnlyList<int> nums, int lo, int hi)
    {
        if (lo > hi)
        {
            return null;
        }
        
        var mid = lo + (hi - lo) / 2;
        var root = new TreeNode(nums[mid])
        {
            left = arrayToBst(nums, lo, mid - 1),
            right = arrayToBst(nums, mid + 1, hi)
        };

        return root;
    }
}