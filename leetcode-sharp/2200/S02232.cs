namespace leetcode_sharp;

// 2232. Minimize Result by Adding Parentheses to Expression
// https://leetcode.com/problems/minimize-result-by-adding-parentheses-to-expression
public class S02232
{
    public string MinimizeResult(string expression)
    {
        var split = expression.Split("+");
        var left = split[0];
        var right = split[1];
        var min = int.MaxValue;
        var result = "(" + expression + ")";

        for (var i = 0; i < left.Length; i++)
        {
            var leftMul = left[..i] == "" ? 1 : int.Parse(left[..i]);
            var leftNum = int.Parse(left[i..]);

            for (var j = 1; j <= right.Length; j++)
            {
                var rightMul = right[j..] == "" ? 1 : int.Parse(right[j..]);
                var rightNum = int.Parse(right[..j]);

                var sum = leftMul * (leftNum + rightNum) * rightMul;
                if (sum < min)
                {
                    min = sum;
                    result = left[..i] + "(" + left[i..] + "+" + right[..j] + ")" + right[j..];
                }
            }
        }

        return result;
    }
}
