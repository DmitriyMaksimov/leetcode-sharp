namespace leetcode_sharp;

// 229. Majority Element II
// https://leetcode.com/problems/majority-element-ii
public class S00229
{
    public IList<int> MajorityElement(int[] nums)
    {
        return nums.GroupBy(n => n).Where(g => g.Count() > nums.Length / 3).Select(x => x.Key).ToArray();
    }
}