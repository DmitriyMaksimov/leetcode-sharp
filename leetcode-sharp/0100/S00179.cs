namespace leetcode_sharp;

// 179. Largest Number
// https://leetcode.com/problems/largest-number
public class S00179
{
    public string LargestNumber(int[] nums)
    {
        var strings = nums.Select(n => n.ToString()).ToList();
        strings.Sort((a, b) => string.Compare(b + a, a + b, StringComparison.Ordinal));

        return strings.First() == "0" ? "0" : string.Join("", strings);
    }
}
