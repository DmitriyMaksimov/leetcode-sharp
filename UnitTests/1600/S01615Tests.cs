using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01615Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01615();
        sut.MaximalNetworkRank(4, new[] {new[] {0, 1}, new[] {0, 3}, new[] {1, 2}, new[] {1, 3}}).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01615();
        sut.MaximalNetworkRank(5,
            new[] {new[] {0, 1}, new[] {0, 3}, new[] {1, 2}, new[] {1, 3}, new[] {2, 3}, new[] {2, 4}}).Should().Be(5);
    }

    [Test]
    public void T3()
    {
        var sut = new S01615();
        sut.MaximalNetworkRank(8,
            new[] {new[] {0, 1}, new[] {1, 2}, new[] {2, 3}, new[] {2, 4}, new[] {5, 6}, new[] {5, 7}}).Should().Be(5);
    }
}