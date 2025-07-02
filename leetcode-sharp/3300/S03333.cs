namespace leetcode_sharp;

// 3333. Find the Original Typed String II
// https://leetcode.com/problems/find-the-original-typed-string-ii
public class S03333
{
    private const int Mod = 1_000_000_007;

    public int PossibleStringCount(string word, int k)
    {
        if (string.IsNullOrEmpty(word))
        {
            return 0;
        }

        var groups = new List<int>();
        var count = 1;
        for (var i = 1; i < word.Length; i++)
        {
            if (word[i] == word[i - 1])
            {
                count++;
            }
            else
            {
                groups.Add(count);
                count = 1;
            }
        }

        groups.Add(count);

        var total = groups.Aggregate<int, long>(1, (current, num) => (current * num) % Mod);

        if (k <= groups.Count)
        {
            return (int)total;
        }

        var dp = new int[k];
        dp[0] = 1;

        foreach (var num in groups)
        {
            var newDp = new int[k];
            var sum = 0L;
            
            for (var s = 0; s < k; s++)
            {
                if (s > 0)
                {
                    sum = (sum + dp[s - 1]) % Mod;
                }

                if (s > num)
                {
                    sum = (sum - dp[s - num - 1] + Mod) % Mod;
                }

                newDp[s] = (int)sum;
            }

            dp = newDp;
        }

        var invalid = 0L;
        
        for (var s = groups.Count; s < k; s++)
        {
            invalid = (invalid + dp[s]) % Mod;
        }

        return (int)((total - invalid + Mod) % Mod);
    }
}