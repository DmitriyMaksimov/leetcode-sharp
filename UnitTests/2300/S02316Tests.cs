using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02316Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02316();
        sut.CountPairs(3, new[] {new[] {0, 1}, new[] {0, 2}, new[] {1, 2}}).Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S02316();
        sut.CountPairs(7, new[] {new[] {0, 2}, new[] {0, 5}, new[] {2, 4}, new[] {1, 6}, new[] {5, 4}}).Should().Be(14);
    }
}