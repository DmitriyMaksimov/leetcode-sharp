using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01129Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01129();
        sut.ShortestAlternatingPaths(3, new[] {new[] {0, 1}, new[] {1, 2}}, Array.Empty<int[]>()).Should().Equal(0, 1, -1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01129();
        sut.ShortestAlternatingPaths(3, new[] {new[] {0, 1}}, new[] {new[] {2, 1}}).Should().Equal(0, 1, -1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01129();
        sut.ShortestAlternatingPaths(5, new[] {new[] {0, 1}, new []{1,2}, new []{2,3}, new []{3,4}}, new[] {new[] {1, 2}, new []{2,3}, new []{3,1}}).Should().Equal(0, 1, 2,3,7);
    }
}