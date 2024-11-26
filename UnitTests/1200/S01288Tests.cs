using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01288Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01288();
        sut.RemoveCoveredIntervals([[1, 4], [3, 6], [2, 8]]).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01288();
        sut.RemoveCoveredIntervals([[1, 4], [2, 3]]).Should().Be(1);
    }
}
