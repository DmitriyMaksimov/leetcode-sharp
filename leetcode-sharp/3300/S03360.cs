namespace leetcode_sharp;

// 3360. Stone Removal Game
// https://leetcode.com/problems/stone-removal-game
public class S03360
{
    public bool CanAliceWin(int n)
    {
        var count = 0;
        var stones = 10;

        while (stones <= n)
        {
            n -= stones;
            stones--;
            count++;
        }

        return count % 2 != 0;
    }
}
