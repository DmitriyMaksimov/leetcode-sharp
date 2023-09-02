namespace leetcode_sharp;

// 645. Set Mismatch
// https://leetcode.com/problems/set-mismatch/
public class S00645
{
    public int[] FindErrorNums(int[] nums)
    {
        var set = new HashSet<int>();
        var result = new int[2];

        foreach (var num in nums)
        {
            if (set.Contains(num))
            {
                result[0] = num;
            }
            else
            {
                set.Add(num);
            }
        }

        for (var i = 1; i <= nums.Length; i++)
        {
            if (!set.Contains(i))
            {
                result[1] = i;
                break;
            }
        }

        return result;
    }
}