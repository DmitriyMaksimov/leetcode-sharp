using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00149Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00149();
        Assert.That(sut.MaxPoints(new[] {new[] {1, 1}, new[] {2, 2}, new[] {3, 3}}), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00149();
        Assert.That(sut.MaxPoints(new[] {new[] {1, 1}, new[] {3, 2}, new[] {5, 3}, new[] {4, 1}, new[] {2, 3}, new[] {1, 4}}), Is.EqualTo(4));
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00149();
        Assert.That(sut.MaxPoints(new[] {new[] {0, 0}}), Is.EqualTo(1));
    }
}