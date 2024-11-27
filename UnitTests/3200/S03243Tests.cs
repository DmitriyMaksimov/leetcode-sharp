using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03243Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03243();
        sut.ShortestDistanceAfterQueries(5, [[2, 4], [0, 2], [0, 4]]).Should().Equal(3, 2, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S03243();
        sut.ShortestDistanceAfterQueries(4, [[0, 3], [0, 2]]).Should().Equal(1, 1);
    }
}
