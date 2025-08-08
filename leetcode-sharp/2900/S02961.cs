namespace leetcode_sharp;

// 2961. Double Modular Exponentiation
// https://leetcode.com/problems/double-modular-exponentiation
public class S02961
{
    public IList<int> GetGoodIndices(int[][] variables, int target)
    {
        var result = new List<int>();

        for (var i = 0; i < variables.Length; i++)
        {
            var a = variables[i][0];
            var b = variables[i][1];
            var c = variables[i][2];
            var m = variables[i][3];

            var baseValue = 1;
            for (var j = 0; j < b; j++)
            {
                baseValue = baseValue * a % 10;
            }

            var formulaResult = 1;
            for (var j = 0; j < c; j++)
            {
                formulaResult = formulaResult * baseValue % m;
            }

            if (formulaResult == target)
            {
                result.Add(i);
            }
        }

        return result;
    }
}