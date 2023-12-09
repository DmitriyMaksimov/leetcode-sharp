using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00807Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00807();
        sut.MaxIncreaseKeepingSkyline(new[]
            {new[] {3, 0, 8, 4}, new[] {2, 4, 5, 7}, new[] {9, 2, 6, 3}, new[] {0, 3, 1, 0}}).Should().Be(35);
    }

    [Test]
    public void T2()
    {
        var sut = new S00807();
        sut.MaxIncreaseKeepingSkyline(new[] {new[] {0, 0, 0}, new[] {0, 0, 0}, new[] {0, 0, 0}}).Should().Be(0);
    }
}