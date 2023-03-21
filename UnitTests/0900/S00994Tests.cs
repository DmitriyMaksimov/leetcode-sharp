using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00994Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00994();
        sut.OrangesRotting(new[] {new[] {2, 1, 1}, new[] {1, 1, 0}, new[] {0, 1, 1}}).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00994();
        sut.OrangesRotting(new[] {new[] {2, 1, 1}, new[] {0, 1, 1}, new[] {1, 0, 1}}).Should().Be(-1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00994();
        sut.OrangesRotting(new[] {new[] {0, 2}}).Should().Be(0);
    }
}