using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01318Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01318();
        Assert.That(sut.MinFlips(2, 6, 5), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01318();
        Assert.That(sut.MinFlips(4, 2, 7), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01318();
        Assert.That(sut.MinFlips(1, 2, 3), Is.EqualTo(0));
    }
}