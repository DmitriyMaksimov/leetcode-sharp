namespace leetcode_sharp;

// 3325. Count Substrings With K-Frequency Characters I
// https://leetcode.com/problems/count-substrings-with-k-frequency-characters-i
public class S03325
{
    public int NumberOfSubstrings(string s, int k)
    {
        var n = s.Length;
        var count = 0;

        for (var left = 0; left < n; left++)
        {
            var freq = new int[26];
            var maxFreq = 0;

            for (var right = left; right < n; right++)
            {
                freq[s[right] - 'a']++;
                maxFreq = Math.Max(maxFreq, freq[s[right] - 'a']);

                if (maxFreq >= k)
                {
                    count += n - right;
                    break;
                }
            }
        }

        return count;
    }
}
