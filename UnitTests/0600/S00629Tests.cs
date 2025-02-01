using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00629Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00629();
        Assert.That(sut.KInversePairs(3, 0), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00629();
        Assert.That(sut.KInversePairs(3, 1), Is.EqualTo(2));
    }
}