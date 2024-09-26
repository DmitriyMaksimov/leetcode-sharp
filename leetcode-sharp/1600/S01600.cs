namespace leetcode_sharp;

// 1600. Throne Inheritance
// https://leetcode.com/problems/throne-inheritance
public static class S01600
{
    public class ThroneInheritance
    {
        private readonly Dictionary<string, List<string>> _map = [];
        private readonly HashSet<string> _dead = [];
        private readonly string _king;

        public ThroneInheritance(string kingName)
        {
            _king = kingName;
            _map[_king] = [];
        }

        public void Birth(string parentName, string childName)
        {
            _map[parentName] = _map.GetValueOrDefault(parentName, []);
            _map[parentName].Add(childName);
        }

        public void Death(string name)
        {
            _dead.Add(name);
        }

        public IList<string> GetInheritanceOrder()
        {
            List<string> res = [];
            Dfs(res, _king);
            return res;
        }

        private void Dfs(List<string> res, string root)
        {
            if (!_dead.Contains(root))
            {
                res.Add(root);
            }

            foreach (var child in _map.GetValueOrDefault(root, []))
            {
                Dfs(res, child);
            }
        }
    }
}
