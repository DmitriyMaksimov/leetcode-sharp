using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01974Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01974();
        Assert.That(sut.MinTimeToType("abc"), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S01974();
        Assert.That(sut.MinTimeToType("bza"), Is.EqualTo(7));
    }

    [Test]
    public void T3()
    {
        var sut = new S01974();
        Assert.That(sut.MinTimeToType("zjpc"), Is.EqualTo(34));
    }
}