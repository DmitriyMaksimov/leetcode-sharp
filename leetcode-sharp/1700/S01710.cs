namespace leetcode_sharp;

// 1710. Maximum Units on a Truck
// https://leetcode.com/problems/maximum-units-on-a-truck/
public class S01710
{
    public int MaximumUnits(int[][] boxTypes, int truckSize)
    {
        Array.Sort(boxTypes, (a, b) => b[1] - a[1]);
        var res = 0;
        
        foreach (var box in boxTypes)
        {
            if (truckSize >= box[0])
            {
                res += box[0] * box[1];
                truckSize -= box[0];
            }
            else
            {
                res += truckSize * box[1];
                break;
            }
        }

        return res;
    }
}