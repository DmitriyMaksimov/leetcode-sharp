using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00506Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00506();
        sut.FindRelativeRanks(new[] {5, 4, 3, 2, 1}).Should()
            .Equal("Gold Medal", "Silver Medal", "Bronze Medal", "4", "5");
    }

    [Test]
    public void T2()
    {
        var sut = new S00506();
        sut.FindRelativeRanks(new[] {10, 3, 8, 9, 4}).Should()
            .Equal("Gold Medal", "5", "Bronze Medal", "Silver Medal", "4");
    }
}