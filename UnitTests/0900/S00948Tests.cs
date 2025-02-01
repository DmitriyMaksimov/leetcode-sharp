using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00948Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00948();
        Assert.That(sut.BagOfTokensScore([100], 50), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S00948();
        Assert.That(sut.BagOfTokensScore([200, 100], 150), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00948();
        Assert.That(sut.BagOfTokensScore([100, 200, 300, 400], 200), Is.EqualTo(2));
    }
}