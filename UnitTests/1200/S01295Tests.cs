using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01295))]
public class S01295Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01295();
        Assert.That(sut.FindNumbers([12, 345, 2, 6, 7896]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01295();
        Assert.That(sut.FindNumbers([555, 901, 482, 1771]), Is.EqualTo(1));
    }
}
