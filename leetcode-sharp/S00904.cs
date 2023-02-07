namespace leetcode_sharp;

// 904. Fruit Into Baskets
// https://leetcode.com/problems/fruit-into-baskets/
public class S00904
{
    public int TotalFruit(int[] fruits)
    {
        var basket = new Dictionary<int, int>();
        var left = 0;
        int right;

        for (right = 0; right < fruits.Length; ++right)
        {
            var rightFruit = fruits[right];
            
            basket[rightFruit] = basket.GetValueOrDefault(rightFruit) + 1;

            if (basket.Count <= 2) continue;
            
            var leftFruit = fruits[left];
            
            basket[leftFruit] -= 1;

            if (basket[leftFruit] == 0)
            {
                basket.Remove(leftFruit);
            }

            left++;
        }

        return right - left;
    }
}