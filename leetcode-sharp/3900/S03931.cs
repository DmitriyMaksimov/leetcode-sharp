namespace leetcode_sharp;

// 3931. Check Adjacent Digit Differences
// https://leetcode.com/problems/check-adjacent-digit-differences
public class S03931
{
    public bool IsAdjacentDiffAtMostTwo(string s)
    {
        for (var i = 0; i < s.Length - 1; i++)
        {
            if (Math.Abs(s[i] - s[i + 1]) > 2)
            {
                return false;
            }
        }

        return true;
    }
}