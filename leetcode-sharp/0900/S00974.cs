namespace leetcode_sharp;

// 974. Subarray Sums Divisible by K
// https://leetcode.com/problems/subarray-sums-divisible-by-k/
public class S00974
{
    public int SubarraysDivByK(int[] nums, int k)
    {
        var reminders = new Dictionary<int, int> {[0] = 1};
        var count = 0;
        var reminder = 0;
        
        foreach (var a in nums)
        {
            reminder = (reminder + a) % k;
            if (reminder < 0) reminder += k;
            count += reminders.GetValueOrDefault(reminder, 0);
            reminders[reminder] = reminders.GetValueOrDefault(reminder, 0) + 1;
        }
        
        return count;
    }
}