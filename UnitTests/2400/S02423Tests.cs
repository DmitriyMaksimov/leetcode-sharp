using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02423Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02423();
        sut.EqualFrequency("abcc").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02423();
        sut.EqualFrequency("aazz").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S02423();
        sut.EqualFrequency("bac").Should().BeTrue();
    }

    [Test]
    public void T4()
    {
        var sut = new S02423();
        sut.EqualFrequency("cccaa").Should().BeTrue();
    }

    [Test]
    public void T5()
    {
        var sut = new S02423();
        sut.EqualFrequency("ddaccb").Should().BeFalse();
    }

    [Test]
    public void T6()
    {
        var sut = new S02423();
        sut.EqualFrequency("abbcc").Should().BeTrue();
    }

    [Test]
    public void T7()
    {
        var sut = new S02423();
        sut.EqualFrequency("babbdd").Should().BeFalse();
    }
}