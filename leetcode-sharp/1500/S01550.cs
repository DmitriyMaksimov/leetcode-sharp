namespace leetcode_sharp;

// 1550. Three Consecutive Odds
// https://leetcode.com/problems/three-consecutive-odds/
public class S01550
{
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        for (var i = 0; i < arr.Length - 2; i++)
        {
            if (arr[i] % 2 == 1 && arr[i + 1] % 2 == 1 && arr[i + 2] % 2 == 1)
            {
                return true;
            }
        }

        return false;
    }
}