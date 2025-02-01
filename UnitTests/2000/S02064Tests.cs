using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02064Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02064();
        Assert.That(sut.MinimizedMaximum(6, [11, 6]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02064();
        Assert.That(sut.MinimizedMaximum(7, [15, 10, 10]), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S02064();
        Assert.That(sut.MinimizedMaximum(1, [100000]), Is.EqualTo(100000));
    }
}
