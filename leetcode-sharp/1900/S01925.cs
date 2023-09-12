namespace leetcode_sharp;

// 1925. Count Square Sum Triples
// https://leetcode.com/problems/count-square-sum-triples/
public class S01925
{
    public int CountTriples(int n)
    {
        var count = 0;

        for (var i = 1; i <= n; i++)
        {
            for (var j = 1; j <= n; j++)
            {
                for (var k = 1; k <= n; k++)
                {
                    if (i * i + j * j == k * k)
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }
}