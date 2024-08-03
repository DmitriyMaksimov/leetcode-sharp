namespace leetcode_sharp;

// 3232. Find if Digit Game Can Be Won
// https://leetcode.com/problems/find-if-digit-game-can-be-won
public class S03232
{
    public bool CanAliceWin(int[] nums)
    {
        var sum = 0;

        foreach (var num in nums)
        {
            if (num > 9)
            {
                sum -= num;
            }
            else
            {
                sum += num;
            }
        }

        return sum != 0;
    }
}
