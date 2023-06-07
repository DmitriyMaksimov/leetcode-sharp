using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01318Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01318();
        sut.MinFlips(2, 6, 5).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01318();
        sut.MinFlips(4, 2, 7).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01318();
        sut.MinFlips(1, 2, 3).Should().Be(0);
    }
}