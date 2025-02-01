using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01903Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01903();
        Assert.That(sut.LargestOddNumber("52"), Is.EqualTo("5"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01903();
        Assert.That(sut.LargestOddNumber("4206"), Is.EqualTo(""));
    }

    [Test]
    public void T3()
    {
        var sut = new S01903();
        Assert.That(sut.LargestOddNumber("35427"), Is.EqualTo("35427"));
    }
}