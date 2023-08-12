namespace leetcode_sharp;

// 15. 3Sum
// https://leetcode.com/problems/3sum/
public class S00015
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var s = new HashSet<(int, int, int)>();

        for (var i = 0; i < nums.Length; i++)
        {
            var j = i + 1;
            var k = nums.Length - 1;
            while (j < k)
            {
                var sum = nums[i] + nums[j] + nums[k];
                switch (sum)
                {
                    case 0:
                        s.Add((nums[i], nums[j], nums[k]));
                        j++;
                        k--;
                        break;
                    case < 0:
                        j++;
                        break;
                    default:
                        k--;
                        break;
                }
            }
        }

        return s.Select(x => new List<int>{x.Item1, x.Item2, x.Item3} as IList<int>).ToList();
    }
}