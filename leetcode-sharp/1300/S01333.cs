namespace leetcode_sharp;

// 1333. Filter Restaurants by Vegan-Friendly, Price and Distance
// https://leetcode.com/problems/filter-restaurants-by-vegan-friendly-price-and-distance
public class S01333
{
    public IList<int> FilterRestaurants(int[][] restaurants, int veganFriendly, int maxPrice, int maxDistance)
    {
        var filteredIds = restaurants.Where(r => r[2] >= veganFriendly && r[3] <= maxPrice && r[4] <= maxDistance).ToList();
        filteredIds.Sort((a, b) => a[1] == b[1] ? b[0] - a[0] : b[1] - a[1]);

        return filteredIds.Select(n => n[0]).ToList();
    }
}
