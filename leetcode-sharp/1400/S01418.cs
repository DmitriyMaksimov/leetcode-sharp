namespace leetcode_sharp;

// 1418. Display Table of Food Orders in a Restaurant
// https://leetcode.com/problems/display-table-of-food-orders-in-a-restaurant
public class S01418
{
    public IList<IList<string>> DisplayTable(IList<IList<string>> orders)
    {
        var tables = new Dictionary<string, int>[501];
        for (var i = 0; i < tables.Length; i++)
        {
            tables[i] = [];
        }

        HashSet<string> foods = [];

        foreach (var order in orders)
        {
            var food = order[2];
            var tableNumber = int.Parse(order[1]);
            foods.Add(food);
            tables[tableNumber][food] = tables[tableNumber].GetValueOrDefault(food) + 1;
        }

        List<IList<string>> result = [];

        for (var i = 0; i <= 500; ++i)
        {
            if (i > 0 && tables[i].Count == 0)
            {
                continue;
            }

            List<string> row = [i == 0 ? "Table" : i.ToString()];
            row.AddRange(foods.Order(StringComparer.Ordinal).Select(food => i == 0 ? food : tables[i].GetValueOrDefault(food).ToString()));

            result.Add(row);
        }

        return result;
    }
}