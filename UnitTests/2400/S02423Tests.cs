using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02423Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02423();
        Assert.That(sut.EqualFrequency("abcc"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02423();
        Assert.That(sut.EqualFrequency("aazz"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S02423();
        Assert.That(sut.EqualFrequency("bac"), Is.True);
    }

    [Test]
    public void T4()
    {
        var sut = new S02423();
        Assert.That(sut.EqualFrequency("cccaa"), Is.True);
    }

    [Test]
    public void T5()
    {
        var sut = new S02423();
        Assert.That(sut.EqualFrequency("ddaccb"), Is.False);
    }

    [Test]
    public void T6()
    {
        var sut = new S02423();
        Assert.That(sut.EqualFrequency("abbcc"), Is.True);
    }

    [Test]
    public void T7()
    {
        var sut = new S02423();
        Assert.That(sut.EqualFrequency("babbdd"), Is.False);
    }
}
