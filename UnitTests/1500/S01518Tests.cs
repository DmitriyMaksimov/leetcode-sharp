using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01518Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01518();
        Assert.That(sut.NumWaterBottles(9, 3), Is.EqualTo(13));
    }

    [Test]
    public void T2()
    {
        var sut = new S01518();
        Assert.That(sut.NumWaterBottles(15, 4), Is.EqualTo(19));
    }
}