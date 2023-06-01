using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01091Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01091();
        sut.ShortestPathBinaryMatrix(new[] {new[] {0, 1}, new[] {1, 0}}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01091();
        sut.ShortestPathBinaryMatrix(new[] {new[] {0, 0, 0}, new[] {1, 1, 0}, new[] {1, 1, 0}}).Should().Be(4);
    }

    [Test]
    public void T3()
    {
        var sut = new S01091();
        sut.ShortestPathBinaryMatrix(new[] {new[] {1, 0, 0}, new[] {1, 1, 0}, new[] {1, 1, 0}}).Should().Be(-1);
    }
}