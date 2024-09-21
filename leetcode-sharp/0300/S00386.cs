namespace leetcode_sharp;

// 386. Lexicographical Numbers
// https://leetcode.com/problems/lexicographical-numbers
public class S00386
{
    public IList<int> LexicalOrder(int n)
    {
        List<int> result = [];
        var current = 1;

        for (var i = 1; i <= n; i++)
        {
            result.Add(current);

            if (current * 10 <= n)
            {
                current *= 10;
            }
            else if (current % 10 != 9 && current + 1 <= n)
            {
                current++;
            }
            else
            {
                while (current / 10 % 10 == 9)
                {
                    current /= 10;
                }

                current = current / 10 + 1;
            }
        }

        return result;
    }
}
