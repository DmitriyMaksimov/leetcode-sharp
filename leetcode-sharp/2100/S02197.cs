namespace leetcode_sharp;

// 2197. Replace Non-Coprime Numbers in Array
// https://leetcode.com/problems/replace-non-coprime-numbers-in-array
public class S02197
{
    public IList<int> ReplaceNonCoprimes(int[] nums)
    {
        var result = new List<int>();

        foreach (var number in nums)
        {
            var current = number;

            while (result.Count > 0)
            {
                var last = result[^1];
                var gcd = Gcd(last, current);

                if (gcd == 1)
                {
                    break;
                }

                current = current / gcd * last;
                result.RemoveAt(result.Count - 1);
            }

            result.Add(current);
        }

        return result;
    }

    private static int Gcd(int a, int b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }
}