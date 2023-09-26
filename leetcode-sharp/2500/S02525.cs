namespace leetcode_sharp;

// 2525. Categorize Box According to Criteria
// https://leetcode.com/problems/categorize-box-according-to-criteria/
public class S02525
{
    public string CategorizeBox(int length, int width, int height, int mass)
    {
        var isBulky = length >= 10_000 || width >= 10_000 || height >= 10_000 || (long)length * width * height >= 1_000_000_000;
        var isHeavy = mass >= 100;

        if (isBulky && isHeavy) return "Both";
        if (isBulky) return "Bulky";

        return isHeavy ? "Heavy" : "Neither";
    }
}