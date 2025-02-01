using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02024Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02024();
        Assert.That(sut.MaxConsecutiveAnswers("TTFF", 2), Is.EqualTo(4));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02024();
        Assert.That(sut.MaxConsecutiveAnswers("TFFT", 1), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S02024();
        Assert.That(sut.MaxConsecutiveAnswers("TTFTTFTT", 1), Is.EqualTo(5));
    }
}