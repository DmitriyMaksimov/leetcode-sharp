namespace leetcode_sharp;

// 1018. Binary Prefix Divisible By 5
// https://leetcode.com/problems/binary-prefix-divisible-by-5/
public class S01018
{
    public IList<bool> PrefixesDivBy5(int[] nums)
    {
        var result = new List<bool>();
        var num = 0;
        foreach (var n in nums)
        {
            num = (num * 2 + n) % 5;
            result.Add(num == 0);
        }

        return result;
    }
}