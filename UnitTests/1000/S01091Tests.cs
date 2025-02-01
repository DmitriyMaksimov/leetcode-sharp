using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01091Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01091();
        Assert.That(sut.ShortestPathBinaryMatrix(new[] {new[] {0, 1}, new[] {1, 0}}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01091();
        Assert.That(sut.ShortestPathBinaryMatrix(new[] {new[] {0, 0, 0}, new[] {1, 1, 0}, new[] {1, 1, 0}}), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S01091();
        Assert.That(sut.ShortestPathBinaryMatrix(new[] {new[] {1, 0, 0}, new[] {1, 1, 0}, new[] {1, 1, 0}}), Is.EqualTo(-1));
    }
}