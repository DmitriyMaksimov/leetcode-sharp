using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02078Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02078();
        sut.MaxDistance(new[] {1, 1, 1, 6, 1, 1, 1}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02078();
        sut.MaxDistance(new[] {1, 8, 3, 8, 3}).Should().Be(4);
    }

    [Test]
    public void T3()
    {
        var sut = new S02078();
        sut.MaxDistance(new[] {0, 1}).Should().Be(1);
    }
}