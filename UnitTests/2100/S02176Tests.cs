using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02176Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02176();
        sut.CountPairs(new[] {3, 1, 2, 2, 2, 1, 3}, 2).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02176();
        sut.CountPairs(new[] {1, 2, 3, 4}, 1).Should().Be(0);
    }
}