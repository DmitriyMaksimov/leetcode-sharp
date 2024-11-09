namespace leetcode_sharp;

// 3285. Find Indices of Stable Mountains
// https://leetcode.com/problems/find-indices-of-stable-mountains
public class S03285
{
    public IList<int> StableMountains(int[] height, int threshold)
    {
        List<int> result = [];

        for (var i = 1; i < height.Length; i++)
        {
            if (height[i - 1] > threshold)
            {
                result.Add(i);
            }
        }

        return result;
    }
}
