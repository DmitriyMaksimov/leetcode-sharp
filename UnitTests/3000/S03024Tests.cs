using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03024Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03024();
        sut.TriangleType([3, 3, 3]).Should().Be("equilateral");
    }

    [Test]
    public void T2()
    {
        var sut = new S03024();
        sut.TriangleType([3, 4, 5]).Should().Be("scalene");
    }
}