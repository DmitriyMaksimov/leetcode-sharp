using System.Text;

namespace leetcode_sharp;

// 3309. Maximum Possible Number by Binary Concatenation
// https://leetcode.com/problems/maximum-possible-number-by-binary-concatenation
public class S03309
{
    public int MaxGoodNumber(int[] nums)
    {
        Array.Sort(nums, (a, b) =>
        {
            var binA = Convert.ToString(a, 2);
            var binB = Convert.ToString(b, 2);
            return string.Compare(binB + binA, binA + binB, StringComparison.Ordinal);
        });

        var binaryConcatenation = new StringBuilder();

        foreach (var num in nums)
        {
            binaryConcatenation.Append(Convert.ToString(num, 2));
        }

        return Convert.ToInt32(binaryConcatenation.ToString(), 2);
    }
}
