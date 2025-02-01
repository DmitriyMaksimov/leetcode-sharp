using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01422Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01422();
        Assert.That(sut.MaxScore("011101"), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S01422();
        Assert.That(sut.MaxScore("00111"), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S01422();
        Assert.That(sut.MaxScore("1111"), Is.EqualTo(3));
    }

    [Test]
    public void T4()
    {
        var sut = new S01422();
        Assert.That(sut.MaxScore("00"), Is.EqualTo(1));
    }
}