namespace leetcode_sharp;

// 3731. Find Missing Elements
// https://leetcode.com/problems/find-missing-elements
public class S03731
{
    public IList<int> FindMissingElements(int[] nums)
    {
        var min = nums.Min();
        var max = nums.Max();
        var hashSet = nums.ToHashSet();

        return Enumerable.Range(min + 1, max - min).Where(x => !hashSet.Contains(x)).ToList();
    }
}