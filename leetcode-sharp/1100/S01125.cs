namespace leetcode_sharp;

// 1125. Smallest Sufficient Team
// https://leetcode.com/problems/smallest-sufficient-team/
public class S01125
{
    public int[] SmallestSufficientTeam(string[] req_skills, IList<IList<string>> people)
    {
        var map = new Dictionary<string, int>();
        for (var i = 0; i < req_skills.Length; i++)
        {
            var s = req_skills[i];
            map[s] = i;
        }

        var skills = new int[people.Count];
        for (var i = 0; i < people.Count; i++)
        {
            var list = people[i];
            var count = 0;
            foreach (var str in list)
            {
                if (map.TryGetValue(str, out var value))
                {
                    count |= (1 << value);
                }
            }
            skills[i] = count;
        }

        var n = req_skills.Length;
        var dp = new List<int>?[1 << n];
        dp[0] = new List<int>();

        for (var i = 0; i < people.Count; i++)
        {
            var personSkills = skills[i];

            for (var j = 0; j < (1 << n); j++)
            {
                if (dp[j] == null)
                {
                    continue;
                }

                var newSkills = j | personSkills;
                if (dp[newSkills] == null || dp[j].Count + 1 < dp[newSkills].Count)
                {
                    var newTeam = new List<int>(dp[j]) {i};
                    dp[newSkills] = newTeam;
                }
            }
        }

        var team = dp[(1 << n) - 1];
        var result = new int[team.Count];
        for (var i = 0; i < team.Count; i++)
        {
            result[i] = team[i];
        }

        return result;
    }
}