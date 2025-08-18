namespace leetcode_sharp;

// 679. 24 Game
// https://leetcode.com/problems/24-game
public class S00679
{
    private const double DiffTolerance = 0.1;

    public bool JudgePoint24(int[] cards)
    {
        return JudgePoint24(cards.Select(n => (double)n).ToList());
    }

    private static bool JudgePoint24(List<double> nums)
    {
        if (nums.Count == 1)
        {
            return Math.Abs(nums[0] - 24) <= DiffTolerance;
        }

        for (var i = 0; i < nums.Count; i++)
        {
            for (var j = 0; j < i; j++)
            {
                var a = nums[i];
                var b = nums[j];

                var possibleValues = new List<double>
                {
                    a + b,
                    a - b,
                    b - a,
                    a * b
                };

                if (Math.Abs(b) > DiffTolerance)
                {
                    possibleValues.Add(a / b);
                }

                if (Math.Abs(a) > DiffTolerance)
                {
                    possibleValues.Add(b / a);
                }

                var remaining = new List<double>();
                for (var k = 0; k < nums.Count; k++)
                {
                    if (k != i && k != j)
                    {
                        remaining.Add(nums[k]);
                    }
                }

                foreach (var val in possibleValues)
                {
                    remaining.Add(val);
                    if (JudgePoint24(remaining))
                    {
                        return true;
                    }

                    remaining.RemoveAt(remaining.Count - 1);
                }
            }
        }

        return false;
    }
}