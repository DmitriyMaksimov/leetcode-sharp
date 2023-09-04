using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00892Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00892();
        sut.SurfaceArea(new[] {new[] {1, 2}, new[] {3, 4}}).Should().Be(34);
    }

    [Test]
    public void T2()
    {
        var sut = new S00892();
        sut.SurfaceArea(new[] {new[] {1, 1, 1}, new[] {1, 0, 1}, new[] {1, 1, 1}}).Should().Be(32);
    }

    [Test]
    public void T3()
    {
        var sut = new S00892();
        sut.SurfaceArea(new[] {new[] {2, 2, 2}, new[] {2, 1, 2}, new[] {2, 2, 2}}).Should().Be(46);
    }
}