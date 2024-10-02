namespace leetcode_sharp;

// 2410. Maximum Matching of Players With Trainers
// https://leetcode.com/problems/maximum-matching-of-players-with-trainers
public class S02410
{
    public int MatchPlayersAndTrainers(int[] players, int[] trainers)
    {
        Array.Sort(players);
        Array.Sort(trainers);

        var j = 0;

        for (var i = 0; i < trainers.Length && j < players.Length; ++i)
        {
            j += players[j] <= trainers[i] ? 1 : 0;
        }

        return j;
    }
}
