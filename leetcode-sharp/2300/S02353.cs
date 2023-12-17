namespace leetcode_sharp;

// 2353. Design a Food Rating System
// https://leetcode.com/problems/design-a-food-rating-system
public class S02353
{
    public class FoodRatings
    {
        class Comparer : IComparer<(int rating, string food)>
        {
            public int Compare((int rating, string food) o1, (int rating, string food) o2)
            {
                if (o1.rating > o2.rating) return 1;
                if (o1.rating < o2.rating) return -1;
                return o2.food.CompareTo(o1.food);
            }
        }

        private readonly Dictionary<string, SortedSet<(int rating, string food)>> _map;
        private readonly Dictionary<string, int> _mapFood;
        private readonly Dictionary<string, string> _mapFoodKit;

        public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
        {
            _map = new Dictionary<string, SortedSet<(int, string)>>();
            _mapFood = new Dictionary<string, int>();
            _mapFoodKit = new Dictionary<string, string>();

            for (var i = 0; i < foods.Length; i++)
            {
                _mapFood[foods[i]] = ratings[i];
                _mapFoodKit[foods[i]] = cuisines[i];
                if (_map.ContainsKey(cuisines[i]))
                {
                    _map[cuisines[i]].Add((ratings[i], foods[i]));
                }
                else
                {
                    SortedSet<(int rating, string food)> s = new(new Comparer()) {(ratings[i], foods[i])};
                    _map.Add(cuisines[i], s);
                }
            }
        }

        public void ChangeRating(string food, int newRating)
        {
            if (_mapFood.ContainsKey(food))
            {
                var oldRating = _mapFood[food];
                _mapFood[food] = newRating;

                var cuisine = _mapFoodKit[food];
                _map[cuisine].Remove((oldRating, food));
                _map[cuisine].Add((newRating, food));
            }
        }

        public string HighestRated(string cuisine)
        {
            return _map[cuisine].Max.food;
        }
    }
}