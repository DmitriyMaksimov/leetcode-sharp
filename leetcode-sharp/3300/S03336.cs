namespace leetcode_sharp;

// 3336. Find the Number of Subsequences With Equal GCD
// https://leetcode.com/problems/find-the-number-of-subsequences-with-equal-gcd
public class S03336
{
    private const int MaxValue = 200;
    private const int States = MaxValue + 1;
    private const int Mod = 1_000_000_007;

    public int SubsequencePairCount(int[] nums)
    {
        var gcd = new int[States, States];
        for (var a = 0; a <= MaxValue; a++)
        {
            for (var b = 0; b <= MaxValue; b++)
            {
                gcd[a, b] = Gcd(a, b);
            }
        }

        const int size = States * States;

        var next = new int[size];
        var current = new int[size];

        for (var g = 1; g <= MaxValue; g++)
        {
            next[g * States + g] = 1;
        }

        foreach (var x in nums.Reverse())
        {
            for (var firstGcd = 0; firstGcd <= MaxValue; firstGcd++)
            {
                var firstGcdAfterAdding = gcd[firstGcd, x];
                var row = firstGcd * States;
                var newRow = firstGcdAfterAdding * States;

                for (var secondGcd = 0; secondGcd <= MaxValue; secondGcd++)
                {
                    var secondGcdAfterAdding = gcd[secondGcd, x];
                    var value = next[row + secondGcd];

                    value += next[newRow + secondGcd];
                    if (value >= Mod)
                    {
                        value -= Mod;
                    }

                    value += next[row + secondGcdAfterAdding];
                    if (value >= Mod)
                    {
                        value -= Mod;
                    }

                    current[row + secondGcd] = value;
                }
            }

            (current, next) = (next, current);
        }

        return next[0];
    }

    private static int Gcd(int a, int b)
    {
        while (a != 0)
        {
            (a, b) = (b % a, a);
        }

        return b;
    }
}