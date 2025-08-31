namespace leetcode_sharp;

// 2522. Partition String Into Substrings With Values at Most K
// https://leetcode.com/problems/partition-string-into-substrings-with-values-at-most-k
public class S02522
{
    public int MinimumPartition(string s, int k)
    {
        var num = 0L;
        var result = 0;

        foreach (var ch in s)
        {
            var digit = ch - '0';

            if (digit > k)
            {
                return -1;
            }

            num = num * 10 + digit;

            if (num > k)
            {
                num = digit;
                result++;
            }
        }

        return result + 1;
    }
}