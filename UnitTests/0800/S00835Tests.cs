using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00835Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00835();
        sut.LargestOverlap([[1, 1, 0], [0, 1, 0], [0, 1, 0]], [[0, 0, 0], [0, 1, 1], [0, 0, 1]]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00835();
        sut.LargestOverlap([[1]], [[1]]).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S00835();
        sut.LargestOverlap([[0]], [[0]]).Should().Be(0);
    }
}
