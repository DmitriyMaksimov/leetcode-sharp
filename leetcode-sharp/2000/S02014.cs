namespace leetcode_sharp;

// 2014. Longest Subsequence Repeated k Times
// https://leetcode.com/problems/longest-subsequence-repeated-k-times
public class S02014
{
    public string LongestSubsequenceRepeatedK(string s, int k)
    {
        var alphabetCount = new int[26];
        foreach (var ch in s)
        {
            alphabetCount[ch - 'a']++;
        }

        var longestRepeatedSub = string.Empty;
        var potentialCandidates = new Queue<string>();
        potentialCandidates.Enqueue(longestRepeatedSub);

        while (potentialCandidates.Count > 0)
        {
            var currentCandidate = potentialCandidates.Dequeue();

            for (int i = 0; i < 26; i++)
            {
                if (alphabetCount[i] >= k)
                {
                    var nextCandidate = currentCandidate + (char)(i + 'a');
                    if (IsSubsequence(s, nextCandidate, k))
                    {
                        longestRepeatedSub = nextCandidate;
                        potentialCandidates.Enqueue(nextCandidate);
                    }
                }
            }
        }

        return longestRepeatedSub;
    }

    private static bool IsSubsequence(string s, string sub, int k)
    {
        var j = 0;
        var repeatCount = 0;

        foreach (var _ in s.Where(ch => ch == sub[j]))
        {
            j++;
            if (j == sub.Length)
            {
                repeatCount++;
                if (repeatCount == k)
                {
                    return true;
                }

                j = 0;
            }
        }

        return false;
    }
}