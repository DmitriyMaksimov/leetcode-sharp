namespace leetcode_sharp;

// 414. Third Maximum Number
// https://leetcode.com/problems/third-maximum-number/
public class S00414
{
    public int ThirdMax(int[] nums)
    {
        return nums.Distinct().OrderByDescending(x => x).Cast<int?>().ElementAtOrDefault(2) ?? nums.Max();
    }
}