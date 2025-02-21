namespace leetcode_sharp;

// 2115. Find All Possible Recipes from Given Supplies
// https://leetcode.com/problems/find-all-possible-recipes-from-given-supplies
public class S02115
{
    public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies)
    {
        HashSet<string> seen = [..supplies];
        Queue<int> queue = [];

        for (var i = 0; i < recipes.Length; ++i)
        {
            queue.Enqueue(i);
        }

        List<string> result = [];
        var prevSize = seen.Count - 1;

        while (seen.Count > prevSize)
        {
            prevSize = seen.Count;
            var size = queue.Count;

            for (var s = 0; s < size; ++s)
            {
                var i = queue.Dequeue();
                var canMake = ingredients[i].All(ing => seen.Contains(ing));

                if (canMake)
                {
                    seen.Add(recipes[i]);
                    result.Add(recipes[i]);
                }
                else
                {
                    queue.Enqueue(i);
                }
            }
        }

        return result;
    }
}
