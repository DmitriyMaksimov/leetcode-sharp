namespace leetcode_sharp;

// 3606. Coupon Code Validator
// https://leetcode.com/problems/coupon-code-validator
public class S03606
{
    public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive)
    {
        var validBusinessLines = new[] { "electronics", "grocery", "pharmacy", "restaurant" };
        var businessLinePriority = validBusinessLines
            .Select((line, index) => new { line, index })
            .ToDictionary(x => x.line, x => x.index);

        var validCoupons = Enumerable.Range(0, code.Length)
            .Where(i =>
                isActive[i] &&
                !string.IsNullOrEmpty(code[i]) &&
                code[i].All(c => char.IsLetterOrDigit(c) || c == '_') &&
                businessLinePriority.ContainsKey(businessLine[i]))
            .Select(i => new { BusinessLine = businessLine[i], Code = code[i] })
            .OrderBy(c => businessLinePriority[c.BusinessLine])
            .ThenBy(c => c.Code, StringComparer.Ordinal)
            .Select(c => c.Code)
            .ToArray();

        return validCoupons;
    }
}