namespace leetcode_sharp;

// 1894. Find the Student that Will Replace the Chalk
// https://leetcode.com/problems/find-the-student-that-will-replace-the-chalk
public class S01894
{
    public int ChalkReplacer(int[] chalk, long k)
    {
        k %= chalk.Select(n => (long)n).Sum();

        for (var i = 0; i < chalk.Length; ++i)
        {
            k -= chalk[i];

            if (k < 0)
            {
                return i;
            }
        }

        return 0;
    }
}
