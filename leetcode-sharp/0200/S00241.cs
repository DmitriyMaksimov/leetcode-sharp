namespace leetcode_sharp;

// 241. Different Ways to Add Parentheses
// https://leetcode.com/problems/different-ways-to-add-parentheses
public class S00241
{
    public IList<int> DiffWaysToCompute(string expression)
    {
        var result = new List<int>();

        for (var i = 0; i < expression.Length; i++)
        {
            if (expression[i] != '-' && expression[i] != '*' && expression[i] != '+') continue;

            var part1 = DiffWaysToCompute(expression[..i]);
            var part2 = DiffWaysToCompute(expression[(i + 1)..]);

            foreach (var p1 in part1)
            {
                foreach (var p2 in part2)
                {
                    var c = expression[i] switch
                    {
                        '+' => p1 + p2,
                        '-' => p1 - p2,
                        '*' => p1 * p2,
                        _ => 0
                    };

                    result.Add(c);
                }
            }
        }

        if (result.Count == 0)
        {
            result.Add(int.Parse(expression));
        }

        return result;
    }
}
