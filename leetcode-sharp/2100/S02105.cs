namespace leetcode_sharp;

// 2105. Watering Plants II
// https://leetcode.com/problems/watering-plants-ii
public class S02105
{
    public int MinimumRefill(int[] plants, int capacityA, int capacityB)
    {
        var result = 0;
        var fullCapacityAlice = capacityA;
        var fullCapacityBob = capacityB;
        var left = 0;
        var right = plants.Length - 1;

        while (left <= right)
        {
            if (left == right)
            {
                if (capacityA >= capacityB)
                {
                    if (plants[left] > capacityA)
                    {
                        result++;
                    }
                }
                else
                {
                    if (plants[right] > capacityB)
                    {
                        result++;
                    }
                }

                break;
            }

            if (plants[left] > capacityA)
            {
                result++;
                capacityA = fullCapacityAlice;
            }

            if (plants[right] > capacityB)
            {
                result++;
                capacityB = fullCapacityBob;
            }

            capacityA -= plants[left];
            capacityB -= plants[right];
            left++;
            right--;
        }

        return result;
    }
}