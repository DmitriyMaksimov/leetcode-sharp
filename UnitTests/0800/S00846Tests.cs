using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00846Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00846();
        sut.IsNStraightHand([1, 2, 3, 6, 2, 3, 4, 7, 8], 3).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00846();
        sut.IsNStraightHand([1, 2, 3, 4, 5], 4).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00846();
        sut.IsNStraightHand([2, 1], 2).Should().BeTrue();
    }
}