using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03945))]
public class S03945Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03945();
        Assert.That(sut.DigitFrequencyScore(122), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03945();
        Assert.That(sut.DigitFrequencyScore(101), Is.EqualTo(2));
    }
}