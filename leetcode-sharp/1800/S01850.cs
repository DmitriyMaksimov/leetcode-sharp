namespace leetcode_sharp;

// 1850. Minimum Adjacent Swaps to Reach the Kth Smallest Number
// https://leetcode.com/problems/minimum-adjacent-swaps-to-reach-the-kth-smallest-number
public class S01850
{
    public int GetMinSwaps(string num, int k)
    {
        var arr = num.ToCharArray();

        for (var i = 0; i < k; i++)
        {
            NextPermutation(arr);
        }

        return CountSteps(num.ToCharArray(), arr, arr.Length);
    }

    private static void NextPermutation(char[] nums)
    {
        var len = nums.Length;
        if (len == 0) return;

        for (var i = len - 1; i >= 1; i--)
        {
            if (nums[i] <= nums[i - 1]) continue;

            Reverse(nums, i);

            for (var j = i; j < len; j++)
            {
                if (nums[j] <= nums[i - 1]) continue;
                
                Swap(nums, i - 1, j);
                return;
            }
        }

        Reverse(nums, 0);
    }

    private static void Reverse(char[] nums, int i)
    {
        var j = nums.Length - 1;
        while (i < j)
        {
            Swap(nums, i, j);
            i++;
            j--;
        }
    }

    private static void Swap(char[] nums, int i, int j)
    {
        (nums[i], nums[j]) = (nums[j], nums[i]);
    }

    private int CountSteps(char[] s1, char[] s2, int size)
    {
        var i = 0;
        var j = 0;
        var count = 0;

        while (i < size)
        {
            j = i;

            while (s1[j] != s2[i])
            {
                j += 1;
            }

            while (i < j)
            {
                Swap(s1, j, j - 1);
                j -= 1;
                count++;
            }

            i++;
        }

        return count;
    }
}