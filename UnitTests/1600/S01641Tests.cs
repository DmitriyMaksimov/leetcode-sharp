using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01641Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01641();
        Assert.That(sut.CountVowelStrings(1), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S01641();
        Assert.That(sut.CountVowelStrings(2), Is.EqualTo(15));
    }

    [Test]
    public void T3()
    {
        var sut = new S01641();
        Assert.That(sut.CountVowelStrings(33), Is.EqualTo(66045));
    }
}