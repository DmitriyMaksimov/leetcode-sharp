namespace leetcode_sharp;

// 1437. Check If All 1's Are at Least Length K Places Away
// https://leetcode.com/problems/check-if-all-1s-are-at-least-length-k-places-away/
public class S01437
{
    public bool KLengthApart(int[] nums, int k)
    {
        var last = -1;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                if (last != -1 && i - last - 1 < k)
                {
                    return false;
                }

                last = i;
            }
        }

        return true;
    }
}