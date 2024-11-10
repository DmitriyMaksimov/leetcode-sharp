namespace leetcode_sharp;

// 3300. Minimum Element After Replacement With Digit Sum
// https://leetcode.com/problems/minimum-element-after-replacement-with-digit-sum
public class S03300
{
    public int MinElement(int[] nums)
    {
        return nums.Select(num => num.ToString().Select(ch => ch - '0').Sum()).Min();
    }
}
