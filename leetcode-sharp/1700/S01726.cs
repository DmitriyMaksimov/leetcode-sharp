namespace leetcode_sharp;

// 1726. Tuple with Same Product
// https://leetcode.com/problems/tuple-with-same-product
public class S01726
{
    public int TupleSameProduct(int[] nums)
    {
        Dictionary<int, int> dictionary = [];
        var result = 0;

        for (var i = 0; i < nums.Length; ++i)
        {
            for (var j = 0; j < i; ++j)
            {
                var product = nums[i] * nums[j];
                dictionary[product] = dictionary.GetValueOrDefault(product);
                result += 8 * dictionary[product];
                ++dictionary[product];
            }
        }

        return result;
    }
}
