using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00847Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00847();
        Assert.That(sut.ShortestPathLength([[1, 2, 3], [0], [0], [0]]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00847();
        Assert.That(sut.ShortestPathLength([[1], [0, 2, 4], [1, 3, 4], [2], [1, 2]]), Is.EqualTo(4));
    }
}