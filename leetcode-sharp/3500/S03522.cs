namespace leetcode_sharp;

// 3522. Calculate Score After Performing Instructions
// https://leetcode.com/problems/calculate-score-after-performing-instructions
public class S03522
{
    public long CalculateScore(string[] instructions, int[] values)
    {
        var n = instructions.Length;
        var visited = new bool[n];
        var score = 0L;
        var i = 0;

        while (i < n && !visited[i])
        {
            visited[i] = true;

            if (instructions[i] == "jump")
            {
                i += values[i];
                if (i < 0 || i >= n)
                {
                    break;
                }
            }
            else
            {
                score += values[i];
                i++;
            }
        }

        return score;
    }
}
