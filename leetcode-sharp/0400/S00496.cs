namespace leetcode_sharp;

// 496. Next Greater Element I
// https://leetcode.com/problems/next-greater-element-i/
public class S00496
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var result = new int[nums1.Length];
        var map = new Dictionary<int, int>();
        var stack = new Stack<int>();
        foreach (var num in nums2)
        {
            while (stack.Count > 0 && stack.Peek() < num)
            {
                map.Add(stack.Pop(), num);
            }

            stack.Push(num);
        }

        for (var i = 0; i < nums1.Length; i++)
        {
            result[i] = map.GetValueOrDefault(nums1[i], -1);
        }

        return result;
    }
}