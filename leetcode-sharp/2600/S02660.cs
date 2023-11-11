namespace leetcode_sharp;

// 2660. Determine the Winner of a Bowling Game
// https://leetcode.com/problems/determine-the-winner-of-a-bowling-game
public class S02660
{
    public int IsWinner(int[] player1, int[] player2)
    {
        var score1 = calculateScore(player1);
        var score2 = calculateScore(player2);

        if (score1 == score2)
        {
            return 0;
        }
        
        return score1 > score2 ? 1 : 2;
    }

    private static int calculateScore(int[] pins)
    {
        var result = 0;

        for (var i = 0; i < pins.Length; i++)
        {
            var multiplier = getMultiplier(pins, i);
            result += multiplier * pins[i];
        }

        return result;
    }

    private static int getMultiplier(int[] pins, int index)
    {
        return index switch
        {
            0 => 1,
            1 => pins[index - 1] == 10 ? 2 : 1,
            _ => pins[index - 1] == 10 || pins[index - 2] == 10 ? 2 : 1
        };
    }
}