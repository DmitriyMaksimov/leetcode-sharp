namespace leetcode_sharp;

// 292. Nim Game
// https://leetcode.com/problems/nim-game/
public class S00292
{
    public bool CanWinNim(int n)
    {
        return n % 4 != 0;
    }
}