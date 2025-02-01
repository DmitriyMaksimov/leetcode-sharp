using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02063Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02063();
        Assert.That(sut.CountVowels("aba"), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S02063();
        Assert.That(sut.CountVowels("abc"), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S02063();
        Assert.That(sut.CountVowels("ltcd"), Is.EqualTo(0));
    }
}
