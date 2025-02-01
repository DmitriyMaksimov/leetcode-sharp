using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00452Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00452();
        Assert.That(sut.FindMinArrowShots(new[] {new[] {10, 16}, new[] {2, 8}, new[] {1, 6}, new[] {7, 12}}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00452();
        Assert.That(sut.FindMinArrowShots(new[] {new[] {1, 2}, new[] {3, 4}, new[] {5, 6}, new[] {7, 8}}), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S00452();
        Assert.That(sut.FindMinArrowShots(new[] {new[] {1, 2}, new[] {2, 3}, new[] {3, 4}, new[] {4, 5}}), Is.EqualTo(2));
    }

    [Test]
    public void T4()
    {
        var sut = new S00452();
        Assert.That(sut.FindMinArrowShots(new[] {new[] {-2147483646, -2147483645}, new[] {2147483646, 2147483647}}), Is.EqualTo(2));
    }

    [Test]
    public void T5()
    {
        var sut = new S00452();
        Assert.That(sut.FindMinArrowShots(new[] {new[] {2, 3}, new[] {2, 3}}), Is.EqualTo(1));
    }

    [Test]
    public void T6()
    {
        var sut = new S00452();
        Assert.That(sut.FindMinArrowShots(new[] {new[] {-2147483648, 2147483647}}), Is.EqualTo(1));
    }

    [Test]
    public void T7()
    {
        var sut = new S00452();
        Assert.That(sut.FindMinArrowShots(new[] {new[] {-2147483648, 2147483647}, new[] {-2147483648, 2147483647}}), Is.EqualTo(1));
    }
}