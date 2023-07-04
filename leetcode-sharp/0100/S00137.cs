namespace leetcode_sharp;

// 137. Single Number II
// https://leetcode.com/problems/single-number-ii/
public class S00137
{
    public int SingleNumber(int[] nums)
    {
        var occurrences = new Dictionary<int, int>();
        
        foreach (var n in nums)
        {
            occurrences[n] = occurrences.GetValueOrDefault(n) + 1;
        }

        return occurrences.First(x => x.Value == 1).Key;
    }
}