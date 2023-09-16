namespace leetcode_sharp;

// 2206. Divide Array Into Equal Pairs
// https://leetcode.com/problems/divide-array-into-equal-pairs/
public class S02206
{
    public bool DivideArray(int[] nums)
    {
        var map = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            map[num] = map.GetValueOrDefault(num) + 1;
        }

        return map.Values.All(value => value % 2 == 0);
    }
}