using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02220Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02220();
        Assert.That(sut.MinBitFlips(10, 7), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02220();
        Assert.That(sut.MinBitFlips(3, 4), Is.EqualTo(3));
    }
}