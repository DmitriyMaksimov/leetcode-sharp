namespace leetcode_sharp;

// 605. Can Place Flowers
// https://leetcode.com/problems/can-place-flowers/
public class S00605
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0)
        {
            return true;
        }

        if (flowerbed.Length == 1)
        {
            return flowerbed[0] == 0 && n == 1;
        }

        if (flowerbed.Length == 2)
        {
            return flowerbed[0] == 0 && flowerbed[1] == 0 && n == 1;
        }
        
        for (var i = 0; i < flowerbed.Length; ++i)
        {
            if (i == 0)
            {
                if (flowerbed[i] == 0 && flowerbed[i + 1] == 0)
                {
                    --n;
                    flowerbed[i] = 1;
                }
            }
            else if (flowerbed[i - 1] == 0 && flowerbed[i] == 0 && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
            {
                --n;
                flowerbed[i] = 1;
            }

            if (n == 0)
            {
                return true;
            }
        }

        return false;
    }
}