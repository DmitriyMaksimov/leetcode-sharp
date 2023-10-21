namespace leetcode_sharp;

// 1425. Constrained Subsequence Sum
// https://leetcode.com/problems/constrained-subsequence-sum
public class S01425
{
    public int ConstrainedSubsetSum(int[] nums, int k)
    {
        var linkedList = new LinkedList<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            nums[i] += linkedList.Count > 0 ? nums[linkedList.First!.Value] : 0;

            while (linkedList.Count > 0 && (i - linkedList.First!.Value >= k || nums[i] >= nums[linkedList.Last!.Value]))
            {
                if (nums[i] >= nums[linkedList.Last!.Value])
                {
                    linkedList.RemoveLast();
                }
                else
                {
                    linkedList.RemoveFirst();
                }
            }

            if (nums[i] > 0)
            {
                linkedList.AddLast(i);
            }
        }

        return nums.Max();
    }
}