namespace leetcode_sharp;

// 682. Baseball Game
// https://leetcode.com/problems/baseball-game/
public class S00682
{
    public int CalPoints(string[] operations)
    {
        var scores = new List<int>();

        foreach (var operation in operations)
        {
            switch (operation)
            {
                case "+":
                    scores.Add(scores[^1] + scores[^2]);
                    break;
                case "D":
                    scores.Add(scores[^1] * 2);
                    break;
                case "C":
                    scores.RemoveAt(scores.Count - 1);
                    break;
                default:
                    scores.Add(int.Parse(operation));
                    break;
            }
        }

        return scores.Sum();
    }
}