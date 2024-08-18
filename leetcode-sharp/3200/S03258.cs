namespace leetcode_sharp;

// 3258. Count Substrings That Satisfy K-Constraint I
// https://leetcode.com/problems/count-substrings-that-satisfy-k-constraint-i
public class S03258
{
    public int CountKConstraintSubstrings(string s, int k)
    {
        var left = 0;
        var right = 0;
        var ones = 0;
        var zeros = 0;
        var result = 0;

        while (right < s.Length)
        {
            if (s[right] == '0')
            {
                zeros++;
            }
            else
            {
                ones++;
            }

            while (zeros > k && ones > k)
            {
                if (s[left] == '0')
                {
                    zeros--;
                }
                else
                {
                    ones--;
                }

                left++;
            }

            result += right - left + 1;
            right++;
        }

        return result;
    }
}
