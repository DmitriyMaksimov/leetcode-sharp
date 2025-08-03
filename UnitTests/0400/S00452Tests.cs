using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00452Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00452();
        Assert.That(sut.FindMinArrowShots([[10, 16], [2, 8], [1, 6], [7, 12]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00452();
        Assert.That(sut.FindMinArrowShots([[1, 2], [3, 4], [5, 6], [7, 8]]), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S00452();
        Assert.That(sut.FindMinArrowShots([[1, 2], [2, 3], [3, 4], [4, 5]]), Is.EqualTo(2));
    }

    [Test]
    public void T4()
    {
        var sut = new S00452();
        Assert.That(sut.FindMinArrowShots([[-2147483646, -2147483645], [2147483646, 2147483647]]), Is.EqualTo(2));
    }

    [Test]
    public void T5()
    {
        var sut = new S00452();
        Assert.That(sut.FindMinArrowShots([[2, 3], [2, 3]]), Is.EqualTo(1));
    }

    [Test]
    public void T6()
    {
        var sut = new S00452();
        Assert.That(sut.FindMinArrowShots([[-2147483648, 2147483647]]), Is.EqualTo(1));
    }

    [Test]
    public void T7()
    {
        var sut = new S00452();
        Assert.That(sut.FindMinArrowShots([[-2147483648, 2147483647], [-2147483648, 2147483647]]), Is.EqualTo(1));
    }
}