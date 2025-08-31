using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03658))]
public class S03658Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03658();
        Assert.That(sut.GcdOfOddEvenSums(4), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03658();
        Assert.That(sut.GcdOfOddEvenSums(5), Is.EqualTo(5));
    }
}