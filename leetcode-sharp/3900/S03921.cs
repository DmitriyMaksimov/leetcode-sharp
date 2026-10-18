namespace leetcode_sharp;

// 3921. Score Validator
// https://leetcode.com/problems/score-validator
public class S03921
{
    public int[] ScoreValidator(string[] events)
    {
        var score = 0;
        var counter = 0;

        foreach (var e in events)
        {
            switch (e)
            {
                case "W":
                    counter++;
                    break;

                case "WD":
                case "NB":
                    score++;
                    break;

                default:
                    score += e[0] - '0';
                    break;
            }

            if (counter == 10)
            {
                break;
            }
        }

        return [score, counter];
    }
}