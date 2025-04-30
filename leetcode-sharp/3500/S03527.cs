namespace leetcode_sharp;

// 3527. Find the Most Common Response
// https://leetcode.com/problems/find-the-most-common-response
public class S03527
{
    public string FindCommonResponse(IList<IList<string>> responses)
    {
        var dictionary = new Dictionary<string, int>();

        foreach (var dailyResponses in responses)
        {
            foreach (var response in dailyResponses.Distinct())
            {
                dictionary[response] = dictionary.GetValueOrDefault(response) + 1;
            }
        }

        var maxCount = dictionary.Values.Max();

        return dictionary
            .Where(kvp => kvp.Value == maxCount)
            .Select(kvp => kvp.Key)
            .Min()!;
    }
}
