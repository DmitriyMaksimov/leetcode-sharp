using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01518Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01518();
        sut.NumWaterBottles(9, 3).Should().Be(13);
    }

    [Test]
    public void T2()
    {
        var sut = new S01518();
        sut.NumWaterBottles(15, 4).Should().Be(19);
    }
}