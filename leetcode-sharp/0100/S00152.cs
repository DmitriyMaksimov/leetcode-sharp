namespace leetcode_sharp;

// 152. Maximum Product Subarray
// https://leetcode.com/problems/maximum-product-subarray/
public class S00152
{
    public int MaxProduct(int[] nums)
    {
        var currentMax = int.MinValue;

        // Skip initial zeros
        var lo = 0;
        while (lo < nums.Length)
        {
            if (nums[lo] != 0)
            {
                break;
            }
            ++lo;
        }

        if (lo > 0)
        {
            // If we found 0 max product can't be less than 0
            currentMax = Math.Max(0, currentMax);
        }
        
        for (var i = lo; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                // If we found 0 max product can't be less than 0
                currentMax = Math.Max(0, currentMax);
                currentMax = Math.Max(currentMax, maxProduct(nums, lo, i));

                lo = i + 1;
                // Skip zeros
                while (lo < nums.Length)
                {
                    if (nums[lo] != 0)
                    {
                        break;
                    }
                    ++lo;
                }

                i = lo;
            }            
        }

        if (lo < nums.Length)
        {
            currentMax = Math.Max(currentMax, maxProduct(nums, lo, nums.Length));
        }

        return currentMax;
    }

    private static int maxProduct(int[] nums, int lo, int hi)
    {
        if (lo == hi - 1)
        {
            return nums[lo];
        }
        
        var numberOfNegatives = 0;

        for (var i = lo; i < hi; i++)
        {
            if (nums[i] < 0) numberOfNegatives++;
        }

        if (numberOfNegatives % 2 == 0)
        {
            // even number of negative elements, the maximum product will be the multiplication of all the elements
            var product = 1;

            for (var i = lo; i < hi; i++)
            {
                product *= nums[i];
            }

            return product;
        }
        else
        {
            // If there are odd number of negative elements, we return max of the following:
            //   - product of all the elements until we find the last negative element.
            //   - product of all the elements starting after the first negative element.
            var product = 1;
            var product2 = 1;
            var foundFirstNegative = false;
            var foundLastNegative = false;

            for (var i = lo; i < hi; i++)
            {
                if (foundFirstNegative)
                {
                    product2 *= nums[i];
                }
                if (nums[i] < 0)
                {
                    foundFirstNegative = true;
                    if (--numberOfNegatives == 0)
                    {
                        foundLastNegative = true;
                    }
                }

                if (!foundLastNegative)
                {
                    product *= nums[i];
                }
            }

            return Math.Max(product, product2);
        }
    }
}