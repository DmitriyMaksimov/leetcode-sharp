using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01039Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01039();
        sut.MinScoreTriangulation([1, 2, 3]).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S01039();
        sut.MinScoreTriangulation([3, 7, 4, 5]).Should().Be(144);
    }

    [Test]
    public void T3()
    {
        var sut = new S01039();
        sut.MinScoreTriangulation([1, 3, 1, 4, 1, 5]).Should().Be(13);
    }
}
