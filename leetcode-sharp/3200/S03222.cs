namespace leetcode_sharp;

// 3222. Find the Winning Player in Coin Game
// https://leetcode.com/problems/find-the-winning-player-in-coin-game
public class S03222
{
    public string LosingPlayer(int x, int y)
    {
        return Math.Min(x, y / 4) % 2 != 0 ? "Alice" : "Bob";
    }
}