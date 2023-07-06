using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00209Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00209();
        sut.MinSubArrayLen(7, new[] {2, 3, 1, 2, 4, 3}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00209();
        sut.MinSubArrayLen(4, new[] {1, 4, 4}).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00209();
        sut.MinSubArrayLen(11, new[] {1, 1, 1, 1, 1, 1, 1, 1}).Should().Be(0);
    }
}