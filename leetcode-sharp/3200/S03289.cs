namespace leetcode_sharp;

// 3289. The Two Sneaky Numbers of Digitville
// https://leetcode.com/problems/the-two-sneaky-numbers-of-digitville
public class S03289
{
    public int[] GetSneakyNumbers(int[] nums)
    {
        var result = new List<int>();
        var hashSet = new HashSet<int>();

        foreach (var num in nums)
        {
            if (!hashSet.Add(num))
            {
                result.Add(num);
            }
        }

        return result.ToArray();
    }
}
