using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02272Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02272();
        Assert.That(sut.LargestVariance("aababbb"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02272();
        Assert.That(sut.LargestVariance("abcde"), Is.EqualTo(0));
    }
}