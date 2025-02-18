using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01419Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01419();
        Assert.That(sut.MinNumberOfFrogs("croakcroak"), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01419();
        Assert.That(sut.MinNumberOfFrogs("crcoakroak"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01419();
        Assert.That(sut.MinNumberOfFrogs("croakcrook"), Is.EqualTo(-1));
    }

    [Test]
    public void T4()
    {
        var sut = new S01419();
        Assert.That(sut.MinNumberOfFrogs("croakcroa"), Is.EqualTo(-1));
    }
}
