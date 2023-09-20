namespace leetcode_sharp;

// 2269. Find the K-Beauty of a Number
// https://leetcode.com/problems/find-the-k-beauty-of-a-number/
public class S02269
{
    public int DivisorSubstrings(int num, int k)
    {
        var s = num.ToString();
        var n = s.Length;
        var ans = 0;

        for (var i = 0; i < n - k + 1; i++)
        {
            var subNum = int.Parse(s.AsSpan(i, k));

            if (subNum != 0 && num % subNum == 0)
            {
                ans++;
            }
        }

        return ans;
    }
}