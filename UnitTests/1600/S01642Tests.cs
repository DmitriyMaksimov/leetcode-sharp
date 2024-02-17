using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01642Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01642();
        sut.FurthestBuilding([4, 2, 7, 6, 9, 14, 12], 5, 1).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01642();
        sut.FurthestBuilding([4, 12, 2, 7, 3, 18, 20, 3, 19], 10, 2).Should().Be(7);
    }

    [Test]
    public void T3()
    {
        var sut = new S01642();
        sut.FurthestBuilding([14, 3, 19, 3], 17, 0).Should().Be(3);
    }
}