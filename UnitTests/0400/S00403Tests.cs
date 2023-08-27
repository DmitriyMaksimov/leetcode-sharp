using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00403Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00403();
        var stones = new[] {0, 1, 3, 5, 6, 8, 12, 17};
        sut.CanCross(stones).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00403();
        var stones = new[] {0, 1, 2, 3, 4, 8, 9, 11};
        sut.CanCross(stones).Should().BeFalse();
    }
}