namespace leetcode_sharp;

// 3192. Minimum Operations to Make Binary Array Elements Equal to One II
// https://leetcode.com/problems/minimum-operations-to-make-binary-array-elements-equal-to-one-ii
public class S03192
{
    public int MinOperations(int[] nums)
    {
        var result = 0;
        var flip = 0;

        foreach (var num in nums)
        {
            if (num + flip != 1)
            {
                ++result;
                flip = flip == 0 ? 1 : 0;
            }
        }

        return result;
    }
}
