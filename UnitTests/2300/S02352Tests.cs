using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02352Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02352();
        sut.EqualPairs(new[] {new[] {3, 2, 1}, new[] {1, 7, 6}, new[] {2, 7, 7}}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S02352();
        sut.EqualPairs(new[] {new[] {3, 1, 2, 2}, new[] {1, 4, 4, 5}, new[] {2, 4, 2, 2}, new[] {2, 4, 2, 2}}).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S02352();
        sut.EqualPairs(new[]
        {
            new[] {3, 1, 2, 2},
            new[] {1, 4, 4, 4},
            new[] {2, 4, 2, 2},
            new[] {2, 5, 2, 2}
        }).Should().Be(3);
    }
}