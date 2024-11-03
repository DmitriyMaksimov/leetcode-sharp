using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02368Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02368();
        sut.ReachableNodes(7, [[0, 1], [1, 2], [3, 1], [4, 0], [0, 5], [5, 6]], [4, 5]).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02368();
        sut.ReachableNodes(7, [[0, 1], [0, 2], [0, 5], [0, 4], [3, 2], [6, 5]], [4, 2, 1]).Should().Be(3);
    }
}
