// ReSharper disable InconsistentNaming
namespace leetcode_sharp;

// 690. Employee Importance
// https://leetcode.com/problems/employee-importance
public class S00690
{
    public class Employee
    {
        public int id;
        public int importance;
        public IList<int> subordinates = null!;
    }

    public int GetImportance(IList<Employee> employees, int id)
    {
        var map = employees.ToDictionary(employee => employee.id);

        var total = 0;
        var queue = new Queue<Employee>();
        queue.Enqueue(map[id]);

        while (queue.Count != 0)
        {
            var current = queue.Dequeue();
            total += current.importance;

            foreach (var subordinate in current.subordinates)
            {
                queue.Enqueue(map[subordinate]);
            }
        }

        return total;
    }
}
