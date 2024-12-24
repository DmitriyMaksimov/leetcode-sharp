namespace leetcode_sharp;

// 3375. Minimum Operations to Make Array Values Equal to K
// https://leetcode.com/problems/minimum-operations-to-make-array-values-equal-to-k
public class S03375
{
    public int MinOperations(int[] nums, int k)
    {
        var hashSet = new HashSet<int>(nums);
        var min = hashSet.Min();
        if (min < k)
        {
            return -1;
        }

        return hashSet.Count + (min == k ? -1 : 0);
    }
}
