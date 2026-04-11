namespace leetcode_sharp;

// 3741. Minimum Distance Between Three Equal Elements II
// https://leetcode.com/problems/minimum-distance-between-three-equal-elements-ii
public class S03741
{
    public int MinimumDistance(int[] nums)
    {
        var length = nums.Length;
        var minDistance = int.MaxValue;
        var indicesByValue = new Dictionary<int, List<int>>();

        for (var i = 0; i < length; i++)
        {
            if (!indicesByValue.TryGetValue(nums[i], out var indexList))
            {
                indexList = [];
                indicesByValue[nums[i]] = indexList;
            }

            indexList.Add(i);
        }

        foreach (var indexList in indicesByValue.Values)
        {
            if (indexList.Count < 3)
            {
                continue;
            }

            var firstIndex = indexList[0];
            var secondIndex = indexList[1];
            var thirdIndex = indexList[2];

            minDistance = Math.Min(
                minDistance,
                Math.Abs(firstIndex - secondIndex)
                + Math.Abs(secondIndex - thirdIndex)
                + Math.Abs(thirdIndex - firstIndex)
            );

            for (var i = 3; i < indexList.Count; i++)
            {
                firstIndex = secondIndex;
                secondIndex = thirdIndex;
                thirdIndex = indexList[i];

                var distance =
                    Math.Abs(firstIndex - secondIndex)
                    + Math.Abs(secondIndex - thirdIndex)
                    + Math.Abs(thirdIndex - firstIndex);

                minDistance = Math.Min(minDistance, distance);
            }
        }

        return minDistance == int.MaxValue ? -1 : minDistance;
    }
}