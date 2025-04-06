namespace leetcode_sharp;

// 3483. Unique 3-Digit Even Numbers
// https://leetcode.com/problems/unique-3-digit-even-numbers
public class S03483
{
    public int TotalNumbers(int[] digits)
    {
        var numbers = new HashSet<(int, int, int)>();

        foreach (var perm in GetPermutations(digits))
        {
            var a = perm[0];
            var b = perm[1];
            var c = perm[2];

            if (a != 0 && c % 2 == 0)
            {
                numbers.Add((a, b, c));
            }
        }

        return numbers.Count;
    }

    private static IEnumerable<int[]> GetPermutations(int[] digits)
    {
        for (var i = 0; i < digits.Length; i++)
        {
            for (var j = 0; j < digits.Length; j++)
            {
                if (j == i) continue;

                for (var k = 0; k < digits.Length; k++)
                {
                    if (k == i || k == j) continue;

                    yield return [digits[i], digits[j], digits[k]];
                }
            }
        }
    }
}
