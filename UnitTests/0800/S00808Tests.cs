using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00808Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00808();
        Assert.That(sut.SoupServings(50), Is.EqualTo(0.625));
    }

    [Test]
    public void T2()
    {
        var sut = new S00808();
        Assert.That(sut.SoupServings(100), Is.EqualTo(0.71875));
    }
}