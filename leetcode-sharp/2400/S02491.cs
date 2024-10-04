namespace leetcode_sharp;

// 2491. Divide Players Into Teams of Equal Skill
// https://leetcode.com/problems/divide-players-into-teams-of-equal-skill
public class S02491
{
    public long DividePlayers(int[] skill)
    {
        Dictionary<long, int> cnt = [];
        foreach (var n in skill)
        {
            cnt[n] = cnt.GetValueOrDefault(n) + 1;
        }

        var expectedSkill = 2 * skill.Sum() / skill.Length;
        var chemistry = 0L;

        foreach (var (value, count) in cnt)
        {
            if (!cnt.ContainsKey(expectedSkill - value) || cnt[expectedSkill - value] != count)
            {
                return -1;
            }

            chemistry += count * value * (expectedSkill - value);
        }

        return chemistry / 2;
    }
}
