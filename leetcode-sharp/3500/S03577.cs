namespace leetcode_sharp;

// 3577. Count the Number of Computer Unlocking Permutations
// https://leetcode.com/problems/count-the-number-of-computer-unlocking-permutations
public class S03577
{
    private const int Mod = 1_000_000_007;

    public int CountPermutations(int[] complexity)
    {
        var result = 1L;

        for (var i = 1; i < complexity.Length; i++)
        {
            if (complexity[i] <= complexity[0])
            {
                return 0;
            }

            result = result * i % Mod;
        }

        return (int)result;
    }
}