using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00995Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00995();
        Assert.That(sut.MinKBitFlips([0, 1, 0], 1), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00995();
        Assert.That(sut.MinKBitFlips([1, 1, 0], 2), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00995();
        Assert.That(sut.MinKBitFlips([0, 0, 0, 1, 0, 1, 1, 0], 3), Is.EqualTo(3));
    }
}