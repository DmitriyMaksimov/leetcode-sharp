using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01220Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01220();
        Assert.That(sut.CountVowelPermutation(1), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S01220();
        Assert.That(sut.CountVowelPermutation(2), Is.EqualTo(10));
    }

    [Test]
    public void T3()
    {
        var sut = new S01220();
        Assert.That(sut.CountVowelPermutation(5), Is.EqualTo(68));
    }
}