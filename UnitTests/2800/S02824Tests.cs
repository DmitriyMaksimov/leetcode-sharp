using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02824Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02824();
        sut.CountPairs(new[] {-1, 1, 2, 3, 1}, 2).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02824();
        sut.CountPairs(new[] {-6, 2, 5, -2, -7, -1, 3}, -2).Should().Be(10);
    }
}